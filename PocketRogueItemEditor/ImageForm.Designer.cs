namespace PocketRogueItemEditor
{
    partial class ImageForm
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
            this.spriteSheetPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // spriteSheetPicture
            // 
            this.spriteSheetPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spriteSheetPicture.Location = new System.Drawing.Point(0, 0);
            this.spriteSheetPicture.Name = "spriteSheetPicture";
            this.spriteSheetPicture.Size = new System.Drawing.Size(480, 424);
            this.spriteSheetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spriteSheetPicture.TabIndex = 0;
            this.spriteSheetPicture.TabStop = false;
            this.spriteSheetPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spriteSheetPicture_MouseClick);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(480, 424);
            this.Controls.Add(this.spriteSheetPicture);
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpriteSheet Selection";
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox spriteSheetPicture;
    }
}