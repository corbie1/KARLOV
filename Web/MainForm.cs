using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{

    public partial class MainForm : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.mdb;";
        private OleDbConnection myConnection;
        

        int geo = 3000;
        string geo_loc = "none";
        int structure = 15000;
        string hard_str = "none";
        int language = 0;
        int slider_price = 2000;
        int animation_price = 5000;
        int slider_number = 0;
        int allPrice = 0;
        int animation_number = 0;
        int contactForm = 0;
        int OnlineChat = 0;
        int mail = 0;
        int pages = 0;
        int searches = 0;
        int pages_number = 0;
        string searches_block = "none";

        public MainForm()
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Модули". При необходимости она может быть перемещена или удалена.
            this.модулиTableAdapter.Fill(this.bdDataSet.Модули);

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
            string query = $"INSERT INTO Верстка (Имя, Фамилия, Слайдеры, [Анимированные блоки], Локализация, [Сложная структура], Геопривязка, Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{slider_number}', '{animation_number}', '{langtext}',  '{hard_str}', '{geo_loc}', '{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();

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

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridVerstka frm = new DataGridVerstka();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            allPrice = 0;
            if (checkBox4.Checked)
            {
                contactForm = 5000;
            }
            else
            {
                contactForm.ToString("none");
            }
            if (checkBox5.Checked)
            {
                OnlineChat = 4000;
            }
            else
            {
                OnlineChat.ToString("none");
            }
            if (checkBox6.Checked)
            {
                mail = 3000;
            }
            else
            {
                mail.ToString("none");
            }
            allPrice = mail + OnlineChat + contactForm;
            textBox2.Text = allPrice.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Модули (Имя, Фамилия, [Форма обратной связи], [Настройка почты], [Онлайн чат], Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{contactForm}', '{mail}', '{OnlineChat}','{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            allPrice = 0;
            pages_number = (int)(numericUpDown3.Value);

            pages = 500;
            searches = 300;
            if(checkBox7.Checked) {
                allPrice = (pages + searches) * pages_number;
                searches_block = "+";
            }
            else
            {
                allPrice = pages * pages_number;
            }
          
                textBox3.Text = allPrice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridModules frm = new DataGridModules();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridNapolnenie frm = new DataGridNapolnenie();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Наполнение (Имя, Фамилия, [Количество страниц], [Поиск и обработка информации], Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{pages_number}', '{searches_block}','{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }
    }
}
