namespace team_Project {
    partial class Minimapdlg {
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
            this.minimap_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimap_box)).BeginInit();
            this.SuspendLayout();
            // 
            // minimap_box
            // 
            this.minimap_box.Location = new System.Drawing.Point(38, 62);
            this.minimap_box.Name = "minimap_box";
            this.minimap_box.Size = new System.Drawing.Size(400, 400);
            this.minimap_box.TabIndex = 0;
            this.minimap_box.TabStop = false;
            // 
            // Minimapdlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 507);
            this.Controls.Add(this.minimap_box);
            this.Name = "Minimapdlg";
            this.Text = "Minimapdlg";
            ((System.ComponentModel.ISupportInitialize)(this.minimap_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minimap_box;
    }
}