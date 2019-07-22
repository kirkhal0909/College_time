namespace College_items
{
    partial class Form_Type_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Type_Items));
            this.oborudovanieDataSet = new College_items.OborudovanieDataSet();
            this.типОборBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new College_items.OborudovanieDataSetTableAdapters.TableAdapterManager();
            this.типОборTableAdapter = new College_items.OborudovanieDataSetTableAdapters.ТипОборTableAdapter();
            this.типОборBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.типОборBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.типОборDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingNavigator)).BeginInit();
            this.типОборBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типОборDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oborudovanieDataSet
            // 
            this.oborudovanieDataSet.DataSetName = "OborudovanieDataSet";
            this.oborudovanieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типОборBindingSource
            // 
            this.типОборBindingSource.DataMember = "ТипОбор";
            this.типОборBindingSource.DataSource = this.oborudovanieDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = College_items.OborudovanieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктКомплектацииTableAdapter = null;
            this.tableAdapterManager.АудиторииTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СтрокаАктаTableAdapter = null;
            this.tableAdapterManager.ТипОборTableAdapter = this.типОборTableAdapter;
            // 
            // типОборTableAdapter
            // 
            this.типОборTableAdapter.ClearBeforeFill = true;
            // 
            // типОборBindingNavigator
            // 
            this.типОборBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типОборBindingNavigator.BindingSource = this.типОборBindingSource;
            this.типОборBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типОборBindingNavigator.CountItemFormat = "из {0}";
            this.типОборBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типОборBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.типОборBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.типОборBindingNavigatorSaveItem});
            this.типОборBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типОборBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типОборBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типОборBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типОборBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типОборBindingNavigator.Name = "типОборBindingNavigator";
            this.типОборBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типОборBindingNavigator.Size = new System.Drawing.Size(369, 27);
            this.типОборBindingNavigator.TabIndex = 0;
            this.типОборBindingNavigator.Text = "bindingNavigator1";
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
            // типОборBindingNavigatorSaveItem
            // 
            this.типОборBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типОборBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("типОборBindingNavigatorSaveItem.Image")));
            this.типОборBindingNavigatorSaveItem.Name = "типОборBindingNavigatorSaveItem";
            this.типОборBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.типОборBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.типОборBindingNavigatorSaveItem.Click += new System.EventHandler(this.типОборBindingNavigatorSaveItem_Click);
            // 
            // типОборDataGridView
            // 
            this.типОборDataGridView.AutoGenerateColumns = false;
            this.типОборDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типОборDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.типОборDataGridView.DataSource = this.типОборBindingSource;
            this.типОборDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.типОборDataGridView.Location = new System.Drawing.Point(0, 27);
            this.типОборDataGridView.Name = "типОборDataGridView";
            this.типОборDataGridView.RowTemplate.Height = 24;
            this.типОборDataGridView.Size = new System.Drawing.Size(369, 272);
            this.типОборDataGridView.TabIndex = 1;
            this.типОборDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.типОборDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодТипОбор";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код тип оборудования";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ТипОбор";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип оборудования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form_Type_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 299);
            this.Controls.Add(this.типОборDataGridView);
            this.Controls.Add(this.типОборBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Type_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип оборудования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Type_Items_FormClosing);
            this.Load += new System.EventHandler(this.Form_Type_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОборBindingNavigator)).EndInit();
            this.типОборBindingNavigator.ResumeLayout(false);
            this.типОборBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типОборDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OborudovanieDataSet oborudovanieDataSet;
        private System.Windows.Forms.BindingSource типОборBindingSource;
        private OborudovanieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типОборBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton типОборBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView типОборDataGridView;
        private OborudovanieDataSetTableAdapters.ТипОборTableAdapter типОборTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}