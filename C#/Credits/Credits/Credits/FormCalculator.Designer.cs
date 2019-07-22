namespace Credits
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.Месяц = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сумма_платежа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(2, 2);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(46, 17);
            this.labelCredit.TabIndex = 0;
            this.labelCredit.Text = "label1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(2, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 17);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label1";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Месяц,
            this.Сумма_платежа});
            this.dataGridViewInfo.Location = new System.Drawing.Point(5, 145);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.RowHeadersVisible = false;
            this.dataGridViewInfo.RowTemplate.Height = 24;
            this.dataGridViewInfo.Size = new System.Drawing.Size(282, 195);
            this.dataGridViewInfo.TabIndex = 2;
            this.dataGridViewInfo.Visible = false;
            // 
            // Месяц
            // 
            this.Месяц.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Месяц.HeaderText = "Месяц";
            this.Месяц.Name = "Месяц";
            this.Месяц.ReadOnly = true;
            this.Месяц.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Сумма_платежа
            // 
            this.Сумма_платежа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Сумма_платежа.HeaderText = "Сумма платежа";
            this.Сумма_платежа.Name = "Сумма_платежа";
            this.Сумма_платежа.ReadOnly = true;
            this.Сумма_платежа.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(205, 75);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 352);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCredit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчёт";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Месяц;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сумма_платежа;
        private System.Windows.Forms.Button buttonExport;
    }
}