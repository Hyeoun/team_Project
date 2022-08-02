namespace team_Project
{
    partial class MainWindow
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
            this.LeftBox = new System.Windows.Forms.PictureBox();
            this.RightBox = new System.Windows.Forms.PictureBox();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_ero = new System.Windows.Forms.Button();
            this.btn_hist = new System.Windows.Forms.Button();
            this.btn_otsu = new System.Windows.Forms.Button();
            this.btn_gau = new System.Windows.Forms.Button();
            this.btn_lap = new System.Windows.Forms.Button();
            this.scope_box = new System.Windows.Forms.PictureBox();
            this.lbl_gray = new System.Windows.Forms.Label();
            this.btn_load1 = new System.Windows.Forms.Button();
            this.btn_save1 = new System.Windows.Forms.Button();
            this.btn_load2 = new System.Windows.Forms.Button();
            this.btn_save2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_match = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scope_box)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.Location = new System.Drawing.Point(31, 71);
            this.LeftBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(370, 370);
            this.LeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftBox.TabIndex = 0;
            this.LeftBox.TabStop = false;
            this.LeftBox.Click += new System.EventHandler(this.LeftBox_Click);
            this.LeftBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBox_MouseMove);
            // 
            // RightBox
            // 
            this.RightBox.Location = new System.Drawing.Point(426, 71);
            this.RightBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(370, 370);
            this.RightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightBox.TabIndex = 0;
            this.RightBox.TabStop = false;
            this.RightBox.Click += new System.EventHandler(this.RightBox_Click);
            this.RightBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBox_MouseMove);
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(828, 71);
            this.btn_exp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(109, 32);
            this.btn_exp.TabIndex = 5;
            this.btn_exp.Text = "팽창연산";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_ero
            // 
            this.btn_ero.Location = new System.Drawing.Point(828, 119);
            this.btn_ero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ero.Name = "btn_ero";
            this.btn_ero.Size = new System.Drawing.Size(109, 32);
            this.btn_ero.TabIndex = 6;
            this.btn_ero.Text = "침식연산";
            this.btn_ero.UseVisualStyleBackColor = true;
            this.btn_ero.Click += new System.EventHandler(this.btn_ero_Click);
            // 
            // btn_hist
            // 
            this.btn_hist.Location = new System.Drawing.Point(828, 181);
            this.btn_hist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hist.Name = "btn_hist";
            this.btn_hist.Size = new System.Drawing.Size(109, 32);
            this.btn_hist.TabIndex = 7;
            this.btn_hist.Text = "히스토그램";
            this.btn_hist.UseVisualStyleBackColor = true;
            this.btn_hist.Click += new System.EventHandler(this.btn_hist_Click);
            // 
            // btn_otsu
            // 
            this.btn_otsu.Location = new System.Drawing.Point(828, 229);
            this.btn_otsu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_otsu.Name = "btn_otsu";
            this.btn_otsu.Size = new System.Drawing.Size(109, 32);
            this.btn_otsu.TabIndex = 8;
            this.btn_otsu.Text = "오츠이진화";
            this.btn_otsu.UseVisualStyleBackColor = true;
            this.btn_otsu.Click += new System.EventHandler(this.btn_otsu_Click);
            // 
            // btn_gau
            // 
            this.btn_gau.Location = new System.Drawing.Point(828, 292);
            this.btn_gau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gau.Name = "btn_gau";
            this.btn_gau.Size = new System.Drawing.Size(109, 32);
            this.btn_gau.TabIndex = 9;
            this.btn_gau.Text = "가우시안";
            this.btn_gau.UseVisualStyleBackColor = true;
            this.btn_gau.Click += new System.EventHandler(this.btn_gau_Click);
            // 
            // btn_lap
            // 
            this.btn_lap.Location = new System.Drawing.Point(828, 341);
            this.btn_lap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lap.Name = "btn_lap";
            this.btn_lap.Size = new System.Drawing.Size(109, 32);
            this.btn_lap.TabIndex = 10;
            this.btn_lap.Text = "라플라시안";
            this.btn_lap.UseVisualStyleBackColor = true;
            this.btn_lap.Click += new System.EventHandler(this.btn_lap_Click);
            // 
            // scope_box
            // 
            this.scope_box.Location = new System.Drawing.Point(980, 434);
            this.scope_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scope_box.Name = "scope_box";
            this.scope_box.Size = new System.Drawing.Size(101, 100);
            this.scope_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scope_box.TabIndex = 2;
            this.scope_box.TabStop = false;
            // 
            // lbl_gray
            // 
            this.lbl_gray.AutoSize = true;
            this.lbl_gray.Location = new System.Drawing.Point(977, 399);
            this.lbl_gray.Name = "lbl_gray";
            this.lbl_gray.Size = new System.Drawing.Size(50, 15);
            this.lbl_gray.TabIndex = 12;
            this.lbl_gray.Text = "gray : ";
            // 
            // btn_load1
            // 
            this.btn_load1.Location = new System.Drawing.Point(90, 456);
            this.btn_load1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load1.Name = "btn_load1";
            this.btn_load1.Size = new System.Drawing.Size(109, 32);
            this.btn_load1.TabIndex = 1;
            this.btn_load1.Text = "불러오기";
            this.btn_load1.UseVisualStyleBackColor = true;
            this.btn_load1.Click += new System.EventHandler(this.btn_load1_Click);
            // 
            // btn_save1
            // 
            this.btn_save1.Location = new System.Drawing.Point(224, 456);
            this.btn_save1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save1.Name = "btn_save1";
            this.btn_save1.Size = new System.Drawing.Size(109, 32);
            this.btn_save1.TabIndex = 2;
            this.btn_save1.Text = "저장";
            this.btn_save1.UseVisualStyleBackColor = true;
            this.btn_save1.Click += new System.EventHandler(this.btn_save1_Click);
            // 
            // btn_load2
            // 
            this.btn_load2.Location = new System.Drawing.Point(486, 456);
            this.btn_load2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load2.Name = "btn_load2";
            this.btn_load2.Size = new System.Drawing.Size(109, 32);
            this.btn_load2.TabIndex = 3;
            this.btn_load2.Text = "불러오기";
            this.btn_load2.UseVisualStyleBackColor = true;
            this.btn_load2.Click += new System.EventHandler(this.btn_load2_Click);
            // 
            // btn_save2
            // 
            this.btn_save2.Location = new System.Drawing.Point(620, 456);
            this.btn_save2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save2.Name = "btn_save2";
            this.btn_save2.Size = new System.Drawing.Size(109, 32);
            this.btn_save2.TabIndex = 4;
            this.btn_save2.Text = "저장";
            this.btn_save2.UseVisualStyleBackColor = true;
            this.btn_save2.Click += new System.EventHandler(this.btn_save2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 512);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(765, 22);
            this.progressBar1.TabIndex = 13;
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(828, 409);
            this.btn_match.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(109, 32);
            this.btn_match.TabIndex = 11;
            this.btn_match.Text = "탬플릿매칭";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1029, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(991, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "이현삼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(991, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "황형준";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(991, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "박성현";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(991, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "김연주";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(981, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub Link";
            //this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 572);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_gray);
            this.Controls.Add(this.scope_box);
            this.Controls.Add(this.btn_save2);
            this.Controls.Add(this.btn_load2);
            this.Controls.Add(this.btn_save1);
            this.Controls.Add(this.btn_load1);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.btn_lap);
            this.Controls.Add(this.btn_gau);
            this.Controls.Add(this.btn_otsu);
            this.Controls.Add(this.btn_hist);
            this.Controls.Add(this.btn_ero);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.LeftBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "ATI 팀프로젝트";
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scope_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftBox;
        private System.Windows.Forms.PictureBox RightBox;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_ero;
        private System.Windows.Forms.Button btn_hist;
        private System.Windows.Forms.Button btn_otsu;
        private System.Windows.Forms.Button btn_gau;
        private System.Windows.Forms.Button btn_lap;
        private System.Windows.Forms.PictureBox scope_box;
        private System.Windows.Forms.Label lbl_gray;
        private System.Windows.Forms.Button btn_load1;
        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_load2;
        private System.Windows.Forms.Button btn_save2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

