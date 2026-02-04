namespace RegistrationApp
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
            this.age_label = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.role_label = new System.Windows.Forms.Label();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            this.major_label = new System.Windows.Forms.Label();
            this.major_textbox = new System.Windows.Forms.TextBox();
            this.registration_button = new System.Windows.Forms.Button();
            this.output_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(46, 66);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(44, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "이름";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(162, 63);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(340, 28);
            this.name_textbox.TabIndex = 1;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(46, 126);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(44, 18);
            this.age_label.TabIndex = 2;
            this.age_label.Text = "나이";
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(162, 123);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(340, 28);
            this.age_textbox.TabIndex = 3;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(46, 202);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(44, 18);
            this.role_label.TabIndex = 4;
            this.role_label.Text = "역할";
            // 
            // role_combobox
            // 
            this.role_combobox.FormattingEnabled = true;
            this.role_combobox.Location = new System.Drawing.Point(162, 199);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(340, 26);
            this.role_combobox.TabIndex = 5;
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(46, 292);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(88, 18);
            this.major_label.TabIndex = 6;
            this.major_label.Text = "전공/과목";
            // 
            // major_textbox
            // 
            this.major_textbox.Location = new System.Drawing.Point(162, 289);
            this.major_textbox.Name = "major_textbox";
            this.major_textbox.Size = new System.Drawing.Size(340, 28);
            this.major_textbox.TabIndex = 7;
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(179, 366);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(193, 43);
            this.registration_button.TabIndex = 8;
            this.registration_button.Text = "등록";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // output_listbox
            // 
            this.output_listbox.FormattingEnabled = true;
            this.output_listbox.ItemHeight = 18;
            this.output_listbox.Location = new System.Drawing.Point(49, 447);
            this.output_listbox.Name = "output_listbox";
            this.output_listbox.Size = new System.Drawing.Size(453, 130);
            this.output_listbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 607);
            this.Controls.Add(this.output_listbox);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.major_textbox);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.role_combobox);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.age_label);
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
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.ComboBox role_combobox;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.TextBox major_textbox;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.ListBox output_listbox;
    }
}

