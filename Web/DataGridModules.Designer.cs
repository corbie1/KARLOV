namespace Web
{
    partial class DataGridModules
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bdDataSet = new Web.bdDataSet();
            this.модулиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.модулиTableAdapter = new Web.bdDataSetTableAdapters.МодулиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбратнойСвязиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.настройкаПочтыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.онлайнЧатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модулиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.формаОбратнойСвязиDataGridViewTextBoxColumn,
            this.настройкаПочтыDataGridViewTextBoxColumn,
            this.онлайнЧатDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.модулиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // модулиBindingSource
            // 
            this.модулиBindingSource.DataMember = "Модули";
            this.модулиBindingSource.DataSource = this.bdDataSet;
            // 
            // модулиTableAdapter
            // 
            this.модулиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // формаОбратнойСвязиDataGridViewTextBoxColumn
            // 
            this.формаОбратнойСвязиDataGridViewTextBoxColumn.DataPropertyName = "Форма обратной связи";
            this.формаОбратнойСвязиDataGridViewTextBoxColumn.HeaderText = "Форма обратной связи";
            this.формаОбратнойСвязиDataGridViewTextBoxColumn.Name = "формаОбратнойСвязиDataGridViewTextBoxColumn";
            // 
            // настройкаПочтыDataGridViewTextBoxColumn
            // 
            this.настройкаПочтыDataGridViewTextBoxColumn.DataPropertyName = "Настройка почты";
            this.настройкаПочтыDataGridViewTextBoxColumn.HeaderText = "Настройка почты";
            this.настройкаПочтыDataGridViewTextBoxColumn.Name = "настройкаПочтыDataGridViewTextBoxColumn";
            // 
            // онлайнЧатDataGridViewTextBoxColumn
            // 
            this.онлайнЧатDataGridViewTextBoxColumn.DataPropertyName = "Онлайн чат";
            this.онлайнЧатDataGridViewTextBoxColumn.HeaderText = "Онлайн чат";
            this.онлайнЧатDataGridViewTextBoxColumn.Name = "онлайнЧатDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // DataGridModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 178);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DataGridModules";
            this.Text = "DataGridModules";
            this.Load += new System.EventHandler(this.DataGridModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модулиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource модулиBindingSource;
        private bdDataSetTableAdapters.МодулиTableAdapter модулиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОбратнойСвязиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn настройкаПочтыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn онлайнЧатDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}