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
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.accdb;";

        bool numb = true;

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
                button2.Visible = true;
                label4.Visible = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;

            }
            else
            {
                textBox1.Visible = false;
                button2.Visible = false;
                label4.Visible = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
       

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (numb == true)
            {
                textBox2.Visible = true;
                numb = false;
            }
            else
            {
                textBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Верстка ([Имя],[Фамилия],[Слайдеры],[Анимированные блоки], [Локализация], [Сложная структура], [Цена])" +
                $" VALUES ()";
        }

        int geo = 0;
        int structure = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            int slider_price = 2000;
            int animation_price = 5000;
            int slider_number = (int)(numericUpDown1.Value);
            int animation_number = (int)(numericUpDown2.Value);

           if (checkBox2.Checked){
                structure = 15000;
                }
            if (checkBox3.Checked)
            {
                geo = 3000;
            }

        }
    }
}
