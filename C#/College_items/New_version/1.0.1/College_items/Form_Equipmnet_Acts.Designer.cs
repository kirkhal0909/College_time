namespace College_items
{
    partial class Form_Equipmnet_Acts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Equipmnet_Acts));
            this.oborudovanieDataSet = new College_items.OborudovanieDataSet();
            this.актКомплектацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.актКомплектацииTableAdapter = new College_items.OborudovanieDataSetTableAdapters.АктКомплектацииTableAdapter();
            this.tableAdapterManager = new College_items.OborudovanieDataSetTableAdapters.TableAdapterManager();
            this.актКомплектацииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.актКомплектацииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.актКомплектацииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.строкиАктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииBindingNavigator)).BeginInit();
            this.актКомплектацииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oborudovanieDataSet
            // 
            this.oborudovanieDataSet.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // актКомплектацииBindingSource
            // 
            this.актКомплектацииBindingSource.DataMember = "АктКомплектации";
            this.актКомплектацииBindingSource.DataSource = this.oborudovanieDataSet;
            // 
            // актКомплектацииTableAdapter
            // 
            this.актКомплектацииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = College_items.OborudovanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктКомплектацииTableAdapter = this.актКомплектацииTableAdapter;
            this.tableAdapterManager.АудиторииTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтрокаАктаTableAdapter = null;
            this.tableAdapterManager.ТипОборTableAdapter = null;
            // 
            // актКомплектацииBindingNavigator
            // 
            this.актКомплектацииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.актКомплектацииBindingNavigator.BindingSource = this.актКомплектацииBindingSource;
            this.актКомплектацииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.актКомплектацииBindingNavigator.CountItemFormat = "из {0}";
            this.актКомплектацииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.актКомплектацииBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.актКомплектацииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.актКомплектацииBindingNavigatorSaveItem});
            this.актКомплектацииBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.актКомплектацииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.актКомплектацииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.актКомплектацииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.актКомплектацииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.актКомплектацииBindingNavigator.Name = "актКомплектацииBindingNavigator";
            this.актКомплектацииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.актКомплектацииBindingNavigator.Size = new System.Drawing.Size(772, 27);
            this.актКомплектацииBindingNavigator.TabIndex = 0;
            this.актКомплектацииBindingNavigator.Text = "bindingNavigator1";
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
            // актКомплектацииBindingNavigatorSaveItem
            // 
            this.актКомплектацииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.актКомплектацииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("актКомплектацииBindingNavigatorSaveItem.Image")));
            this.актКомплектацииBindingNavigatorSaveItem.Name = "актКомплектацииBindingNavigatorSaveItem";
            this.актКомплектацииBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.актКомплектацииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.актКомплектацииBindingNavigatorSaveItem.Click += new System.EventHandler(this.актКомплектацииBindingNavigatorSaveItem_Click);
            // 
            // актКомплектацииDataGridView
            // 
            this.актКомплектацииDataGridView.AutoGenerateColumns = false;
            this.актКомплектацииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.актКомплектацииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.актКомплектацииDataGridView.DataSource = this.актКомплектацииBindingSource;
            this.актКомплектацииDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.актКомплектацииDataGridView.Location = new System.Drawing.Point(0, 55);
            this.актКомплектацииDataGridView.Name = "актКомплектацииDataGridView";
            this.актКомплектацииDataGridView.RowTemplate.Height = 24;
            this.актКомплектацииDataGridView.Size = new System.Drawing.Size(772, 250);
            this.актКомплектацииDataGridView.TabIndex = 1;
            this.актКомплектацииDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.актКомплектацииDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодАкта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код акта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Комплектация";
            this.dataGridViewTextBoxColumn2.HeaderText = "Комплектация";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата комплектации";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата комплектации";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата разкомплектации";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата разкомплектации";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ИнвентНомер";
            this.dataGridViewTextBoxColumn5.HeaderText = "Инвент номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкиАктовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // строкиАктовToolStripMenuItem
            // 
            this.строкиАктовToolStripMenuItem.Name = "строкиАктовToolStripMenuItem";
            this.строкиАктовToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.строкиАктовToolStripMenuItem.Text = "Строки актов";
            this.строкиАктовToolStripMenuItem.Click += new System.EventHandler(this.строкиАктовToolStripMenuItem_Click);
            // 
            // Form_Equipmnet_Acts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 305);
            this.Controls.Add(this.актКомплектацииDataGridView);
            this.Controls.Add(this.актКомплектацииBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Equipmnet_Acts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акты комплектаций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipmnet_Acts_FormClosing);
            this.Load += new System.EventHandler(this.Form_Equipmnet_Acts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииBindingNavigator)).EndInit();
            this.актКомплектацииBindingNavigator.ResumeLayout(false);
            this.актКомплектацииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.актКомплектацииDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OborudovanieDataSet oborudovanieDataSet;
        private System.Windows.Forms.BindingSource актКомплектацииBindingSource;
        private OborudovanieDataSetTableAdapters.АктКомплектацииTableAdapter актКомплектацииTableAdapter;
        private OborudovanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator актКомплектацииBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton актКомплектацииBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView актКомплектацииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem строкиАктовToolStripMenuItem;
    }
}