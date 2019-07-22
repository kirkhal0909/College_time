namespace Credits
{
    partial class FormEditCurrency
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
            System.Windows.Forms.Label валютаLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.Windows.Forms.Label код_буквенныйLabel;
            System.Windows.Forms.Label код_числовойLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCurrency));
            this.кредитыDataSet = new Credits.КредитыDataSet();
            this.валютыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.валютыTableAdapter = new Credits.КредитыDataSetTableAdapters.ВалютыTableAdapter();
            this.tableAdapterManager = new Credits.КредитыDataSetTableAdapters.TableAdapterManager();
            this.валютыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.валютаTextBox = new System.Windows.Forms.TextBox();
            this.изображениеPictureBox = new System.Windows.Forms.PictureBox();
            this.код_буквенныйTextBox = new System.Windows.Forms.TextBox();
            this.код_числовойTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            валютаLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            код_буквенныйLabel = new System.Windows.Forms.Label();
            код_числовойLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingNavigator)).BeginInit();
            this.валютыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // валютаLabel
            // 
            валютаLabel.AutoSize = true;
            валютаLabel.Location = new System.Drawing.Point(12, 41);
            валютаLabel.Name = "валютаLabel";
            валютаLabel.Size = new System.Drawing.Size(62, 17);
            валютаLabel.TabIndex = 1;
            валютаLabel.Text = "Валюта:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Location = new System.Drawing.Point(12, 66);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(102, 17);
            изображениеLabel.TabIndex = 3;
            изображениеLabel.Text = "Изображение:";
            // 
            // код_буквенныйLabel
            // 
            код_буквенныйLabel.AutoSize = true;
            код_буквенныйLabel.Location = new System.Drawing.Point(12, 125);
            код_буквенныйLabel.Name = "код_буквенныйLabel";
            код_буквенныйLabel.Size = new System.Drawing.Size(112, 17);
            код_буквенныйLabel.TabIndex = 5;
            код_буквенныйLabel.Text = "Код буквенный:";
            // 
            // код_числовойLabel
            // 
            код_числовойLabel.AutoSize = true;
            код_числовойLabel.Location = new System.Drawing.Point(12, 153);
            код_числовойLabel.Name = "код_числовойLabel";
            код_числовойLabel.Size = new System.Drawing.Size(103, 17);
            код_числовойLabel.TabIndex = 7;
            код_числовойLabel.Text = "Код числовой:";
            // 
            // кредитыDataSet
            // 
            this.кредитыDataSet.DataSetName = "КредитыDataSet";
            this.кредитыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // валютыBindingSource
            // 
            this.валютыBindingSource.AllowNew = true;
            this.валютыBindingSource.DataMember = "Валюты";
            this.валютыBindingSource.DataSource = this.кредитыDataSet;
            // 
            // валютыTableAdapter
            // 
            this.валютыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Credits.КредитыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютыTableAdapter = this.валютыTableAdapter;
            this.tableAdapterManager.КредитыTableAdapter = null;
            // 
            // валютыBindingNavigator
            // 
            this.валютыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.валютыBindingNavigator.BindingSource = this.валютыBindingSource;
            this.валютыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.валютыBindingNavigator.CountItemFormat = "из {0}";
            this.валютыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.валютыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.валютыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.валютыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.валютыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.валютыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.валютыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.валютыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.валютыBindingNavigator.Name = "валютыBindingNavigator";
            this.валютыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.валютыBindingNavigator.Size = new System.Drawing.Size(318, 27);
            this.валютыBindingNavigator.TabIndex = 0;
            this.валютыBindingNavigator.Text = "bindingNavigator1";
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
            // валютаTextBox
            // 
            this.валютаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютыBindingSource, "Валюта", true));
            this.валютаTextBox.Location = new System.Drawing.Point(130, 38);
            this.валютаTextBox.Name = "валютаTextBox";
            this.валютаTextBox.Size = new System.Drawing.Size(176, 22);
            this.валютаTextBox.TabIndex = 2;
            // 
            // изображениеPictureBox
            // 
            this.изображениеPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.изображениеPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.валютыBindingSource, "Изображение", true));
            this.изображениеPictureBox.Location = new System.Drawing.Point(176, 65);
            this.изображениеPictureBox.Name = "изображениеPictureBox";
            this.изображениеPictureBox.Size = new System.Drawing.Size(100, 50);
            this.изображениеPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.изображениеPictureBox.TabIndex = 4;
            this.изображениеPictureBox.TabStop = false;
            // 
            // код_буквенныйTextBox
            // 
            this.код_буквенныйTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютыBindingSource, "Код_буквенный", true));
            this.код_буквенныйTextBox.Location = new System.Drawing.Point(130, 122);
            this.код_буквенныйTextBox.Name = "код_буквенныйTextBox";
            this.код_буквенныйTextBox.Size = new System.Drawing.Size(176, 22);
            this.код_буквенныйTextBox.TabIndex = 6;
            // 
            // код_числовойTextBox
            // 
            this.код_числовойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютыBindingSource, "Код_числовой", true));
            this.код_числовойTextBox.Location = new System.Drawing.Point(130, 150);
            this.код_числовойTextBox.Name = "код_числовойTextBox";
            this.код_числовойTextBox.Size = new System.Drawing.Size(176, 22);
            this.код_числовойTextBox.TabIndex = 8;
            this.код_числовойTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.код_числовойTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEditCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(валютаLabel);
            this.Controls.Add(this.валютаTextBox);
            this.Controls.Add(изображениеLabel);
            this.Controls.Add(this.изображениеPictureBox);
            this.Controls.Add(код_буквенныйLabel);
            this.Controls.Add(this.код_буквенныйTextBox);
            this.Controls.Add(код_числовойLabel);
            this.Controls.Add(this.код_числовойTextBox);
            this.Controls.Add(this.валютыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор валют";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditCurrency_FormClosing);
            this.Load += new System.EventHandler(this.FormEditCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.кредитыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютыBindingNavigator)).EndInit();
            this.валютыBindingNavigator.ResumeLayout(false);
            this.валютыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изображениеPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private КредитыDataSet кредитыDataSet;
        private System.Windows.Forms.BindingSource валютыBindingSource;
        private КредитыDataSetTableAdapters.ВалютыTableAdapter валютыTableAdapter;
        private КредитыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator валютыBindingNavigator;
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
        private System.Windows.Forms.TextBox валютаTextBox;
        private System.Windows.Forms.PictureBox изображениеPictureBox;
        private System.Windows.Forms.TextBox код_буквенныйTextBox;
        private System.Windows.Forms.TextBox код_числовойTextBox;
        private System.Windows.Forms.Button button1;
    }
}