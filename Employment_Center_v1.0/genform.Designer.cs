namespace Employment_Center_v1._0
{
    partial class genform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new Employment_Center_v1._0.DatabaseDataSet();
            this.gentableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gentableTableAdapter = new Employment_Center_v1._0.DatabaseDataSetTableAdapters.gentableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отрасльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.требованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.опытРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графикРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обратнаяСвязьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПросмотровDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addvacbtn = new System.Windows.Forms.Button();
            this.exitappbtn = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.отрасльDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.требованияDataGridViewTextBoxColumn,
            this.опытРаботыDataGridViewTextBoxColumn,
            this.зПDataGridViewTextBoxColumn,
            this.графикРаботыDataGridViewTextBoxColumn,
            this.местоположениеDataGridViewTextBoxColumn,
            this.обратнаяСвязьDataGridViewTextBoxColumn,
            this.колвоПросмотровDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gentableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1155, 656);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gentableBindingSource
            // 
            this.gentableBindingSource.DataMember = "gentable";
            this.gentableBindingSource.DataSource = this.databaseDataSet;
            // 
            // gentableTableAdapter
            // 
            this.gentableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // отрасльDataGridViewTextBoxColumn
            // 
            this.отрасльDataGridViewTextBoxColumn.DataPropertyName = "Отрасль";
            this.отрасльDataGridViewTextBoxColumn.HeaderText = "Отрасль";
            this.отрасльDataGridViewTextBoxColumn.Name = "отрасльDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // требованияDataGridViewTextBoxColumn
            // 
            this.требованияDataGridViewTextBoxColumn.DataPropertyName = "Требования";
            this.требованияDataGridViewTextBoxColumn.HeaderText = "Требования";
            this.требованияDataGridViewTextBoxColumn.Name = "требованияDataGridViewTextBoxColumn";
            // 
            // опытРаботыDataGridViewTextBoxColumn
            // 
            this.опытРаботыDataGridViewTextBoxColumn.DataPropertyName = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.Name = "опытРаботыDataGridViewTextBoxColumn";
            // 
            // зПDataGridViewTextBoxColumn
            // 
            this.зПDataGridViewTextBoxColumn.DataPropertyName = "ЗП";
            this.зПDataGridViewTextBoxColumn.HeaderText = "ЗП";
            this.зПDataGridViewTextBoxColumn.Name = "зПDataGridViewTextBoxColumn";
            // 
            // графикРаботыDataGridViewTextBoxColumn
            // 
            this.графикРаботыDataGridViewTextBoxColumn.DataPropertyName = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.HeaderText = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.Name = "графикРаботыDataGridViewTextBoxColumn";
            // 
            // местоположениеDataGridViewTextBoxColumn
            // 
            this.местоположениеDataGridViewTextBoxColumn.DataPropertyName = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.HeaderText = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.Name = "местоположениеDataGridViewTextBoxColumn";
            // 
            // обратнаяСвязьDataGridViewTextBoxColumn
            // 
            this.обратнаяСвязьDataGridViewTextBoxColumn.DataPropertyName = "Обратная связь";
            this.обратнаяСвязьDataGridViewTextBoxColumn.HeaderText = "Обратная связь";
            this.обратнаяСвязьDataGridViewTextBoxColumn.Name = "обратнаяСвязьDataGridViewTextBoxColumn";
            // 
            // колвоПросмотровDataGridViewTextBoxColumn
            // 
            this.колвоПросмотровDataGridViewTextBoxColumn.DataPropertyName = "Кол-во просмотров";
            this.колвоПросмотровDataGridViewTextBoxColumn.HeaderText = "Кол-во просмотров";
            this.колвоПросмотровDataGridViewTextBoxColumn.Name = "колвоПросмотровDataGridViewTextBoxColumn";
            this.колвоПросмотровDataGridViewTextBoxColumn.Visible = false;
            // 
            // addvacbtn
            // 
            this.addvacbtn.Location = new System.Drawing.Point(1197, 12);
            this.addvacbtn.Name = "addvacbtn";
            this.addvacbtn.Size = new System.Drawing.Size(139, 23);
            this.addvacbtn.TabIndex = 1;
            this.addvacbtn.Text = "Добавить вакансию";
            this.addvacbtn.UseVisualStyleBackColor = true;
            this.addvacbtn.Click += new System.EventHandler(this.addvacbtn_Click);
            // 
            // exitappbtn
            // 
            this.exitappbtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exitappbtn.Location = new System.Drawing.Point(1197, 41);
            this.exitappbtn.Name = "exitappbtn";
            this.exitappbtn.Size = new System.Drawing.Size(139, 23);
            this.exitappbtn.TabIndex = 2;
            this.exitappbtn.Text = "Закрыть приолжение";
            this.exitappbtn.UseVisualStyleBackColor = true;
            this.exitappbtn.Click += new System.EventHandler(this.exitappbtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Location = new System.Drawing.Point(1197, 70);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(139, 23);
            this.aboutbtn.TabIndex = 3;
            this.aboutbtn.Text = "О программе";
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // genform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 680);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.exitappbtn);
            this.Controls.Add(this.addvacbtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "genform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "genform";
            this.Load += new System.EventHandler(this.genform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource gentableBindingSource;
        private DatabaseDataSetTableAdapters.gentableTableAdapter gentableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отрасльDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn требованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn опытРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обратнаяСвязьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПросмотровDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addvacbtn;
        private System.Windows.Forms.Button exitappbtn;
        private System.Windows.Forms.Button aboutbtn;
    }
}