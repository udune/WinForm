namespace RadioButton_App
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
            this.gender_groupbox = new System.Windows.Forms.GroupBox();
            this.rbtfemale = new System.Windows.Forms.RadioButton();
            this.rbtmale = new System.Windows.Forms.RadioButton();
            this.color_groupbox = new System.Windows.Forms.GroupBox();
            this.rbtblue = new System.Windows.Forms.RadioButton();
            this.rbtred = new System.Windows.Forms.RadioButton();
            this.result_button = new System.Windows.Forms.Button();
            this.gender_groupbox.SuspendLayout();
            this.color_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gender_groupbox
            // 
            this.gender_groupbox.Controls.Add(this.rbtfemale);
            this.gender_groupbox.Controls.Add(this.rbtmale);
            this.gender_groupbox.Location = new System.Drawing.Point(47, 58);
            this.gender_groupbox.Name = "gender_groupbox";
            this.gender_groupbox.Size = new System.Drawing.Size(198, 125);
            this.gender_groupbox.TabIndex = 0;
            this.gender_groupbox.TabStop = false;
            this.gender_groupbox.Text = "성별 선택";
            // 
            // rbtfemale
            // 
            this.rbtfemale.AutoSize = true;
            this.rbtfemale.Location = new System.Drawing.Point(21, 78);
            this.rbtfemale.Name = "rbtfemale";
            this.rbtfemale.Size = new System.Drawing.Size(69, 22);
            this.rbtfemale.TabIndex = 1;
            this.rbtfemale.TabStop = true;
            this.rbtfemale.Text = "여자";
            this.rbtfemale.UseVisualStyleBackColor = true;
            // 
            // rbtmale
            // 
            this.rbtmale.AutoSize = true;
            this.rbtmale.Checked = true;
            this.rbtmale.Location = new System.Drawing.Point(21, 41);
            this.rbtmale.Name = "rbtmale";
            this.rbtmale.Size = new System.Drawing.Size(69, 22);
            this.rbtmale.TabIndex = 0;
            this.rbtmale.TabStop = true;
            this.rbtmale.Text = "남자";
            this.rbtmale.UseVisualStyleBackColor = true;
            // 
            // color_groupbox
            // 
            this.color_groupbox.Controls.Add(this.rbtblue);
            this.color_groupbox.Controls.Add(this.rbtred);
            this.color_groupbox.Location = new System.Drawing.Point(313, 58);
            this.color_groupbox.Name = "color_groupbox";
            this.color_groupbox.Size = new System.Drawing.Size(200, 125);
            this.color_groupbox.TabIndex = 1;
            this.color_groupbox.TabStop = false;
            this.color_groupbox.Text = "색상 선택";
            // 
            // rbtblue
            // 
            this.rbtblue.AutoSize = true;
            this.rbtblue.Location = new System.Drawing.Point(26, 78);
            this.rbtblue.Name = "rbtblue";
            this.rbtblue.Size = new System.Drawing.Size(69, 22);
            this.rbtblue.TabIndex = 3;
            this.rbtblue.TabStop = true;
            this.rbtblue.Text = "파랑";
            this.rbtblue.UseVisualStyleBackColor = true;
            // 
            // rbtred
            // 
            this.rbtred.AutoSize = true;
            this.rbtred.Checked = true;
            this.rbtred.Location = new System.Drawing.Point(26, 41);
            this.rbtred.Name = "rbtred";
            this.rbtred.Size = new System.Drawing.Size(69, 22);
            this.rbtred.TabIndex = 2;
            this.rbtred.TabStop = true;
            this.rbtred.Text = "빨강";
            this.rbtred.UseVisualStyleBackColor = true;
            // 
            // result_button
            // 
            this.result_button.Location = new System.Drawing.Point(223, 267);
            this.result_button.Name = "result_button";
            this.result_button.Size = new System.Drawing.Size(113, 75);
            this.result_button.TabIndex = 2;
            this.result_button.Text = "선택 결과";
            this.result_button.UseVisualStyleBackColor = true;
            this.result_button.Click += new System.EventHandler(this.result_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.result_button);
            this.Controls.Add(this.color_groupbox);
            this.Controls.Add(this.gender_groupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gender_groupbox.ResumeLayout(false);
            this.gender_groupbox.PerformLayout();
            this.color_groupbox.ResumeLayout(false);
            this.color_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gender_groupbox;
        private System.Windows.Forms.GroupBox color_groupbox;
        private System.Windows.Forms.RadioButton rbtfemale;
        private System.Windows.Forms.RadioButton rbtmale;
        private System.Windows.Forms.RadioButton rbtblue;
        private System.Windows.Forms.RadioButton rbtred;
        private System.Windows.Forms.Button result_button;
    }
}

