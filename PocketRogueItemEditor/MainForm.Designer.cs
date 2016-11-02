namespace PocketRogueItemEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stackableCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newItemButton = new System.Windows.Forms.Button();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.openSpriteSheetButton = new System.Windows.Forms.Button();
            this.iconTextBox = new System.Windows.Forms.TextBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.slotPanel = new System.Windows.Forms.Panel();
            this.slotLabel = new System.Windows.Forms.Label();
            this.equipSlotBox = new System.Windows.Forms.ComboBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.slotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stackableCheckBox
            // 
            this.stackableCheckBox.AutoSize = true;
            this.stackableCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackableCheckBox.Location = new System.Drawing.Point(703, 0);
            this.stackableCheckBox.Name = "stackableCheckBox";
            this.stackableCheckBox.Size = new System.Drawing.Size(535, 36);
            this.stackableCheckBox.TabIndex = 1;
            this.stackableCheckBox.Text = "Stackable";
            this.stackableCheckBox.UseVisualStyleBackColor = true;
            this.stackableCheckBox.CheckedChanged += new System.EventHandler(this.stackableCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(703, 702);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(535, 64);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.namePanel.Location = new System.Drawing.Point(703, 36);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(535, 79);
            this.namePanel.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = true;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(98, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(437, 38);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyEnter);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // newItemButton
            // 
            this.newItemButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newItemButton.Location = new System.Drawing.Point(703, 638);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(535, 64);
            this.newItemButton.TabIndex = 4;
            this.newItemButton.Text = "New Item";
            this.newItemButton.UseVisualStyleBackColor = true;
            this.newItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.openSpriteSheetButton);
            this.iconPanel.Controls.Add(this.iconTextBox);
            this.iconPanel.Controls.Add(this.iconLabel);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(703, 115);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(535, 95);
            this.iconPanel.TabIndex = 5;
            // 
            // openSpriteSheetButton
            // 
            this.openSpriteSheetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.openSpriteSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSpriteSheetButton.Location = new System.Drawing.Point(457, 38);
            this.openSpriteSheetButton.Name = "openSpriteSheetButton";
            this.openSpriteSheetButton.Size = new System.Drawing.Size(78, 57);
            this.openSpriteSheetButton.TabIndex = 2;
            this.openSpriteSheetButton.Text = "…";
            this.openSpriteSheetButton.UseVisualStyleBackColor = true;
            this.openSpriteSheetButton.Click += new System.EventHandler(this.openSpriteSheetButton_Click);
            // 
            // iconTextBox
            // 
            this.iconTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconTextBox.Location = new System.Drawing.Point(76, 0);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.Size = new System.Drawing.Size(459, 38);
            this.iconTextBox.TabIndex = 1;
            this.iconTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iconTextBox_KeyEnter);
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconLabel.Location = new System.Drawing.Point(0, 0);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(76, 32);
            this.iconLabel.TabIndex = 0;
            this.iconLabel.Text = "Icon:";
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AllowUserToResizeColumns = false;
            this.itemGridView.AllowUserToResizeRows = false;
            this.itemGridView.AutoGenerateColumns = false;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.itemGridView.DataSource = this.itemDefinitionBindingSource;
            this.itemGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemGridView.Location = new System.Drawing.Point(0, 0);
            this.itemGridView.MultiSelect = false;
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowHeadersVisible = false;
            this.itemGridView.RowTemplate.Height = 40;
            this.itemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGridView.Size = new System.Drawing.Size(703, 766);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_RowEnter);
            // 
            // slotPanel
            // 
            this.slotPanel.Controls.Add(this.equipSlotBox);
            this.slotPanel.Controls.Add(this.slotLabel);
            this.slotPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.slotPanel.Location = new System.Drawing.Point(703, 210);
            this.slotPanel.Name = "slotPanel";
            this.slotPanel.Size = new System.Drawing.Size(535, 100);
            this.slotPanel.TabIndex = 6;
            // 
            // slotLabel
            // 
            this.slotLabel.AutoSize = true;
            this.slotLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slotLabel.Location = new System.Drawing.Point(0, 0);
            this.slotLabel.Name = "slotLabel";
            this.slotLabel.Size = new System.Drawing.Size(154, 32);
            this.slotLabel.TabIndex = 0;
            this.slotLabel.Text = "Equip Slot:";
            // 
            // equipSlotBox
            // 
            this.equipSlotBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipSlotBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipSlotBox.FormattingEnabled = true;
            this.equipSlotBox.Items.AddRange(new object[] {
            "HELMET",
            "CHEST",
            "LEGS",
            "BOOTS",
            "RING",
            "PRIMARY_HAND",
            "OFF_HAND"});
            this.equipSlotBox.Location = new System.Drawing.Point(154, 0);
            this.equipSlotBox.Name = "equipSlotBox";
            this.equipSlotBox.Size = new System.Drawing.Size(381, 39);
            this.equipSlotBox.TabIndex = 1;
            this.equipSlotBox.SelectedIndexChanged += new System.EventHandler(this.equipSlotBox_SelectedIndexChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDefinitionBindingSource
            // 
            this.itemDefinitionBindingSource.DataSource = typeof(PocketRogueItemEditor.ItemDefinition);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 766);
            this.Controls.Add(this.slotPanel);
            this.Controls.Add(this.iconPanel);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stackableCheckBox);
            this.Controls.Add(this.itemGridView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Rogue Item Editor";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.slotPanel.ResumeLayout(false);
            this.slotPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox stackableCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.TextBox iconTextBox;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.BindingSource itemDefinitionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button openSpriteSheetButton;
        private System.Windows.Forms.Panel slotPanel;
        private System.Windows.Forms.Label slotLabel;
        private System.Windows.Forms.ComboBox equipSlotBox;
    }
}

