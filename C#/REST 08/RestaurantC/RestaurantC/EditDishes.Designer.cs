namespace RestaurantC
{
    partial class EditDishes
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
            System.Windows.Forms.Label блюдоLabel;
            System.Windows.Forms.Label добавка_к_ценеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDishes));
            this.restaurantDataSet = new RestaurantC.RestaurantDataSet();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.БлюдаTableAdapter();
            this.tableAdapterManager = new RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.категорииTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.КатегорииTableAdapter();
            this.блюдаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.блюдаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.блюдаDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_блюда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_блюда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюдоTextBox = new System.Windows.Forms.TextBox();
            this.добавка_к_ценеTextBox = new System.Windows.Forms.TextBox();
            this.фото_блюдаPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonChangeИнгредиенты = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTipКатегория = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            блюдоLabel = new System.Windows.Forms.Label();
            добавка_к_ценеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).BeginInit();
            this.блюдаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // блюдоLabel
            // 
            блюдоLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            блюдоLabel.AutoSize = true;
            блюдоLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            блюдоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            блюдоLabel.Location = new System.Drawing.Point(450, 264);
            блюдоLabel.Name = "блюдоLabel";
            блюдоLabel.Size = new System.Drawing.Size(80, 25);
            блюдоLabel.TabIndex = 3;
            блюдоLabel.Text = "Блюдо:";
            // 
            // добавка_к_ценеLabel
            // 
            добавка_к_ценеLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            добавка_к_ценеLabel.AutoSize = true;
            добавка_к_ценеLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            добавка_к_ценеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            добавка_к_ценеLabel.Location = new System.Drawing.Point(450, 300);
            добавка_к_ценеLabel.Name = "добавка_к_ценеLabel";
            добавка_к_ценеLabel.Size = new System.Drawing.Size(162, 25);
            добавка_к_ценеLabel.TabIndex = 5;
            добавка_к_ценеLabel.Text = "Добавка к цене:";
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
            this.блюдаBindingSource.CurrentChanged += new System.EventHandler(this.блюдаBindingSource_CurrentChanged);
            this.блюдаBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.блюдаBindingSource_ListChanged);
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
            this.блюдаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.блюдаBindingNavigator.BindingSource = this.блюдаBindingSource;
            this.блюдаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.блюдаBindingNavigator.CountItemFormat = "блюдо из {0}";
            this.блюдаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.блюдаBindingNavigatorSaveItem});
            this.блюдаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.блюдаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.блюдаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.блюдаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.блюдаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.блюдаBindingNavigator.Name = "блюдаBindingNavigator";
            this.блюдаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.блюдаBindingNavigator.Size = new System.Drawing.Size(765, 27);
            this.блюдаBindingNavigator.TabIndex = 0;
            this.блюдаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить блюдо";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(97, 24);
            this.bindingNavigatorCountItem.Text = "блюдо из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить блюдо";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // блюдаBindingNavigatorSaveItem
            // 
            this.блюдаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.блюдаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("блюдаBindingNavigatorSaveItem.Image")));
            this.блюдаBindingNavigatorSaveItem.Name = "блюдаBindingNavigatorSaveItem";
            this.блюдаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.блюдаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.блюдаBindingNavigatorSaveItem.Click += new System.EventHandler(this.блюдаBindingNavigatorSaveItem_Click);
            // 
            // блюдаDataGridView
            // 
            this.блюдаDataGridView.AllowUserToAddRows = false;
            this.блюдаDataGridView.AllowUserToDeleteRows = false;
            this.блюдаDataGridView.AllowUserToOrderColumns = true;
            this.блюдаDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.блюдаDataGridView.AutoGenerateColumns = false;
            this.блюдаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.блюдаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_блюда,
            this.Название_блюда,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.блюдаDataGridView.DataSource = this.блюдаBindingSource;
            this.блюдаDataGridView.Location = new System.Drawing.Point(12, 30);
            this.блюдаDataGridView.Name = "блюдаDataGridView";
            this.блюдаDataGridView.ReadOnly = true;
            this.блюдаDataGridView.RowTemplate.Height = 24;
            this.блюдаDataGridView.Size = new System.Drawing.Size(427, 439);
            this.блюдаDataGridView.TabIndex = 1;
            this.блюдаDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.блюдаDataGridView_CellEnter);
            this.блюдаDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.блюдаDataGridView_CellLeave);
            this.блюдаDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.блюдаDataGridView_CellValueChanged);
            this.блюдаDataGridView.CurrentCellChanged += new System.EventHandler(this.блюдаDataGridView_CurrentCellChanged_2);
            this.блюдаDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.блюдаDataGridView_RowsRemoved);
            // 
            // ID_блюда
            // 
            this.ID_блюда.DataPropertyName = "ID_блюда";
            this.ID_блюда.HeaderText = "ID_блюда";
            this.ID_блюда.Name = "ID_блюда";
            this.ID_блюда.ReadOnly = true;
            this.ID_блюда.Visible = false;
            // 
            // Название_блюда
            // 
            this.Название_блюда.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Название_блюда.DataPropertyName = "Блюдо";
            this.Название_блюда.HeaderText = "Блюдо";
            this.Название_блюда.Name = "Название_блюда";
            this.Название_блюда.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_категории";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_категории";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Добавка_к_цене";
            this.dataGridViewTextBoxColumn4.HeaderText = "Добавка_к_цене";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 149;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.блюдаBindingSource, "ID_категории", true));
            this.comboBox1.DataSource = this.категорииBindingSource;
            this.comboBox1.DisplayMember = "Категория";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(578, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_категории";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.restaurantDataSet;
            // 
            // блюдоTextBox
            // 
            this.блюдоTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.блюдоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.блюдаBindingSource, "Блюдо", true));
            this.блюдоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.блюдоTextBox.Location = new System.Drawing.Point(543, 261);
            this.блюдоTextBox.Name = "блюдоTextBox";
            this.блюдоTextBox.Size = new System.Drawing.Size(215, 30);
            this.блюдоTextBox.TabIndex = 4;
            this.блюдоTextBox.TextChanged += new System.EventHandler(this.блюдоTextBox_TextChanged);
            // 
            // добавка_к_ценеTextBox
            // 
            this.добавка_к_ценеTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.добавка_к_ценеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.блюдаBindingSource, "Добавка_к_цене", true));
            this.добавка_к_ценеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавка_к_ценеTextBox.Location = new System.Drawing.Point(625, 297);
            this.добавка_к_ценеTextBox.Name = "добавка_к_ценеTextBox";
            this.добавка_к_ценеTextBox.Size = new System.Drawing.Size(133, 30);
            this.добавка_к_ценеTextBox.TabIndex = 6;
            this.добавка_к_ценеTextBox.TextChanged += new System.EventHandler(this.добавка_к_ценеTextBox_TextChanged);
            // 
            // фото_блюдаPictureBox
            // 
            this.фото_блюдаPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.фото_блюдаPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.фото_блюдаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.блюдаBindingSource, "Фото_блюда", true));
            this.фото_блюдаPictureBox.Location = new System.Drawing.Point(509, 55);
            this.фото_блюдаPictureBox.Name = "фото_блюдаPictureBox";
            this.фото_блюдаPictureBox.Size = new System.Drawing.Size(200, 200);
            this.фото_блюдаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фото_блюдаPictureBox.TabIndex = 8;
            this.фото_блюдаPictureBox.TabStop = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddImage.Location = new System.Drawing.Point(641, 222);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(34, 33);
            this.buttonAddImage.TabIndex = 11;
            this.buttonAddImage.Text = "+";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveImage.Location = new System.Drawing.Point(675, 222);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(34, 33);
            this.buttonRemoveImage.TabIndex = 10;
            this.buttonRemoveImage.Text = "X";
            this.buttonRemoveImage.UseVisualStyleBackColor = true;
            this.buttonRemoveImage.Click += new System.EventHandler(this.buttonRemoveImage_Click);
            // 
            // buttonChangeИнгредиенты
            // 
            this.buttonChangeИнгредиенты.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonChangeИнгредиенты.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeИнгредиенты.Location = new System.Drawing.Point(466, 398);
            this.buttonChangeИнгредиенты.Name = "buttonChangeИнгредиенты";
            this.buttonChangeИнгредиенты.Size = new System.Drawing.Size(281, 34);
            this.buttonChangeИнгредиенты.TabIndex = 12;
            this.buttonChangeИнгредиенты.Text = "Изменить ингредиенты";
            this.buttonChangeИнгредиенты.UseVisualStyleBackColor = true;
            this.buttonChangeИнгредиенты.Click += new System.EventHandler(this.buttonChangeИнгредиенты_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(450, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 25);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Категория:";
            this.toolTipКатегория.SetToolTip(this.linkLabel1, "Добавить/изменить список категорий\r\n");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(470, 435);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(277, 34);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Для изменения ингредиентов/категорий\r\nнеобходимо сохранить изменения блюд\r\n";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // EditDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 481);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonChangeИнгредиенты);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(блюдоLabel);
            this.Controls.Add(this.блюдоTextBox);
            this.Controls.Add(добавка_к_ценеLabel);
            this.Controls.Add(this.добавка_к_ценеTextBox);
            this.Controls.Add(this.фото_блюдаPictureBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.блюдаDataGridView);
            this.Controls.Add(this.блюдаBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(18, 528);
            this.Name = "EditDishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор блюд";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDishes_FormClosing);
            this.Load += new System.EventHandler(this.EditDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingNavigator)).EndInit();
            this.блюдаBindingNavigator.ResumeLayout(false);
            this.блюдаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фото_блюдаPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private RestaurantDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator блюдаBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton блюдаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView блюдаDataGridView;
        private RestaurantDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private System.Windows.Forms.TextBox блюдоTextBox;
        private System.Windows.Forms.TextBox добавка_к_ценеTextBox;
        private System.Windows.Forms.PictureBox фото_блюдаPictureBox;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonChangeИнгредиенты;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTipКатегория;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_блюда;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_блюда;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}