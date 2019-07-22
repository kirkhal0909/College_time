namespace RestaurantC
{
    partial class Dishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishes));
            this.restaurantDataSet = new RestaurantC.RestaurantDataSet();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.БлюдаTableAdapter();
            this.tableAdapterManager = new RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.категорииTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.КатегорииTableAdapter();
            this.блюдаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.блюдаDataGridView = new System.Windows.Forms.DataGridView();
            this.Блюдо = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_блюда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_категории = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Добавка_к_цене = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КатегорииComboBox = new System.Windows.Forms.ComboBox();
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фото_блюдаPictureBox = new System.Windows.Forms.PictureBox();
            this.блюдоLabel1 = new System.Windows.Forms.Label();
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ингредиентыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter();
            this.ингредиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.Ингредиенты_ID_блюда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ингредиенты_ID_продукта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Продукт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ингредиенты_Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фото_ингредиента = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTipБлюдо = new System.Windows.Forms.ToolTip(this.components);
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ПродуктыTableAdapter();
            this.продуктыDataGridView = new System.Windows.Forms.DataGridView();
            this.Продукт_ИД_продукта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Продукт_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Продукт_Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фото_продукта = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMakeUp = new System.Windows.Forms.Label();
            this.ингредиентPictureBox = new System.Windows.Forms.PictureBox();
            this.КатегорииToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).BeginInit();
            this.блюдаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.AllowNew = false;
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.restaurantDataSet;
            this.блюдаBindingSource.PositionChanged += new System.EventHandler(this.блюдаBindingSource_PositionChanged);
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БлюдаTableAdapter = this.блюдаTableAdapter;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = this.категорииTableAdapter;
            this.tableAdapterManager.ПродуктыTableAdapter = null;
            // 
            // категорииTableAdapter
            // 
            this.категорииTableAdapter.ClearBeforeFill = true;
            // 
            // блюдаBindingNavigator
            // 
            this.блюдаBindingNavigator.AddNewItem = null;
            this.блюдаBindingNavigator.BindingSource = this.блюдаBindingSource;
            this.блюдаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.блюдаBindingNavigator.CountItemFormat = "блюдо из {0}";
            this.блюдаBindingNavigator.DeleteItem = null;
            this.блюдаBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.блюдаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.блюдаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.блюдаBindingNavigator.Location = new System.Drawing.Point(12, 45);
            this.блюдаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.блюдаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.блюдаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.блюдаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.блюдаBindingNavigator.Name = "блюдаBindingNavigator";
            this.блюдаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.блюдаBindingNavigator.Size = new System.Drawing.Size(275, 27);
            this.блюдаBindingNavigator.TabIndex = 0;
            this.блюдаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(97, 24);
            this.bindingNavigatorCountItem.Text = "блюдо из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // блюдаDataGridView
            // 
            this.блюдаDataGridView.AllowDrop = true;
            this.блюдаDataGridView.AllowUserToAddRows = false;
            this.блюдаDataGridView.AllowUserToDeleteRows = false;
            this.блюдаDataGridView.AllowUserToOrderColumns = true;
            this.блюдаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.блюдаDataGridView.AutoGenerateColumns = false;
            this.блюдаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.блюдаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Блюдо,
            this.Стоимость,
            this.ID_блюда,
            this.ID_категории,
            this.Добавка_к_цене});
            this.блюдаDataGridView.DataSource = this.блюдаBindingSource;
            this.блюдаDataGridView.Location = new System.Drawing.Point(12, 75);
            this.блюдаDataGridView.Name = "блюдаDataGridView";
            this.блюдаDataGridView.RowTemplate.Height = 24;
            this.блюдаDataGridView.Size = new System.Drawing.Size(409, 440);
            this.блюдаDataGridView.TabIndex = 1;
            this.блюдаDataGridView.Sorted += new System.EventHandler(this.блюдаDataGridView_Sorted);
            // 
            // Блюдо
            // 
            this.Блюдо.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Блюдо.DataPropertyName = "Блюдо";
            this.Блюдо.HeaderText = "Блюдо";
            this.Блюдо.Name = "Блюдо";
            // 
            // Стоимость
            // 
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.Width = 94;
            // 
            // ID_блюда
            // 
            this.ID_блюда.DataPropertyName = "ID_блюда";
            this.ID_блюда.HeaderText = "ID_блюда";
            this.ID_блюда.Name = "ID_блюда";
            this.ID_блюда.Visible = false;
            // 
            // ID_категории
            // 
            this.ID_категории.DataPropertyName = "ID_категории";
            this.ID_категории.HeaderText = "ID_категории";
            this.ID_категории.Name = "ID_категории";
            this.ID_категории.Visible = false;
            // 
            // Добавка_к_цене
            // 
            this.Добавка_к_цене.DataPropertyName = "Добавка_к_цене";
            this.Добавка_к_цене.HeaderText = "Добавка_к_цене";
            this.Добавка_к_цене.Name = "Добавка_к_цене";
            this.Добавка_к_цене.Visible = false;
            // 
            // КатегорииComboBox
            // 
            this.КатегорииComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.КатегорииComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.КатегорииComboBox.DataSource = this.категорииBindingSource;
            this.КатегорииComboBox.DisplayMember = "Категория";
            this.КатегорииComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.КатегорииComboBox.FormattingEnabled = true;
            this.КатегорииComboBox.Location = new System.Drawing.Point(12, 8);
            this.КатегорииComboBox.Name = "КатегорииComboBox";
            this.КатегорииComboBox.Size = new System.Drawing.Size(409, 33);
            this.КатегорииComboBox.TabIndex = 2;
            this.КатегорииComboBox.ValueMember = "ID_категории";
            this.КатегорииComboBox.SelectedIndexChanged += new System.EventHandler(this.КатегорииComboBox_SelectedIndexChanged);
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.restaurantDataSet;
            this.категорииBindingSource.PositionChanged += new System.EventHandler(this.категорииBindingSource_PositionChanged);
            // 
            // фото_блюдаPictureBox
            // 
            this.фото_блюдаPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.фото_блюдаPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.фото_блюдаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.блюдаBindingSource, "Фото_блюда", true));
            this.фото_блюдаPictureBox.Location = new System.Drawing.Point(438, 44);
            this.фото_блюдаPictureBox.Name = "фото_блюдаPictureBox";
            this.фото_блюдаPictureBox.Size = new System.Drawing.Size(200, 200);
            this.фото_блюдаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фото_блюдаPictureBox.TabIndex = 5;
            this.фото_блюдаPictureBox.TabStop = false;
            // 
            // блюдоLabel1
            // 
            this.блюдоLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.блюдоLabel1.AutoSize = true;
            this.блюдоLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.блюдаBindingSource, "Блюдо", true));
            this.блюдоLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.блюдоLabel1.Location = new System.Drawing.Point(433, 13);
            this.блюдоLabel1.Name = "блюдоLabel1";
            this.блюдоLabel1.Size = new System.Drawing.Size(64, 25);
            this.блюдоLabel1.TabIndex = 7;
            this.блюдоLabel1.Text = "label1";
            this.блюдоLabel1.TextChanged += new System.EventHandler(this.блюдоLabel1_TextChanged);
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataMember = "БлюдаИнгредиенты";
            this.ингредиентыBindingSource.DataSource = this.блюдаBindingSource;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // ингредиентыDataGridView
            // 
            this.ингредиентыDataGridView.AllowUserToAddRows = false;
            this.ингредиентыDataGridView.AllowUserToDeleteRows = false;
            this.ингредиентыDataGridView.AllowUserToOrderColumns = true;
            this.ингредиентыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ингредиентыDataGridView.AutoGenerateColumns = false;
            this.ингредиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ингредиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ингредиенты_ID_блюда,
            this.Ингредиенты_ID_продукта,
            this.Продукт,
            this.Ингредиенты_Количество,
            this.Стоимость_,
            this.Фото_ингредиента});
            this.ингредиентыDataGridView.DataSource = this.ингредиентыBindingSource;
            this.ингредиентыDataGridView.Location = new System.Drawing.Point(655, 75);
            this.ингредиентыDataGridView.Name = "ингредиентыDataGridView";
            this.ингредиентыDataGridView.RowTemplate.Height = 24;
            this.ингредиентыDataGridView.Size = new System.Drawing.Size(408, 440);
            this.ингредиентыDataGridView.TabIndex = 7;
            this.ингредиентыDataGridView.Sorted += new System.EventHandler(this.ингредиентыDataGridView_Sorted);
            // 
            // Ингредиенты_ID_блюда
            // 
            this.Ингредиенты_ID_блюда.DataPropertyName = "ID_блюда";
            this.Ингредиенты_ID_блюда.HeaderText = "ID_блюда";
            this.Ингредиенты_ID_блюда.Name = "Ингредиенты_ID_блюда";
            this.Ингредиенты_ID_блюда.ReadOnly = true;
            this.Ингредиенты_ID_блюда.Visible = false;
            // 
            // Ингредиенты_ID_продукта
            // 
            this.Ингредиенты_ID_продукта.DataPropertyName = "ID_продукта";
            this.Ингредиенты_ID_продукта.HeaderText = "ID_продукта";
            this.Ингредиенты_ID_продукта.Name = "Ингредиенты_ID_продукта";
            this.Ингредиенты_ID_продукта.ReadOnly = true;
            this.Ингредиенты_ID_продукта.Visible = false;
            // 
            // Продукт
            // 
            this.Продукт.HeaderText = "Продукт";
            this.Продукт.Name = "Продукт";
            this.Продукт.ReadOnly = true;
            this.Продукт.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Продукт.Width = 123;
            // 
            // Ингредиенты_Количество
            // 
            this.Ингредиенты_Количество.DataPropertyName = "Количество";
            this.Ингредиенты_Количество.HeaderText = "Количество";
            this.Ингредиенты_Количество.Name = "Ингредиенты_Количество";
            this.Ингредиенты_Количество.ReadOnly = true;
            this.Ингредиенты_Количество.Width = 70;
            // 
            // Стоимость_
            // 
            this.Стоимость_.HeaderText = "Стоимость";
            this.Стоимость_.Name = "Стоимость_";
            this.Стоимость_.ReadOnly = true;
            this.Стоимость_.Width = 70;
            // 
            // Фото_ингредиента
            // 
            this.Фото_ингредиента.HeaderText = "Фото_ингредиента";
            this.Фото_ингредиента.Name = "Фото_ингредиента";
            this.Фото_ингредиента.ReadOnly = true;
            this.Фото_ингредиента.Visible = false;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.restaurantDataSet;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыDataGridView
            // 
            this.продуктыDataGridView.AllowUserToAddRows = false;
            this.продуктыDataGridView.AllowUserToDeleteRows = false;
            this.продуктыDataGridView.AllowUserToOrderColumns = true;
            this.продуктыDataGridView.AutoGenerateColumns = false;
            this.продуктыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продуктыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Продукт_ИД_продукта,
            this.Продукт_,
            this.Продукт_Стоимость,
            this.Фото_продукта});
            this.продуктыDataGridView.DataSource = this.продуктыBindingSource;
            this.продуктыDataGridView.Location = new System.Drawing.Point(88, 160);
            this.продуктыDataGridView.Name = "продуктыDataGridView";
            this.продуктыDataGridView.RowTemplate.Height = 24;
            this.продуктыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.продуктыDataGridView.TabIndex = 7;
            this.продуктыDataGridView.Visible = false;
            // 
            // Продукт_ИД_продукта
            // 
            this.Продукт_ИД_продукта.DataPropertyName = "ИД_продукта";
            this.Продукт_ИД_продукта.HeaderText = "ИД_продукта";
            this.Продукт_ИД_продукта.Name = "Продукт_ИД_продукта";
            this.Продукт_ИД_продукта.ReadOnly = true;
            // 
            // Продукт_
            // 
            this.Продукт_.DataPropertyName = "Продукт";
            this.Продукт_.HeaderText = "Продукт";
            this.Продукт_.Name = "Продукт_";
            this.Продукт_.ReadOnly = true;
            // 
            // Продукт_Стоимость
            // 
            this.Продукт_Стоимость.DataPropertyName = "Стоимость";
            this.Продукт_Стоимость.HeaderText = "Стоимость";
            this.Продукт_Стоимость.Name = "Продукт_Стоимость";
            this.Продукт_Стоимость.ReadOnly = true;
            // 
            // Фото_продукта
            // 
            this.Фото_продукта.DataPropertyName = "Фото_продукта";
            this.Фото_продукта.HeaderText = "Фото_продукта";
            this.Фото_продукта.Name = "Фото_продукта";
            this.Фото_продукта.ReadOnly = true;
            this.Фото_продукта.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(433, 288);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(185, 25);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Цена за продукты:";
            // 
            // labelMakeUp
            // 
            this.labelMakeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMakeUp.AutoSize = true;
            this.labelMakeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMakeUp.Location = new System.Drawing.Point(707, 47);
            this.labelMakeUp.Name = "labelMakeUp";
            this.labelMakeUp.Size = new System.Drawing.Size(149, 25);
            this.labelMakeUp.TabIndex = 10;
            this.labelMakeUp.Text = "Состав блюда:";
            // 
            // ингредиентPictureBox
            // 
            this.ингредиентPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ингредиентPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ингредиентPictureBox.Location = new System.Drawing.Point(538, 361);
            this.ингредиентPictureBox.Name = "ингредиентPictureBox";
            this.ингредиентPictureBox.Size = new System.Drawing.Size(100, 100);
            this.ингредиентPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ингредиентPictureBox.TabIndex = 11;
            this.ингредиентPictureBox.TabStop = false;
            this.ингредиентPictureBox.Visible = false;
            // 
            // Dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 527);
            this.Controls.Add(this.ингредиентPictureBox);
            this.Controls.Add(this.labelMakeUp);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.продуктыDataGridView);
            this.Controls.Add(this.ингредиентыDataGridView);
            this.Controls.Add(this.блюдоLabel1);
            this.Controls.Add(this.фото_блюдаPictureBox);
            this.Controls.Add(this.КатегорииComboBox);
            this.Controls.Add(this.блюдаDataGridView);
            this.Controls.Add(this.блюдаBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1101, 450);
            this.Name = "Dishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блюда";
            this.Load += new System.EventHandler(this.Dishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).EndInit();
            this.блюдаBindingNavigator.ResumeLayout(false);
            this.блюдаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private RestaurantDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator блюдаBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView блюдаDataGridView;
        private RestaurantDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private System.Windows.Forms.ComboBox КатегорииComboBox;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private System.Windows.Forms.PictureBox фото_блюдаPictureBox;
        private System.Windows.Forms.Label блюдоLabel1;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private System.Windows.Forms.DataGridView ингредиентыDataGridView;
        private System.Windows.Forms.ToolTip toolTipБлюдо;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private RestaurantDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridView продуктыDataGridView;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMakeUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ингредиенты_ID_блюда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ингредиенты_ID_продукта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ингредиенты_Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость_;
        private System.Windows.Forms.DataGridViewImageColumn Фото_ингредиента;
        private System.Windows.Forms.PictureBox ингредиентPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт_ИД_продукта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт_Стоимость;
        private System.Windows.Forms.DataGridViewImageColumn Фото_продукта;
        private System.Windows.Forms.ToolTip КатегорииToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Блюдо;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_блюда;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_категории;
        private System.Windows.Forms.DataGridViewTextBoxColumn Добавка_к_цене;
    }
}