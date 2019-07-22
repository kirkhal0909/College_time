namespace College_items
{
    partial class Form_Add_Item
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
            System.Windows.Forms.Label кодТипОборLabel;
            System.Windows.Forms.Label кодАудитLabel;
            System.Windows.Forms.Label датаПриобрLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label списанLabel;
            System.Windows.Forms.Label примечаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Item));
            this.label1 = new System.Windows.Forms.Label();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.списанCheckBox = new System.Windows.Forms.CheckBox();
            this.примечаниеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAuditory = new System.Windows.Forms.ComboBox();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudovanieDataSet = new College_items.OborudovanieDataSet();
            this.оборудованиеTableAdapter = new College_items.OborudovanieDataSetTableAdapters.ОборудованиеTableAdapter();
            this.tableAdapterManager = new College_items.OborudovanieDataSetTableAdapters.TableAdapterManager();
            this.oborudovanieDataSet1 = new College_items.OborudovanieDataSet();
            this.аудиторииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аудиторииTableAdapter = new College_items.OborudovanieDataSetTableAdapters.АудиторииTableAdapter();
            this.кодАудитTextBox = new System.Windows.Forms.TextBox();
            this.кодТипОборTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.типОборBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типОборTableAdapter = new College_items.OborudovanieDataSetTableAdapters.ТипОборTableAdapter();
            this.датаПриобрMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            кодТипОборLabel = new System.Windows.Forms.Label();
            кодАудитLabel = new System.Windows.Forms.Label();
            датаПриобрLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            списанLabel = new System.Windows.Forms.Label();
            примечаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аудиторииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодТипОборLabel
            // 
            кодТипОборLabel.AutoSize = true;
            кодТипОборLabel.Location = new System.Drawing.Point(12, 45);
            кодТипОборLabel.Name = "кодТипОборLabel";
            кодТипОборLabel.Size = new System.Drawing.Size(135, 17);
            кодТипОборLabel.TabIndex = 2;
            кодТипОборLabel.Text = "Тип оборудования:";
            кодТипОборLabel.Click += new System.EventHandler(this.кодТипОборLabel_Click);
            // 
            // кодАудитLabel
            // 
            кодАудитLabel.AutoSize = true;
            кодАудитLabel.Location = new System.Drawing.Point(12, 17);
            кодАудитLabel.Name = "кодАудитLabel";
            кодАудитLabel.Size = new System.Drawing.Size(83, 17);
            кодАудитLabel.TabIndex = 4;
            кодАудитLabel.Text = "Аудитория:";
            кодАудитLabel.Click += new System.EventHandler(this.кодАудитLabel_Click);
            // 
            // датаПриобрLabel
            // 
            датаПриобрLabel.AutoSize = true;
            датаПриобрLabel.Location = new System.Drawing.Point(12, 73);
            датаПриобрLabel.Name = "датаПриобрLabel";
            датаПриобрLabel.Size = new System.Drawing.Size(147, 17);
            датаПриобрLabel.TabIndex = 6;
            датаПриобрLabel.Text = "Дата Приобретения:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 100);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(82, 17);
            стоимостьLabel.TabIndex = 8;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // списанLabel
            // 
            списанLabel.AutoSize = true;
            списанLabel.Location = new System.Drawing.Point(12, 130);
            списанLabel.Name = "списанLabel";
            списанLabel.Size = new System.Drawing.Size(60, 17);
            списанLabel.TabIndex = 10;
            списанLabel.Text = "Списан:";
            // 
            // примечаниеLabel
            // 
            примечаниеLabel.AutoSize = true;
            примечаниеLabel.Location = new System.Drawing.Point(12, 158);
            примечаниеLabel.Name = "примечаниеLabel";
            примечаниеLabel.Size = new System.Drawing.Size(95, 17);
            примечаниеLabel.TabIndex = 12;
            примечаниеLabel.Text = "Примечание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оборудованиеBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(165, 97);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 22);
            this.стоимостьTextBox.TabIndex = 9;
            // 
            // списанCheckBox
            // 
            this.списанCheckBox.Location = new System.Drawing.Point(165, 125);
            this.списанCheckBox.Name = "списанCheckBox";
            this.списанCheckBox.Size = new System.Drawing.Size(200, 24);
            this.списанCheckBox.TabIndex = 11;
            this.списанCheckBox.UseVisualStyleBackColor = true;
            // 
            // примечаниеTextBox
            // 
            this.примечаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оборудованиеBindingSource, "Примечание", true));
            this.примечаниеTextBox.Location = new System.Drawing.Point(165, 155);
            this.примечаниеTextBox.Name = "примечаниеTextBox";
            this.примечаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.примечаниеTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxAuditory
            // 
            this.comboBoxAuditory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAuditory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAuditory.DataSource = this.аудиторииBindingSource;
            this.comboBoxAuditory.DisplayMember = "НазвАудит";
            this.comboBoxAuditory.FormattingEnabled = true;
            this.comboBoxAuditory.Location = new System.Drawing.Point(165, 14);
            this.comboBoxAuditory.Name = "comboBoxAuditory";
            this.comboBoxAuditory.Size = new System.Drawing.Size(200, 24);
            this.comboBoxAuditory.TabIndex = 15;
            this.comboBoxAuditory.ValueMember = "КодАудит";
            this.comboBoxAuditory.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuditory_SelectedIndexChanged);
            this.comboBoxAuditory.ValueMemberChanged += new System.EventHandler(this.comboBoxAuditory_ValueMemberChanged);
            this.comboBoxAuditory.SelectedValueChanged += new System.EventHandler(this.comboBoxAuditory_SelectedValueChanged);
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.oborudovanieDataSet;
            // 
            // oborudovanieDataSet
            // 
            this.oborudovanieDataSet.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = College_items.OborudovanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АудиторииTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = this.оборудованиеTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТипОборTableAdapter = null;
            // 
            // oborudovanieDataSet1
            // 
            this.oborudovanieDataSet1.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аудиторииBindingSource
            // 
            this.аудиторииBindingSource.DataMember = "Аудитории";
            this.аудиторииBindingSource.DataSource = this.oborudovanieDataSet1;
            // 
            // аудиторииTableAdapter
            // 
            this.аудиторииTableAdapter.ClearBeforeFill = true;
            // 
            // кодАудитTextBox
            // 
            this.кодАудитTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оборудованиеBindingSource, "КодАудит", true));
            this.кодАудитTextBox.Location = new System.Drawing.Point(15, 262);
            this.кодАудитTextBox.Name = "кодАудитTextBox";
            this.кодАудитTextBox.Size = new System.Drawing.Size(0, 22);
            this.кодАудитTextBox.TabIndex = 16;
            // 
            // кодТипОборTextBox
            // 
            this.кодТипОборTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оборудованиеBindingSource, "КодТипОбор", true));
            this.кодТипОборTextBox.Location = new System.Drawing.Point(15, 234);
            this.кодТипОборTextBox.Name = "кодТипОборTextBox";
            this.кодТипОборTextBox.Size = new System.Drawing.Size(0, 22);
            this.кодТипОборTextBox.TabIndex = 17;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxItem.DataSource = this.типОборBindingSource;
            this.comboBoxItem.DisplayMember = "ТипОбор";
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(165, 42);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(200, 24);
            this.comboBoxItem.TabIndex = 18;
            this.comboBoxItem.ValueMember = "КодТипОбор";
            // 
            // типОборBindingSource
            // 
            this.типОборBindingSource.DataMember = "ТипОбор";
            this.типОборBindingSource.DataSource = this.oborudovanieDataSet1;
            // 
            // типОборTableAdapter
            // 
            this.типОборTableAdapter.ClearBeforeFill = true;
            // 
            // датаПриобрMaskedTextBox
            // 
            this.датаПриобрMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оборудованиеBindingSource, "ДатаПриобр", true));
            this.датаПриобрMaskedTextBox.Location = new System.Drawing.Point(165, 71);
            this.датаПриобрMaskedTextBox.Mask = "00/00/0000";
            this.датаПриобрMaskedTextBox.Name = "датаПриобрMaskedTextBox";
            this.датаПриобрMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.датаПриобрMaskedTextBox.TabIndex = 19;
            this.датаПриобрMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Form_Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.датаПриобрMaskedTextBox);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.кодТипОборTextBox);
            this.Controls.Add(this.кодАудитTextBox);
            this.Controls.Add(this.comboBoxAuditory);
            this.Controls.Add(this.button1);
            this.Controls.Add(кодТипОборLabel);
            this.Controls.Add(кодАудитLabel);
            this.Controls.Add(датаПриобрLabel);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(списанLabel);
            this.Controls.Add(this.списанCheckBox);
            this.Controls.Add(примечаниеLabel);
            this.Controls.Add(this.примечаниеTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить оборудование";
            this.Load += new System.EventHandler(this.Form_Add_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аудиторииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private OborudovanieDataSet oborudovanieDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private OborudovanieDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private OborudovanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.CheckBox списанCheckBox;
        private System.Windows.Forms.TextBox примечаниеTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAuditory;
        private OborudovanieDataSet oborudovanieDataSet1;
        private System.Windows.Forms.BindingSource аудиторииBindingSource;
        private OborudovanieDataSetTableAdapters.АудиторииTableAdapter аудиторииTableAdapter;
        private System.Windows.Forms.TextBox кодАудитTextBox;
        private System.Windows.Forms.TextBox кодТипОборTextBox;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.BindingSource типОборBindingSource;
        private OborudovanieDataSetTableAdapters.ТипОборTableAdapter типОборTableAdapter;
        private System.Windows.Forms.MaskedTextBox датаПриобрMaskedTextBox;
    }
}