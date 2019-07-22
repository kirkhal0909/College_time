namespace OPTdbf
{
    partial class FormProducts
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
            System.Windows.Forms.Label иД_товараLabel;
            System.Windows.Forms.Label товарLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label изображение_товараLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.oPTDataSet = new OPTdbf.OPTDataSet();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new OPTdbf.OPTDataSetTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new OPTdbf.OPTDataSetTableAdapters.TableAdapterManager();
            this.складBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.иД_товараTextBox = new System.Windows.Forms.TextBox();
            this.товарTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.изображение_товараPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxText = new System.Windows.Forms.ComboBox();
            this.складBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFindByText = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindByID = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            иД_товараLabel = new System.Windows.Forms.Label();
            товарLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            изображение_товараLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).BeginInit();
            this.складBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображение_товараPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // иД_товараLabel
            // 
            иД_товараLabel.AutoSize = true;
            иД_товараLabel.Location = new System.Drawing.Point(50, 132);
            иД_товараLabel.Name = "иД_товараLabel";
            иД_товараLabel.Size = new System.Drawing.Size(83, 17);
            иД_товараLabel.TabIndex = 1;
            иД_товараLabel.Text = "ИД товара:";
            // 
            // товарLabel
            // 
            товарLabel.AutoSize = true;
            товарLabel.Location = new System.Drawing.Point(50, 160);
            товарLabel.Name = "товарLabel";
            товарLabel.Size = new System.Drawing.Size(52, 17);
            товарLabel.TabIndex = 3;
            товарLabel.Text = "Товар:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(50, 188);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(90, 17);
            количествоLabel.TabIndex = 5;
            количествоLabel.Text = "Количество:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(50, 216);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(82, 17);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // изображение_товараLabel
            // 
            изображение_товараLabel.AutoSize = true;
            изображение_товараLabel.Location = new System.Drawing.Point(50, 241);
            изображение_товараLabel.Name = "изображение_товараLabel";
            изображение_товараLabel.Size = new System.Drawing.Size(152, 17);
            изображение_товараLabel.TabIndex = 9;
            изображение_товараLabel.Text = "Изображение товара:";
            // 
            // oPTDataSet
            // 
            this.oPTDataSet.DataSetName = "OPTDataSet";
            this.oPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = OPTdbf.OPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.Элементы_заказовTableAdapter = null;
            // 
            // складBindingNavigator
            // 
            this.складBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.складBindingNavigator.BindingSource = this.складBindingSource;
            this.складBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.складBindingNavigator.CountItemFormat = "из {0}";
            this.складBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.складBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.складBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.складBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.складBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.складBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.складBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.складBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.складBindingNavigator.Name = "складBindingNavigator";
            this.складBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.складBindingNavigator.Size = new System.Drawing.Size(409, 27);
            this.складBindingNavigator.TabIndex = 0;
            this.складBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить товар";
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
            this.bindingNavigatorDeleteItem.Text = "Удалить товар";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Первый товар";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Предыдущий товар";
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
            this.bindingNavigatorMoveNextItem.Text = "Следующий товар";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Последний товар";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // иД_товараTextBox
            // 
            this.иД_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "ИД_товара", true));
            this.иД_товараTextBox.Location = new System.Drawing.Point(208, 129);
            this.иД_товараTextBox.Name = "иД_товараTextBox";
            this.иД_товараTextBox.ReadOnly = true;
            this.иД_товараTextBox.Size = new System.Drawing.Size(150, 22);
            this.иД_товараTextBox.TabIndex = 2;
            // 
            // товарTextBox
            // 
            this.товарTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Товар", true));
            this.товарTextBox.Location = new System.Drawing.Point(208, 157);
            this.товарTextBox.Name = "товарTextBox";
            this.товарTextBox.Size = new System.Drawing.Size(150, 22);
            this.товарTextBox.TabIndex = 4;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(208, 185);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(150, 22);
            this.количествоTextBox.TabIndex = 6;
            this.количествоTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.количествоTextBox_KeyPress);
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(208, 213);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(150, 22);
            this.стоимостьTextBox.TabIndex = 8;
            this.стоимостьTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.стоимостьTextBox_KeyPress);
            // 
            // изображение_товараPictureBox
            // 
            this.изображение_товараPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.изображение_товараPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.складBindingSource, "Изображение_товара", true));
            this.изображение_товараPictureBox.Location = new System.Drawing.Point(208, 241);
            this.изображение_товараPictureBox.Name = "изображение_товараPictureBox";
            this.изображение_товараPictureBox.Size = new System.Drawing.Size(150, 100);
            this.изображение_товараPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.изображение_товараPictureBox.TabIndex = 10;
            this.изображение_товараPictureBox.TabStop = false;
            // 
            // comboBoxText
            // 
            this.comboBoxText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxText.DataSource = this.складBindingSource1;
            this.comboBoxText.DisplayMember = "Товар";
            this.comboBoxText.FormattingEnabled = true;
            this.comboBoxText.Location = new System.Drawing.Point(3, 24);
            this.comboBoxText.Name = "comboBoxText";
            this.comboBoxText.Size = new System.Drawing.Size(222, 24);
            this.comboBoxText.TabIndex = 11;
            this.comboBoxText.ValueMember = "ИД_товара";
            // 
            // складBindingSource1
            // 
            this.складBindingSource1.DataMember = "Склад";
            this.складBindingSource1.DataSource = this.oPTDataSet;
            // 
            // buttonFindByText
            // 
            this.buttonFindByText.Location = new System.Drawing.Point(77, 54);
            this.buttonFindByText.Name = "buttonFindByText";
            this.buttonFindByText.Size = new System.Drawing.Size(75, 23);
            this.buttonFindByText.TabIndex = 12;
            this.buttonFindByText.Text = "Найти";
            this.buttonFindByText.UseVisualStyleBackColor = true;
            this.buttonFindByText.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxText);
            this.panel1.Controls.Add(this.buttonFindByText);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 88);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск товара по названию:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonFindByID);
            this.panel2.Location = new System.Drawing.Point(248, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 88);
            this.panel2.TabIndex = 14;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(2, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(145, 22);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поиск товара по ИД:";
            // 
            // buttonFindByID
            // 
            this.buttonFindByID.Location = new System.Drawing.Point(39, 54);
            this.buttonFindByID.Name = "buttonFindByID";
            this.buttonFindByID.Size = new System.Drawing.Size(75, 23);
            this.buttonFindByID.TabIndex = 12;
            this.buttonFindByID.Text = "Найти";
            this.buttonFindByID.UseVisualStyleBackColor = true;
            this.buttonFindByID.Click += new System.EventHandler(this.buttonFindByID_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(53, 261);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(149, 23);
            this.buttonLoadImage.TabIndex = 15;
            this.buttonLoadImage.Text = "Загрузить картинку";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(53, 307);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(149, 23);
            this.buttonDeleteImage.TabIndex = 16;
            this.buttonDeleteImage.Text = "Удалить картинку";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 356);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(иД_товараLabel);
            this.Controls.Add(this.иД_товараTextBox);
            this.Controls.Add(товарLabel);
            this.Controls.Add(this.товарTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(изображение_товараLabel);
            this.Controls.Add(this.изображение_товараPictureBox);
            this.Controls.Add(this.складBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор продуктов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProducts_FormClosing);
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).EndInit();
            this.складBindingNavigator.ResumeLayout(false);
            this.складBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображение_товараPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OPTDataSet oPTDataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private OPTDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private OPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator складBindingNavigator;
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
        private System.Windows.Forms.TextBox иД_товараTextBox;
        private System.Windows.Forms.TextBox товарTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.PictureBox изображение_товараPictureBox;
        private System.Windows.Forms.ComboBox comboBoxText;
        private System.Windows.Forms.BindingSource складBindingSource1;
        private System.Windows.Forms.Button buttonFindByText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindByID;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonDeleteImage;
    }
}