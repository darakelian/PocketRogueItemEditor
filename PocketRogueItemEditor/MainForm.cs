using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PocketRogueItemEditor
{
    public partial class MainForm : Form
    {
        public ItemDefinition ActiveDefinition { get; set; }
        List<ItemDefinition> definitions = new List<ItemDefinition>();
        //BindingList<ItemDefinition> bList;// = new BindingList<ItemDefinition>(definitions);

        public MainForm()
        {
            InitializeComponent();
            //bList = new BindingList<ItemDefinition>(definitions);
            //var bindingList = new BindingList<ItemDefinition>(this.definitions);
            //var source = new BindingSource(bList, null);
            //this.itemGridView.DataSource = source;
        }

        //Save to JSON
        private void saveButton_Click(object sender, EventArgs e)
        {
            string jsonString = JsonConvert.SerializeObject(
                this.itemDefinitionBindingSource, Formatting.Indented);
            string path = Properties.Settings.Default.JsonFilePath;
            File.WriteAllText(path, jsonString);
        }

        //Change name.
        private void nameTextBox_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (this.ActiveDefinition != null)
                {
                    this.ActiveDefinition.name = this.nameTextBox.Text;
                    this.itemGridView.Refresh();
                    e.SuppressKeyPress = true;
                }
            }
        }

        //Change icon coords.
        private void iconTextBox_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (this.ActiveDefinition != null)
                {
                    this.ActiveDefinition.icon = this.convertTextToArray();
                    this.itemGridView.Refresh();
                    e.SuppressKeyPress = true;
                }
            }
        }

        //Cell enter.
        private void itemGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = e != null ? itemGridView.Rows[e.RowIndex] :
                itemGridView.Rows[itemGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected)];
            if (row.Selected)
            {
                ItemDefinition def = (ItemDefinition)row.DataBoundItem;
                this.ActiveDefinition = def;
                this.RefreshDefinition();
            }
        }

        //Add new item.
        private void newItemButton_Click(object sender, EventArgs e)
        {
            ItemDefinition def = new ItemDefinition();
            def.name = "New Item";
            def.stackable = false;
            def.icon = new int[] { 1, 1 };
            def.slot = "CHEST";
            this.itemDefinitionBindingSource.Add(def);
            this.ActiveDefinition = def;
            this.RefreshDefinition();
        }

        //Set stackable.
        private void stackableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ActiveDefinition != null)
            {
                CheckBox box = sender as CheckBox;
                this.ActiveDefinition.stackable = box.Checked;
            }
        }

        //Prompt user to locate json file if setting is not set, otherwise load
        //the json file.
        private void MainForm_Shown(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.JsonFilePath;
            if (path.Equals(""))
            {
                openJsonFile();
            }
            else
            {
                Console.WriteLine("Parsing existing JSON file.");
                loadJsonFile();
            }
        }

        //Load the json file from the settings property.
        private void loadJsonFile()
        {
            Stream fileStream = null;
            try
            {
                if ((fileStream = File.OpenRead(Properties.Settings.Default.JsonFilePath)) != null)
                {
                    using (fileStream)
                    {
                        using (var reader = new StreamReader(fileStream))
                        {
                            string json = reader.ReadToEnd();
                            loadJsonFile(json);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                openJsonFile();
                //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        //Load the json file from a string.
        private void loadJsonFile(string json)
        {
            List<ItemDefinition> defs = JsonConvert.DeserializeObject<List<ItemDefinition>>(json);
            this.itemDefinitionBindingSource.DataSource = defs;
            this.itemGridView.ClearSelection();
            //this.itemGridView.Rows[1].Selected = true;
        }

        //Open up the sprite sheet.
        private void openSpriteSheetButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveDefinition == null)
            {
                return;
            }
            ImageForm imageForm = new ImageForm();
            //imageForm.ShowDialog(this);
            //Prompt to select file.
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    Bitmap bmp = new Bitmap(dlg.FileName);
                    //int width = bmp.Width;
                    //int height = bmp.Height;
                    imageForm.spriteSheetPicture.Image = bmp;
                    //imageForm.Size = new Size(width, height);
                    //Console.WriteLine(width + " " + height);
                    imageForm.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Refresh the values of the text boxes and check boxes.
        /// </summary>
        public void RefreshDefinition()
        {
            if (this.ActiveDefinition == null)
            {
                return;
            }
            this.iconTextBox.Text = this.convertArrayToString();
            this.stackableCheckBox.Checked = this.ActiveDefinition.stackable;
            this.nameTextBox.Text = this.ActiveDefinition.name;
            this.equipSlotBox.SelectedItem = this.ActiveDefinition.slot;
        }

        /// <summary>
        /// Converts the textbox string value into an integer array. This method
        /// also removes leading and trailing brackets since the code sets the
        /// text in the box to include the brackets.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] convertTextToArray(string value = null)
        {
            string text = this.iconTextBox.Text;
            if (text.Contains("[") || text.Contains("]"))
            {
                text = text.Trim(new char[] { '[', ']' });
            }
            string[] aText = text.Split(',');
            int[] coords = new int[aText.Length];
            for (int i = 0; i < aText.Length; i++)
            {
                coords[i] = int.Parse(aText[i]);
            }
            return coords;
        }

        public string convertArrayToString(int[] array = null)
        {
            int[] arrayToConvert = array != null ? array : this.ActiveDefinition.icon;
            string s = "[";
            for (int i = 0; i < arrayToConvert.Length; i++)
            {
                s += arrayToConvert[i].ToString();
                if (i != arrayToConvert.Length - 1)
                {
                    s += ",";
                }
            }
            s += "]";
            return s;
        }

        public void openJsonFile()
        {
            //Prompt to select file.
            Stream fileStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFile.Filter = "json files (*.json)|*.json";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFile.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            using (var reader = new StreamReader(fileStream))
                            {
                                string json = reader.ReadToEnd();
                                string selectedPath = openFile.FileName;
                                Properties.Settings.Default.JsonFilePath = selectedPath;
                                Properties.Settings.Default.Save();
                                loadJsonFile(json);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Update the active definition's slot index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipSlotBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveDefinition != null)
            {
                ComboBox box = sender as ComboBox;
                if (box != null && box.SelectedItem != null)
                {
                    this.ActiveDefinition.slot = box.SelectedItem.ToString();
                    Console.WriteLine(this.ActiveDefinition.slot);
                }
            }
        }
    }
}
