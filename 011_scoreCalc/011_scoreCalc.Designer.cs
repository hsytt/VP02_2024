namespace _011_scoreCalc
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblKor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEng);
            this.groupBox1.Controls.Add(this.txtMath);
            this.groupBox1.Controls.Add(this.txtKor);
            this.groupBox1.Controls.Add(this.lblEng);
            this.groupBox1.Controls.Add(this.lblMath);
            this.groupBox1.Controls.Add(this.lblKor);
            this.groupBox1.Location = new System.Drawing.Point(35, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(188, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(67, 165);
            this.txtEng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 23);
            this.txtEng.TabIndex = 5;
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(67, 107);
            this.txtMath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 23);
            this.txtMath.TabIndex = 4;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKor
            // 
            this.txtKor.Location = new System.Drawing.Point(67, 49);
            this.txtKor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(100, 23);
            this.txtKor.TabIndex = 3;
            this.txtKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(20, 168);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(31, 15);
            this.lblEng.TabIndex = 2;
            this.lblEng.Text = "영어";
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Location = new System.Drawing.Point(19, 111);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(31, 15);
            this.lblMath.TabIndex = 1;
            this.lblMath.Text = "수학";
            // 
            // lblKor
            // 
            this.lblKor.AutoSize = true;
            this.lblKor.Location = new System.Drawing.Point(16, 53);
            this.lblKor.Name = "lblKor";
            this.lblKor.Size = new System.Drawing.Size(35, 15);
            this.lblKor.TabIndex = 0;
            this.lblKor.Text = " 국어";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAvg);
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.lblAvg);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Location = new System.Drawing.Point(258, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(188, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(65, 80);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(100, 23);
            this.txtAvg.TabIndex = 6;
            this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(65, 34);
            this.txtSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 23);
            this.txtSum.TabIndex = 5;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(21, 84);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(31, 15);
            this.lblAvg.TabIndex = 4;
            this.lblAvg.Text = "평균";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(21, 39);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 15);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "총점";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Label lblKor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtSum;
    }
}

