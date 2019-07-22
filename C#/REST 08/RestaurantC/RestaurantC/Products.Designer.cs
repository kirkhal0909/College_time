namespace RestaurantC
{
    partial class Products
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
            System.Windows.Forms.Label продуктLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.restaurantDataSet = new RestaurantC.RestaurantDataSet();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ПродуктыTableAdapter();
            this.tableAdapterManager = new RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.продуктыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.продуктыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.продуктTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.фото_продуктаPictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.HintRemove = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxПродукты = new System.Windows.Forms.ComboBox();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.HintAdd = new System.Windows.Forms.ToolTip(this.components);
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ингредиентыTableAdapter = new RestaurantC.RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter();
            продуктLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingNavigator)).BeginInit();
            this.продуктыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_продуктаPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // продуктLabel
            // 
            продуктLabel.AutoSize = true;
            продуктLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            продуктLabel.Location = new System.Drawing.Point(7, 294);
            продуктLabel.Name = "продуктLabel";
            продуктLabel.Size = new System.Drawing.Size(97, 25);
            продуктLabel.TabIndex = 1;
            продуктLabel.Text = "Продукт:";
            продуктLabel.Click += new System.EventHandler(this.продуктLabel_Click);
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            стоимостьLabel.Location = new System.Drawing.Point(7, 335);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(125, 25);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            стоимостьLabel.Click += new System.EventHandler(this.стоимостьLabel_Click);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.restaurantDataSet;
            this.продуктыBindingSource.Filter = "";
            this.продуктыBindingSource.CurrentChanged += new System.EventHandler(this.продуктыBindingSource_CurrentChanged);
            this.продуктыBindingSource.CurrentItemChanged += new System.EventHandler(this.продуктыBindingSource_CurrentItemChanged);
            this.продуктыBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.продуктыBindingSource_ListChanged);
            this.продуктыBindingSource.PositionChanged += new System.EventHandler(this.продуктыBindingSource_PositionChanged);
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantC.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БлюдаTableAdapter = null;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.ПродуктыTableAdapter = this.продуктыTableAdapter;
            // 
            // продуктыBindingNavigator
            // 
            this.продуктыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.продуктыBindingNavigator.BindingSource = this.продуктыBindingSource;
            this.продуктыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.продуктыBindingNavigator.CountItemFormat = "из {0}";
            this.продуктыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.продуктыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.продуктыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.продуктыBindingNavigatorSaveItem});
            this.продуктыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.продуктыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.продуктыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.продуктыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.продуктыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.продуктыBindingNavigator.Name = "продуктыBindingNavigator";
            this.продуктыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.продуктыBindingNavigator.Size = new System.Drawing.Size(380, 27);
            this.продуктыBindingNavigator.TabIndex = 0;
            this.продуктыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить новый продукт";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить продукт";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.EnabledChanged += new System.EventHandler(this.bindingNavigatorDeleteItem_EnabledChanged);
            this.bindingNavigatorDeleteItem.Paint += new System.Windows.Forms.PaintEventHandler(this.bindingNavigatorDeleteItem_Paint);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "К первому продукту";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "К предыдущему продукту";
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
            this.bindingNavigatorMoveNextItem.Text = "К следующему продукту";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "К последнему продукту";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // продуктыBindingNavigatorSaveItem
            // 
            this.продуктыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.продуктыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("продуктыBindingNavigatorSaveItem.Image")));
            this.продуктыBindingNavigatorSaveItem.Name = "продуктыBindingNavigatorSaveItem";
            this.продуктыBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.продуктыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.продуктыBindingNavigatorSaveItem.Click += new System.EventHandler(this.продуктыBindingNavigatorSaveItem_Click);
            // 
            // продуктTextBox
            // 
            this.продуктTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктыBindingSource, "Продукт", true));
            this.продуктTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продуктTextBox.Location = new System.Drawing.Point(138, 289);
            this.продуктTextBox.Name = "продуктTextBox";
            this.продуктTextBox.Size = new System.Drawing.Size(230, 30);
            this.продуктTextBox.TabIndex = 2;
            this.продуктTextBox.TextChanged += new System.EventHandler(this.продуктTextBox_TextChanged);
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимостьTextBox.Location = new System.Drawing.Point(138, 335);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(230, 30);
            this.стоимостьTextBox.TabIndex = 4;
            this.стоимостьTextBox.TextChanged += new System.EventHandler(this.стоимостьTextBox_TextChanged);
            this.стоимостьTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.стоимостьTextBox_KeyPress);
            // 
            // фото_продуктаPictureBox
            // 
            this.фото_продуктаPictureBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.фото_продуктаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.продуктыBindingSource, "Фото_продукта", true));
            this.фото_продуктаPictureBox.Location = new System.Drawing.Point(12, 85);
            this.фото_продуктаPictureBox.Name = "фото_продуктаPictureBox";
            this.фото_продуктаPictureBox.Size = new System.Drawing.Size(356, 191);
            this.фото_продуктаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.фото_продуктаPictureBox.TabIndex = 6;
            this.фото_продуктаPictureBox.TabStop = false;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveImage.Location = new System.Drawing.Point(334, 243);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(34, 33);
            this.buttonRemoveImage.TabIndex = 7;
            this.buttonRemoveImage.Text = "X";
            this.HintRemove.SetToolTip(this.buttonRemoveImage, "Удалить картинку");
            this.buttonRemoveImage.UseVisualStyleBackColor = true;
            this.buttonRemoveImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddImage.Location = new System.Drawing.Point(300, 243);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(34, 33);
            this.buttonAddImage.TabIndex = 8;
            this.buttonAddImage.Text = "+";
            this.HintAdd.SetToolTip(this.buttonAddImage, "Добавить/изменить картинку");
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // comboBoxПродукты
            // 
            this.comboBoxПродукты.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxПродукты.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxПродукты.DataSource = this.продуктыBindingSource1;
            this.comboBoxПродукты.DisplayMember = "Продукт";
            this.comboBoxПродукты.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxПродукты.FormattingEnabled = true;
            this.comboBoxПродукты.Location = new System.Drawing.Point(11, 41);
            this.comboBoxПродукты.Name = "comboBoxПродукты";
            this.comboBoxПродукты.Size = new System.Drawing.Size(357, 33);
            this.comboBoxПродукты.TabIndex = 9;
            this.comboBoxПродукты.SelectedIndexChanged += new System.EventHandler(this.продуктComboBox_SelectedIndexChanged);
            this.comboBoxПродукты.SelectedValueChanged += new System.EventHandler(this.comboBoxПродукты_SelectedValueChanged);
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.restaurantDataSet;
            this.продуктыBindingSource1.PositionChanged += new System.EventHandler(this.продуктыBindingSource1_PositionChanged);
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataMember = "ПродуктыИнгредиенты";
            this.ингредиентыBindingSource.DataSource = this.продуктыBindingSource;
            this.ингредиентыBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.ингредиентыBindingSource_BindingComplete);
            this.ингредиентыBindingSource.CurrentChanged += new System.EventHandler(this.ингредиентыBindingSource_CurrentChanged);
            this.ингредиентыBindingSource.CurrentItemChanged += new System.EventHandler(this.ингредиентыBindingSource_CurrentItemChanged);
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 373);
            this.Controls.Add(this.comboBoxПродукты);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(продуктLabel);
            this.Controls.Add(this.продуктTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.фото_продуктаPictureBox);
            this.Controls.Add(this.продуктыBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Продукты (НЕ СОХРАНЕНО!)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Products_FormClosing);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingNavigator)).EndInit();
            this.продуктыBindingNavigator.ResumeLayout(false);
            this.продуктыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фото_продуктаPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private RestaurantDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator продуктыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton продуктыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox продуктTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.PictureBox фото_продуктаPictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.ToolTip HintRemove;
        private System.Windows.Forms.ComboBox comboBoxПродукты;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private System.Windows.Forms.ToolTip HintAdd;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private RestaurantDataSetTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
    }
}