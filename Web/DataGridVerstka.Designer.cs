namespace Web
{
    partial class DataGridVerstka
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
            this.components = new System.ComponentModel.Container();
            this.версткаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.версткаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.версткаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdDataSet2 = new Web.bdDataSet();
            this.версткаBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.версткаTableAdapter1 = new Web.bdDataSetTableAdapters.ВерсткаTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // версткаBindingSource
            // 
            this.версткаBindingSource.DataMember = "Верстка";
            // 
            // версткаBindingSource1
            // 
            this.версткаBindingSource1.DataMember = "Верстка";
            // 
            // версткаBindingSource2
            // 
            this.версткаBindingSource2.DataMember = "Верстка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.версткаBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdDataSet2
            // 
            this.bdDataSet2.DataSetName = "bdDataSet";
            this.bdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // версткаBindingSource3
            // 
            this.версткаBindingSource3.DataMember = "Верстка";
            this.версткаBindingSource3.DataSource = this.bdDataSet2;
            // 
            // версткаTableAdapter1
            // 
            this.версткаTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Слайдеры";
            this.dataGridViewTextBoxColumn4.HeaderText = "Слайдеры";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Анимированные блоки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Анимированные блоки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Локализация";
            this.dataGridViewTextBoxColumn6.HeaderText = "Локализация";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Сложная структура";
            this.dataGridViewTextBoxColumn7.HeaderText = "Сложная структура";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Геопривязка";
            this.dataGridViewTextBoxColumn8.HeaderText = "Геопривязка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn9.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // DataGridVerstka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 176);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridVerstka";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource версткаBindingSource;
        private bdDataSetTableAdapters.ВерсткаTableAdapter версткаTableAdapter;
        private bdDataSet bdDataSet1;
        private System.Windows.Forms.BindingSource версткаBindingSource1;
        private System.Windows.Forms.BindingSource версткаBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn слайдерыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn анимированныеБлокиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn локализацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сложнаяСтруктураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn геопривязкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet bdDataSet2;
        private System.Windows.Forms.BindingSource версткаBindingSource3;
        private bdDataSetTableAdapters.ВерсткаTableAdapter версткаTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}