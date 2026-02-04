namespace ComboBox_App_2
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
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.fruitselectgrp = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fruitselectgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(17, 50);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(196, 26);
            this.cbbox.TabIndex = 0;
            this.cbbox.SelectedIndexChanged += new System.EventHandler(this.cbbox_SelectedIndexChanged);
            // 
            // fruitselectgrp
            // 
            this.fruitselectgrp.Controls.Add(this.button1);
            this.fruitselectgrp.Controls.Add(this.lb);
            this.fruitselectgrp.Controls.Add(this.cbbox);
            this.fruitselectgrp.Location = new System.Drawing.Point(37, 35);
            this.fruitselectgrp.Name = "fruitselectgrp";
            this.fruitselectgrp.Size = new System.Drawing.Size(329, 220);
            this.fruitselectgrp.TabIndex = 1;
            this.fruitselectgrp.TabStop = false;
            this.fruitselectgrp.Text = "과일선택예제";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(25, 147);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 18);
            this.lb.TabIndex = 1;
            this.lb.Text = "결과";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "과일";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fruitselectgrp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fruitselectgrp.ResumeLayout(false);
            this.fruitselectgrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.GroupBox fruitselectgrp;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button button1;
    }
}

