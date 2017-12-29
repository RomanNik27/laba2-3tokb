namespace Password
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.OldPassTxtBx = new System.Windows.Forms.TextBox();
            this.NewPassTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(82, 86);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(108, 23);
            this.ChangeBtn.TabIndex = 0;
            this.ChangeBtn.Text = "Сменить пароль";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // OldPassTxtBx
            // 
            this.OldPassTxtBx.Location = new System.Drawing.Point(141, 21);
            this.OldPassTxtBx.Name = "OldPassTxtBx";
            this.OldPassTxtBx.PasswordChar = '*';
            this.OldPassTxtBx.Size = new System.Drawing.Size(108, 20);
            this.OldPassTxtBx.TabIndex = 1;
            // 
            // NewPassTxtBx
            // 
            this.NewPassTxtBx.Location = new System.Drawing.Point(141, 47);
            this.NewPassTxtBx.Name = "NewPassTxtBx";
            this.NewPassTxtBx.PasswordChar = '*';
            this.NewPassTxtBx.Size = new System.Drawing.Size(108, 20);
            this.NewPassTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новый пароль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassTxtBx);
            this.Controls.Add(this.OldPassTxtBx);
            this.Controls.Add(this.ChangeBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сменить пароль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.TextBox OldPassTxtBx;
        private System.Windows.Forms.TextBox NewPassTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

