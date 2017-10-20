namespace PocketRogueItemEditor
{
    partial class BonusesForm
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
            this.updateBonusesButton = new System.Windows.Forms.Button();
            this.bonusesGridView = new System.Windows.Forms.DataGridView();
            this.BonusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bonusesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBonusesButton
            // 
            this.updateBonusesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateBonusesButton.Location = new System.Drawing.Point(0, 295);
            this.updateBonusesButton.Name = "updateBonusesButton";
            this.updateBonusesButton.Size = new System.Drawing.Size(284, 37);
            this.updateBonusesButton.TabIndex = 0;
            this.updateBonusesButton.Text = "Update";
            this.updateBonusesButton.UseVisualStyleBackColor = true;
            this.updateBonusesButton.Click += new System.EventHandler(this.updateBonusesButton_Click);
            // 
            // bonusesGridView
            // 
            this.bonusesGridView.AllowUserToAddRows = false;
            this.bonusesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bonusesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BonusColumn,
            this.ValueColumn});
            this.bonusesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bonusesGridView.Location = new System.Drawing.Point(0, 0);
            this.bonusesGridView.Name = "bonusesGridView";
            this.bonusesGridView.RowHeadersVisible = false;
            this.bonusesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bonusesGridView.Size = new System.Drawing.Size(284, 295);
            this.bonusesGridView.TabIndex = 1;
            // 
            // BonusColumn
            // 
            this.BonusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BonusColumn.HeaderText = "Bonus";
            this.BonusColumn.Name = "BonusColumn";
            // 
            // ValueColumn
            // 
            this.ValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // itemDefinitionBindingSource
            // 
            this.itemDefinitionBindingSource.DataSource = typeof(PocketRogueItemEditor.ItemDefinition);
            // 
            // BonusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.bonusesGridView);
            this.Controls.Add(this.updateBonusesButton);
            this.Name = "BonusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BonusesForm";
            ((System.ComponentModel.ISupportInitialize)(this.bonusesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDefinitionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateBonusesButton;
        private System.Windows.Forms.DataGridView bonusesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.BindingSource itemDefinitionBindingSource;
    }
}