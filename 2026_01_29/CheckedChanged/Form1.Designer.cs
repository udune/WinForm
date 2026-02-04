namespace CheckedChanged
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.state_label = new System.Windows.Forms.Label();
            this.hobby_groupbox = new System.Windows.Forms.GroupBox();
            this.check_apple = new System.Windows.Forms.CheckBox();
            this.check_banana = new System.Windows.Forms.CheckBox();
            this.check_orange = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.hobby_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.state_label);
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "C#은 쉽고 재미있습니다";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(16, 63);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(195, 22);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "동의 하시겠습니까?";
            this.checkBox.ThreeState = true;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.agreeCheck_Click);
            this.checkBox.CheckStateChanged += new System.EventHandler(this.agreeStateCheck_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(202, 263);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(138, 65);
            this.checkbutton.TabIndex = 1;
            this.checkbutton.Text = "button1";
            this.checkbutton.UseVisualStyleBackColor = true;
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(237, 64);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(54, 18);
            this.state_label.TabIndex = 2;
            this.state_label.Text = "label2";
            // 
            // hobby_groupbox
            // 
            this.hobby_groupbox.Controls.Add(this.button1);
            this.hobby_groupbox.Controls.Add(this.check_orange);
            this.hobby_groupbox.Controls.Add(this.check_banana);
            this.hobby_groupbox.Controls.Add(this.check_apple);
            this.hobby_groupbox.Location = new System.Drawing.Point(581, 113);
            this.hobby_groupbox.Name = "hobby_groupbox";
            this.hobby_groupbox.Size = new System.Drawing.Size(297, 142);
            this.hobby_groupbox.TabIndex = 2;
            this.hobby_groupbox.TabStop = false;
            this.hobby_groupbox.Text = "과일선택";
            // 
            // check_apple
            // 
            this.check_apple.AutoSize = true;
            this.check_apple.Location = new System.Drawing.Point(15, 45);
            this.check_apple.Name = "check_apple";
            this.check_apple.Size = new System.Drawing.Size(70, 22);
            this.check_apple.TabIndex = 0;
            this.check_apple.Text = "사과";
            this.check_apple.UseVisualStyleBackColor = true;
            // 
            // check_banana
            // 
            this.check_banana.AutoSize = true;
            this.check_banana.Location = new System.Drawing.Point(15, 73);
            this.check_banana.Name = "check_banana";
            this.check_banana.Size = new System.Drawing.Size(88, 22);
            this.check_banana.TabIndex = 1;
            this.check_banana.Text = "바나나";
            this.check_banana.UseVisualStyleBackColor = true;
            // 
            // check_orange
            // 
            this.check_orange.AutoSize = true;
            this.check_orange.Location = new System.Drawing.Point(15, 101);
            this.check_orange.Name = "check_orange";
            this.check_orange.Size = new System.Drawing.Size(88, 22);
            this.check_orange.TabIndex = 2;
            this.check_orange.Text = "오렌지";
            this.check_orange.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "선택된 과일은?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 589);
            this.Controls.Add(this.hobby_groupbox);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hobby_groupbox.ResumeLayout(false);
            this.hobby_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.GroupBox hobby_groupbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_orange;
        private System.Windows.Forms.CheckBox check_banana;
        private System.Windows.Forms.CheckBox check_apple;
    }
}

