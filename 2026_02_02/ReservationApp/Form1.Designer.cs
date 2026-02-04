namespace ReservationApp
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
            this.date_label = new System.Windows.Forms.Label();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.count_label = new System.Windows.Forms.Label();
            this.count_combobox = new System.Windows.Forms.ComboBox();
            this.seat_groupbox = new System.Windows.Forms.GroupBox();
            this.middle_rdbtn = new System.Windows.Forms.RadioButton();
            this.hall_rdbtn = new System.Windows.Forms.RadioButton();
            this.window_rdbtn = new System.Windows.Forms.RadioButton();
            this.request_groupbox = new System.Windows.Forms.GroupBox();
            this.silent_checkbox = new System.Windows.Forms.CheckBox();
            this.consent_checkbox = new System.Windows.Forms.CheckBox();
            this.water_checkbox = new System.Windows.Forms.CheckBox();
            this.reservation_confirm_button = new System.Windows.Forms.Button();
            this.seat_groupbox.SuspendLayout();
            this.request_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(58, 61);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "이름:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(129, 51);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(317, 28);
            this.name_textbox.TabIndex = 1;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(58, 111);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(92, 18);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "날짜 선택:";
            // 
            // datetimepicker
            // 
            this.datetimepicker.Location = new System.Drawing.Point(182, 101);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(264, 28);
            this.datetimepicker.TabIndex = 3;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(58, 172);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(74, 18);
            this.count_label.TabIndex = 4;
            this.count_label.Text = "인원 수:";
            // 
            // count_combobox
            // 
            this.count_combobox.FormattingEnabled = true;
            this.count_combobox.Location = new System.Drawing.Point(182, 163);
            this.count_combobox.Name = "count_combobox";
            this.count_combobox.Size = new System.Drawing.Size(264, 26);
            this.count_combobox.TabIndex = 5;
            // 
            // seat_groupbox
            // 
            this.seat_groupbox.Controls.Add(this.middle_rdbtn);
            this.seat_groupbox.Controls.Add(this.hall_rdbtn);
            this.seat_groupbox.Controls.Add(this.window_rdbtn);
            this.seat_groupbox.Location = new System.Drawing.Point(61, 259);
            this.seat_groupbox.Name = "seat_groupbox";
            this.seat_groupbox.Size = new System.Drawing.Size(385, 114);
            this.seat_groupbox.TabIndex = 6;
            this.seat_groupbox.TabStop = false;
            this.seat_groupbox.Text = "좌석 위치";
            // 
            // middle_rdbtn
            // 
            this.middle_rdbtn.AutoSize = true;
            this.middle_rdbtn.Location = new System.Drawing.Point(269, 57);
            this.middle_rdbtn.Name = "middle_rdbtn";
            this.middle_rdbtn.Size = new System.Drawing.Size(69, 22);
            this.middle_rdbtn.TabIndex = 2;
            this.middle_rdbtn.Text = "중간";
            this.middle_rdbtn.UseVisualStyleBackColor = true;
            // 
            // hall_rdbtn
            // 
            this.hall_rdbtn.AutoSize = true;
            this.hall_rdbtn.Location = new System.Drawing.Point(147, 57);
            this.hall_rdbtn.Name = "hall_rdbtn";
            this.hall_rdbtn.Size = new System.Drawing.Size(69, 22);
            this.hall_rdbtn.TabIndex = 1;
            this.hall_rdbtn.Text = "복도";
            this.hall_rdbtn.UseVisualStyleBackColor = true;
            // 
            // window_rdbtn
            // 
            this.window_rdbtn.AutoSize = true;
            this.window_rdbtn.Checked = true;
            this.window_rdbtn.Location = new System.Drawing.Point(31, 57);
            this.window_rdbtn.Name = "window_rdbtn";
            this.window_rdbtn.Size = new System.Drawing.Size(69, 22);
            this.window_rdbtn.TabIndex = 0;
            this.window_rdbtn.TabStop = true;
            this.window_rdbtn.Text = "창가";
            this.window_rdbtn.UseVisualStyleBackColor = true;
            // 
            // request_groupbox
            // 
            this.request_groupbox.Controls.Add(this.silent_checkbox);
            this.request_groupbox.Controls.Add(this.consent_checkbox);
            this.request_groupbox.Controls.Add(this.water_checkbox);
            this.request_groupbox.Location = new System.Drawing.Point(61, 420);
            this.request_groupbox.Name = "request_groupbox";
            this.request_groupbox.Size = new System.Drawing.Size(385, 114);
            this.request_groupbox.TabIndex = 7;
            this.request_groupbox.TabStop = false;
            this.request_groupbox.Text = "추가 요청사항";
            // 
            // silent_checkbox
            // 
            this.silent_checkbox.AutoSize = true;
            this.silent_checkbox.Location = new System.Drawing.Point(249, 56);
            this.silent_checkbox.Name = "silent_checkbox";
            this.silent_checkbox.Size = new System.Drawing.Size(130, 22);
            this.silent_checkbox.TabIndex = 2;
            this.silent_checkbox.Text = "조용한 자리";
            this.silent_checkbox.UseVisualStyleBackColor = true;
            // 
            // consent_checkbox
            // 
            this.consent_checkbox.AutoSize = true;
            this.consent_checkbox.Location = new System.Drawing.Point(113, 56);
            this.consent_checkbox.Name = "consent_checkbox";
            this.consent_checkbox.Size = new System.Drawing.Size(130, 22);
            this.consent_checkbox.TabIndex = 1;
            this.consent_checkbox.Text = "콘센트 필요";
            this.consent_checkbox.UseVisualStyleBackColor = true;
            // 
            // water_checkbox
            // 
            this.water_checkbox.AutoSize = true;
            this.water_checkbox.Location = new System.Drawing.Point(21, 56);
            this.water_checkbox.Name = "water_checkbox";
            this.water_checkbox.Size = new System.Drawing.Size(94, 22);
            this.water_checkbox.TabIndex = 0;
            this.water_checkbox.Text = "물 제공";
            this.water_checkbox.UseVisualStyleBackColor = true;
            // 
            // reservation_confirm_button
            // 
            this.reservation_confirm_button.Location = new System.Drawing.Point(182, 581);
            this.reservation_confirm_button.Name = "reservation_confirm_button";
            this.reservation_confirm_button.Size = new System.Drawing.Size(124, 42);
            this.reservation_confirm_button.TabIndex = 8;
            this.reservation_confirm_button.Text = "예약 확인";
            this.reservation_confirm_button.UseVisualStyleBackColor = true;
            this.reservation_confirm_button.Click += new System.EventHandler(this.reservation_confirm_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 667);
            this.Controls.Add(this.reservation_confirm_button);
            this.Controls.Add(this.request_groupbox);
            this.Controls.Add(this.seat_groupbox);
            this.Controls.Add(this.count_combobox);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.seat_groupbox.ResumeLayout(false);
            this.seat_groupbox.PerformLayout();
            this.request_groupbox.ResumeLayout(false);
            this.request_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.ComboBox count_combobox;
        private System.Windows.Forms.GroupBox seat_groupbox;
        private System.Windows.Forms.RadioButton middle_rdbtn;
        private System.Windows.Forms.RadioButton hall_rdbtn;
        private System.Windows.Forms.RadioButton window_rdbtn;
        private System.Windows.Forms.GroupBox request_groupbox;
        private System.Windows.Forms.CheckBox silent_checkbox;
        private System.Windows.Forms.CheckBox consent_checkbox;
        private System.Windows.Forms.CheckBox water_checkbox;
        private System.Windows.Forms.Button reservation_confirm_button;
    }
}

