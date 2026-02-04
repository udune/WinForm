namespace CheckBox_Sample
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
            this.check_agree = new System.Windows.Forms.CheckBox();
            this.next_button = new System.Windows.Forms.Button();
            this.hobby_groupbox = new System.Windows.Forms.GroupBox();
            this.reading_check = new System.Windows.Forms.CheckBox();
            this.health_check = new System.Windows.Forms.CheckBox();
            this.game_check = new System.Windows.Forms.CheckBox();
            this.select_button = new System.Windows.Forms.Button();
            this.state_check = new System.Windows.Forms.CheckBox();
            this.current_state = new System.Windows.Forms.Label();
            this.hobby_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_agree
            // 
            this.check_agree.AutoSize = true;
            this.check_agree.Location = new System.Drawing.Point(34, 39);
            this.check_agree.Name = "check_agree";
            this.check_agree.Size = new System.Drawing.Size(232, 22);
            this.check_agree.TabIndex = 0;
            this.check_agree.Text = "이용 약관에 동의합니다.";
            this.check_agree.UseVisualStyleBackColor = true;
            this.check_agree.CheckedChanged += new System.EventHandler(this.agree_check);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(634, 39);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(123, 38);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "다음";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // hobby_groupbox
            // 
            this.hobby_groupbox.Controls.Add(this.current_state);
            this.hobby_groupbox.Controls.Add(this.state_check);
            this.hobby_groupbox.Controls.Add(this.select_button);
            this.hobby_groupbox.Controls.Add(this.game_check);
            this.hobby_groupbox.Controls.Add(this.health_check);
            this.hobby_groupbox.Controls.Add(this.reading_check);
            this.hobby_groupbox.Location = new System.Drawing.Point(34, 122);
            this.hobby_groupbox.Name = "hobby_groupbox";
            this.hobby_groupbox.Size = new System.Drawing.Size(723, 300);
            this.hobby_groupbox.TabIndex = 2;
            this.hobby_groupbox.TabStop = false;
            this.hobby_groupbox.Text = "취미를 선택하세요:";
            // 
            // reading_check
            // 
            this.reading_check.AutoSize = true;
            this.reading_check.Location = new System.Drawing.Point(40, 71);
            this.reading_check.Name = "reading_check";
            this.reading_check.Size = new System.Drawing.Size(70, 22);
            this.reading_check.TabIndex = 0;
            this.reading_check.Text = "독서";
            this.reading_check.UseVisualStyleBackColor = true;
            // 
            // health_check
            // 
            this.health_check.AutoSize = true;
            this.health_check.Location = new System.Drawing.Point(40, 118);
            this.health_check.Name = "health_check";
            this.health_check.Size = new System.Drawing.Size(70, 22);
            this.health_check.TabIndex = 1;
            this.health_check.Text = "운동";
            this.health_check.UseVisualStyleBackColor = true;
            // 
            // game_check
            // 
            this.game_check.AutoSize = true;
            this.game_check.Location = new System.Drawing.Point(40, 165);
            this.game_check.Name = "game_check";
            this.game_check.Size = new System.Drawing.Size(70, 22);
            this.game_check.TabIndex = 2;
            this.game_check.Text = "게임";
            this.game_check.UseVisualStyleBackColor = true;
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(590, 224);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(114, 49);
            this.select_button.TabIndex = 3;
            this.select_button.Text = "선택 확인";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // state_check
            // 
            this.state_check.AutoSize = true;
            this.state_check.Location = new System.Drawing.Point(40, 224);
            this.state_check.Name = "state_check";
            this.state_check.Size = new System.Drawing.Size(259, 22);
            this.state_check.TabIndex = 4;
            this.state_check.Text = "중간 상태 허용 (ThreeState)";
            this.state_check.ThreeState = true;
            this.state_check.UseVisualStyleBackColor = true;
            this.state_check.CheckStateChanged += new System.EventHandler(this.agree_state_check);
            // 
            // current_state
            // 
            this.current_state.AutoSize = true;
            this.current_state.Location = new System.Drawing.Point(40, 253);
            this.current_state.Name = "current_state";
            this.current_state.Size = new System.Drawing.Size(134, 18);
            this.current_state.TabIndex = 5;
            this.current_state.Text = "현재 상태: 없음";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hobby_groupbox);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.check_agree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.hobby_groupbox.ResumeLayout(false);
            this.hobby_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_agree;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.GroupBox hobby_groupbox;
        private System.Windows.Forms.CheckBox reading_check;
        private System.Windows.Forms.CheckBox health_check;
        private System.Windows.Forms.CheckBox game_check;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.CheckBox state_check;
        private System.Windows.Forms.Label current_state;
    }
}

