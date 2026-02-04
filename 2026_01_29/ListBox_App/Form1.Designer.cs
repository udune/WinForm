namespace ListBox_App
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
            this.listbox = new System.Windows.Forms.ListBox();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.input_txtbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 18;
            this.listbox.Location = new System.Drawing.Point(40, 53);
            this.listbox.Name = "listbox";
            this.listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listbox.Size = new System.Drawing.Size(272, 274);
            this.listbox.TabIndex = 0;
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.select_btn);
            this.grpbox.Controls.Add(this.delete_btn);
            this.grpbox.Controls.Add(this.add_btn);
            this.grpbox.Controls.Add(this.input_txtbox);
            this.grpbox.Controls.Add(this.listbox);
            this.grpbox.Location = new System.Drawing.Point(40, 34);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(714, 368);
            this.grpbox.TabIndex = 1;
            this.grpbox.TabStop = false;
            // 
            // input_txtbox
            // 
            this.input_txtbox.Location = new System.Drawing.Point(350, 62);
            this.input_txtbox.Name = "input_txtbox";
            this.input_txtbox.Size = new System.Drawing.Size(288, 28);
            this.input_txtbox.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(350, 137);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(146, 43);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "추가";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(350, 209);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(146, 43);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "선택 삭제";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(350, 284);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(146, 43);
            this.select_btn.TabIndex = 4;
            this.select_btn.Text = "선택";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox input_txtbox;
    }
}

