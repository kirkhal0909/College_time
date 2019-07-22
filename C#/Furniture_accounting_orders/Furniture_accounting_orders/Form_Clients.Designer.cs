namespace Furniture_accounting_orders
{
    partial class Form_Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clients));
            this.ordersDataSet = new Furniture_accounting_orders.ordersDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Furniture_accounting_orders.ordersDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager();
            this.клиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClientFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.labelClientAddress = new System.Windows.Forms.Label();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.labelClientFIO = new System.Windows.Forms.Label();
            this.textBoxClientFIO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "ordersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.ordersDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Furniture_accounting_orders.ordersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КатегорииTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.МебельTableAdapter = null;
            this.tableAdapterManager.Элементы_заказовTableAdapter = null;
            // 
            // клиентыDataGridView
            // 
            this.клиентыDataGridView.AllowUserToAddRows = false;
            this.клиентыDataGridView.AllowUserToDeleteRows = false;
            this.клиентыDataGridView.AutoGenerateColumns = false;
            this.клиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumnClientFIO,
            this.dataGridViewTextBoxColumnClientAddress,
            this.dataGridViewTextBoxColumnClientPhone});
            this.клиентыDataGridView.DataSource = this.клиентыBindingSource;
            this.клиентыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.клиентыDataGridView.Location = new System.Drawing.Point(0, 0);
            this.клиентыDataGridView.Name = "клиентыDataGridView";
            this.клиентыDataGridView.ReadOnly = true;
            this.клиентыDataGridView.RowTemplate.Height = 24;
            this.клиентыDataGridView.Size = new System.Drawing.Size(651, 233);
            this.клиентыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ИД клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnClientFIO
            // 
            this.dataGridViewTextBoxColumnClientFIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnClientFIO.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumnClientFIO.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumnClientFIO.Name = "dataGridViewTextBoxColumnClientFIO";
            this.dataGridViewTextBoxColumnClientFIO.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnClientAddress
            // 
            this.dataGridViewTextBoxColumnClientAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnClientAddress.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumnClientAddress.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumnClientAddress.Name = "dataGridViewTextBoxColumnClientAddress";
            this.dataGridViewTextBoxColumnClientAddress.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnClientPhone
            // 
            this.dataGridViewTextBoxColumnClientPhone.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumnClientPhone.HeaderText = "Номер";
            this.dataGridViewTextBoxColumnClientPhone.Name = "dataGridViewTextBoxColumnClientPhone";
            this.dataGridViewTextBoxColumnClientPhone.ReadOnly = true;
            this.dataGridViewTextBoxColumnClientPhone.Width = 140;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.клиентыDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 235);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRemoveClient);
            this.panel2.Controls.Add(this.buttonEditClient);
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 50);
            this.panel2.TabIndex = 4;
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveClient.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRemoveClient.Location = new System.Drawing.Point(11, 5);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(277, 37);
            this.buttonRemoveClient.TabIndex = 9;
            this.buttonRemoveClient.Text = "Удалить клиента";
            this.buttonRemoveClient.UseVisualStyleBackColor = true;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditClient.Location = new System.Drawing.Point(363, 5);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(277, 37);
            this.buttonEditClient.TabIndex = 8;
            this.buttonEditClient.Text = "Редактировать клиента";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonAddClient);
            this.panel3.Controls.Add(this.labelClientPhone);
            this.panel3.Controls.Add(this.textBoxClientPhone);
            this.panel3.Controls.Add(this.labelClientAddress);
            this.panel3.Controls.Add(this.textBoxClientAddress);
            this.panel3.Controls.Add(this.labelClientFIO);
            this.panel3.Controls.Add(this.textBoxClientFIO);
            this.panel3.Location = new System.Drawing.Point(0, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 117);
            this.panel3.TabIndex = 5;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddClient.ForeColor = System.Drawing.Color.Green;
            this.buttonAddClient.Location = new System.Drawing.Point(363, 76);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(277, 34);
            this.buttonAddClient.TabIndex = 10;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientPhone.Location = new System.Drawing.Point(7, 80);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(74, 24);
            this.labelClientPhone.TabIndex = 13;
            this.labelClientPhone.Text = "Номер:";
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientPhone.Location = new System.Drawing.Point(88, 77);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(265, 30);
            this.textBoxClientPhone.TabIndex = 12;
            // 
            // labelClientAddress
            // 
            this.labelClientAddress.AutoSize = true;
            this.labelClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientAddress.Location = new System.Drawing.Point(7, 44);
            this.labelClientAddress.Name = "labelClientAddress";
            this.labelClientAddress.Size = new System.Drawing.Size(72, 24);
            this.labelClientAddress.TabIndex = 11;
            this.labelClientAddress.Text = "Адрес:";
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientAddress.Location = new System.Drawing.Point(88, 41);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(552, 30);
            this.textBoxClientAddress.TabIndex = 10;
            // 
            // labelClientFIO
            // 
            this.labelClientFIO.AutoSize = true;
            this.labelClientFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientFIO.Location = new System.Drawing.Point(7, 8);
            this.labelClientFIO.Name = "labelClientFIO";
            this.labelClientFIO.Size = new System.Drawing.Size(59, 24);
            this.labelClientFIO.TabIndex = 9;
            this.labelClientFIO.Text = "ФИО:";
            // 
            // textBoxClientFIO
            // 
            this.textBoxClientFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientFIO.Location = new System.Drawing.Point(88, 5);
            this.textBoxClientFIO.Name = "textBoxClientFIO";
            this.textBoxClientFIO.Size = new System.Drawing.Size(552, 30);
            this.textBoxClientFIO.TabIndex = 8;
            // 
            // Form_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ordersDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private ordersDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private ordersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView клиентыDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.Label labelClientAddress;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.Label labelClientFIO;
        private System.Windows.Forms.TextBox textBoxClientFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClientFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClientPhone;
    }
}