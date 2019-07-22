namespace Furniture_accounting_orders
{
    partial class Form_Add_Order_Enter_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Order_Enter_Client));
            this.ordersDataSet = new Furniture_accounting_orders.ordersDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager();
            this.заказыTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.ЗаказыTableAdapter();
            this.элементы_заказовTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.Элементы_заказовTableAdapter();
            this.клиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnКлиентыИдКлиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИДКлиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnДатаЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.элементы_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.элементы_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnНомерЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnНомерМебели = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnКоличество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnЦена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDoOrder = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "ordersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.ordersDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.МебельTableAdapter = null;
            this.tableAdapterManager.Элементы_заказовTableAdapter = this.элементы_заказовTableAdapter;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // элементы_заказовTableAdapter
            // 
            this.элементы_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыDataGridView
            // 
            this.клиентыDataGridView.AllowUserToAddRows = false;
            this.клиентыDataGridView.AllowUserToDeleteRows = false;
            this.клиентыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.клиентыDataGridView.AutoGenerateColumns = false;
            this.клиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnКлиентыИдКлиента,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.клиентыDataGridView.DataSource = this.клиентыBindingSource;
            this.клиентыDataGridView.Location = new System.Drawing.Point(23, 12);
            this.клиентыDataGridView.Name = "клиентыDataGridView";
            this.клиентыDataGridView.ReadOnly = true;
            this.клиентыDataGridView.RowTemplate.Height = 24;
            this.клиентыDataGridView.Size = new System.Drawing.Size(640, 306);
            this.клиентыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnКлиентыИдКлиента
            // 
            this.dataGridViewTextBoxColumnКлиентыИдКлиента.DataPropertyName = "ИД клиента";
            this.dataGridViewTextBoxColumnКлиентыИдКлиента.HeaderText = "ИД клиента";
            this.dataGridViewTextBoxColumnКлиентыИдКлиента.Name = "dataGridViewTextBoxColumnКлиентыИдКлиента";
            this.dataGridViewTextBoxColumnКлиентыИдКлиента.ReadOnly = true;
            this.dataGridViewTextBoxColumnКлиентыИдКлиента.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "КлиентыЗаказы";
            this.заказыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // заказыDataGridView
            // 
            this.заказыDataGridView.AllowUserToAddRows = false;
            this.заказыDataGridView.AllowUserToDeleteRows = false;
            this.заказыDataGridView.AutoGenerateColumns = false;
            this.заказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа,
            this.dataGridViewTextBoxColumnИДКлиента,
            this.dataGridViewTextBoxColumnДатаЗаказа});
            this.заказыDataGridView.DataSource = this.заказыBindingSource;
            this.заказыDataGridView.Location = new System.Drawing.Point(48, 26);
            this.заказыDataGridView.Name = "заказыDataGridView";
            this.заказыDataGridView.ReadOnly = true;
            this.заказыDataGridView.RowTemplate.Height = 24;
            this.заказыDataGridView.Size = new System.Drawing.Size(10, 10);
            this.заказыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа
            // 
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа.DataPropertyName = "Номер заказа";
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа.Name = "dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа";
            this.dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnИДКлиента
            // 
            this.dataGridViewTextBoxColumnИДКлиента.DataPropertyName = "ИД клиента";
            this.dataGridViewTextBoxColumnИДКлиента.HeaderText = "ИД клиента";
            this.dataGridViewTextBoxColumnИДКлиента.Name = "dataGridViewTextBoxColumnИДКлиента";
            this.dataGridViewTextBoxColumnИДКлиента.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnДатаЗаказа
            // 
            this.dataGridViewTextBoxColumnДатаЗаказа.DataPropertyName = "Дата заказа";
            this.dataGridViewTextBoxColumnДатаЗаказа.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumnДатаЗаказа.Name = "dataGridViewTextBoxColumnДатаЗаказа";
            this.dataGridViewTextBoxColumnДатаЗаказа.ReadOnly = true;
            // 
            // элементы_заказовBindingSource
            // 
            this.элементы_заказовBindingSource.DataMember = "ЗаказыЭлементы_заказов";
            this.элементы_заказовBindingSource.DataSource = this.заказыBindingSource;
            // 
            // элементы_заказовDataGridView
            // 
            this.элементы_заказовDataGridView.AllowUserToAddRows = false;
            this.элементы_заказовDataGridView.AllowUserToDeleteRows = false;
            this.элементы_заказовDataGridView.AutoGenerateColumns = false;
            this.элементы_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.элементы_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnНомерЗаказа,
            this.dataGridViewTextBoxColumnНомерМебели,
            this.dataGridViewTextBoxColumnКоличество,
            this.dataGridViewTextBoxColumnЦена});
            this.элементы_заказовDataGridView.DataSource = this.элементы_заказовBindingSource;
            this.элементы_заказовDataGridView.Location = new System.Drawing.Point(32, 26);
            this.элементы_заказовDataGridView.Name = "элементы_заказовDataGridView";
            this.элементы_заказовDataGridView.ReadOnly = true;
            this.элементы_заказовDataGridView.RowTemplate.Height = 24;
            this.элементы_заказовDataGridView.Size = new System.Drawing.Size(10, 10);
            this.элементы_заказовDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumnНомерЗаказа
            // 
            this.dataGridViewTextBoxColumnНомерЗаказа.DataPropertyName = "Номер заказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.Name = "dataGridViewTextBoxColumnНомерЗаказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnНомерМебели
            // 
            this.dataGridViewTextBoxColumnНомерМебели.DataPropertyName = "Номер мебели";
            this.dataGridViewTextBoxColumnНомерМебели.HeaderText = "Номер мебели";
            this.dataGridViewTextBoxColumnНомерМебели.Name = "dataGridViewTextBoxColumnНомерМебели";
            this.dataGridViewTextBoxColumnНомерМебели.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnКоличество
            // 
            this.dataGridViewTextBoxColumnКоличество.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumnКоличество.HeaderText = "Количество";
            this.dataGridViewTextBoxColumnКоличество.Name = "dataGridViewTextBoxColumnКоличество";
            this.dataGridViewTextBoxColumnКоличество.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnЦена
            // 
            this.dataGridViewTextBoxColumnЦена.DataPropertyName = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦена.HeaderText = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦена.Name = "dataGridViewTextBoxColumnЦена";
            this.dataGridViewTextBoxColumnЦена.ReadOnly = true;
            // 
            // buttonDoOrder
            // 
            this.buttonDoOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoOrder.ForeColor = System.Drawing.Color.Green;
            this.buttonDoOrder.Location = new System.Drawing.Point(391, 324);
            this.buttonDoOrder.Name = "buttonDoOrder";
            this.buttonDoOrder.Size = new System.Drawing.Size(272, 34);
            this.buttonDoOrder.TabIndex = 15;
            this.buttonDoOrder.Text = "Оформить заказ";
            this.buttonDoOrder.UseVisualStyleBackColor = true;
            this.buttonDoOrder.Click += new System.EventHandler(this.buttonDoOrder_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.Color.Black;
            this.buttonClients.Location = new System.Drawing.Point(23, 324);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(258, 34);
            this.buttonClients.TabIndex = 16;
            this.buttonClients.Text = "Редактор клиентов";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // Form_Add_Order_Enter_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 370);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonDoOrder);
            this.Controls.Add(this.элементы_заказовDataGridView);
            this.Controls.Add(this.заказыDataGridView);
            this.Controls.Add(this.клиентыDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_Order_Enter_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.Form_Add_Order_Enter_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ordersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private ordersDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private ordersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView клиентыDataGridView;
        private ordersDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private ordersDataSetTableAdapters.Элементы_заказовTableAdapter элементы_заказовTableAdapter;
        private System.Windows.Forms.DataGridView заказыDataGridView;
        private System.Windows.Forms.BindingSource элементы_заказовBindingSource;
        private System.Windows.Forms.DataGridView элементы_заказовDataGridView;
        private System.Windows.Forms.Button buttonDoOrder;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnКлиентыИдКлиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnНомерЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnНомерМебели;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnКоличество;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnЦена;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИДКлиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnДатаЗаказа;
    }
}