namespace Furniture_accounting_orders
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.buttonEditFurniture = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditFurniture
            // 
            this.buttonEditFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditFurniture.Location = new System.Drawing.Point(12, 195);
            this.buttonEditFurniture.Name = "buttonEditFurniture";
            this.buttonEditFurniture.Size = new System.Drawing.Size(293, 55);
            this.buttonEditFurniture.TabIndex = 0;
            this.buttonEditFurniture.Text = "Редактор мебели";
            this.buttonEditFurniture.UseVisualStyleBackColor = true;
            this.buttonEditFurniture.Click += new System.EventHandler(this.buttonEditFurniture_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(12, 134);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(293, 55);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(12, 72);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(293, 55);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrderAdd.Location = new System.Drawing.Point(12, 11);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(293, 55);
            this.buttonOrderAdd.TabIndex = 3;
            this.buttonOrderAdd.Text = "Добавить заказ";
            this.buttonOrderAdd.UseVisualStyleBackColor = true;
            this.buttonOrderAdd.Click += new System.EventHandler(this.buttonOrderAdd_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 263);
            this.Controls.Add(this.buttonOrderAdd);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonEditFurniture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditFurniture;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonOrderAdd;
    }
}