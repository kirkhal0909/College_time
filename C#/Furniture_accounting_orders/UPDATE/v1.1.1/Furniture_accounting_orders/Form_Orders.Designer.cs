namespace Furniture_accounting_orders
{
    partial class Form_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Orders));
            this.ordersDataSet = new Furniture_accounting_orders.ordersDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager();
            this.запрос_заказ_клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос_заказ_клиентTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.Запрос_заказ_клиентTableAdapter();
            this.заказыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnНомерЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИдКлиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInfo = new System.Windows.Forms.Label();
            this.запрос_заказ_клиентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИнфоИдКлиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИнфоФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИнфоАдрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnИнфоНомер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос_элементы_заказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос_элементы_заказаTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.Запрос_элементы_заказаTableAdapter();
            this.запрос_элементы_заказаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnКоличество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnЦена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_заказ_клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_заказ_клиентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_элементы_заказаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_элементы_заказаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "ordersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.ordersDataSet;
            this.заказыBindingSource.PositionChanged += new System.EventHandler(this.заказыBindingSource_CurrentItemChanged);
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МебельTableAdapter = null;
            this.tableAdapterManager.Элементы_заказовTableAdapter = null;
            // 
            // запрос_заказ_клиентBindingSource
            // 
            this.запрос_заказ_клиентBindingSource.DataMember = "Запрос_заказ_клиент";
            this.запрос_заказ_клиентBindingSource.DataSource = this.ordersDataSet;
            // 
            // запрос_заказ_клиентTableAdapter
            // 
            this.запрос_заказ_клиентTableAdapter.ClearBeforeFill = true;
            // 
            // заказыDataGridView
            // 
            this.заказыDataGridView.AllowUserToAddRows = false;
            this.заказыDataGridView.AllowUserToDeleteRows = false;
            this.заказыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.заказыDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заказыDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.заказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnНомерЗаказа,
            this.dataGridViewTextBoxColumnИдКлиента,
            this.dataGridViewTextBoxColumn3});
            this.заказыDataGridView.DataSource = this.заказыBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.заказыDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.заказыDataGridView.Location = new System.Drawing.Point(12, 12);
            this.заказыDataGridView.Name = "заказыDataGridView";
            this.заказыDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заказыDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.заказыDataGridView.RowTemplate.Height = 24;
            this.заказыDataGridView.Size = new System.Drawing.Size(367, 377);
            this.заказыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumnНомерЗаказа
            // 
            this.dataGridViewTextBoxColumnНомерЗаказа.DataPropertyName = "Номер заказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.Name = "dataGridViewTextBoxColumnНомерЗаказа";
            this.dataGridViewTextBoxColumnНомерЗаказа.ReadOnly = true;
            this.dataGridViewTextBoxColumnНомерЗаказа.Width = 80;
            // 
            // dataGridViewTextBoxColumnИдКлиента
            // 
            this.dataGridViewTextBoxColumnИдКлиента.DataPropertyName = "ИД клиента";
            this.dataGridViewTextBoxColumnИдКлиента.HeaderText = "ИД клиента";
            this.dataGridViewTextBoxColumnИдКлиента.Name = "dataGridViewTextBoxColumnИдКлиента";
            this.dataGridViewTextBoxColumnИдКлиента.ReadOnly = true;
            this.dataGridViewTextBoxColumnИдКлиента.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата заказа";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(401, 21);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(75, 24);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "Клиент";
            this.labelInfo.Visible = false;
            // 
            // запрос_заказ_клиентDataGridView
            // 
            this.запрос_заказ_клиентDataGridView.AllowUserToAddRows = false;
            this.запрос_заказ_клиентDataGridView.AllowUserToDeleteRows = false;
            this.запрос_заказ_клиентDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.запрос_заказ_клиентDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.запрос_заказ_клиентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.запрос_заказ_клиентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumnИнфоИдКлиента,
            this.dataGridViewTextBoxColumnИнфоФИО,
            this.dataGridViewTextBoxColumnИнфоАдрес,
            this.dataGridViewTextBoxColumnИнфоНомер});
            this.запрос_заказ_клиентDataGridView.DataSource = this.запрос_заказ_клиентBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.запрос_заказ_клиентDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.запрос_заказ_клиентDataGridView.Location = new System.Drawing.Point(12, 12);
            this.запрос_заказ_клиентDataGridView.Name = "запрос_заказ_клиентDataGridView";
            this.запрос_заказ_клиентDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.запрос_заказ_клиентDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.запрос_заказ_клиентDataGridView.RowTemplate.Height = 24;
            this.запрос_заказ_клиентDataGridView.Size = new System.Drawing.Size(10, 10);
            this.запрос_заказ_клиентDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn
            // 
            this.dataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.dataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnИнфоИдКлиента
            // 
            this.dataGridViewTextBoxColumnИнфоИдКлиента.DataPropertyName = "ИД_клиента";
            this.dataGridViewTextBoxColumnИнфоИдКлиента.HeaderText = "ИД_клиента";
            this.dataGridViewTextBoxColumnИнфоИдКлиента.Name = "dataGridViewTextBoxColumnИнфоИдКлиента";
            this.dataGridViewTextBoxColumnИнфоИдКлиента.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnИнфоФИО
            // 
            this.dataGridViewTextBoxColumnИнфоФИО.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumnИнфоФИО.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumnИнфоФИО.Name = "dataGridViewTextBoxColumnИнфоФИО";
            this.dataGridViewTextBoxColumnИнфоФИО.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnИнфоАдрес
            // 
            this.dataGridViewTextBoxColumnИнфоАдрес.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumnИнфоАдрес.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumnИнфоАдрес.Name = "dataGridViewTextBoxColumnИнфоАдрес";
            this.dataGridViewTextBoxColumnИнфоАдрес.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnИнфоНомер
            // 
            this.dataGridViewTextBoxColumnИнфоНомер.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumnИнфоНомер.HeaderText = "Номер";
            this.dataGridViewTextBoxColumnИнфоНомер.Name = "dataGridViewTextBoxColumnИнфоНомер";
            this.dataGridViewTextBoxColumnИнфоНомер.ReadOnly = true;
            // 
            // запрос_элементы_заказаBindingSource
            // 
            this.запрос_элементы_заказаBindingSource.DataMember = "Запрос_элементы_заказа";
            this.запрос_элементы_заказаBindingSource.DataSource = this.ordersDataSet;
            // 
            // запрос_элементы_заказаTableAdapter
            // 
            this.запрос_элементы_заказаTableAdapter.ClearBeforeFill = true;
            // 
            // запрос_элементы_заказаDataGridView
            // 
            this.запрос_элементы_заказаDataGridView.AllowUserToAddRows = false;
            this.запрос_элементы_заказаDataGridView.AllowUserToDeleteRows = false;
            this.запрос_элементы_заказаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.запрос_элементы_заказаDataGridView.AutoGenerateColumns = false;
            this.запрос_элементы_заказаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.запрос_элементы_заказаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumnКоличество,
            this.dataGridViewTextBoxColumnЦена,
            this.dataGridViewTextBoxColumn8});
            this.запрос_элементы_заказаDataGridView.DataSource = this.запрос_элементы_заказаBindingSource;
            this.запрос_элементы_заказаDataGridView.Location = new System.Drawing.Point(395, 148);
            this.запрос_элементы_заказаDataGridView.Name = "запрос_элементы_заказаDataGridView";
            this.запрос_элементы_заказаDataGridView.ReadOnly = true;
            this.запрос_элементы_заказаDataGridView.RowTemplate.Height = 24;
            this.запрос_элементы_заказаDataGridView.Size = new System.Drawing.Size(570, 241);
            this.запрос_элементы_заказаDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер мебели";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер мебели";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn5.HeaderText = "Название";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnКоличество
            // 
            this.dataGridViewTextBoxColumnКоличество.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumnКоличество.HeaderText = "Количество";
            this.dataGridViewTextBoxColumnКоличество.Name = "dataGridViewTextBoxColumnКоличество";
            this.dataGridViewTextBoxColumnКоличество.ReadOnly = true;
            this.dataGridViewTextBoxColumnКоличество.Width = 70;
            // 
            // dataGridViewTextBoxColumnЦена
            // 
            this.dataGridViewTextBoxColumnЦена.DataPropertyName = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦена.HeaderText = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦена.Name = "dataGridViewTextBoxColumnЦена";
            this.dataGridViewTextBoxColumnЦена.ReadOnly = true;
            this.dataGridViewTextBoxColumnЦена.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Цена за всё";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена за всё";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // Form_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 404);
            this.Controls.Add(this.запрос_элементы_заказаDataGridView);
            this.Controls.Add(this.запрос_заказ_клиентDataGridView);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.заказыDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form_Orders_Load);
            this.Shown += new System.EventHandler(this.Form_Orders_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_заказ_клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_заказ_клиентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_элементы_заказаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_элементы_заказаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ordersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private ordersDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private ordersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource запрос_заказ_клиентBindingSource;
        private ordersDataSetTableAdapters.Запрос_заказ_клиентTableAdapter запрос_заказ_клиентTableAdapter;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView заказыDataGridView;
        private System.Windows.Forms.DataGridView запрос_заказ_клиентDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИнфоИдКлиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИнфоФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИнфоАдрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИнфоНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnНомерЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnИдКлиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource запрос_элементы_заказаBindingSource;
        private ordersDataSetTableAdapters.Запрос_элементы_заказаTableAdapter запрос_элементы_заказаTableAdapter;
        private System.Windows.Forms.DataGridView запрос_элементы_заказаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnКоличество;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnЦена;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}