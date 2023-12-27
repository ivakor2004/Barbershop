using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms.Design;

namespace Курсач
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class UsersWorkForm : Form
    {

        ApplicationContext appCon = new ApplicationContext();
        int selectedRow;

        private string date;//текст, который выводятся в текстбокс о выбранной дате из календаря


        private int 
            thisTable, //текущая отображаемая таблица
            thisCalendar; //принимает значение о запуске календаря

        private string //выделенные в таблицах переменные
            highlightIdStaff,
            highlightIdProd,
            highlightIdRec,
            highlighEmployee,
            highlighProduct,
            highlighTime,
            highlighDate;

        private string //выбранные из таблиц данные
            selectedIdStaff,
            selectedIdProd,
            selectedIdRec,
            selectedRecord,
            selectedDate,
            selectedTime; 

        public string userName; //Имя текущего пользователя
        public string userPhone; //Номер телефона текущего пользователя

        public UsersWorkForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //Методы, которые создают колонки таблицы для dataGridView, отображения и размера колонок таблиц, отображаемых в dataGridView 
        private void CreateColumnsOfEmployee()
        {
            dataGridView1.Columns.Clear();
            monthCalendar.Visible = false;

            dataGridView1.Columns.Add("IdStaff", "id");
            dataGridView1.Columns.Add("Name", "Имя Барбера");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            this.dataGridView1.Columns["IdStaff"].Visible = false; //Колокнка с id барберов не будет отображаться
            this.dataGridView1.Columns["IsNew"].Visible = false;
            this.dataGridView1.Columns["Name"].Width = 522; //Колонка "Имя барбера" имеет ширину 522

        }

        private void CreateColumnsOfService()
        {
            dataGridView1.Columns.Clear();
            monthCalendar.Visible = false;

            dataGridView1.Columns.Add("IdProd", "id");
            dataGridView1.Columns.Add("Name", "Услуга");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add("Discription", "Описание услуги");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            this.dataGridView1.Columns["IdProd"].Visible = false;
            this.dataGridView1.Columns["Discription"].Visible = false;
            this.dataGridView1.Columns["IsNew"].Visible = false;
            this.dataGridView1.Columns["Name"].Width = 455;
            this.dataGridView1.Columns["Price"].Width = 50;
        }

        private void CreateColumnsOfRecord()
        {
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("IdRec", "idRec");
            dataGridView2.Columns.Add("Record", "Время записи");
            dataGridView2.Columns.Add("IsNew", String.Empty);

            this.dataGridView2.Columns["IdRec"].Visible = false;
            this.dataGridView2.Columns["IsNew"].Visible = false;
            this.dataGridView2.Columns["Record"].Width = 164;
        }

        //Методы для определения типа данных колонок таблиц, отображаемых в dataGridView
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
 
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);

        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);

        }
        //Методы для определения таблиц и данных БД из которой берутся данные для таблиц, отображаемых в dataGridView
        private void RefreshDataGridOfEmployee(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Employee";

            SqlCommand command = new SqlCommand(queryString, appCon.GetConnection());

            appCon.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            thisTable = 1;
        }

        private void RefreshDataGridOfService(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Service";

            SqlCommand command = new SqlCommand(queryString, appCon.GetConnection());

            appCon.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(dgw, reader);
            }
            reader.Close();
            thisTable = 2;
        }

        private void RefreshDataGridOfRecord(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Records";

            SqlCommand command = new SqlCommand(queryString, appCon.GetConnection());

            appCon.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        //Методы, которые определяют, что происходит, после нажатия на поле в таблицах, отображаемых в dataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                if(thisTable == 1)//Если отображается первая таблица
                {
                    highlighEmployee = row.Cells[1].Value.ToString();//имя барбера
                    highlightIdStaff = row.Cells[0].Value.ToString();//id барбера
                }
                if (thisTable == 2)//Если отображается вторая таблица
                {
                    highlighProduct = row.Cells[1].Value.ToString();//наименование услуги
                    highlightIdProd = row.Cells[0].Value.ToString();//id услуги
                }

            }
        }

        //Если отображается dataGridView2
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                highlighTime = row.Cells[1].Value.ToString();//выбранное время записи
                highlightIdRec = row.Cells[0].Value.ToString();//id времени записи
            }
        }

        //Метод используется для того, чтобы нажатию на кнопку "Оформить заказ" выбранные данные заносились в базу данных
       
        private void AddOrd_button_Click(object sender, EventArgs e)
        {
            if (chekTextBox())
            {
                return;
            }

            int IdStaff = Convert.ToInt16(selectedIdStaff) ; //id барбера
            int IdProd = Convert.ToInt16(selectedIdProd); //id услуги
            string dateOfOrd = selectedDate; //дата
            int IdRec = Convert.ToInt16(selectedIdRec); //id времени записи
            string Record = selectedRecord; //время записи
            string loginUser = userName; //текущий пользователь
            string phoneUser = userPhone; //номер телефона текущего пользователя

            string querystring = $"insert into [Order] (IdStaff, IdProd, dateOfOrd, IdRec, Record, Name, Phone) values ('{IdStaff}','{IdProd}','{dateOfOrd}','{IdRec}','{Record}','{loginUser}', '{phoneUser}')";

            SqlCommand command = new SqlCommand(querystring, appCon.GetConnection());

            appCon.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"Заказ оформлен:\nУслуга: {textBox_Service.Text}\nДата и время: {date + " " + selectedTime}\nСпециалист: {textBox_Employee.Text} ", "Успешная регистрация");
            }
            else
            {
                MessageBox.Show("Повторите попытку...", "Ошибка!");
            }

            appCon.closeConnection();
        }

        //Метод выполняет проверку, все ли данные внесены в тексбоксы
        private Boolean chekTextBox()
        {

            if (textBox_Service.Text == null || textBox_Time.Text.Length < 28 || textBox_Employee.Text == null)
            {
                MessageBox.Show("Заполните все формы и повторите попытку");
                return true;
            }
            else
            {
                return false;
            }
        }

        //Метод переносит выбранные  данные из таблиц и календаря в текстбоксы, при условии что отображается таблица, содержащая выбранные данные
        private void selectionButton_Click(object sender, EventArgs e)
        {

            if (thisTable == 1)
            {
                textBox_Employee.Text = highlighEmployee;
                selectedIdStaff = highlightIdStaff;
            }

            if (thisTable == 2)
            {
                textBox_Service.Text = highlighProduct;
                selectedIdProd = highlightIdProd;
            }

            if (thisTable == 3&& thisCalendar == 1)
            { 
                date = String.Format("Вы выбрали: {0}", highlighDate);
                selectedIdRec = highlightIdRec;
                selectedDate = highlighDate;
                selectedTime = highlighTime;

                textBox_Time.Text = date + " " + highlighTime;
            }
        }

        //Метод определяющий действия после нажатия на кнопку удаления данных текущей таблицы из текстбокса
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (thisTable == 1)
            {
                textBox_Employee.Clear();
            }

            if (thisTable == 2)
            {
                textBox_Service.Clear();
            }

            if (thisTable == 3 && thisCalendar == 1)
            {
                textBox_Time.Clear();
            }
        }

        //После нажатия на ссылку закрыватеся текущее окно, и открывается окно авторизации
        private void Auth_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Методы, которые описывают действия, по нажатию на кнопки "employeeButton", "serviceButton", "TimeButton"
        //По нажатию на них в dataGridView отображается выбранная таблица
        private void employeeButton_Click(object sender, EventArgs e) 
        {
            dataGridView2.Visible = false;
            CreateColumnsOfEmployee();
            RefreshDataGridOfEmployee(dataGridView1);
        }
        private void serviceButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;    
            CreateColumnsOfService();
            RefreshDataGridOfService(dataGridView1);
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            thisCalendar = 1;
            thisTable = 3;
            dataGridView1.Columns.Clear();
            monthCalendar.Visible = true;
            dataGridView2.Visible = true;
            CreateColumnsOfRecord();
            RefreshDataGridOfRecord(dataGridView2);
        }

        //Метод, заносящий в переменную date1 данные о выбранном поле календаря "monthCalendar"
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            highlighDate = e.Start.ToShortDateString();
        } 

    }
}
