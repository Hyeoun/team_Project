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
            this.zoom_box = new System.Windows.Forms.PictureBox();
            this.OpenFiledlg = new System.Windows.Forms.OpenFileDialog();
            this.btn_zoom_in = new System.Windows.Forms.Button();
            this.btn_zoom_out = new System.Windows.Forms.Button();
            this.ZoomNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_box)).BeginInit();
            this.SuspendLayout();
            // 
            // zoom_box
            // 
            this.zoom_box.Location = new System.Drawing.Point(25, 98);
            this.zoom_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoom_box.Name = "zoom_box";
            this.zoom_box.Size = new System.Drawing.Size(370, 370);
            this.zoom_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoom_box.TabIndex = 0;
            this.zoom_box.TabStop = false;
            this.zoom_box.Paint += new System.Windows.Forms.PaintEventHandler(this.left_box_Paint);
            this.zoom_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.left_box_MouseMove);
            // 
            // OpenFiledlg
            // 
            this.OpenFiledlg.FileName = "OpenFiledlg";
            // 
            // btn_zoom_in
            // 
            this.btn_zoom_in.Location = new System.Drawing.Point(97, 46);
            this.btn_zoom_in.Name = "btn_zoom_in";
            this.btn_zoom_in.Size = new System.Drawing.Size(83, 36);
            this.btn_zoom_in.TabIndex = 1;
            this.btn_zoom_in.Text = "확대";
            this.btn_zoom_in.UseVisualStyleBackColor = true;
            this.btn_zoom_in.Click += new System.EventHandler(this.btn_zoom_in_Click);
            // 
            // btn_zoom_out
            // 
            this.btn_zoom_out.Location = new System.Drawing.Point(208, 46);
            this.btn_zoom_out.Name = "btn_zoom_out";
            this.btn_zoom_out.Size = new System.Drawing.Size(83, 36);
            this.btn_zoom_out.TabIndex = 1;
            this.btn_zoom_out.Text = "축소";
            this.btn_zoom_out.UseVisualStyleBackColor = true;
            this.btn_zoom_out.Click += new System.EventHandler(this.btn_zoom_out_Click);
            // 
            // ZoomNum
            // 
            this.ZoomNum.AutoSize = true;
            this.ZoomNum.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ZoomNum.Location = new System.Drawing.Point(171, 470);
            this.ZoomNum.Name = "ZoomNum";
            this.ZoomNum.Size = new System.Drawing.Size(110, 34);
            this.ZoomNum.TabIndex = 2;
            this.ZoomNum.Text = "label1";
            // 
            // Minimapdlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 519);
            this.Controls.Add(this.ZoomNum);
            this.Controls.Add(this.btn_zoom_out);
            this.Controls.Add(this.btn_zoom_in);
            this.Controls.Add(this.zoom_box);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Minimapdlg";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Minimapdlg_Deactivate);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.zoom_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zoom_box;
        private System.Windows.Forms.OpenFileDialog OpenFiledlg;
        private System.Windows.Forms.Button btn_zoom_in;
        private System.Windows.Forms.Button btn_zoom_out;
        private System.Windows.Forms.Label ZoomNum;
    }
}

