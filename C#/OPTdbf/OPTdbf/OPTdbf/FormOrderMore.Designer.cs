namespace OPTdbf
{
    partial class FormOrderMore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderMore));
            this.oPTDataSet = new OPTdbf.OPTDataSet();
            this.запрос_Элементы_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос_Элементы_заказовTableAdapter = new OPTdbf.OPTDataSetTableAdapters.Запрос_Элементы_заказовTableAdapter();
            this.tableAdapterManager = new OPTdbf.OPTDataSetTableAdapters.TableAdapterManager();
            this.запрос_Элементы_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.ИД_товара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Товар = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new OPTdbf.OPTDataSetTableAdapters.ЗаказыTableAdapter();
            this.заказыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oPTDataSet
            // 
            this.oPTDataSet.DataSetName = "OPTDataSet";
            this.oPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запрос_Элементы_заказовBindingSource
            // 
            this.запрос_Элементы_заказовBindingSource.DataMember = "Запрос_Элементы_заказов";
            this.запрос_Элементы_заказовBindingSource.DataSource = this.oPTDataSet;
            // 
            // запрос_Элементы_заказовTableAdapter
            // 
            this.запрос_Элементы_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = OPTdbf.OPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.Элементы_заказовTableAdapter = null;
            // 
            // запрос_Элементы_заказовDataGridView
            // 
            this.запрос_Элементы_заказовDataGridView.AllowUserToAddRows = false;
            this.запрос_Элементы_заказовDataGridView.AllowUserToDeleteRows = false;
            this.запрос_Элементы_заказовDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.запрос_Элементы_заказовDataGridView.AutoGenerateColumns = false;
            this.запрос_Элементы_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.запрос_Элементы_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_товара,
            this.Товар,
            this.количество,
            this.цена});
            this.запрос_Элементы_заказовDataGridView.DataSource = this.запрос_Элементы_заказовBindingSource;
            this.запрос_Элементы_заказовDataGridView.Location = new System.Drawing.Point(12, 38);
            this.запрос_Элементы_заказовDataGridView.Name = "запрос_Элементы_заказовDataGridView";
            this.запрос_Элементы_заказовDataGridView.ReadOnly = true;
            this.запрос_Элементы_заказовDataGridView.RowTemplate.Height = 24;
            this.запрос_Элементы_заказовDataGridView.Size = new System.Drawing.Size(493, 331);
            this.запрос_Элементы_заказовDataGridView.TabIndex = 1;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(12, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(164, 17);
            this.labelOrder.TabIndex = 2;
            this.labelOrder.Text = "Заказ №2 на сумму 123";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(342, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ИД_товара
            // 
            this.ИД_товара.DataPropertyName = "ИД_товара";
            this.ИД_товара.HeaderText = "ИД_товара";
            this.ИД_товара.Name = "ИД_товара";
            this.ИД_товара.ReadOnly = true;
            this.ИД_товара.Visible = false;
            // 
            // Товар
            // 
            this.Товар.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Товар.DataPropertyName = "Товар";
            this.Товар.HeaderText = "Товар";
            this.Товар.Name = "Товар";
            this.Товар.ReadOnly = true;
            // 
            // количество
            // 
            this.количество.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.количество.DataPropertyName = "Количество";
            this.количество.HeaderText = "Количество";
            this.количество.Name = "количество";
            this.количество.ReadOnly = true;
            this.количество.Width = 115;
            // 
            // цена
            // 
            this.цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.цена.DataPropertyName = "Цена";
            this.цена.HeaderText = "Цена";
            this.цена.Name = "цена";
            this.цена.ReadOnly = true;
            this.цена.Width = 72;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.oPTDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // заказыDataGridView
            // 
            this.заказыDataGridView.AllowUserToAddRows = false;
            this.заказыDataGridView.AllowUserToDeleteRows = false;
            this.заказыDataGridView.AutoGenerateColumns = false;
            this.заказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.телефон,
            this.email,
            this.адрес,
            this.дата,
            this.dataGridViewCheckBoxColumn1});
            this.заказыDataGridView.DataSource = this.заказыBindingSource;
            this.заказыDataGridView.Location = new System.Drawing.Point(48, 76);
            this.заказыDataGridView.Name = "заказыDataGridView";
            this.заказыDataGridView.ReadOnly = true;
            this.заказыDataGridView.RowTemplate.Height = 24;
            this.заказыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.заказыDataGridView.TabIndex = 3;
            this.заказыDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД_заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД_заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // телефон
            // 
            this.телефон.DataPropertyName = "Телефон_заказчика";
            this.телефон.HeaderText = "Телефон_заказчика";
            this.телефон.Name = "телефон";
            this.телефон.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "e-mail_заказчика";
            this.email.HeaderText = "e-mail_заказчика";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // адрес
            // 
            this.адрес.DataPropertyName = "Адрес_доставки";
            this.адрес.HeaderText = "Адрес_доставки";
            this.адрес.Name = "адрес";
            this.адрес.ReadOnly = true;
            // 
            // дата
            // 
            this.дата.DataPropertyName = "Дата_заказа";
            this.дата.HeaderText = "Дата_заказа";
            this.дата.Name = "дата";
            this.дата.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Оплачен";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Оплачен";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // FormOrderMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 375);
            this.Controls.Add(this.заказыDataGridView);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.запрос_Элементы_заказовDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderMore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Товары заказа";
            this.Load += new System.EventHandler(this.FormOrderMore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OPTDataSet oPTDataSet;
        private System.Windows.Forms.BindingSource запрос_Элементы_заказовBindingSource;
        private OPTDataSetTableAdapters.Запрос_Элементы_заказовTableAdapter запрос_Элементы_заказовTableAdapter;
        private OPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView запрос_Элементы_заказовDataGridView;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_товара;
        private System.Windows.Forms.DataGridViewTextBoxColumn Товар;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn цена;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private OPTDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridView заказыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn дата;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}