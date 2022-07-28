namespace team_Project {
    partial class Form1 {
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
            this.open_dlg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.Location = new System.Drawing.Point(24, 72);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(370, 370);
            this.LeftBox.TabIndex = 0;
            this.LeftBox.TabStop = false;
            // 
            // RightBox
            // 
            this.RightBox.Location = new System.Drawing.Point(419, 72);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(370, 370);
            this.RightBox.TabIndex = 0;
            this.RightBox.TabStop = false;
            // 
            // open_dlg
            // 
            this.open_dlg.Location = new System.Drawing.Point(24, 24);
            this.open_dlg.Name = "open_dlg";
            this.open_dlg.Size = new System.Drawing.Size(109, 33);
            this.open_dlg.TabIndex = 1;
            this.open_dlg.Text = "미니맵";
            this.open_dlg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "팽창연산";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "침식연산";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "히스토그램";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(810, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "오츠이진화";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(810, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "가우시안";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(810, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 33);
            this.button6.TabIndex = 1;
            this.button6.Text = "라플라시안";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(816, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.open_dlg);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.LeftBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftBox;
        private System.Windows.Forms.PictureBox RightBox;
        private System.Windows.Forms.Button open_dlg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

