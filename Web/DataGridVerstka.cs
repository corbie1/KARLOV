﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class DataGridVerstka : Form
    {
        public DataGridVerstka()
        {
            InitializeComponent();
        }

        private void DataGridVerstka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Верстка". При необходимости она может быть перемещена или удалена.
            this.версткаTableAdapter.Fill(this.bdDataSet.Верстка);

        }
    }
}
