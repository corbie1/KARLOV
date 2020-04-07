using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Web
{

    public partial class Form2 : Form
    {
        private OleDbConnection myConnection;
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.mdb;";


        int geo = 3000;
        string geo_loc = "none";
        int structure = 15000;
        string hard_str = "none";
        int language = 0;
        int slider_price = 2000;
        int animation_price = 5000;
        int slider_number;
        int allPrice = 0;
        int animation_number;

        public Form2()
        {
            InitializeComponent();
            try
            {
                myConnection = new OleDbConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                new DataException("Отсутствует подключение");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Visible = true;
                label4.Visible = true;
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Visible = false;

                label4.Visible = false;
                textBox1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider_number = (int)(numericUpDown1.Value);
            animation_number = (int)(numericUpDown2.Value);
            string langtext = textBox1.Text;
            MessageBox.Show("Kek");
            string query = $"INSERT INTO Верстка ([Имя],[Фамилия],[Слайдеры],[Анимированные блоки], [Локализация], [Сложная структура], [Цена]) VALUES ({GlobalTrash.Username}, {GlobalTrash.Fam}, {slider_number}, {animation_number}, {langtext}, {geo_loc}, {hard_str}, {allPrice}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slider_number = (int)(numericUpDown1.Value);
            animation_number = (int)(numericUpDown2.Value);

            if (textBox1.Text != "")
            {
                language += 1000;
            }

            allPrice = slider_number * slider_price + animation_price * animation_number + language;

            if (checkBox2.Checked)
            {
                allPrice += structure;
                hard_str = "+";
            }


            if (checkBox3.Checked)
            {
                allPrice += geo;
                geo_loc = "+";

            }

            textBox4.Text = allPrice.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "SELECT Имя, Фамилия FROM Верстка";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            listBox1.Items.Clear();

            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
            }

            // закрываем OleDbDataReader
            reader.Close();
        }
    }
}
