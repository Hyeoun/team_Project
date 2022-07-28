namespace team_Project {
    partial class Savedlg {
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
            this.btn_allsave = new System.Windows.Forms.Button();
            this.btn_partsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_allsave
            // 
            this.btn_allsave.Location = new System.Drawing.Point(98, 121);
            this.btn_allsave.Name = "btn_allsave";
            this.btn_allsave.Size = new System.Drawing.Size(95, 35);
            this.btn_allsave.TabIndex = 0;
            this.btn_allsave.Text = "전체저장";
            this.btn_allsave.UseVisualStyleBackColor = true;
            // 
            // btn_partsave
            // 
            this.btn_partsave.Location = new System.Drawing.Point(391, 121);
            this.btn_partsave.Name = "btn_partsave";
            this.btn_partsave.Size = new System.Drawing.Size(95, 35);
            this.btn_partsave.TabIndex = 0;
            this.btn_partsave.Text = "부분저장";
            this.btn_partsave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "전체 혹은 일부를 저장합니다.";
            // 
            // Savedlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_partsave);
            this.Controls.Add(this.btn_allsave);
            this.Name = "Savedlg";
            this.Text = "Savedlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_allsave;
        private System.Windows.Forms.Button btn_partsave;
        private System.Windows.Forms.Label label1;
    }
}