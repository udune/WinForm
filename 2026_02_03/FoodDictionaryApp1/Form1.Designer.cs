namespace FoodDictionaryApp1
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
            this.menu_label = new System.Windows.Forms.Label();
            this.menu_combobox = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.result_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Location = new System.Drawing.Point(61, 68);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(92, 18);
            this.menu_label.TabIndex = 0;
            this.menu_label.Text = "메뉴 선택:";
            // 
            // menu_combobox
            // 
            this.menu_combobox.FormattingEnabled = true;
            this.menu_combobox.Location = new System.Drawing.Point(178, 65);
            this.menu_combobox.Name = "menu_combobox";
            this.menu_combobox.Size = new System.Drawing.Size(254, 26);
            this.menu_combobox.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(64, 137);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(368, 33);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "추가";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(64, 197);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(368, 33);
            this.order_button.TabIndex = 3;
            this.order_button.Text = "결재";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // result_listbox
            // 
            this.result_listbox.BackColor = System.Drawing.SystemColors.Menu;
            this.result_listbox.FormattingEnabled = true;
            this.result_listbox.ItemHeight = 18;
            this.result_listbox.Location = new System.Drawing.Point(64, 283);
            this.result_listbox.Name = "result_listbox";
            this.result_listbox.Size = new System.Drawing.Size(368, 202);
            this.result_listbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 552);
            this.Controls.Add(this.result_listbox);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.menu_combobox);
            this.Controls.Add(this.menu_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.ComboBox menu_combobox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.ListBox result_listbox;
    }
}

