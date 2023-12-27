namespace Курсач
{
    partial class FormOfAuthorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfAuthorization));
            this.UserName_Label = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.UserPhone_Label = new System.Windows.Forms.Label();
            this.textBox_UserPhone = new System.Windows.Forms.TextBox();
            this.buttonOfJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reg_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.BackColor = System.Drawing.Color.Transparent;
            this.UserName_Label.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserName_Label.ForeColor = System.Drawing.Color.White;
            this.UserName_Label.Location = new System.Drawing.Point(12, 87);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(119, 16);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "Имя пользователя";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_UserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_UserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_UserName.Location = new System.Drawing.Point(135, 85);
            this.textBox_UserName.MaxLength = 25;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_UserName.Size = new System.Drawing.Size(169, 23);
            this.textBox_UserName.TabIndex = 1;
            this.textBox_UserName.Text = "Введите имя";
            this.textBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_UserName.Click += new System.EventHandler(this.textBox_UserName_Click);
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            this.textBox_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UserName_KeyPress);
            this.textBox_UserName.Leave += new System.EventHandler(this.textBox_UserName_Leave);
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
            this.UserPhone_Label.TabIndex = 2;
            this.UserPhone_Label.Text = "Номер телефона";
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
            this.textBox_UserPhone.TabIndex = 3;
            this.textBox_UserPhone.Text = "Введите номер телефона";
            this.textBox_UserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_UserPhone.Click += new System.EventHandler(this.textBox_UserPhone_Click);
            this.textBox_UserPhone.TextChanged += new System.EventHandler(this.textBox_UserPhone_TextChanged);
            this.textBox_UserPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UserPhone_KeyPress);
            this.textBox_UserPhone.Leave += new System.EventHandler(this.textBox_UserPhone_Leave);
            // 
            // buttonOfJoin
            // 
            this.buttonOfJoin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOfJoin.ForeColor = System.Drawing.Color.Black;
            this.buttonOfJoin.Location = new System.Drawing.Point(135, 160);
            this.buttonOfJoin.Name = "buttonOfJoin";
            this.buttonOfJoin.Size = new System.Drawing.Size(169, 23);
            this.buttonOfJoin.TabIndex = 4;
            this.buttonOfJoin.Text = " Войти";
            this.buttonOfJoin.UseVisualStyleBackColor = false;
            this.buttonOfJoin.Click += new System.EventHandler(this.buttonOfJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "нет аккаунта?";
            // 
            // Reg_LinkLabel
            // 
            this.Reg_LinkLabel.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.Reg_LinkLabel.AutoSize = true;
            this.Reg_LinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.Reg_LinkLabel.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Reg_LinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reg_LinkLabel.ForeColor = System.Drawing.Color.Gray;
            this.Reg_LinkLabel.LinkColor = System.Drawing.Color.Tan;
            this.Reg_LinkLabel.Location = new System.Drawing.Point(228, 188);
            this.Reg_LinkLabel.Name = "Reg_LinkLabel";
            this.Reg_LinkLabel.Size = new System.Drawing.Size(76, 15);
            this.Reg_LinkLabel.TabIndex = 6;
            this.Reg_LinkLabel.TabStop = true;
            this.Reg_LinkLabel.Text = "Регистрация";
            this.Reg_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reg_LinkLabel_LinkClicked);
            // 
            // FormOfAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Reg_LinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOfJoin);
            this.Controls.Add(this.textBox_UserPhone);
            this.Controls.Add(this.UserPhone_Label);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.UserName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOfAuthorization";
            this.Text = "Окно авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserName_Label;
        private TextBox textBox_UserName;
        private Label UserPhone_Label;
        private TextBox textBox_UserPhone;
        private Button buttonOfJoin;
        private Label label1;
        private LinkLabel Reg_LinkLabel;
    }
}