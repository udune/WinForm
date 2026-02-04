namespace TypeGame
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.score_title_label = new System.Windows.Forms.Label();
            this.remaintime_title_label = new System.Windows.Forms.Label();
            this.besttime_title_label = new System.Windows.Forms.Label();
            this.remaintime_label = new System.Windows.Forms.Label();
            this.example_label = new System.Windows.Forms.Label();
            this.score_value_label = new System.Windows.Forms.Label();
            this.besttime_value_label = new System.Windows.Forms.Label();
            this.pause_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.typeCount_label = new System.Windows.Forms.Label();
            this.typeCount_value_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(112, 136);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(555, 28);
            this.input_textbox.TabIndex = 0;
            this.input_textbox.TextChanged += new System.EventHandler(this.input_textbox_TextChanged);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(115, 209);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 46);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "시작";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // score_title_label
            // 
            this.score_title_label.AutoSize = true;
            this.score_title_label.Location = new System.Drawing.Point(416, 209);
            this.score_title_label.Name = "score_title_label";
            this.score_title_label.Size = new System.Drawing.Size(44, 18);
            this.score_title_label.TabIndex = 2;
            this.score_title_label.Text = "점수";
            // 
            // remaintime_title_label
            // 
            this.remaintime_title_label.AutoSize = true;
            this.remaintime_title_label.Location = new System.Drawing.Point(535, 209);
            this.remaintime_title_label.Name = "remaintime_title_label";
            this.remaintime_title_label.Size = new System.Drawing.Size(80, 18);
            this.remaintime_title_label.TabIndex = 3;
            this.remaintime_title_label.Text = "남은시간";
            // 
            // besttime_title_label
            // 
            this.besttime_title_label.AutoSize = true;
            this.besttime_title_label.Location = new System.Drawing.Point(535, 249);
            this.besttime_title_label.Name = "besttime_title_label";
            this.besttime_title_label.Size = new System.Drawing.Size(80, 18);
            this.besttime_title_label.TabIndex = 4;
            this.besttime_title_label.Text = "최단시간";
            // 
            // remaintime_label
            // 
            this.remaintime_label.AutoSize = true;
            this.remaintime_label.Location = new System.Drawing.Point(621, 209);
            this.remaintime_label.Name = "remaintime_label";
            this.remaintime_label.Size = new System.Drawing.Size(46, 18);
            this.remaintime_label.TabIndex = 5;
            this.remaintime_label.Text = "30초";
            // 
            // example_label
            // 
            this.example_label.AutoSize = true;
            this.example_label.Location = new System.Drawing.Point(115, 95);
            this.example_label.Name = "example_label";
            this.example_label.Size = new System.Drawing.Size(116, 18);
            this.example_label.TabIndex = 6;
            this.example_label.Text = "문제출제영역";
            // 
            // score_value_label
            // 
            this.score_value_label.AutoSize = true;
            this.score_value_label.Location = new System.Drawing.Point(466, 209);
            this.score_value_label.Name = "score_value_label";
            this.score_value_label.Size = new System.Drawing.Size(36, 18);
            this.score_value_label.TabIndex = 7;
            this.score_value_label.Text = "0점";
            // 
            // besttime_value_label
            // 
            this.besttime_value_label.AutoSize = true;
            this.besttime_value_label.Location = new System.Drawing.Point(621, 249);
            this.besttime_value_label.Name = "besttime_value_label";
            this.besttime_value_label.Size = new System.Drawing.Size(17, 18);
            this.besttime_value_label.TabIndex = 8;
            this.besttime_value_label.Text = "-";
            // 
            // pause_button
            // 
            this.pause_button.Location = new System.Drawing.Point(236, 209);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(100, 46);
            this.pause_button.TabIndex = 9;
            this.pause_button.Text = "일시정지";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(567, 352);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(100, 46);
            this.stop_button.TabIndex = 10;
            this.stop_button.Text = "종료";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(277, 18);
            this.title.TabIndex = 11;
            this.title.Text = "타자 연습 게임 (made by 김민찬)";
            // 
            // typeCount_label
            // 
            this.typeCount_label.AutoSize = true;
            this.typeCount_label.Location = new System.Drawing.Point(416, 249);
            this.typeCount_label.Name = "typeCount_label";
            this.typeCount_label.Size = new System.Drawing.Size(44, 18);
            this.typeCount_label.TabIndex = 12;
            this.typeCount_label.Text = "타수";
            // 
            // typeCount_value_label
            // 
            this.typeCount_value_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeCount_value_label.AutoSize = true;
            this.typeCount_value_label.Location = new System.Drawing.Point(475, 249);
            this.typeCount_value_label.Name = "typeCount_value_label";
            this.typeCount_value_label.Size = new System.Drawing.Size(18, 18);
            this.typeCount_value_label.TabIndex = 13;
            this.typeCount_value_label.Text = "0";
            this.typeCount_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeCount_value_label);
            this.Controls.Add(this.typeCount_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.besttime_value_label);
            this.Controls.Add(this.score_value_label);
            this.Controls.Add(this.example_label);
            this.Controls.Add(this.remaintime_label);
            this.Controls.Add(this.besttime_title_label);
            this.Controls.Add(this.remaintime_title_label);
            this.Controls.Add(this.score_title_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.input_textbox);
            this.Name = "Form1";
            this.Text = "타자 연습 게임";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label score_title_label;
        private System.Windows.Forms.Label remaintime_title_label;
        private System.Windows.Forms.Label besttime_title_label;
        private System.Windows.Forms.Label remaintime_label;
        private System.Windows.Forms.Label example_label;
        private System.Windows.Forms.Label score_value_label;
        private System.Windows.Forms.Label besttime_value_label;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label typeCount_label;
        private System.Windows.Forms.Label typeCount_value_label;
    }
}
