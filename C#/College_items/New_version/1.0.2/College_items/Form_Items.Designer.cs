namespace College_items
{
    partial class Form_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Items));
            this.типОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oborudovanieDataSet = new College_items.OborudovanieDataSet();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оборудованиеTableAdapter = new College_items.OborudovanieDataSetTableAdapters.ОборудованиеTableAdapter();
            this.tableAdapterManager = new College_items.OborudovanieDataSetTableAdapters.TableAdapterManager();
            this.оборудованиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.оборудованиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.оборудованиеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).BeginInit();
            this.оборудованиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // типОборудованияToolStripMenuItem
            // 
            this.типОборудованияToolStripMenuItem.Name = "типОборудованияToolStripMenuItem";
            this.типОборудованияToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.типОборудованияToolStripMenuItem.Text = "Тип оборудования";
            this.типОборудованияToolStripMenuItem.Click += new System.EventHandler(this.типОборудованияToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типОборудованияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oborudovanieDataSet
            // 
            this.oborudovanieDataSet.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.oborudovanieDataSet;
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
            // оборудованиеBindingNavigator
            // 
            this.оборудованиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оборудованиеBindingNavigator.BindingSource = this.оборудованиеBindingSource;
            this.оборудованиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оборудованиеBindingNavigator.CountItemFormat = "из {0}";
            this.оборудованиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оборудованиеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.оборудованиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.оборудованиеBindingNavigatorSaveItem});
            this.оборудованиеBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.оборудованиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оборудованиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оборудованиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оборудованиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оборудованиеBindingNavigator.Name = "оборудованиеBindingNavigator";
            this.оборудованиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оборудованиеBindingNavigator.Size = new System.Drawing.Size(733, 27);
            this.оборудованиеBindingNavigator.TabIndex = 3;
            this.оборудованиеBindingNavigator.Text = "bindingNavigator1";
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
            // оборудованиеBindingNavigatorSaveItem
            // 
            this.оборудованиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оборудованиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оборудованиеBindingNavigatorSaveItem.Image")));
            this.оборудованиеBindingNavigatorSaveItem.Name = "оборудованиеBindingNavigatorSaveItem";
            this.оборудованиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.оборудованиеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оборудованиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.оборудованиеBindingNavigatorSaveItem_Click_3);
            // 
            // оборудованиеDataGridView
            // 
            this.оборудованиеDataGridView.AutoGenerateColumns = false;
            this.оборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.оборудованиеDataGridView.DataSource = this.оборудованиеBindingSource;
            this.оборудованиеDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.оборудованиеDataGridView.Location = new System.Drawing.Point(0, 55);
            this.оборудованиеDataGridView.Name = "оборудованиеDataGridView";
            this.оборудованиеDataGridView.RowTemplate.Height = 24;
            this.оборудованиеDataGridView.Size = new System.Drawing.Size(733, 297);
            this.оборудованиеDataGridView.TabIndex = 3;
            this.оборудованиеDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.оборудованиеDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодОбор";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "КодТипОбор";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код тип оборудования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "КодАудит";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код аудитории";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ДатаПриобр";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата приобретения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Списан";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Списан";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Примечание";
            this.dataGridViewTextBoxColumn6.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 352);
            this.Controls.Add(this.оборудованиеDataGridView);
            this.Controls.Add(this.оборудованиеBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Items_FormClosing);
            this.Load += new System.EventHandler(this.Form_Items_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingNavigator)).EndInit();
            this.оборудованиеBindingNavigator.ResumeLayout(false);
            this.оборудованиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem типОборудованияToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private OborudovanieDataSet oborudovanieDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private OborudovanieDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private OborudovanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оборудованиеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton оборудованиеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView оборудованиеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}