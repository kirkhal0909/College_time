namespace РасходТоплива
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ПроцентНаТрассе = new System.Windows.Forms.Label();
            this.ПроцентВГороде = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.записиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расход_топливаDataSet = new РасходТоплива.Расход_топливаDataSet();
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
            this.записиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.записиTableAdapter = new РасходТоплива.Расход_топливаDataSetTableAdapters.ЗаписиTableAdapter();
            this.tableAdapterManager = new РасходТоплива.Расход_топливаDataSetTableAdapters.TableAdapterManager();
            this.записиDataGridView = new System.Windows.Forms.DataGridView();
            this.км_в_путиTextBox = new System.Windows.Forms.TextBox();
            this.руб_лTextBox = new System.Windows.Forms.TextBox();
            this.л_100км_на_трассеTextBox = new System.Windows.Forms.TextBox();
            this.л_100км_в_городеTextBox = new System.Windows.Forms.TextBox();
            this.путь_в_городеTextBox = new System.Windows.Forms.TextBox();
            this.путь_на_трассеTextBox = new System.Windows.Forms.TextBox();
            this.labelVsego = new System.Windows.Forms.Label();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Километров = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КилометровНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЗатратыВгороде = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЗатратыВгородеНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.затратыНаТрассе = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.затратыНаТрассеНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПутьВГородеНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПутьНаТрассеНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СтоимостьНаПоказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПутьВГороде = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПутьНаТрассе = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingNavigator)).BeginInit();
            this.записиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_топливаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Километров в пути";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(231, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(178, 26);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить рассчёт";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(399, 466);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(209, 17);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Всего расход 0 л. затраты 0 р.";
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(12, 463);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(157, 23);
            this.buttonRemoveAll.TabIndex = 15;
            this.buttonRemoveAll.Text = "Удалить все записи";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(169, 463);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(224, 23);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Удалить выбранную запись";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Расход топлива в городе";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Расход топлива на трассе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "л. / 100 км.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "л. / 100 км.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Стоимость топлива руб./л.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "руб.";
            // 
            // ПроцентНаТрассе
            // 
            this.ПроцентНаТрассе.AutoSize = true;
            this.ПроцентНаТрассе.Location = new System.Drawing.Point(669, 95);
            this.ПроцентНаТрассе.Name = "ПроцентНаТрассе";
            this.ПроцентНаТрассе.Size = new System.Drawing.Size(20, 17);
            this.ПроцентНаТрассе.TabIndex = 36;
            this.ПроцентНаТрассе.Text = "%";
            // 
            // ПроцентВГороде
            // 
            this.ПроцентВГороде.AutoSize = true;
            this.ПроцентВГороде.Location = new System.Drawing.Point(669, 44);
            this.ПроцентВГороде.Name = "ПроцентВГороде";
            this.ПроцентВГороде.Size = new System.Drawing.Size(20, 17);
            this.ПроцентВГороде.TabIndex = 35;
            this.ПроцентВГороде.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Путь на трассе";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Путь в городе";
            // 
            // записиBindingNavigator
            // 
            this.записиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.записиBindingNavigator.BindingSource = this.записиBindingSource;
            this.записиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.записиBindingNavigator.CountItemFormat = "запись из {0}";
            this.записиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.записиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.записиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.записиBindingNavigatorSaveItem});
            this.записиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.записиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.записиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.записиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.записиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.записиBindingNavigator.Name = "записиBindingNavigator";
            this.записиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.записиBindingNavigator.Size = new System.Drawing.Size(789, 27);
            this.записиBindingNavigator.TabIndex = 37;
            this.записиBindingNavigator.Text = "bindingNavigator1";
            this.записиBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // записиBindingSource
            // 
            this.записиBindingSource.DataMember = "Записи";
            this.записиBindingSource.DataSource = this.расход_топливаDataSet;
            this.записиBindingSource.CurrentChanged += new System.EventHandler(this.записиBindingSource_CurrentChanged);
            this.записиBindingSource.CurrentItemChanged += new System.EventHandler(this.записиBindingSource_CurrentItemChanged);
            // 
            // расход_топливаDataSet
            // 
            this.расход_топливаDataSet.DataSetName = "Расход_топливаDataSet";
            this.расход_топливаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(99, 24);
            this.bindingNavigatorCountItem.Text = "запись из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // записиBindingNavigatorSaveItem
            // 
            this.записиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.записиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("записиBindingNavigatorSaveItem.Image")));
            this.записиBindingNavigatorSaveItem.Name = "записиBindingNavigatorSaveItem";
            this.записиBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.записиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.записиBindingNavigatorSaveItem.Click += new System.EventHandler(this.записиBindingNavigatorSaveItem_Click_1);
            // 
            // записиTableAdapter
            // 
            this.записиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = РасходТоплива.Расход_топливаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаписиTableAdapter = this.записиTableAdapter;
            // 
            // записиDataGridView
            // 
            this.записиDataGridView.AllowUserToAddRows = false;
            this.записиDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.записиDataGridView.AutoGenerateColumns = false;
            this.записиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.записиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Дата,
            this.Километров,
            this.КилометровНаПоказ,
            this.ЗатратыВгороде,
            this.ЗатратыВгородеНаПоказ,
            this.затратыНаТрассе,
            this.затратыНаТрассеНаПоказ,
            this.ПутьВГородеНаПоказ,
            this.ПутьНаТрассеНаПоказ,
            this.СтоимостьНаПоказ,
            this.Цена,
            this.Стоимость,
            this.ПутьВГороде,
            this.ПутьНаТрассе});
            this.записиDataGridView.DataSource = this.записиBindingSource;
            this.записиDataGridView.Location = new System.Drawing.Point(12, 180);
            this.записиDataGridView.Name = "записиDataGridView";
            this.записиDataGridView.ReadOnly = true;
            this.записиDataGridView.RowTemplate.Height = 24;
            this.записиDataGridView.Size = new System.Drawing.Size(883, 277);
            this.записиDataGridView.TabIndex = 37;
            this.записиDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.записиDataGridView_CellValueChanged);
            this.записиDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.записиDataGridView_RowPostPaint);
            this.записиDataGridView.Sorted += new System.EventHandler(this.записиDataGridView_Sorted);
            // 
            // км_в_путиTextBox
            // 
            this.км_в_путиTextBox.Location = new System.Drawing.Point(9, 41);
            this.км_в_путиTextBox.Name = "км_в_путиTextBox";
            this.км_в_путиTextBox.Size = new System.Drawing.Size(141, 22);
            this.км_в_путиTextBox.TabIndex = 38;
            this.км_в_путиTextBox.Text = "500";
            this.км_в_путиTextBox.TextChanged += new System.EventHandler(this.км_в_путиTextBox_TextChanged);
            this.км_в_путиTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.км_в_путиTextBox_KeyPress);
            // 
            // руб_лTextBox
            // 
            this.руб_лTextBox.Location = new System.Drawing.Point(9, 92);
            this.руб_лTextBox.Name = "руб_лTextBox";
            this.руб_лTextBox.Size = new System.Drawing.Size(141, 22);
            this.руб_лTextBox.TabIndex = 39;
            this.руб_лTextBox.Text = "40";
            this.руб_лTextBox.TextChanged += new System.EventHandler(this.км_в_путиTextBox_TextChanged);
            this.руб_лTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.км_в_путиTextBox_KeyPress);
            // 
            // л_100км_на_трассеTextBox
            // 
            this.л_100км_на_трассеTextBox.Location = new System.Drawing.Point(231, 92);
            this.л_100км_на_трассеTextBox.Name = "л_100км_на_трассеTextBox";
            this.л_100км_на_трассеTextBox.Size = new System.Drawing.Size(141, 22);
            this.л_100км_на_трассеTextBox.TabIndex = 40;
            this.л_100км_на_трассеTextBox.Text = "7";
            this.л_100км_на_трассеTextBox.TextChanged += new System.EventHandler(this.км_в_путиTextBox_TextChanged);
            this.л_100км_на_трассеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.км_в_путиTextBox_KeyPress);
            // 
            // л_100км_в_городеTextBox
            // 
            this.л_100км_в_городеTextBox.Location = new System.Drawing.Point(231, 41);
            this.л_100км_в_городеTextBox.Name = "л_100км_в_городеTextBox";
            this.л_100км_в_городеTextBox.Size = new System.Drawing.Size(141, 22);
            this.л_100км_в_городеTextBox.TabIndex = 41;
            this.л_100км_в_городеTextBox.Text = "11";
            this.л_100км_в_городеTextBox.TextChanged += new System.EventHandler(this.км_в_путиTextBox_TextChanged);
            this.л_100км_в_городеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.км_в_путиTextBox_KeyPress);
            // 
            // путь_в_городеTextBox
            // 
            this.путь_в_городеTextBox.Location = new System.Drawing.Point(504, 41);
            this.путь_в_городеTextBox.Name = "путь_в_городеTextBox";
            this.путь_в_городеTextBox.Size = new System.Drawing.Size(125, 22);
            this.путь_в_городеTextBox.TabIndex = 42;
            this.путь_в_городеTextBox.Text = "50";
            this.путь_в_городеTextBox.TextChanged += new System.EventHandler(this.путь_в_городеTextBox_TextChanged);
            this.путь_в_городеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.путь_в_городеTextBox_KeyPress);
            // 
            // путь_на_трассеTextBox
            // 
            this.путь_на_трассеTextBox.Location = new System.Drawing.Point(504, 92);
            this.путь_на_трассеTextBox.Name = "путь_на_трассеTextBox";
            this.путь_на_трассеTextBox.Size = new System.Drawing.Size(125, 22);
            this.путь_на_трассеTextBox.TabIndex = 43;
            this.путь_на_трассеTextBox.Text = "50";
            this.путь_на_трассеTextBox.TextChanged += new System.EventHandler(this.путь_на_трассеTextBox_TextChanged);
            this.путь_на_трассеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.путь_в_городеTextBox_KeyPress);
            // 
            // labelVsego
            // 
            this.labelVsego.AutoSize = true;
            this.labelVsego.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelVsego.Location = new System.Drawing.Point(441, 137);
            this.labelVsego.Name = "labelVsego";
            this.labelVsego.Size = new System.Drawing.Size(245, 17);
            this.labelVsego.TabIndex = 44;
            this.labelVsego.Text = "Рассчёт: расход 0 л. затраты 0 руб.";
            // 
            // Дата
            // 
            this.Дата.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Дата.DataPropertyName = "Дата";
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            this.Дата.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Дата.Width = 48;
            // 
            // Километров
            // 
            this.Километров.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Километров.DataPropertyName = "Км в пути";
            this.Километров.HeaderText = "Км в пути";
            this.Километров.Name = "Километров";
            this.Километров.ReadOnly = true;
            this.Километров.Visible = false;
            // 
            // КилометровНаПоказ
            // 
            this.КилометровНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.КилометровНаПоказ.HeaderText = "Километров в пути";
            this.КилометровНаПоказ.Name = "КилометровНаПоказ";
            this.КилометровНаПоказ.ReadOnly = true;
            this.КилометровНаПоказ.Width = 121;
            // 
            // ЗатратыВгороде
            // 
            this.ЗатратыВгороде.DataPropertyName = "л/100км в городе";
            this.ЗатратыВгороде.HeaderText = "л/100км в городе";
            this.ЗатратыВгороде.Name = "ЗатратыВгороде";
            this.ЗатратыВгороде.ReadOnly = true;
            this.ЗатратыВгороде.Visible = false;
            // 
            // ЗатратыВгородеНаПоказ
            // 
            this.ЗатратыВгородеНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ЗатратыВгородеНаПоказ.HeaderText = "л/100км в городе";
            this.ЗатратыВгородеНаПоказ.Name = "ЗатратыВгородеНаПоказ";
            this.ЗатратыВгородеНаПоказ.ReadOnly = true;
            this.ЗатратыВгородеНаПоказ.Width = 96;
            // 
            // затратыНаТрассе
            // 
            this.затратыНаТрассе.DataPropertyName = "л/100км на трассе";
            this.затратыНаТрассе.HeaderText = "л/100км на трассе";
            this.затратыНаТрассе.Name = "затратыНаТрассе";
            this.затратыНаТрассе.ReadOnly = true;
            this.затратыНаТрассе.Visible = false;
            // 
            // затратыНаТрассеНаПоказ
            // 
            this.затратыНаТрассеНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.затратыНаТрассеНаПоказ.HeaderText = "л/100км на трассе";
            this.затратыНаТрассеНаПоказ.Name = "затратыНаТрассеНаПоказ";
            this.затратыНаТрассеНаПоказ.ReadOnly = true;
            this.затратыНаТрассеНаПоказ.Width = 104;
            // 
            // ПутьВГородеНаПоказ
            // 
            this.ПутьВГородеНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ПутьВГородеНаПоказ.HeaderText = "Путь в городе";
            this.ПутьВГородеНаПоказ.Name = "ПутьВГородеНаПоказ";
            this.ПутьВГородеНаПоказ.ReadOnly = true;
            this.ПутьВГородеНаПоказ.Width = 118;
            // 
            // ПутьНаТрассеНаПоказ
            // 
            this.ПутьНаТрассеНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ПутьНаТрассеНаПоказ.HeaderText = "Путь на трассе";
            this.ПутьНаТрассеНаПоказ.Name = "ПутьНаТрассеНаПоказ";
            this.ПутьНаТрассеНаПоказ.ReadOnly = true;
            this.ПутьНаТрассеНаПоказ.Width = 126;
            // 
            // СтоимостьНаПоказ
            // 
            this.СтоимостьНаПоказ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.СтоимостьНаПоказ.HeaderText = "Стоимость";
            this.СтоимостьНаПоказ.Name = "СтоимостьНаПоказ";
            this.СтоимостьНаПоказ.ReadOnly = true;
            this.СтоимостьНаПоказ.Width = 107;
            // 
            // Цена
            // 
            this.Цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            // 
            // Стоимость
            // 
            this.Стоимость.DataPropertyName = "Руб/л";
            this.Стоимость.HeaderText = "Руб/л";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Visible = false;
            // 
            // ПутьВГороде
            // 
            this.ПутьВГороде.DataPropertyName = "Путь в городе";
            this.ПутьВГороде.HeaderText = "Путь в городе";
            this.ПутьВГороде.Name = "ПутьВГороде";
            this.ПутьВГороде.ReadOnly = true;
            this.ПутьВГороде.Visible = false;
            // 
            // ПутьНаТрассе
            // 
            this.ПутьНаТрассе.DataPropertyName = "Путь на трассе";
            this.ПутьНаТрассе.HeaderText = "Путь на трассе";
            this.ПутьНаТрассе.Name = "ПутьНаТрассе";
            this.ПутьНаТрассе.ReadOnly = true;
            this.ПутьНаТрассе.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 492);
            this.Controls.Add(this.labelVsego);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.путь_на_трассеTextBox);
            this.Controls.Add(this.путь_в_городеTextBox);
            this.Controls.Add(this.л_100км_в_городеTextBox);
            this.Controls.Add(this.л_100км_на_трассеTextBox);
            this.Controls.Add(this.руб_лTextBox);
            this.Controls.Add(this.км_в_путиTextBox);
            this.Controls.Add(this.записиDataGridView);
            this.Controls.Add(this.записиBindingNavigator);
            this.Controls.Add(this.ПроцентНаТрассе);
            this.Controls.Add(this.ПроцентВГороде);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Расход топлива";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingNavigator)).EndInit();
            this.записиBindingNavigator.ResumeLayout(false);
            this.записиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_топливаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ПроцентНаТрассе;
        private System.Windows.Forms.Label ПроцентВГороде;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Расход_топливаDataSet расход_топливаDataSet;
        private System.Windows.Forms.BindingSource записиBindingSource;
        private Расход_топливаDataSetTableAdapters.ЗаписиTableAdapter записиTableAdapter;
        private Расход_топливаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator записиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton записиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView записиDataGridView;
        private System.Windows.Forms.TextBox км_в_путиTextBox;
        private System.Windows.Forms.TextBox руб_лTextBox;
        private System.Windows.Forms.TextBox л_100км_на_трассеTextBox;
        private System.Windows.Forms.TextBox л_100км_в_городеTextBox;
        private System.Windows.Forms.TextBox путь_в_городеTextBox;
        private System.Windows.Forms.TextBox путь_на_трассеTextBox;
        private System.Windows.Forms.Label labelVsego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Километров;
        private System.Windows.Forms.DataGridViewTextBoxColumn КилометровНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЗатратыВгороде;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЗатратыВгородеНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn затратыНаТрассе;
        private System.Windows.Forms.DataGridViewTextBoxColumn затратыНаТрассеНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПутьВГородеНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПутьНаТрассеНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СтоимостьНаПоказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПутьВГороде;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПутьНаТрассе;
    }
}

