using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.PortableExecutable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Курсач
{
    public partial class FormOfRegistration : Form, User
    {

        ApplicationContext appCon = new ApplicationContext();

        public string UserName { get; set; }
        public string UserPhone { get; set; }

        public FormOfRegistration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Метод используется для возврата в окно регистраци по нажатию на ссылку
        private void Auth_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Методы описывают свойство состояния текста для тексбоксов "textBox_UserLogin" и "textBox_UserPhone"
        //В данном случае текст текстбоксов становится чёрным
        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_UserName.Text != "Введите имя") { textBox_UserName.ForeColor = Color.Black; }
        }

        private void textBox_UserPhone_TextChanged(object sender, EventArgs e)
        {
            if (textBox_UserPhone.Text != "Введите номер телефона") { textBox_UserPhone.ForeColor = Color.Black; }
        }

        //Методы для описания свойста Click
        //По нажатию на текстбоксы формы очищаются, при условии, что был введён изначальный текст
        private void textBox_UserPhone_Click(object sender, EventArgs e)
        {
            if (textBox_UserPhone.Text == "Введите номер телефона")
                textBox_UserPhone.Clear();
        }

        private void textBox_UserName_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "Введите имя")
                textBox_UserName.Clear();
        }

        //Метод определяется действия программы по нажатию на кнопку регистрации
        private void buttonOfReg_Click(object sender, EventArgs e)
        {
            if (chekUser())
            {
                return;
            }

            UserName = textBox_UserName.Text;
            UserPhone = textBox_UserPhone.Text;

            string querystring = $"insert into Customer (Name, Phone) values( '{UserName}', '{UserPhone}')";

            SqlCommand command = new SqlCommand(querystring, appCon.GetConnection());

            appCon.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Аккаунт успешно создан!", "Успешная регистрация");

                UsersWorkForm frm2 = new UsersWorkForm();
                frm2.user_label.Text = this.UserName;
                frm2.userName = this.UserName;
                frm2.userPhone = this.UserPhone;
                this.Hide();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            appCon.closeConnection();

        }

        //Метод используется для проверку наличия пользователя в базе данных
        private Boolean chekUser()
        {
            UserName = textBox_UserName.Text;
            UserPhone = textBox_UserPhone.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Name, Phone from Customer where Name = '{UserName}' and Phone = '{UserPhone}'";

            SqlCommand command = new SqlCommand(querystring, appCon.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
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

        //Методы описывают, что происходит с тексбоксами после того, как они перестают быть активными элементами формы
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
