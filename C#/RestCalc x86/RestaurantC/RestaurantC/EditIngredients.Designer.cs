namespace RestaurantC
{
    partial class EditIngredients
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
            System.Windows.Forms.Label labelИнгредиенты_блюда;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredients));
            this.restaurantDataSet = new RestaurantC.RestaurantDataSet();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.БлюдаTableAdapter();
            this.tableAdapterManager = new RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.ингредиентыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter();
            this.продуктыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ПродуктыTableAdapter();
            this.блюдоLabel1 = new System.Windows.Forms.Label();
            this.фото_блюдаPictureBox = new System.Windows.Forms.PictureBox();
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ингредиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ингредиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ингредиент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_ингредиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_блюдаTextBox = new System.Windows.Forms.TextBox();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_продукта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Продукт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSave = new System.Windows.Forms.Button();
            this.фото_продуктаPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            labelИнгредиенты_блюда = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_продуктаPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelИнгредиенты_блюда
            // 
            labelИнгредиенты_блюда.AutoSize = true;
            labelИнгредиенты_блюда.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelИнгредиенты_блюда.Location = new System.Drawing.Point(61, 139);
            labelИнгредиенты_блюда.Name = "labelИнгредиенты_блюда";
            labelИнгредиенты_блюда.Size = new System.Drawing.Size(209, 25);
            labelИнгредиенты_блюда.TabIndex = 9;
            labelИнгредиенты_блюда.Text = "Ингредиенты блюда:";
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.restaurantDataSet;
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
            this.tableAdapterManager.ИнгредиентыTableAdapter = this.ингредиентыTableAdapter;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.ПродуктыTableAdapter = this.продуктыTableAdapter;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // блюдоLabel1
            // 
            this.блюдоLabel1.AutoSize = true;
            this.блюдоLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.блюдаBindingSource, "Блюдо", true));
            this.блюдоLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.блюдоLabel1.Location = new System.Drawing.Point(12, 7);
            this.блюдоLabel1.Name = "блюдоLabel1";
            this.блюдоLabel1.Size = new System.Drawing.Size(170, 25);
            this.блюдоLabel1.TabIndex = 2;
            this.блюдоLabel1.Text = "Название_блюда";
            // 
            // фото_блюдаPictureBox
            // 
            this.фото_блюдаPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.фото_блюдаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.блюдаBindingSource, "Фото_блюда", true));
            this.фото_блюдаPictureBox.Location = new System.Drawing.Point(17, 36);
            this.фото_блюдаPictureBox.Name = "фото_блюдаPictureBox";
            this.фото_блюдаPictureBox.Size = new System.Drawing.Size(100, 100);
            this.фото_блюдаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фото_блюдаPictureBox.TabIndex = 4;
            this.фото_блюдаPictureBox.TabStop = false;
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataMember = "БлюдаИнгредиенты";
            this.ингредиентыBindingSource.DataSource = this.блюдаBindingSource;
            // 
            // ингредиентыDataGridView
            // 
            this.ингредиентыDataGridView.AllowUserToAddRows = false;
            this.ингредиентыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ингредиентыDataGridView.AutoGenerateColumns = false;
            this.ингредиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ингредиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ID_ингредиента,
            this.Ингредиент,
            this.Количество_ингредиента});
            this.ингредиентыDataGridView.DataSource = this.ингредиентыBindingSource;
            this.ингредиентыDataGridView.Location = new System.Drawing.Point(12, 167);
            this.ингредиентыDataGridView.Name = "ингредиентыDataGridView";
            this.ингредиентыDataGridView.RowTemplate.Height = 24;
            this.ингредиентыDataGridView.Size = new System.Drawing.Size(359, 270);
            this.ингредиентыDataGridView.TabIndex = 4;
            this.ингредиентыDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ингредиентыDataGridView_CellValueChanged);
            this.ингредиентыDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ингредиентыDataGridView_DataError);
            this.ингредиентыDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ингредиентыDataGridView_DefaultValuesNeeded);
            this.ингредиентыDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ингредиентыDataGridView_RowsRemoved);
            this.ингредиентыDataGridView.Sorted += new System.EventHandler(this.ингредиентыDataGridView_Sorted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_блюда";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_блюда";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ID_ингредиента
            // 
            this.ID_ингредиента.DataPropertyName = "ID_продукта";
            this.ID_ингредиента.HeaderText = "ID_продукта";
            this.ID_ингредиента.Name = "ID_ингредиента";
            this.ID_ингредиента.ReadOnly = true;
            this.ID_ингредиента.Visible = false;
            // 
            // Ингредиент
            // 
            this.Ингредиент.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ингредиент.HeaderText = "Продукт";
            this.Ингредиент.Name = "Ингредиент";
            this.Ингредиент.ReadOnly = true;
            // 
            // Количество_ингредиента
            // 
            this.Количество_ингредиента.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Количество_ингредиента.DataPropertyName = "Количество";
            this.Количество_ингредиента.HeaderText = "Количество";
            this.Количество_ингредиента.Name = "Количество_ингредиента";
            this.Количество_ингредиента.Width = 115;
            // 
            // iD_блюдаTextBox
            // 
            this.iD_блюдаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.блюдаBindingSource, "ID_блюда", true));
            this.iD_блюдаTextBox.Enabled = false;
            this.iD_блюдаTextBox.Location = new System.Drawing.Point(-4, 234);
            this.iD_блюдаTextBox.Name = "iD_блюдаTextBox";
            this.iD_блюдаTextBox.Size = new System.Drawing.Size(0, 22);
            this.iD_блюдаTextBox.TabIndex = 5;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.restaurantDataSet;
            // 
            // продуктыDataGridView
            // 
            this.продуктыDataGridView.AllowUserToAddRows = false;
            this.продуктыDataGridView.AllowUserToDeleteRows = false;
            this.продуктыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.продуктыDataGridView.AutoGenerateColumns = false;
            this.продуктыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продуктыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_продукта,
            this.Продукт,
            this.Стоимость});
            this.продуктыDataGridView.DataSource = this.продуктыBindingSource;
            this.продуктыDataGridView.Location = new System.Drawing.Point(438, 31);
            this.продуктыDataGridView.Name = "продуктыDataGridView";
            this.продуктыDataGridView.ReadOnly = true;
            this.продуктыDataGridView.RowTemplate.Height = 24;
            this.продуктыDataGridView.Size = new System.Drawing.Size(343, 406);
            this.продуктыDataGridView.TabIndex = 5;
            // 
            // ID_продукта
            // 
            this.ID_продукта.DataPropertyName = "ИД_продукта";
            this.ID_продукта.HeaderText = "ИД_продукта";
            this.ID_продукта.Name = "ID_продукта";
            this.ID_продукта.ReadOnly = true;
            this.ID_продукта.Visible = false;
            // 
            // Продукт
            // 
            this.Продукт.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Продукт.DataPropertyName = "Продукт";
            this.Продукт.HeaderText = "Продукт";
            this.Продукт.Name = "Продукт";
            this.Продукт.ReadOnly = true;
            // 
            // Стоимость
            // 
            this.Стоимость.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Стоимость.DataPropertyName = "Стоимость";
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Width = 107;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonAdd.Location = new System.Drawing.Point(389, 248);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 31);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "<";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator1.BindingSource = this.продуктыBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "продукт из {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(477, 1);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(284, 27);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(106, 24);
            this.bindingNavigatorCountItem.Text = "продукт из {0}";
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
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(123, 99);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(248, 37);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // фото_продуктаPictureBox
            // 
            this.фото_продуктаPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.фото_продуктаPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.фото_продуктаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.продуктыBindingSource, "Фото_продукта", true));
            this.фото_продуктаPictureBox.Location = new System.Drawing.Point(381, 192);
            this.фото_продуктаPictureBox.Name = "фото_продуктаPictureBox";
            this.фото_продуктаPictureBox.Size = new System.Drawing.Size(50, 50);
            this.фото_продуктаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фото_продуктаPictureBox.TabIndex = 11;
            this.фото_продуктаPictureBox.TabStop = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.ForeColor = System.Drawing.Color.Green;
            this.buttonProducts.Location = new System.Drawing.Point(749, -1);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(32, 32);
            this.buttonProducts.TabIndex = 12;
            this.buttonProducts.Text = "+";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(389, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EditIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.фото_продуктаPictureBox);
            this.Controls.Add(labelИнгредиенты_блюда);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.продуктыDataGridView);
            this.Controls.Add(this.iD_блюдаTextBox);
            this.Controls.Add(this.ингредиентыDataGridView);
            this.Controls.Add(this.блюдоLabel1);
            this.Controls.Add(this.фото_блюдаPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditIngredients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditIngredients_FormClosing);
            this.Load += new System.EventHandler(this.EditIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_продуктаPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private RestaurantDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label блюдоLabel1;
        private System.Windows.Forms.PictureBox фото_блюдаPictureBox;
        private RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private System.Windows.Forms.DataGridView ингредиентыDataGridView;
        private System.Windows.Forms.TextBox iD_блюдаTextBox;
        private RestaurantDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private System.Windows.Forms.DataGridView продуктыDataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ингредиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ингредиент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_ингредиента;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_продукта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.PictureBox фото_продуктаPictureBox;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button button1;
    }
}