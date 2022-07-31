namespace team_Project
{
    partial class Minimapdlg
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.left_box = new System.Windows.Forms.PictureBox();
            this.OpenFiledlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.left_box)).BeginInit();
            this.SuspendLayout();
            // 
            // left_box
            // 
            this.left_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left_box.Location = new System.Drawing.Point(25, 98);
            this.left_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.left_box.Name = "left_box";
            this.left_box.Size = new System.Drawing.Size(400, 400);
            this.left_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left_box.TabIndex = 0;
            this.left_box.TabStop = false;
            this.left_box.Paint += new System.Windows.Forms.PaintEventHandler(this.left_box_Paint);
            this.left_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.left_box_MouseMove);
            // 
            // OpenFiledlg
            // 
            this.OpenFiledlg.FileName = "OpenFiledlg";
            // 
            // Minimapdlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 519);
            this.Controls.Add(this.left_box);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Minimapdlg";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Minimapdlg_Deactivate);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.left_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox left_box;
        private System.Windows.Forms.OpenFileDialog OpenFiledlg;
    }
}

