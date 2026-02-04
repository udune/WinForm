namespace TextBox_App2
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
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(64, 162);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(178, 28);
            this.input_textBox.TabIndex = 0;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(290, 162);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(153, 28);
            this.check_btn.TabIndex = 1;
            this.check_btn.Text = "이름변경";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(64, 113);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(62, 18);
            this.result_label.TabIndex = 2;
            this.result_label.Text = "홍길동";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.input_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label result_label;
    }
}

