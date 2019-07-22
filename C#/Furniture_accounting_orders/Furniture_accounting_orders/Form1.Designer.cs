namespace Furniture_accounting_orders
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ordersDataSet = new Furniture_accounting_orders.ordersDataSet();
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорииTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.КатегорииTableAdapter();
            this.tableAdapterManager = new Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager();
            this.мебельTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.МебельTableAdapter();
            this.категорииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnКатегория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мебельDataGridView = new System.Windows.Forms.DataGridView();
            this.мебельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddFurniture = new System.Windows.Forms.Button();
            this.labelPriceFurniture = new System.Windows.Forms.Label();
            this.textBoxPriceFurniture = new System.Windows.Forms.TextBox();
            this.labelDescriptionFurniture = new System.Windows.Forms.Label();
            this.textBoxDescriptionFurniture = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRemoveFurniture = new System.Windows.Forms.Button();
            this.buttonEditFurniture = new System.Windows.Forms.Button();
            this.labelFurnitureName = new System.Windows.Forms.Label();
            this.textBoxFurnitureName = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFurniturePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFurnitureDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "ordersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.ordersDataSet;
            // 
            // категорииTableAdapter
            // 
            this.категорииTableAdapter.ClearBeforeFill = true;
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
            // мебельTableAdapter
            // 
            this.мебельTableAdapter.ClearBeforeFill = true;
            // 
            // категорииDataGridView
            // 
            this.категорииDataGridView.AllowUserToAddRows = false;
            this.категорииDataGridView.AllowUserToDeleteRows = false;
            this.категорииDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.категорииDataGridView.AutoGenerateColumns = false;
            this.категорииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.категорииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumnКатегория});
            this.категорииDataGridView.DataSource = this.категорииBindingSource;
            this.категорииDataGridView.Location = new System.Drawing.Point(11, 19);
            this.категорииDataGridView.MultiSelect = false;
            this.категорииDataGridView.Name = "категорииDataGridView";
            this.категорииDataGridView.ReadOnly = true;
            this.категорииDataGridView.RowTemplate.Height = 24;
            this.категорииDataGridView.Size = new System.Drawing.Size(302, 263);
            this.категорииDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД категории";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД категории";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumnКатегория
            // 
            this.dataGridViewTextBoxColumnКатегория.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnКатегория.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumnКатегория.HeaderText = "Категория";
            this.dataGridViewTextBoxColumnКатегория.Name = "dataGridViewTextBoxColumnКатегория";
            this.dataGridViewTextBoxColumnКатегория.ReadOnly = true;
            // 
            // мебельDataGridView
            // 
            this.мебельDataGridView.AllowUserToAddRows = false;
            this.мебельDataGridView.AllowUserToDeleteRows = false;
            this.мебельDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.мебельDataGridView.AutoGenerateColumns = false;
            this.мебельDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мебельDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumnFurnitureName,
            this.dataGridViewTextBoxColumnFurniturePrice,
            this.dataGridViewTextBoxColumnFurnitureDescription});
            this.мебельDataGridView.DataSource = this.мебельBindingSource;
            this.мебельDataGridView.Location = new System.Drawing.Point(3, 3);
            this.мебельDataGridView.Name = "мебельDataGridView";
            this.мебельDataGridView.ReadOnly = true;
            this.мебельDataGridView.RowTemplate.Height = 24;
            this.мебельDataGridView.Size = new System.Drawing.Size(662, 279);
            this.мебельDataGridView.TabIndex = 2;
            // 
            // мебельBindingSource
            // 
            this.мебельBindingSource.DataMember = "КатегорииМебель";
            this.мебельBindingSource.DataSource = this.категорииBindingSource;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonAddCategory);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.textBoxAddCategory);
            this.panel1.Controls.Add(this.категорииDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 488);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonRemoveCategory);
            this.panel3.Controls.Add(this.buttonEditCategory);
            this.panel3.Location = new System.Drawing.Point(-1, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 104);
            this.panel3.TabIndex = 5;
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveCategory.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveCategory.Location = new System.Drawing.Point(11, 11);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(302, 37);
            this.buttonRemoveCategory.TabIndex = 7;
            this.buttonRemoveCategory.Text = "Удалить категорию";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCategory.Location = new System.Drawing.Point(11, 54);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(302, 37);
            this.buttonEditCategory.TabIndex = 6;
            this.buttonEditCategory.Text = "Редактировать категорию";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCategory.ForeColor = System.Drawing.Color.Green;
            this.buttonAddCategory.Location = new System.Drawing.Point(11, 438);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(302, 37);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "Добавить категорию";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(11, 401);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(110, 24);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категория:";
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddCategory.Location = new System.Drawing.Point(127, 398);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(186, 30);
            this.textBoxAddCategory.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonAddFurniture);
            this.panel2.Controls.Add(this.labelPriceFurniture);
            this.panel2.Controls.Add(this.textBoxPriceFurniture);
            this.panel2.Controls.Add(this.labelDescriptionFurniture);
            this.panel2.Controls.Add(this.textBoxDescriptionFurniture);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelFurnitureName);
            this.panel2.Controls.Add(this.мебельDataGridView);
            this.panel2.Controls.Add(this.textBoxFurnitureName);
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 488);
            this.panel2.TabIndex = 4;
            // 
            // buttonAddFurniture
            // 
            this.buttonAddFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFurniture.ForeColor = System.Drawing.Color.Green;
            this.buttonAddFurniture.Location = new System.Drawing.Point(368, 438);
            this.buttonAddFurniture.Name = "buttonAddFurniture";
            this.buttonAddFurniture.Size = new System.Drawing.Size(259, 37);
            this.buttonAddFurniture.TabIndex = 6;
            this.buttonAddFurniture.Text = "Добавить мебель";
            this.buttonAddFurniture.UseVisualStyleBackColor = true;
            this.buttonAddFurniture.Click += new System.EventHandler(this.buttonAddFurniture_Click);
            // 
            // labelPriceFurniture
            // 
            this.labelPriceFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPriceFurniture.AutoSize = true;
            this.labelPriceFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceFurniture.Location = new System.Drawing.Point(364, 401);
            this.labelPriceFurniture.Name = "labelPriceFurniture";
            this.labelPriceFurniture.Size = new System.Drawing.Size(165, 24);
            this.labelPriceFurniture.TabIndex = 12;
            this.labelPriceFurniture.Text = "Цена за единицу:";
            // 
            // textBoxPriceFurniture
            // 
            this.textBoxPriceFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPriceFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceFurniture.Location = new System.Drawing.Point(535, 398);
            this.textBoxPriceFurniture.Name = "textBoxPriceFurniture";
            this.textBoxPriceFurniture.Size = new System.Drawing.Size(92, 30);
            this.textBoxPriceFurniture.TabIndex = 11;
            // 
            // labelDescriptionFurniture
            // 
            this.labelDescriptionFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDescriptionFurniture.AutoSize = true;
            this.labelDescriptionFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionFurniture.Location = new System.Drawing.Point(10, 446);
            this.labelDescriptionFurniture.Name = "labelDescriptionFurniture";
            this.labelDescriptionFurniture.Size = new System.Drawing.Size(105, 24);
            this.labelDescriptionFurniture.TabIndex = 10;
            this.labelDescriptionFurniture.Text = "Описание:";
            // 
            // textBoxDescriptionFurniture
            // 
            this.textBoxDescriptionFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDescriptionFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescriptionFurniture.Location = new System.Drawing.Point(194, 442);
            this.textBoxDescriptionFurniture.Name = "textBoxDescriptionFurniture";
            this.textBoxDescriptionFurniture.Size = new System.Drawing.Size(164, 30);
            this.textBoxDescriptionFurniture.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonRemoveFurniture);
            this.panel4.Controls.Add(this.buttonEditFurniture);
            this.panel4.Location = new System.Drawing.Point(-1, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(666, 104);
            this.panel4.TabIndex = 8;
            // 
            // buttonRemoveFurniture
            // 
            this.buttonRemoveFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveFurniture.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveFurniture.Location = new System.Drawing.Point(117, 11);
            this.buttonRemoveFurniture.Name = "buttonRemoveFurniture";
            this.buttonRemoveFurniture.Size = new System.Drawing.Size(412, 37);
            this.buttonRemoveFurniture.TabIndex = 9;
            this.buttonRemoveFurniture.Text = "Удалить выделенную мебель";
            this.buttonRemoveFurniture.UseVisualStyleBackColor = true;
            this.buttonRemoveFurniture.Click += new System.EventHandler(this.buttonRemoveFurniture_Click);
            // 
            // buttonEditFurniture
            // 
            this.buttonEditFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditFurniture.Location = new System.Drawing.Point(117, 54);
            this.buttonEditFurniture.Name = "buttonEditFurniture";
            this.buttonEditFurniture.Size = new System.Drawing.Size(412, 37);
            this.buttonEditFurniture.TabIndex = 8;
            this.buttonEditFurniture.Text = "Редактировать выделенную мебель";
            this.buttonEditFurniture.UseVisualStyleBackColor = true;
            this.buttonEditFurniture.Click += new System.EventHandler(this.buttonEditFurniture_Click);
            // 
            // labelFurnitureName
            // 
            this.labelFurnitureName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFurnitureName.AutoSize = true;
            this.labelFurnitureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFurnitureName.Location = new System.Drawing.Point(10, 401);
            this.labelFurnitureName.Name = "labelFurnitureName";
            this.labelFurnitureName.Size = new System.Drawing.Size(174, 24);
            this.labelFurnitureName.TabIndex = 7;
            this.labelFurnitureName.Text = "Название мебели:";
            // 
            // textBoxFurnitureName
            // 
            this.textBoxFurnitureName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFurnitureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFurnitureName.Location = new System.Drawing.Point(194, 398);
            this.textBoxFurnitureName.Name = "textBoxFurnitureName";
            this.textBoxFurnitureName.Size = new System.Drawing.Size(164, 30);
            this.textBoxFurnitureName.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер мебели";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер мебели";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumnFurnitureName
            // 
            this.dataGridViewTextBoxColumnFurnitureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnFurnitureName.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumnFurnitureName.HeaderText = "Название";
            this.dataGridViewTextBoxColumnFurnitureName.Name = "dataGridViewTextBoxColumnFurnitureName";
            this.dataGridViewTextBoxColumnFurnitureName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnFurniturePrice
            // 
            this.dataGridViewTextBoxColumnFurniturePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumnFurniturePrice.DataPropertyName = "Цена за единицу";
            this.dataGridViewTextBoxColumnFurniturePrice.HeaderText = "Цена за единицу";
            this.dataGridViewTextBoxColumnFurniturePrice.Name = "dataGridViewTextBoxColumnFurniturePrice";
            this.dataGridViewTextBoxColumnFurniturePrice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnFurnitureDescription
            // 
            this.dataGridViewTextBoxColumnFurnitureDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnFurnitureDescription.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumnFurnitureDescription.HeaderText = "Описание";
            this.dataGridViewTextBoxColumnFurnitureDescription.Name = "dataGridViewTextBoxColumnFurnitureDescription";
            this.dataGridViewTextBoxColumnFurnitureDescription.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мебель";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мебельBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ordersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private ordersDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private ordersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView категорииDataGridView;
        private ordersDataSetTableAdapters.МебельTableAdapter мебельTableAdapter;
        private System.Windows.Forms.BindingSource мебельBindingSource;
        private System.Windows.Forms.DataGridView мебельDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnКатегория;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Label labelFurnitureName;
        private System.Windows.Forms.TextBox textBoxFurnitureName;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRemoveFurniture;
        private System.Windows.Forms.Button buttonEditFurniture;
        private System.Windows.Forms.Label labelDescriptionFurniture;
        private System.Windows.Forms.TextBox textBoxDescriptionFurniture;
        private System.Windows.Forms.Label labelPriceFurniture;
        private System.Windows.Forms.TextBox textBoxPriceFurniture;
        private System.Windows.Forms.Button buttonAddFurniture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFurniturePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFurnitureDescription;
    }
}

