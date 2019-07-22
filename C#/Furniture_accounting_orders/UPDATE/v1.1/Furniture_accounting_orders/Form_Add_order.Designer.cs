namespace Furniture_accounting_orders
{
    partial class Form_Add_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_order));
            this.ordersDataSet = new Furniture_accounting_orders.ordersDataSet();
            this.tableAdapterManager = new Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager();
            this.категорииTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.КатегорииTableAdapter();
            this.мебельTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.МебельTableAdapter();
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnКатегория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мебельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мебельDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnНомерМебели = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnНазвание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnОписание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnOrderНомерМебели = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnНазваниеМебели = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnЦенаЗаЕдиницу = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnКоличество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonDoOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "ordersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = this.категорииTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МебельTableAdapter = this.мебельTableAdapter;
            this.tableAdapterManager.Элементы_заказовTableAdapter = null;
            // 
            // категорииTableAdapter
            // 
            this.категорииTableAdapter.ClearBeforeFill = true;
            // 
            // мебельTableAdapter
            // 
            this.мебельTableAdapter.ClearBeforeFill = true;
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.ordersDataSet;
            // 
            // категорииDataGridView
            // 
            this.категорииDataGridView.AllowUserToAddRows = false;
            this.категорииDataGridView.AllowUserToDeleteRows = false;
            this.категорииDataGridView.AutoGenerateColumns = false;
            this.категорииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.категорииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnКатегория});
            this.категорииDataGridView.DataSource = this.категорииBindingSource;
            this.категорииDataGridView.Location = new System.Drawing.Point(14, 19);
            this.категорииDataGridView.Name = "категорииDataGridView";
            this.категорииDataGridView.ReadOnly = true;
            this.категорииDataGridView.RowTemplate.Height = 24;
            this.категорииDataGridView.Size = new System.Drawing.Size(300, 286);
            this.категорииDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumnКатегория
            // 
            this.dataGridViewTextBoxColumnКатегория.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnКатегория.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumnКатегория.HeaderText = "Категория";
            this.dataGridViewTextBoxColumnКатегория.Name = "dataGridViewTextBoxColumnКатегория";
            this.dataGridViewTextBoxColumnКатегория.ReadOnly = true;
            // 
            // мебельBindingSource
            // 
            this.мебельBindingSource.DataMember = "КатегорииМебель";
            this.мебельBindingSource.DataSource = this.категорииBindingSource;
            // 
            // мебельDataGridView
            // 
            this.мебельDataGridView.AllowUserToAddRows = false;
            this.мебельDataGridView.AllowUserToDeleteRows = false;
            this.мебельDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.мебельDataGridView.AutoGenerateColumns = false;
            this.мебельDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мебельDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnНомерМебели,
            this.dataGridViewTextBoxColumnНазвание,
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу,
            this.dataGridViewTextBoxColumnОписание});
            this.мебельDataGridView.DataSource = this.мебельBindingSource;
            this.мебельDataGridView.Location = new System.Drawing.Point(335, 3);
            this.мебельDataGridView.Name = "мебельDataGridView";
            this.мебельDataGridView.ReadOnly = true;
            this.мебельDataGridView.RowTemplate.Height = 24;
            this.мебельDataGridView.Size = new System.Drawing.Size(680, 261);
            this.мебельDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumnНомерМебели
            // 
            this.dataGridViewTextBoxColumnНомерМебели.DataPropertyName = "Номер мебели";
            this.dataGridViewTextBoxColumnНомерМебели.HeaderText = "Номер мебели";
            this.dataGridViewTextBoxColumnНомерМебели.Name = "dataGridViewTextBoxColumnНомерМебели";
            this.dataGridViewTextBoxColumnНомерМебели.ReadOnly = true;
            this.dataGridViewTextBoxColumnНомерМебели.Width = 60;
            // 
            // dataGridViewTextBoxColumnНазвание
            // 
            this.dataGridViewTextBoxColumnНазвание.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnНазвание.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumnНазвание.HeaderText = "Название";
            this.dataGridViewTextBoxColumnНазвание.Name = "dataGridViewTextBoxColumnНазвание";
            this.dataGridViewTextBoxColumnНазвание.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnЦенаЗаЕдиницу
            // 
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу.DataPropertyName = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу.HeaderText = "Цена за единицу";
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу.Name = "dataGridViewTextBoxColumnЦенаЗаЕдиницу";
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу.ReadOnly = true;
            this.dataGridViewTextBoxColumnЦенаЗаЕдиницу.Width = 80;
            // 
            // dataGridViewTextBoxColumnОписание
            // 
            this.dataGridViewTextBoxColumnОписание.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnОписание.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumnОписание.HeaderText = "Описание";
            this.dataGridViewTextBoxColumnОписание.Name = "dataGridViewTextBoxColumnОписание";
            this.dataGridViewTextBoxColumnОписание.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.категорииDataGridView);
            this.panel1.Controls.Add(this.мебельDataGridView);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 315);
            this.panel1.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(574, 271);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(272, 34);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить в заказ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(347, 277);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(122, 24);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Количество:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount.Location = new System.Drawing.Point(475, 272);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(94, 30);
            this.textBoxCount.TabIndex = 10;
            this.textBoxCount.Text = "1";
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrderНомерМебели,
            this.ColumnНазваниеМебели,
            this.ColumnЦенаЗаЕдиницу,
            this.ColumnКоличество});
            this.dataGridViewItems.Location = new System.Drawing.Point(13, 320);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(998, 202);
            this.dataGridViewItems.TabIndex = 5;
            // 
            // ColumnOrderНомерМебели
            // 
            this.ColumnOrderНомерМебели.Frozen = true;
            this.ColumnOrderНомерМебели.HeaderText = "Номер мебели";
            this.ColumnOrderНомерМебели.Name = "ColumnOrderНомерМебели";
            this.ColumnOrderНомерМебели.ReadOnly = true;
            this.ColumnOrderНомерМебели.Width = 60;
            // 
            // ColumnНазваниеМебели
            // 
            this.ColumnНазваниеМебели.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnНазваниеМебели.HeaderText = "Мебель";
            this.ColumnНазваниеМебели.Name = "ColumnНазваниеМебели";
            this.ColumnНазваниеМебели.ReadOnly = true;
            // 
            // ColumnЦенаЗаЕдиницу
            // 
            this.ColumnЦенаЗаЕдиницу.HeaderText = "Цена за единицу";
            this.ColumnЦенаЗаЕдиницу.Name = "ColumnЦенаЗаЕдиницу";
            this.ColumnЦенаЗаЕдиницу.ReadOnly = true;
            this.ColumnЦенаЗаЕдиницу.Width = 80;
            // 
            // ColumnКоличество
            // 
            this.ColumnКоличество.HeaderText = "Количество";
            this.ColumnКоличество.Name = "ColumnКоличество";
            this.ColumnКоличество.ReadOnly = true;
            this.ColumnКоличество.Width = 92;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemove.Location = new System.Drawing.Point(13, 528);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(272, 34);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Удалить из заказа";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelSum
            // 
            this.labelSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(346, 534);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(173, 24);
            this.labelSum.TabIndex = 13;
            this.labelSum.Text = "Сумма заказа: 0 р.";
            // 
            // buttonDoOrder
            // 
            this.buttonDoOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoOrder.ForeColor = System.Drawing.Color.Green;
            this.buttonDoOrder.Location = new System.Drawing.Point(739, 528);
            this.buttonDoOrder.Name = "buttonDoOrder";
            this.buttonDoOrder.Size = new System.Drawing.Size(272, 34);
            this.buttonDoOrder.TabIndex = 14;
            this.buttonDoOrder.Text = "Оформить заказ";
            this.buttonDoOrder.UseVisualStyleBackColor = true;
            this.buttonDoOrder.Click += new System.EventHandler(this.buttonDoOrder_Click);
            // 
            // Form_Add_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 567);
            this.Controls.Add(this.buttonDoOrder);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.Form_Add_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ordersDataSet ordersDataSet;
        private ordersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ordersDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private ordersDataSetTableAdapters.МебельTableAdapter мебельTableAdapter;
        private System.Windows.Forms.DataGridView категорииDataGridView;
        private System.Windows.Forms.BindingSource мебельBindingSource;
        private System.Windows.Forms.DataGridView мебельDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnКатегория;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnНомерМебели;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnНазвание;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnЦенаЗаЕдиницу;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnОписание;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderНомерМебели;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnНазваниеМебели;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnЦенаЗаЕдиницу;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnКоличество;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonDoOrder;
    }
}