namespace ContactApp1
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.phonebook_label = new System.Windows.Forms.Label();
            this.phonebook_textbox = new System.Windows.Forms.TextBox();
            this.result_listbox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(74, 57);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "이름:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(184, 47);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(282, 28);
            this.name_textbox.TabIndex = 3;
            // 
            // phonebook_label
            // 
            this.phonebook_label.AutoSize = true;
            this.phonebook_label.Location = new System.Drawing.Point(74, 115);
            this.phonebook_label.Name = "phonebook_label";
            this.phonebook_label.Size = new System.Drawing.Size(86, 18);
            this.phonebook_label.TabIndex = 4;
            this.phonebook_label.Text = "전화번호:";
            // 
            // phonebook_textbox
            // 
            this.phonebook_textbox.Location = new System.Drawing.Point(184, 105);
            this.phonebook_textbox.Name = "phonebook_textbox";
            this.phonebook_textbox.Size = new System.Drawing.Size(282, 28);
            this.phonebook_textbox.TabIndex = 5;
            // 
            // result_listbox
            // 
            this.result_listbox.FormattingEnabled = true;
            this.result_listbox.ItemHeight = 18;
            this.result_listbox.Location = new System.Drawing.Point(77, 246);
            this.result_listbox.Name = "result_listbox";
            this.result_listbox.Size = new System.Drawing.Size(389, 220);
            this.result_listbox.TabIndex = 6;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(77, 179);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(99, 36);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "추가";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(224, 179);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(99, 36);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "저장";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(367, 179);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(99, 36);
            this.load_button.TabIndex = 9;
            this.load_button.Text = "불러오기";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 515);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.result_listbox);
            this.Controls.Add(this.phonebook_textbox);
            this.Controls.Add(this.phonebook_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label phonebook_label;
        private System.Windows.Forms.TextBox phonebook_textbox;
        private System.Windows.Forms.ListBox result_listbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
    }
}

