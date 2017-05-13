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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slotPanel = new System.Windows.Forms.Panel();
            this.equipSlotBox = new System.Windows.Forms.ComboBox();
            this.slotLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setBonusesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).BeginInit();
            this.slotPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackableCheckBox
            // 
            this.stackableCheckBox.AutoSize = true;
            this.stackableCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackableCheckBox.Location = new System.Drawing.Point(264, 0);
            this.stackableCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.stackableCheckBox.Name = "stackableCheckBox";
            this.stackableCheckBox.Size = new System.Drawing.Size(200, 17);
            this.stackableCheckBox.TabIndex = 1;
            this.stackableCheckBox.Text = "Stackable";
            this.stackableCheckBox.UseVisualStyleBackColor = true;
            this.stackableCheckBox.CheckedChanged += new System.EventHandler(this.stackableCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(264, 294);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 27);
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
            this.namePanel.Location = new System.Drawing.Point(264, 17);
            this.namePanel.Margin = new System.Windows.Forms.Padding(1);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(200, 33);
            this.namePanel.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = true;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(38, 0);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyEnter);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // newItemButton
            // 
            this.newItemButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newItemButton.Location = new System.Drawing.Point(264, 267);
            this.newItemButton.Margin = new System.Windows.Forms.Padding(1);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(200, 27);
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
            this.iconPanel.Location = new System.Drawing.Point(264, 50);
            this.iconPanel.Margin = new System.Windows.Forms.Padding(1);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(200, 40);
            this.iconPanel.TabIndex = 5;
            // 
            // openSpriteSheetButton
            // 
            this.openSpriteSheetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.openSpriteSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSpriteSheetButton.Location = new System.Drawing.Point(171, 20);
            this.openSpriteSheetButton.Margin = new System.Windows.Forms.Padding(1);
            this.openSpriteSheetButton.Name = "openSpriteSheetButton";
            this.openSpriteSheetButton.Size = new System.Drawing.Size(29, 20);
            this.openSpriteSheetButton.TabIndex = 2;
            this.openSpriteSheetButton.Text = "…";
            this.openSpriteSheetButton.UseVisualStyleBackColor = true;
            this.openSpriteSheetButton.Click += new System.EventHandler(this.openSpriteSheetButton_Click);
            // 
            // iconTextBox
            // 
            this.iconTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconTextBox.Location = new System.Drawing.Point(31, 0);
            this.iconTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.Size = new System.Drawing.Size(169, 20);
            this.iconTextBox.TabIndex = 1;
            this.iconTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iconTextBox_KeyEnter);
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconLabel.Location = new System.Drawing.Point(0, 0);
            this.iconLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(31, 13);
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
            this.itemGridView.Margin = new System.Windows.Forms.Padding(1);
            this.itemGridView.MultiSelect = false;
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowHeadersVisible = false;
            this.itemGridView.RowTemplate.Height = 40;
            this.itemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGridView.Size = new System.Drawing.Size(264, 321);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_RowEnter);
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
            // slotPanel
            // 
            this.slotPanel.Controls.Add(this.equipSlotBox);
            this.slotPanel.Controls.Add(this.slotLabel);
            this.slotPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.slotPanel.Location = new System.Drawing.Point(264, 90);
            this.slotPanel.Margin = new System.Windows.Forms.Padding(1);
            this.slotPanel.Name = "slotPanel";
            this.slotPanel.Size = new System.Drawing.Size(200, 42);
            this.slotPanel.TabIndex = 6;
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
            "OFF_HAND",
            "GENERAL"});
            this.equipSlotBox.Location = new System.Drawing.Point(58, 0);
            this.equipSlotBox.Margin = new System.Windows.Forms.Padding(1);
            this.equipSlotBox.Name = "equipSlotBox";
            this.equipSlotBox.Size = new System.Drawing.Size(142, 21);
            this.equipSlotBox.TabIndex = 1;
            this.equipSlotBox.SelectedIndexChanged += new System.EventHandler(this.equipSlotBox_SelectedIndexChanged);
            // 
            // slotLabel
            // 
            this.slotLabel.AutoSize = true;
            this.slotLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slotLabel.Location = new System.Drawing.Point(0, 0);
            this.slotLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.slotLabel.Name = "slotLabel";
            this.slotLabel.Size = new System.Drawing.Size(58, 13);
            this.slotLabel.TabIndex = 0;
            this.slotLabel.Text = "Equip Slot:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.setBonusesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(264, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 7;
            // 
            // setBonusesButton
            // 
            this.setBonusesButton.Location = new System.Drawing.Point(58, 4);
            this.setBonusesButton.Name = "setBonusesButton";
            this.setBonusesButton.Size = new System.Drawing.Size(142, 23);
            this.setBonusesButton.TabIndex = 1;
            this.setBonusesButton.Text = "Set Bonuses";
            this.setBonusesButton.UseVisualStyleBackColor = true;
            this.setBonusesButton.Click += new System.EventHandler(this.setBonusesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonuses:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slotPanel);
            this.Controls.Add(this.iconPanel);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stackableCheckBox);
            this.Controls.Add(this.itemGridView);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Rogue Item Editor";
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).EndInit();
            this.slotPanel.ResumeLayout(false);
            this.slotPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setBonusesButton;
        private System.Windows.Forms.Label label1;
    }
}

