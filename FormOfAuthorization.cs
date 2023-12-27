using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;

namespace Курсач
{
    public partial class FormOfAuthorization : Form, User
    {
        ApplicationContext appCon = new ApplicationContext();

        public string UserName { get; set; }
        public string UserPhone { get; set; }

        public FormOfAuthorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Методы описывают свойство состояния текста для тексбоксов "textBox_UserLogin" и "textBox_UserPhone"
        //В данном случае текст текстбоксов становится чёрным
        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {
            if(textBox_UserName.Text != "Введите имя") { textBox_UserName.ForeColor = Color.Black;}
        }

        private void textBox_UserPhone_TextChanged(object sender, EventArgs e) 
        {
            if (textBox_UserPhone.Text != "Введите номер телефона") { textBox_UserPhone.ForeColor = Color.Black; }
        }


        //Методы для описания свойста Click
        //По нажатию на текстбоксы формы очищаются, при условии, что был введён изначальный текст
        private void textBox_UserName_Click(object sender, System.EventArgs e)
        {
            if (textBox_UserName.Text == "Введите имя")
                textBox_UserName.Clear();
        }

        private void textBox_UserPhone_Click(object sender, EventArgs e)
        {
            if (textBox_UserPhone.Text == "Введите номер телефона")
                textBox_UserPhone.Clear();
        }

        //Метод определяется действия программы по нажатию на кнопку входа
        private void buttonOfJoin_Click(object sender, EventArgs e)
        {
            UserName = textBox_UserName.Text;
            UserPhone = textBox_UserPhone.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select Name, Phone from Customer where Name = '{this.UserName}' and Phone = '{this.UserPhone}'";

            SqlCommand command = new SqlCommand(querystring, appCon.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                UsersWorkForm frm2 = new UsersWorkForm();
                frm2.user_label.Text = this.UserName;
                frm2.userName= this.UserName;
                frm2.userPhone= this.UserPhone;
                this.Hide();
                frm2.ShowDialog();

                back("Введите имя", "Введите номер телефона");
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не сущестсвует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //Метод используется для перехода к форме регистрации, по нажатия на LinkLabel
        private void Reg_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOfRegistration frmReg = new FormOfRegistration();    
            this.Hide();
            frmReg.ShowDialog();

            back("Введите имя", "Введите номер телефона");
        }

        //Метод используется для ограничения введения возможных символов
        //Он допускает введение любых символов, кроме пробела
        private void textBox_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (number == 32) //пробел
            {
                e.Handled = true;
            }
        }

        //Метод используется для ограничения введения возможных символов
        //Он допускает введение только цифр, клавиши BackSpace и символа '+'
        private void textBox_UserPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }

        //Следующие методы описывают, что происходит с тексбоксами после того, как они перестают быть активными элементами формы
        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_UserName.ForeColor = SystemColors.WindowFrame;
                textBox_UserName.Text = "Введите имя";

            }
        }

        private void textBox_UserPhone_Leave(object sender, EventArgs e)
        {
            if (textBox_UserPhone.Text == "")
            {
                textBox_UserPhone.ForeColor = SystemColors.WindowFrame;
                textBox_UserPhone.Text = "Введите номер телефона";

            }
        }

        //Метод, задающий цвет шрифта и принимающий значение текса для тексбоксов
        private void back(string text1, string text2)
        {
            textBox_UserName.ForeColor = SystemColors.WindowFrame;
            textBox_UserPhone.ForeColor = SystemColors.WindowFrame;
            textBox_UserName.Text = text1;
            textBox_UserPhone.Text = text2;
            this.Show();
        }
    }
}