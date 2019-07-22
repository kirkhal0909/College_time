namespace RestaurantC
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.категорииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.категорииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.категорииDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_категории = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new RestaurantC.RestaurantDataSet();
            this.категорииTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.КатегорииTableAdapter();
            this.tableAdapterManager = new RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюдаTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.БлюдаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingNavigator)).BeginInit();
            this.категорииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // категорииBindingNavigator
            // 
            this.категорииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.категорииBindingNavigator.BindingSource = this.категорииBindingSource;
            this.категорииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.категорииBindingNavigator.CountItemFormat = "категория из {0}";
            this.категорииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.категорииBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.категорииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.категорииBindingNavigatorSaveItem});
            this.категорииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.категорииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.категорииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.категорииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.категорииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.категорииBindingNavigator.Name = "категорииBindingNavigator";
            this.категорииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.категорииBindingNavigator.Size = new System.Drawing.Size(460, 27);
            this.категорииBindingNavigator.TabIndex = 0;
            this.категорииBindingNavigator.Text = "bindingNavigator1";
            this.категорииBindingNavigator.RefreshItems += new System.EventHandler(this.категорииBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить категорию";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(121, 24);
            this.bindingNavigatorCountItem.Text = "категория из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить категорию";
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
            // категорииBindingNavigatorSaveItem
            // 
            this.категорииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.категорииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("категорииBindingNavigatorSaveItem.Image")));
            this.категорииBindingNavigatorSaveItem.Name = "категорииBindingNavigatorSaveItem";
            this.категорииBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.категорииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.категорииBindingNavigatorSaveItem.Click += new System.EventHandler(this.категорииBindingNavigatorSaveItem_Click);
            // 
            // категорииDataGridView
            // 
            this.категорииDataGridView.AllowUserToAddRows = false;
            this.категорииDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.категорииDataGridView.AutoGenerateColumns = false;
            this.категорииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.категорииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_категории,
            this.Категория});
            this.категорииDataGridView.DataSource = this.категорииBindingSource;
            this.категорииDataGridView.Location = new System.Drawing.Point(12, 30);
            this.категорииDataGridView.MultiSelect = false;
            this.категорииDataGridView.Name = "категорииDataGridView";
            this.категорииDataGridView.RowTemplate.Height = 24;
            this.категорииDataGridView.Size = new System.Drawing.Size(436, 355);
            this.категорииDataGridView.TabIndex = 1;
            this.категорииDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.категорииDataGridView_CellEndEdit);
            this.категорииDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.категорииDataGridView_CellValueChanged);
            this.категорииDataGridView.CurrentCellChanged += new System.EventHandler(this.категорииDataGridView_CurrentCellChanged);
            this.категорииDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.категорииDataGridView_UserDeletedRow);
            // 
            // ID_категории
            // 
            this.ID_категории.DataPropertyName = "ID_категории";
            this.ID_категории.HeaderText = "ID_категории";
            this.ID_категории.Name = "ID_категории";
            this.ID_категории.Visible = false;
            // 
            // Категория
            // 
            this.Категория.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Категория.DataPropertyName = "Категория";
            this.Категория.HeaderText = "Категория";
            this.Категория.Name = "Категория";
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.restaurantDataSet;
            this.категорииBindingSource.CurrentChanged += new System.EventHandler(this.категорииBindingSource_CurrentChanged);
            this.категорииBindingSource.PositionChanged += new System.EventHandler(this.категорииBindingSource_PositionChanged);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорииTableAdapter
            // 
            this.категорииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БлюдаTableAdapter = null;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = this.категорииTableAdapter;
            this.tableAdapterManager.ПродуктыTableAdapter = null;
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
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 397);
            this.Controls.Add(this.категорииDataGridView);
            this.Controls.Add(this.категорииBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категории";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categories_FormClosing);
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingNavigator)).EndInit();
            this.категорииBindingNavigator.ResumeLayout(false);
            this.категорииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private RestaurantDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator категорииBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton категорииBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView категорииDataGridView;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private RestaurantDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_категории;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
    }
}