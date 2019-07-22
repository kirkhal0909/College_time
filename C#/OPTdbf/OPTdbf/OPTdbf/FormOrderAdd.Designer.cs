namespace OPTdbf
{
    partial class FormOrderAdd
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
            System.Windows.Forms.Label телефон_заказчикаLabel;
            System.Windows.Forms.Label e_mail_заказчикаLabel;
            System.Windows.Forms.Label адрес_доставкиLabel;
            System.Windows.Forms.Label иД_заказаLabel;
            System.Windows.Forms.Label иД_товараLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label элемент_заказаLabel;
            System.Windows.Forms.Label товарLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderAdd));
            this.складDataGridView = new System.Windows.Forms.DataGridView();
            this.ИД_товара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Товар = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPTDataSet = new OPTdbf.OPTDataSet();
            this.заказDataGridView = new System.Windows.Forms.DataGridView();
            this.ИД_товара_заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Товар_заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость_заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxIDRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.дата_заказаTextBox = new System.Windows.Forms.TextBox();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.иД_заказаTextBox = new System.Windows.Forms.TextBox();
            this.телефон_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.e_mail_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.адрес_доставкиTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.товарTextBox = new System.Windows.Forms.TextBox();
            this.элементы_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.элемент_заказаTextBox = new System.Windows.Forms.TextBox();
            this.иД_заказаTextBox1 = new System.Windows.Forms.TextBox();
            this.иД_товараTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.складTableAdapter = new OPTdbf.OPTDataSetTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new OPTdbf.OPTDataSetTableAdapters.TableAdapterManager();
            this.заказыTableAdapter = new OPTdbf.OPTDataSetTableAdapters.ЗаказыTableAdapter();
            this.элементы_заказовTableAdapter = new OPTdbf.OPTDataSetTableAdapters.Элементы_заказовTableAdapter();
            телефон_заказчикаLabel = new System.Windows.Forms.Label();
            e_mail_заказчикаLabel = new System.Windows.Forms.Label();
            адрес_доставкиLabel = new System.Windows.Forms.Label();
            иД_заказаLabel = new System.Windows.Forms.Label();
            иД_товараLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            элемент_заказаLabel = new System.Windows.Forms.Label();
            товарLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // телефон_заказчикаLabel
            // 
            телефон_заказчикаLabel.AutoSize = true;
            телефон_заказчикаLabel.Location = new System.Drawing.Point(3, 10);
            телефон_заказчикаLabel.Name = "телефон_заказчикаLabel";
            телефон_заказчикаLabel.Size = new System.Drawing.Size(144, 17);
            телефон_заказчикаLabel.TabIndex = 0;
            телефон_заказчикаLabel.Text = "Телефон заказчика:";
            // 
            // e_mail_заказчикаLabel
            // 
            e_mail_заказчикаLabel.AutoSize = true;
            e_mail_заказчикаLabel.Location = new System.Drawing.Point(3, 38);
            e_mail_заказчикаLabel.Name = "e_mail_заказчикаLabel";
            e_mail_заказчикаLabel.Size = new System.Drawing.Size(122, 17);
            e_mail_заказчикаLabel.TabIndex = 2;
            e_mail_заказчикаLabel.Text = "e-mail заказчика:";
            // 
            // адрес_доставкиLabel
            // 
            адрес_доставкиLabel.AutoSize = true;
            адрес_доставкиLabel.Location = new System.Drawing.Point(3, 66);
            адрес_доставкиLabel.Name = "адрес_доставкиLabel";
            адрес_доставкиLabel.Size = new System.Drawing.Size(116, 17);
            адрес_доставкиLabel.TabIndex = 4;
            адрес_доставкиLabel.Text = "Адрес доставки:";
            // 
            // иД_заказаLabel
            // 
            иД_заказаLabel.AutoSize = true;
            иД_заказаLabel.Location = new System.Drawing.Point(16, 32);
            иД_заказаLabel.Name = "иД_заказаLabel";
            иД_заказаLabel.Size = new System.Drawing.Size(82, 17);
            иД_заказаLabel.TabIndex = 0;
            иД_заказаLabel.Text = "ИД заказа:";
            иД_заказаLabel.Visible = false;
            // 
            // иД_товараLabel
            // 
            иД_товараLabel.AutoSize = true;
            иД_товараLabel.Location = new System.Drawing.Point(16, 60);
            иД_товараLabel.Name = "иД_товараLabel";
            иД_товараLabel.Size = new System.Drawing.Size(83, 17);
            иД_товараLabel.TabIndex = 2;
            иД_товараLabel.Text = "ИД товара:";
            иД_товараLabel.Visible = false;
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(16, 88);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(90, 17);
            количествоLabel.TabIndex = 4;
            количествоLabel.Text = "Количество:";
            количествоLabel.Visible = false;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(16, 116);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(82, 17);
            стоимостьLabel.TabIndex = 6;
            стоимостьLabel.Text = "Стоимость:";
            стоимостьLabel.Visible = false;
            // 
            // элемент_заказаLabel
            // 
            элемент_заказаLabel.AutoSize = true;
            элемент_заказаLabel.Location = new System.Drawing.Point(14, 153);
            элемент_заказаLabel.Name = "элемент_заказаLabel";
            элемент_заказаLabel.Size = new System.Drawing.Size(118, 17);
            элемент_заказаLabel.TabIndex = 8;
            элемент_заказаLabel.Text = "Элемент заказа:";
            элемент_заказаLabel.Visible = false;
            // 
            // товарLabel
            // 
            товарLabel.AutoSize = true;
            товарLabel.Location = new System.Drawing.Point(25, 139);
            товарLabel.Name = "товарLabel";
            товарLabel.Size = new System.Drawing.Size(52, 17);
            товарLabel.TabIndex = 10;
            товарLabel.Text = "Товар:";
            товарLabel.Visible = false;
            // 
            // складDataGridView
            // 
            this.складDataGridView.AllowUserToAddRows = false;
            this.складDataGridView.AllowUserToDeleteRows = false;
            this.складDataGridView.AutoGenerateColumns = false;
            this.складDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.складDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_товара,
            this.Товар,
            this.Количество,
            this.Стоимость,
            this.dataGridViewImageColumn1});
            this.складDataGridView.DataSource = this.складBindingSource;
            this.складDataGridView.Location = new System.Drawing.Point(12, 12);
            this.складDataGridView.Name = "складDataGridView";
            this.складDataGridView.RowTemplate.Height = 80;
            this.складDataGridView.Size = new System.Drawing.Size(715, 220);
            this.складDataGridView.TabIndex = 1;
            this.складDataGridView.CurrentCellChanged += new System.EventHandler(this.складDataGridView_CurrentCellChanged);
            // 
            // ИД_товара
            // 
            this.ИД_товара.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ИД_товара.DataPropertyName = "ИД_товара";
            this.ИД_товара.HeaderText = "ИД_товара";
            this.ИД_товара.Name = "ИД_товара";
            this.ИД_товара.ReadOnly = true;
            this.ИД_товара.Width = 112;
            // 
            // Товар
            // 
            this.Товар.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Товар.DataPropertyName = "Товар";
            this.Товар.HeaderText = "Товар";
            this.Товар.Name = "Товар";
            this.Товар.ReadOnly = true;
            // 
            // Количество
            // 
            this.Количество.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Количество.DataPropertyName = "Количество";
            this.Количество.HeaderText = "Количество";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            this.Количество.Width = 115;
            // 
            // Стоимость
            // 
            this.Стоимость.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Стоимость.DataPropertyName = "Стоимость";
            this.Стоимость.HeaderText = "Стоимость одной единицы";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Width = 127;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Изображение_товара";
            this.dataGridViewImageColumn1.HeaderText = "Изображение_товара";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.oPTDataSet;
            // 
            // oPTDataSet
            // 
            this.oPTDataSet.DataSetName = "OPTDataSet";
            this.oPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказDataGridView
            // 
            this.заказDataGridView.AllowUserToAddRows = false;
            this.заказDataGridView.AllowUserToDeleteRows = false;
            this.заказDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ИД_товара_заказ,
            this.Товар_заказ,
            this.Количество_заказ,
            this.Стоимость_заказ});
            this.заказDataGridView.Location = new System.Drawing.Point(12, 295);
            this.заказDataGridView.Name = "заказDataGridView";
            this.заказDataGridView.ReadOnly = true;
            this.заказDataGridView.RowTemplate.Height = 24;
            this.заказDataGridView.Size = new System.Drawing.Size(715, 150);
            this.заказDataGridView.TabIndex = 2;
            this.заказDataGridView.CurrentCellChanged += new System.EventHandler(this.заказDataGridView_CurrentCellChanged);
            // 
            // ИД_товара_заказ
            // 
            this.ИД_товара_заказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ИД_товара_заказ.HeaderText = "ИД_товара";
            this.ИД_товара_заказ.Name = "ИД_товара_заказ";
            this.ИД_товара_заказ.ReadOnly = true;
            this.ИД_товара_заказ.Width = 112;
            // 
            // Товар_заказ
            // 
            this.Товар_заказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Товар_заказ.HeaderText = "Товар";
            this.Товар_заказ.Name = "Товар_заказ";
            this.Товар_заказ.ReadOnly = true;
            // 
            // Количество_заказ
            // 
            this.Количество_заказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Количество_заказ.HeaderText = "Количество";
            this.Количество_заказ.Name = "Количество_заказ";
            this.Количество_заказ.ReadOnly = true;
            this.Количество_заказ.Width = 115;
            // 
            // Стоимость_заказ
            // 
            this.Стоимость_заказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Стоимость_заказ.HeaderText = "Стоимость";
            this.Стоимость_заказ.Name = "Стоимость_заказ";
            this.Стоимость_заказ.ReadOnly = true;
            this.Стоимость_заказ.Width = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ИД товара:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(111, 238);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 238);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(307, 238);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 7;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(55, 275);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(203, 17);
            this.labelSum.TabIndex = 8;
            this.labelSum.Text = "Полная стоимость товаров: 0";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(226, 450);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(83, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxIDRemove
            // 
            this.textBoxIDRemove.Location = new System.Drawing.Point(111, 450);
            this.textBoxIDRemove.Name = "textBoxIDRemove";
            this.textBoxIDRemove.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDRemove.TabIndex = 10;
            this.textBoxIDRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ИД товара:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.дата_заказаTextBox);
            this.panel1.Controls.Add(this.buttonAddOrder);
            this.panel1.Controls.Add(this.иД_заказаTextBox);
            this.panel1.Controls.Add(телефон_заказчикаLabel);
            this.panel1.Controls.Add(this.телефон_заказчикаTextBox);
            this.panel1.Controls.Add(e_mail_заказчикаLabel);
            this.panel1.Controls.Add(this.e_mail_заказчикаTextBox);
            this.panel1.Controls.Add(адрес_доставкиLabel);
            this.panel1.Controls.Add(this.адрес_доставкиTextBox);
            this.panel1.Location = new System.Drawing.Point(733, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 150);
            this.panel1.TabIndex = 12;
            // 
            // дата_заказаTextBox
            // 
            this.дата_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Дата_заказа", true));
            this.дата_заказаTextBox.Location = new System.Drawing.Point(23, 114);
            this.дата_заказаTextBox.Name = "дата_заказаTextBox";
            this.дата_заказаTextBox.Size = new System.Drawing.Size(0, 22);
            this.дата_заказаTextBox.TabIndex = 10;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.oPTDataSet;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(89, 106);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(129, 23);
            this.buttonAddOrder.TabIndex = 8;
            this.buttonAddOrder.Text = "Сохранить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // иД_заказаTextBox
            // 
            this.иД_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "ИД_заказа", true));
            this.иД_заказаTextBox.Location = new System.Drawing.Point(23, 86);
            this.иД_заказаTextBox.Name = "иД_заказаTextBox";
            this.иД_заказаTextBox.Size = new System.Drawing.Size(0, 22);
            this.иД_заказаTextBox.TabIndex = 7;
            // 
            // телефон_заказчикаTextBox
            // 
            this.телефон_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Телефон_заказчика", true));
            this.телефон_заказчикаTextBox.Location = new System.Drawing.Point(153, 7);
            this.телефон_заказчикаTextBox.Name = "телефон_заказчикаTextBox";
            this.телефон_заказчикаTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефон_заказчикаTextBox.TabIndex = 1;
            // 
            // e_mail_заказчикаTextBox
            // 
            this.e_mail_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "e-mail_заказчика", true));
            this.e_mail_заказчикаTextBox.Location = new System.Drawing.Point(153, 35);
            this.e_mail_заказчикаTextBox.Name = "e_mail_заказчикаTextBox";
            this.e_mail_заказчикаTextBox.Size = new System.Drawing.Size(100, 22);
            this.e_mail_заказчикаTextBox.TabIndex = 3;
            // 
            // адрес_доставкиTextBox
            // 
            this.адрес_доставкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Адрес_доставки", true));
            this.адрес_доставкиTextBox.Location = new System.Drawing.Point(153, 63);
            this.адрес_доставкиTextBox.Name = "адрес_доставкиTextBox";
            this.адрес_доставкиTextBox.Size = new System.Drawing.Size(100, 22);
            this.адрес_доставкиTextBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(товарLabel);
            this.panel2.Controls.Add(this.товарTextBox);
            this.panel2.Controls.Add(элемент_заказаLabel);
            this.panel2.Controls.Add(this.элемент_заказаTextBox);
            this.panel2.Controls.Add(иД_заказаLabel);
            this.panel2.Controls.Add(this.иД_заказаTextBox1);
            this.panel2.Controls.Add(иД_товараLabel);
            this.panel2.Controls.Add(this.иД_товараTextBox);
            this.panel2.Controls.Add(количествоLabel);
            this.panel2.Controls.Add(this.количествоTextBox);
            this.panel2.Controls.Add(стоимостьLabel);
            this.panel2.Controls.Add(this.стоимостьTextBox);
            this.panel2.Location = new System.Drawing.Point(740, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 220);
            this.panel2.TabIndex = 13;
            // 
            // товарTextBox
            // 
            this.товарTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "Товар", true));
            this.товарTextBox.Location = new System.Drawing.Point(83, 136);
            this.товарTextBox.Name = "товарTextBox";
            this.товарTextBox.Size = new System.Drawing.Size(0, 22);
            this.товарTextBox.TabIndex = 11;
            // 
            // элементы_заказовBindingSource
            // 
            this.элементы_заказовBindingSource.DataMember = "ЗаказыЭлементы_заказов";
            this.элементы_заказовBindingSource.DataSource = this.заказыBindingSource;
            // 
            // элемент_заказаTextBox
            // 
            this.элемент_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "Элемент_заказа", true));
            this.элемент_заказаTextBox.Location = new System.Drawing.Point(138, 150);
            this.элемент_заказаTextBox.Name = "элемент_заказаTextBox";
            this.элемент_заказаTextBox.Size = new System.Drawing.Size(0, 22);
            this.элемент_заказаTextBox.TabIndex = 9;
            // 
            // иД_заказаTextBox1
            // 
            this.иД_заказаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "ИД_заказа", true));
            this.иД_заказаTextBox1.Location = new System.Drawing.Point(112, 29);
            this.иД_заказаTextBox1.Name = "иД_заказаTextBox1";
            this.иД_заказаTextBox1.Size = new System.Drawing.Size(0, 22);
            this.иД_заказаTextBox1.TabIndex = 1;
            // 
            // иД_товараTextBox
            // 
            this.иД_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "ИД_товара", true));
            this.иД_товараTextBox.Location = new System.Drawing.Point(112, 57);
            this.иД_товараTextBox.Name = "иД_товараTextBox";
            this.иД_товараTextBox.Size = new System.Drawing.Size(0, 22);
            this.иД_товараTextBox.TabIndex = 3;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(112, 85);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(0, 22);
            this.количествоTextBox.TabIndex = 5;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.элементы_заказовBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(112, 113);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(0, 22);
            this.стоимостьTextBox.TabIndex = 7;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = OPTdbf.OPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
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
            // FormOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxIDRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.заказDataGridView);
            this.Controls.Add(this.складDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.FormOrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.складDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.элементы_заказовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OPTDataSet oPTDataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private OPTDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private OPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView складDataGridView;
        private System.Windows.Forms.DataGridView заказDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_товара_заказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Товар_заказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_заказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость_заказ;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxIDRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private OPTDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.TextBox телефон_заказчикаTextBox;
        private System.Windows.Forms.TextBox e_mail_заказчикаTextBox;
        private System.Windows.Forms.TextBox адрес_доставкиTextBox;
        private System.Windows.Forms.TextBox иД_заказаTextBox;
        private System.Windows.Forms.TextBox дата_заказаTextBox;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource элементы_заказовBindingSource;
        private OPTDataSetTableAdapters.Элементы_заказовTableAdapter элементы_заказовTableAdapter;
        private System.Windows.Forms.TextBox иД_заказаTextBox1;
        private System.Windows.Forms.TextBox иД_товараTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox элемент_заказаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИД_товара;
        private System.Windows.Forms.DataGridViewTextBoxColumn Товар;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox товарTextBox;
    }
}