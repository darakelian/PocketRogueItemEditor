using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketRogueItemEditor
{
    public partial class ImageForm : Form
    {

        public ImageForm()
        {
            InitializeComponent();
        }

        //Click event.
        private void spriteSheetPicture_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location);
            MainForm form = this.Owner as MainForm;
            if (form == null)
            {
                Console.WriteLine("Null form");
                return;
            }
            int x = 1 + e.X / 16;
            int y = 1 + e.Y / 16;
            form.ActiveDefinition.icon = new int[] { x, y };
            form.RefreshDefinition();
            this.Close();
        }
    }
}
