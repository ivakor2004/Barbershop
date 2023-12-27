namespace Курсач
{
    partial class FormOfRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfRegistration));
            this.buttonOfReg = new System.Windows.Forms.Button();
            this.textBox_UserPhone = new System.Windows.Forms.TextBox();
            this.UserPhone_Label = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Auth_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOfReg
            // 
            this.buttonOfReg.Location = new System.Drawing.Point(135, 160);
            this.buttonOfReg.Name = "buttonOfReg";
            this.buttonOfReg.Size = new System.Drawing.Size(169, 23);
            this.buttonOfReg.TabIndex = 9;
            this.buttonOfReg.Text = "Зарегистрироваться";
            this.buttonOfReg.UseVisualStyleBackColor = true;
            this.buttonOfReg.Click += new System.EventHandler(this.buttonOfReg_Click);
            // 
            // textBox_UserPhone
            // 
            this.textBox_UserPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_UserPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserPhone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_UserPhone.Location = new System.Drawing.Point(135, 120);
            this.textBox_UserPhone.MaxLength = 13;
            this.textBox_UserPhone.Name = "textBox_UserPhone";
            this.textBox_UserPhone.Size = new System.Drawing.Size(169, 23);
            this.textBox_UserPhone.TabIndex = 8;
            this.textBox_UserPhone.Text = "Введите номер телефона";
            this.textBox_UserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_UserPhone.Click += new System.EventHandler(this.textBox_UserPhone_Click);
            this.textBox_UserPhone.TextChanged += new System.EventHandler(this.textBox_UserPhone_TextChanged);
            this.textBox_UserPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UserPhone_KeyPress);
            this.textBox_UserPhone.Leave += new System.EventHandler(this.textBox_UserPhone_Leave);
            // 
            // UserPhone_Label
            // 
            this.UserPhone_Label.AutoSize = true;
            this.UserPhone_Label.BackColor = System.Drawing.Color.Transparent;
            this.UserPhone_Label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserPhone_Label.ForeColor = System.Drawing.Color.White;
            this.UserPhone_Label.Location = new System.Drawing.Point(20, 122);
            this.UserPhone_Label.Name = "UserPhone_Label";
            this.UserPhone_Label.Size = new System.Drawing.Size(105, 16);
            this.UserPhone_Label.TabIndex = 7;
            this.UserPhone_Label.Text = "Номер телефона";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_UserName.Location = new System.Drawing.Point(135, 85);
            this.textBox_UserName.MaxLength = 25;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(169, 23);
            this.textBox_UserName.TabIndex = 6;
            this.textBox_UserName.Text = "Введите имя";
            this.textBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_UserName.Click += new System.EventHandler(this.textBox_UserName_Click);
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            this.textBox_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UserName_KeyPress);
            this.textBox_UserName.Leave += new System.EventHandler(this.textBox_UserName_Leave);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.BackColor = System.Drawing.Color.Transparent;
            this.Login_label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_label.ForeColor = System.Drawing.Color.White;
            this.Login_label.Location = new System.Drawing.Point(12, 87);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(119, 16);
            this.Login_label.TabIndex = 5;
            this.Login_label.Text = "Имя пользователя";
            // 
            // Auth_label
            // 
            this.Auth_label.AutoSize = true;
            this.Auth_label.BackColor = System.Drawing.Color.Transparent;
            this.Auth_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Auth_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Auth_label.ForeColor = System.Drawing.Color.Tan;
            this.Auth_label.Location = new System.Drawing.Point(12, 9);
            this.Auth_label.Name = "Auth_label";
            this.Auth_label.Size = new System.Drawing.Size(156, 15);
            this.Auth_label.TabIndex = 10;
            this.Auth_label.Text = "Назад в окно авторизации";
            this.Auth_label.Click += new System.EventHandler(this.Auth_label_Click);
            // 
            // FormOfRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Auth_label);
            this.Controls.Add(this.buttonOfReg);
            this.Controls.Add(this.textBox_UserPhone);
            this.Controls.Add(this.UserPhone_Label);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.Login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOfRegistration";
            this.Text = "Окно регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOfReg;
        private TextBox textBox_UserPhone;
        private Label UserPhone_Label;
        private TextBox textBox_UserName;
        private Label Login_label;
        private Label Auth_label;
    }
}