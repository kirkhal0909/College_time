namespace OPTdbf
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.oPTDataSet = new OPTdbf.OPTDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new OPTdbf.OPTDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new OPTdbf.OPTDataSetTableAdapters.TableAdapterManager();
            this.заказыDataGridView = new System.Windows.Forms.DataGridView();
            this.запрос_Элементы_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос_Элементы_заказовTableAdapter = new OPTdbf.OPTDataSetTableAdapters.Запрос_Элементы_заказовTableAdapter();
            this.buttonLookItems = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИД_заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.элементы_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.элементы_заказовTableAdapter = new OPTdbf.OPTDataSetTableAdapters.Элементы_заказовTableAdapter();
            this.элементы_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new OPTdbf.OPTDataSetTableAdapters.СкладTableAdapter();
            this.складDataGridView = new System.Windows.Forms.DataGridView();
            this.ИД_товара_склад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Товар_склад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_склад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость_склад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИД_элемент_заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИД_заказа_элемент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ИД_товара_элемент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_элемент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость_элемент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oPTDataSet
            // 
            this.oPTDataSet.DataSetName = "OPTDataSet";
            this.oPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = OPTdbf.OPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.Элементы_заказовTableAdapter = this.элементы_заказовTableAdapter;
            // 
            // заказыDataGridView
            // 
            this.заказыDataGridView.AllowUserToAddRows = false;
            this.заказыDataGridView.AllowUserToDeleteRows = false;
            this.заказыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.заказыDataGridView.AutoGenerateColumns = false;
            this.заказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_заказа,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.заказыDataGridView.DataSource = this.заказыBindingSource;
            this.заказыDataGridView.Location = new System.Drawing.Point(12, 32);
            this.заказыDataGridView.Name = "заказыDataGridView";
            this.заказыDataGridView.ReadOnly = true;
            this.заказыDataGridView.RowTemplate.Height = 24;
            this.заказыDataGridView.Size = new System.Drawing.Size(671, 347);
            this.заказыDataGridView.TabIndex = 1;
            this.заказыDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.заказыDataGridView_CellValueChanged);
            this.заказыDataGridView.CurrentCellChanged += new System.EventHandler(this.заказыDataGridView_CurrentCellChanged);
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
            // buttonLookItems
            // 
            this.buttonLookItems.Location = new System.Drawing.Point(192, 2);
            this.buttonLookItems.Name = "buttonLookItems";
            this.buttonLookItems.Size = new System.Drawing.Size(118, 23);
            this.buttonLookItems.TabIndex = 2;
            this.buttonLookItems.Text = "Товары заказа";
            this.buttonLookItems.UseVisualStyleBackColor = true;
            this.buttonLookItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ИД заказа:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.buttonLookItems);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 30);
            this.panel1.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(310, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить заказ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес_доставки";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес_доставки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "e-mail_заказчика";
            this.dataGridViewTextBoxColumn3.HeaderText = "e-mail_заказчика";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Телефон_заказчика";
            this.dataGridViewTextBoxColumn2.HeaderText = "Телефон_заказчика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 173;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_заказа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_заказа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // ИД_заказа
            // 
            this.ИД_заказа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ИД_заказа.DataPropertyName = "ИД_заказа";
            this.ИД_заказа.HeaderText = "ИД_заказа";
            this.ИД_заказа.Name = "ИД_заказа";
            this.ИД_заказа.ReadOnly = true;
            this.ИД_заказа.Width = 111;
            // 
            // элементы_заказовBindingSource
            // 
            this.элементы_заказовBindingSource.DataMember = "Элементы_заказов";
            this.элементы_заказовBindingSource.DataSource = this.oPTDataSet;
            // 
            // элементы_заказовTableAdapter
            // 
            this.элементы_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // элементы_заказовDataGridView
            // 
            this.элементы_заказовDataGridView.AutoGenerateColumns = false;
            this.элементы_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.элементы_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_элемент_заказа,
            this.ИД_заказа_элемент,
            this.ИД_товара_элемент,
            this.Количество_элемент,
            this.Стоимость_элемент});
            this.элементы_заказовDataGridView.DataSource = this.элементы_заказовBindingSource;
            this.элементы_заказовDataGridView.Location = new System.Drawing.Point(23, 60);
            this.элементы_заказовDataGridView.Name = "элементы_заказовDataGridView";
            this.элементы_заказовDataGridView.RowTemplate.Height = 24;
            this.элементы_заказовDataGridView.Size = new System.Drawing.Size(300, 220);
            this.элементы_заказовDataGridView.TabIndex = 6;
            this.элементы_заказовDataGridView.Visible = false;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.oPTDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // складDataGridView
            // 
            this.складDataGridView.AutoGenerateColumns = false;
            this.складDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.складDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_товара_склад,
            this.Товар_склад,
            this.Количество_склад,
            this.Стоимость_склад});
            this.складDataGridView.DataSource = this.складBindingSource;
            this.складDataGridView.Location = new System.Drawing.Point(32, 110);
            this.складDataGridView.Name = "складDataGridView";
            this.складDataGridView.RowTemplate.Height = 24;
            this.складDataGridView.Size = new System.Drawing.Size(300, 220);
            this.складDataGridView.TabIndex = 6;
            this.складDataGridView.Visible = false;
            // 
            // ИД_товара_склад
            // 
            this.ИД_товара_склад.DataPropertyName = "ИД_товара";
            this.ИД_товара_склад.HeaderText = "ИД_товара";
            this.ИД_товара_склад.Name = "ИД_товара_склад";
            // 
            // Товар_склад
            // 
            this.Товар_склад.DataPropertyName = "Товар";
            this.Товар_склад.HeaderText = "Товар";
            this.Товар_склад.Name = "Товар_склад";
            // 
            // Количество_склад
            // 
            this.Количество_склад.DataPropertyName = "Количество";
            this.Количество_склад.HeaderText = "Количество";
            this.Количество_склад.Name = "Количество_склад";
            // 
            // Стоимость_склад
            // 
            this.Стоимость_склад.DataPropertyName = "Стоимость";
            this.Стоимость_склад.HeaderText = "Стоимость";
            this.Стоимость_склад.Name = "Стоимость_склад";
            // 
            // ИД_элемент_заказа
            // 
            this.ИД_элемент_заказа.DataPropertyName = "Элемент_заказа";
            this.ИД_элемент_заказа.HeaderText = "Элемент_заказа";
            this.ИД_элемент_заказа.Name = "ИД_элемент_заказа";
            // 
            // ИД_заказа_элемент
            // 
            this.ИД_заказа_элемент.DataPropertyName = "ИД_заказа";
            this.ИД_заказа_элемент.HeaderText = "ИД_заказа";
            this.ИД_заказа_элемент.Name = "ИД_заказа_элемент";
            // 
            // ИД_товара_элемент
            // 
            this.ИД_товара_элемент.DataPropertyName = "ИД_товара";
            this.ИД_товара_элемент.HeaderText = "ИД_товара";
            this.ИД_товара_элемент.Name = "ИД_товара_элемент";
            // 
            // Количество_элемент
            // 
            this.Количество_элемент.DataPropertyName = "Количество";
            this.Количество_элемент.HeaderText = "Количество";
            this.Количество_элемент.Name = "Количество_элемент";
            // 
            // Стоимость_элемент
            // 
            this.Стоимость_элемент.DataPropertyName = "Стоимость";
            this.Стоимость_элемент.HeaderText = "Стоимость";
            this.Стоимость_элемент.Name = "Стоимость_элемент";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.складDataGridView);
            this.Controls.Add(this.элементы_заказовDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.заказыDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос_Элементы_заказовBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OPTDataSet oPTDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private OPTDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private OPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView заказыDataGridView;
        private System.Windows.Forms.BindingSource запрос_Элементы_заказовBindingSource;
        private OPTDataSetTableAdapters.Запрос_Элементы_заказовTableAdapter запрос_Элементы_заказовTableAdapter;
        private System.Windows.Forms.Button buttonLookItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource элементы_заказовBindingSource;
        private OPTDataSetTableAdapters.Элементы_заказовTableAdapter элементы_заказовTableAdapter;
        private System.Windows.Forms.DataGridView элементы_заказовDataGridView;
        private System.Windows.Forms.BindingSource складBindingSource;
        private OPTDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridView складDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_элемент_заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_заказа_элемент;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_товара_элемент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_элемент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость_элемент;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_товара_склад;
        private System.Windows.Forms.DataGridViewTextBoxColumn Товар_склад;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_склад;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость_склад;
    }
}