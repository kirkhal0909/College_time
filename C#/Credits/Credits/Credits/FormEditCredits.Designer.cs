namespace Credits
{
    partial class FormEditCredits
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
            System.Windows.Forms.Label максимальная_суммаLabel;
            System.Windows.Forms.Label минимальный_срокLabel;
            System.Windows.Forms.Label процентная_ставкаLabel;
            System.Windows.Forms.Label максимальный_срокLabel;
            System.Windows.Forms.Label название_кредитаLabel;
            System.Windows.Forms.Label минимальная_суммаLabel;
            System.Windows.Forms.Label валютаLabel;
            System.Windows.Forms.Label единовременная_комиссияLabel;
            System.Windows.Forms.Label ежемесячная_комиссияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCredits));
            this.кредитыDataSet = new Credits.КредитыDataSet();
            this.кредитыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кредитыTableAdapter = new Credits.КредитыDataSetTableAdapters.КредитыTableAdapter();
            this.tableAdapterManager = new Credits.КредитыDataSetTableAdapters.TableAdapterManager();
            this.валютыTableAdapter = new Credits.КредитыDataSetTableAdapters.ВалютыTableAdapter();
            this.кредитыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.кредитыDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGrid_название_кредита = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ежемесячная_комиссияTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.единовременная_комиссияTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.изображениеPictureBox = new System.Windows.Forms.PictureBox();
            this.валютыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кредитыDataSet1 = new Credits.КредитыDataSet();
            this.валютаComboBox = new System.Windows.Forms.ComboBox();
            this.валютыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditCurrency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelСрок = new System.Windows.Forms.Label();
            this.максимальный_срокTextBox = new System.Windows.Forms.TextBox();
            this.название_кредитаTextBox = new System.Windows.Forms.TextBox();
            this.минимальный_срокTextBox = new System.Windows.Forms.TextBox();
            this.процентная_ставкаTextBox = new System.Windows.Forms.TextBox();
            this.максимальная_суммаTextBox = new System.Windows.Forms.TextBox();
            this.минимальная_суммаTextBox = new System.Windows.Forms.TextBox();
            this.кредитыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditCredit = new System.Windows.Forms.Button();
            максимальная_суммаLabel = new System.Windows.Forms.Label();
            минимальный_срокLabel = new System.Windows.Forms.Label();
            процентная_ставкаLabel = new System.Windows.Forms.Label();
            максимальный_срокLabel = new System.Windows.Forms.Label();
            название_кредитаLabel = new System.Windows.Forms.Label();
            минимальная_суммаLabel = new System.Windows.Forms.Label();
            валютаLabel = new System.Windows.Forms.Label();
            единовременная_комиссияLabel = new System.Windows.Forms.Label();
            ежемесячная_комиссияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingNavigator)).BeginInit();
            this.кредитыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataGridView)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // максимальная_суммаLabel
            // 
            максимальная_суммаLabel.AutoSize = true;
            максимальная_суммаLabel.Location = new System.Drawing.Point(13, 155);
            максимальная_суммаLabel.Name = "максимальная_суммаLabel";
            максимальная_суммаLabel.Size = new System.Drawing.Size(153, 17);
            максимальная_суммаLabel.TabIndex = 8;
            максимальная_суммаLabel.Text = "Максимальная сумма:";
            // 
            // минимальный_срокLabel
            // 
            минимальный_срокLabel.AutoSize = true;
            минимальный_срокLabel.Location = new System.Drawing.Point(13, 76);
            минимальный_срокLabel.Name = "минимальный_срокLabel";
            минимальный_срокLabel.Size = new System.Drawing.Size(139, 17);
            минимальный_срокLabel.TabIndex = 10;
            минимальный_срокLabel.Text = "Минимальный срок:";
            // 
            // процентная_ставкаLabel
            // 
            процентная_ставкаLabel.AutoSize = true;
            процентная_ставкаLabel.Location = new System.Drawing.Point(13, 49);
            процентная_ставкаLabel.Name = "процентная_ставкаLabel";
            процентная_ставкаLabel.Size = new System.Drawing.Size(141, 17);
            процентная_ставкаLabel.TabIndex = 4;
            процентная_ставкаLabel.Text = "Процентная ставка:";
            // 
            // максимальный_срокLabel
            // 
            максимальный_срокLabel.AutoSize = true;
            максимальный_срокLabel.Location = new System.Drawing.Point(13, 103);
            максимальный_срокLabel.Name = "максимальный_срокLabel";
            максимальный_срокLabel.Size = new System.Drawing.Size(145, 17);
            максимальный_срокLabel.TabIndex = 12;
            максимальный_срокLabel.Text = "Максимальный срок:";
            // 
            // название_кредитаLabel
            // 
            название_кредитаLabel.AutoSize = true;
            название_кредитаLabel.Location = new System.Drawing.Point(13, 22);
            название_кредитаLabel.Name = "название_кредитаLabel";
            название_кредитаLabel.Size = new System.Drawing.Size(134, 17);
            название_кредитаLabel.TabIndex = 2;
            название_кредитаLabel.Text = "Название кредита:";
            название_кредитаLabel.Click += new System.EventHandler(this.название_кредитаLabel_Click);
            // 
            // минимальная_суммаLabel
            // 
            минимальная_суммаLabel.AutoSize = true;
            минимальная_суммаLabel.Location = new System.Drawing.Point(13, 129);
            минимальная_суммаLabel.Name = "минимальная_суммаLabel";
            минимальная_суммаLabel.Size = new System.Drawing.Size(147, 17);
            минимальная_суммаLabel.TabIndex = 6;
            минимальная_суммаLabel.Text = "Минимальная сумма:";
            // 
            // валютаLabel
            // 
            валютаLabel.AutoSize = true;
            валютаLabel.Location = new System.Drawing.Point(13, 233);
            валютаLabel.Name = "валютаLabel";
            валютаLabel.Size = new System.Drawing.Size(62, 17);
            валютаLabel.TabIndex = 18;
            валютаLabel.Text = "Валюта:";
            // 
            // единовременная_комиссияLabel
            // 
            единовременная_комиссияLabel.AutoSize = true;
            единовременная_комиссияLabel.Location = new System.Drawing.Point(13, 181);
            единовременная_комиссияLabel.Name = "единовременная_комиссияLabel";
            единовременная_комиссияLabel.Size = new System.Drawing.Size(133, 17);
            единовременная_комиссияLabel.TabIndex = 21;
            единовременная_комиссияLabel.Text = "Разовая комиссия:";
            // 
            // ежемесячная_комиссияLabel
            // 
            ежемесячная_комиссияLabel.AutoSize = true;
            ежемесячная_комиссияLabel.Location = new System.Drawing.Point(13, 207);
            ежемесячная_комиссияLabel.Name = "ежемесячная_комиссияLabel";
            ежемесячная_комиссияLabel.Size = new System.Drawing.Size(168, 17);
            ежемесячная_комиссияLabel.TabIndex = 23;
            ежемесячная_комиссияLabel.Text = "Ежемесячная комиссия:";
            // 
            // кредитыDataSet
            // 
            this.кредитыDataSet.DataSetName = "КредитыDataSet";
            this.кредитыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кредитыBindingSource
            // 
            this.кредитыBindingSource.DataMember = "Кредиты";
            this.кредитыBindingSource.DataSource = this.кредитыDataSet;
            // 
            // кредитыTableAdapter
            // 
            this.кредитыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Credits.КредитыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютыTableAdapter = this.валютыTableAdapter;
            this.tableAdapterManager.КредитыTableAdapter = this.кредитыTableAdapter;
            // 
            // валютыTableAdapter
            // 
            this.валютыTableAdapter.ClearBeforeFill = true;
            // 
            // кредитыBindingNavigator
            // 
            this.кредитыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.кредитыBindingNavigator.BindingSource = this.кредитыBindingSource;
            this.кредитыBindingNavigator.CountItem = null;
            this.кредитыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.кредитыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.кредитыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.кредитыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.кредитыBindingNavigator.MoveFirstItem = null;
            this.кредитыBindingNavigator.MoveLastItem = null;
            this.кредитыBindingNavigator.MoveNextItem = null;
            this.кредитыBindingNavigator.MovePreviousItem = null;
            this.кредитыBindingNavigator.Name = "кредитыBindingNavigator";
            this.кредитыBindingNavigator.PositionItem = null;
            this.кредитыBindingNavigator.Size = new System.Drawing.Size(688, 27);
            this.кредитыBindingNavigator.TabIndex = 0;
            this.кредитыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить новый кредит";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить выбранный кредит";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // кредитыDataGridView
            // 
            this.кредитыDataGridView.AllowUserToAddRows = false;
            this.кредитыDataGridView.AutoGenerateColumns = false;
            this.кредитыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.кредитыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGrid_название_кредита});
            this.кредитыDataGridView.DataSource = this.кредитыBindingSource;
            this.кредитыDataGridView.Location = new System.Drawing.Point(2, 26);
            this.кредитыDataGridView.Name = "кредитыDataGridView";
            this.кредитыDataGridView.ReadOnly = true;
            this.кредитыDataGridView.RowTemplate.Height = 24;
            this.кредитыDataGridView.Size = new System.Drawing.Size(300, 299);
            this.кредитыDataGridView.TabIndex = 1;
            this.кредитыDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.кредитыDataGridView_KeyPress);
            // 
            // DataGrid_название_кредита
            // 
            this.DataGrid_название_кредита.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid_название_кредита.DataPropertyName = "Название_кредита";
            this.DataGrid_название_кредита.HeaderText = "Название кредита";
            this.DataGrid_название_кредита.Name = "DataGrid_название_кредита";
            this.DataGrid_название_кредита.ReadOnly = true;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(ежемесячная_комиссияLabel);
            this.panelEdit.Controls.Add(this.ежемесячная_комиссияTextBox);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(единовременная_комиссияLabel);
            this.panelEdit.Controls.Add(this.единовременная_комиссияTextBox);
            this.panelEdit.Controls.Add(this.buttonSave);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.изображениеPictureBox);
            this.panelEdit.Controls.Add(валютаLabel);
            this.panelEdit.Controls.Add(this.валютаComboBox);
            this.panelEdit.Controls.Add(this.buttonEditCurrency);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.labelСрок);
            this.panelEdit.Controls.Add(минимальная_суммаLabel);
            this.panelEdit.Controls.Add(название_кредитаLabel);
            this.panelEdit.Controls.Add(this.максимальный_срокTextBox);
            this.panelEdit.Controls.Add(this.название_кредитаTextBox);
            this.panelEdit.Controls.Add(максимальный_срокLabel);
            this.panelEdit.Controls.Add(процентная_ставкаLabel);
            this.panelEdit.Controls.Add(this.минимальный_срокTextBox);
            this.panelEdit.Controls.Add(this.процентная_ставкаTextBox);
            this.panelEdit.Controls.Add(минимальный_срокLabel);
            this.panelEdit.Controls.Add(this.максимальная_суммаTextBox);
            this.panelEdit.Controls.Add(this.минимальная_суммаTextBox);
            this.panelEdit.Controls.Add(максимальная_суммаLabel);
            this.panelEdit.Enabled = false;
            this.panelEdit.Location = new System.Drawing.Point(306, 26);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(387, 299);
            this.panelEdit.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "%";
            // 
            // ежемесячная_комиссияTextBox
            // 
            this.ежемесячная_комиссияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Ежемесячная_комиссия", true));
            this.ежемесячная_комиссияTextBox.Location = new System.Drawing.Point(192, 204);
            this.ежемесячная_комиссияTextBox.Name = "ежемесячная_комиссияTextBox";
            this.ежемесячная_комиссияTextBox.Size = new System.Drawing.Size(147, 22);
            this.ежемесячная_комиссияTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "%";
            // 
            // единовременная_комиссияTextBox
            // 
            this.единовременная_комиссияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Единовременная_комиссия", true));
            this.единовременная_комиссияTextBox.Location = new System.Drawing.Point(193, 178);
            this.единовременная_комиссияTextBox.Name = "единовременная_комиссияTextBox";
            this.единовременная_комиссияTextBox.Size = new System.Drawing.Size(146, 22);
            this.единовременная_комиссияTextBox.TabIndex = 22;
            this.единовременная_комиссияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.процентная_ставкаTextBox_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(168, 258);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(171, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "%";
            // 
            // изображениеPictureBox
            // 
            this.изображениеPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.валютыBindingSource1, "Изображение", true));
            this.изображениеPictureBox.Location = new System.Drawing.Point(150, 234);
            this.изображениеPictureBox.Name = "изображениеPictureBox";
            this.изображениеPictureBox.Size = new System.Drawing.Size(32, 14);
            this.изображениеPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.изображениеPictureBox.TabIndex = 20;
            this.изображениеPictureBox.TabStop = false;
            // 
            // валютыBindingSource1
            // 
            this.валютыBindingSource1.DataMember = "Валюты";
            this.валютыBindingSource1.DataSource = this.кредитыDataSet1;
            // 
            // кредитыDataSet1
            // 
            this.кредитыDataSet1.DataSetName = "КредитыDataSet";
            this.кредитыDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // валютаComboBox
            // 
            this.валютаComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.валютаComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.валютаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютыBindingSource, "Валюта", true));
            this.валютаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.кредитыBindingSource, "ИД_валюты", true));
            this.валютаComboBox.DataSource = this.валютыBindingSource1;
            this.валютаComboBox.DisplayMember = "Валюта";
            this.валютаComboBox.FormattingEnabled = true;
            this.валютаComboBox.Location = new System.Drawing.Point(193, 232);
            this.валютаComboBox.Name = "валютаComboBox";
            this.валютаComboBox.Size = new System.Drawing.Size(146, 24);
            this.валютаComboBox.TabIndex = 7;
            this.валютаComboBox.ValueMember = "ИД_валюты";
            // 
            // валютыBindingSource
            // 
            this.валютыBindingSource.DataMember = "Валюты";
            this.валютыBindingSource.DataSource = this.кредитыDataSet;
            // 
            // buttonEditCurrency
            // 
            this.buttonEditCurrency.Location = new System.Drawing.Point(16, 258);
            this.buttonEditCurrency.Name = "buttonEditCurrency";
            this.buttonEditCurrency.Size = new System.Drawing.Size(125, 23);
            this.buttonEditCurrency.TabIndex = 9;
            this.buttonEditCurrency.Text = "Редактор валют";
            this.buttonEditCurrency.UseVisualStyleBackColor = true;
            this.buttonEditCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "мес.";
            // 
            // labelСрок
            // 
            this.labelСрок.AutoSize = true;
            this.labelСрок.Location = new System.Drawing.Point(347, 103);
            this.labelСрок.Name = "labelСрок";
            this.labelСрок.Size = new System.Drawing.Size(36, 17);
            this.labelСрок.TabIndex = 14;
            this.labelСрок.Text = "мес.";
            // 
            // максимальный_срокTextBox
            // 
            this.максимальный_срокTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Максимальный срок", true));
            this.максимальный_срокTextBox.Location = new System.Drawing.Point(193, 100);
            this.максимальный_срокTextBox.Name = "максимальный_срокTextBox";
            this.максимальный_срокTextBox.Size = new System.Drawing.Size(146, 22);
            this.максимальный_срокTextBox.TabIndex = 4;
            this.максимальный_срокTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.минимальная_суммаTextBox_KeyPress);
            // 
            // название_кредитаTextBox
            // 
            this.название_кредитаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Название_кредита", true));
            this.название_кредитаTextBox.Location = new System.Drawing.Point(193, 19);
            this.название_кредитаTextBox.Name = "название_кредитаTextBox";
            this.название_кредитаTextBox.Size = new System.Drawing.Size(146, 22);
            this.название_кредитаTextBox.TabIndex = 1;
            // 
            // минимальный_срокTextBox
            // 
            this.минимальный_срокTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Минимальный срок", true));
            this.минимальный_срокTextBox.Location = new System.Drawing.Point(193, 73);
            this.минимальный_срокTextBox.Name = "минимальный_срокTextBox";
            this.минимальный_срокTextBox.Size = new System.Drawing.Size(146, 22);
            this.минимальный_срокTextBox.TabIndex = 3;
            this.минимальный_срокTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.минимальная_суммаTextBox_KeyPress);
            // 
            // процентная_ставкаTextBox
            // 
            this.процентная_ставкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Процентная_ставка", true));
            this.процентная_ставкаTextBox.Location = new System.Drawing.Point(193, 46);
            this.процентная_ставкаTextBox.Name = "процентная_ставкаTextBox";
            this.процентная_ставкаTextBox.Size = new System.Drawing.Size(146, 22);
            this.процентная_ставкаTextBox.TabIndex = 2;
            this.процентная_ставкаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.процентная_ставкаTextBox_KeyPress);
            // 
            // максимальная_суммаTextBox
            // 
            this.максимальная_суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Максимальная_сумма", true));
            this.максимальная_суммаTextBox.Location = new System.Drawing.Point(193, 152);
            this.максимальная_суммаTextBox.Name = "максимальная_суммаTextBox";
            this.максимальная_суммаTextBox.Size = new System.Drawing.Size(146, 22);
            this.максимальная_суммаTextBox.TabIndex = 6;
            this.максимальная_суммаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.минимальная_суммаTextBox_KeyPress);
            // 
            // минимальная_суммаTextBox
            // 
            this.минимальная_суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кредитыBindingSource, "Минимальная_сумма", true));
            this.минимальная_суммаTextBox.Location = new System.Drawing.Point(193, 126);
            this.минимальная_суммаTextBox.Name = "минимальная_суммаTextBox";
            this.минимальная_суммаTextBox.Size = new System.Drawing.Size(146, 22);
            this.минимальная_суммаTextBox.TabIndex = 5;
            this.минимальная_суммаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.минимальная_суммаTextBox_KeyPress);
            // 
            // кредитыBindingSource1
            // 
            this.кредитыBindingSource1.DataMember = "Кредиты";
            this.кредитыBindingSource1.DataSource = this.кредитыDataSet1;
            // 
            // buttonEditCredit
            // 
            this.buttonEditCredit.Location = new System.Drawing.Point(26, 332);
            this.buttonEditCredit.Name = "buttonEditCredit";
            this.buttonEditCredit.Size = new System.Drawing.Size(257, 23);
            this.buttonEditCredit.TabIndex = 10;
            this.buttonEditCredit.Text = "Редактировать выбранный кредит";
            this.buttonEditCredit.UseVisualStyleBackColor = true;
            this.buttonEditCredit.Click += new System.EventHandler(this.buttonEditCredit_Click);
            // 
            // FormEditCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 361);
            this.Controls.Add(this.buttonEditCredit);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.кредитыDataGridView);
            this.Controls.Add(this.кредитыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditCredits_FormClosing);
            this.Load += new System.EventHandler(this.FormEditCredits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingNavigator)).EndInit();
            this.кредитыBindingNavigator.ResumeLayout(false);
            this.кредитыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataGridView)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КредитыDataSet кредитыDataSet;
        private System.Windows.Forms.BindingSource кредитыBindingSource;
        private КредитыDataSetTableAdapters.КредитыTableAdapter кредитыTableAdapter;
        private КредитыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator кредитыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridView кредитыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGrid_название_кредита;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelСрок;
        private System.Windows.Forms.TextBox максимальный_срокTextBox;
        private System.Windows.Forms.TextBox название_кредитаTextBox;
        private System.Windows.Forms.TextBox минимальный_срокTextBox;
        private System.Windows.Forms.TextBox процентная_ставкаTextBox;
        private System.Windows.Forms.TextBox максимальная_суммаTextBox;
        private System.Windows.Forms.TextBox минимальная_суммаTextBox;
        private КредитыDataSetTableAdapters.ВалютыTableAdapter валютыTableAdapter;
        private System.Windows.Forms.BindingSource валютыBindingSource;
        private System.Windows.Forms.Button buttonEditCurrency;
        private System.Windows.Forms.ComboBox валютаComboBox;
        private КредитыDataSet кредитыDataSet1;
        private System.Windows.Forms.BindingSource валютыBindingSource1;
        private System.Windows.Forms.BindingSource кредитыBindingSource1;
        private System.Windows.Forms.Button buttonEditCredit;
        private System.Windows.Forms.PictureBox изображениеPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox единовременная_комиссияTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ежемесячная_комиссияTextBox;
        private System.Windows.Forms.Label label4;
    }
}