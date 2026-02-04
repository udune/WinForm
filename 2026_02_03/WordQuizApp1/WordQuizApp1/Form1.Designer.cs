namespace WordQuizApp1
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
            this.meaning_label = new System.Windows.Forms.Label();
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.result_listbox = new System.Windows.Forms.ListBox();
            this.quiz_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meaning_label
            // 
            this.meaning_label.AutoSize = true;
            this.meaning_label.Location = new System.Drawing.Point(51, 57);
            this.meaning_label.Name = "meaning_label";
            this.meaning_label.Size = new System.Drawing.Size(80, 18);
            this.meaning_label.TabIndex = 0;
            this.meaning_label.Text = "한글 뜻: ";
            // 
            // answer_textbox
            // 
            this.answer_textbox.Location = new System.Drawing.Point(54, 118);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(398, 28);
            this.answer_textbox.TabIndex = 1;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(54, 196);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(398, 37);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "정답 제출";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // result_listbox
            // 
            this.result_listbox.FormattingEnabled = true;
            this.result_listbox.ItemHeight = 18;
            this.result_listbox.Location = new System.Drawing.Point(54, 288);
            this.result_listbox.Name = "result_listbox";
            this.result_listbox.Size = new System.Drawing.Size(398, 166);
            this.result_listbox.TabIndex = 3;
            // 
            // quiz_label
            // 
            this.quiz_label.AutoSize = true;
            this.quiz_label.Location = new System.Drawing.Point(138, 57);
            this.quiz_label.Name = "quiz_label";
            this.quiz_label.Size = new System.Drawing.Size(44, 18);
            this.quiz_label.TabIndex = 4;
            this.quiz_label.Text = "학교";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 537);
            this.Controls.Add(this.quiz_label);
            this.Controls.Add(this.result_listbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.meaning_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label meaning_label;
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox result_listbox;
        private System.Windows.Forms.Label quiz_label;
    }
}

