namespace Reversi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButton8x8 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStartVsComputer = new System.Windows.Forms.Button();
            this.radioButton12x12 = new System.Windows.Forms.RadioButton();
            this.radioButton10x10 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(0, 142);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(252, 39);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать игру вдвоём";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // radioButton8x8
            // 
            this.radioButton8x8.AutoSize = true;
            this.radioButton8x8.Checked = true;
            this.radioButton8x8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton8x8.Location = new System.Drawing.Point(3, 33);
            this.radioButton8x8.Name = "radioButton8x8";
            this.radioButton8x8.Size = new System.Drawing.Size(65, 29);
            this.radioButton8x8.TabIndex = 1;
            this.radioButton8x8.TabStop = true;
            this.radioButton8x8.Text = "8x8";
            this.radioButton8x8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStartVsComputer);
            this.panel1.Controls.Add(this.radioButton12x12);
            this.panel1.Controls.Add(this.radioButton10x10);
            this.panel1.Controls.Add(this.radioButton8x8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 186);
            this.panel1.TabIndex = 2;
            // 
            // buttonStartVsComputer
            // 
            this.buttonStartVsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartVsComputer.Location = new System.Drawing.Point(0, 70);
            this.buttonStartVsComputer.Name = "buttonStartVsComputer";
            this.buttonStartVsComputer.Size = new System.Drawing.Size(252, 66);
            this.buttonStartVsComputer.TabIndex = 5;
            this.buttonStartVsComputer.Text = "Играть против компьютера";
            this.buttonStartVsComputer.UseVisualStyleBackColor = true;
            this.buttonStartVsComputer.Click += new System.EventHandler(this.buttonStartVsComputer_Click);
            // 
            // radioButton12x12
            // 
            this.radioButton12x12.AutoSize = true;
            this.radioButton12x12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton12x12.Location = new System.Drawing.Point(167, 33);
            this.radioButton12x12.Name = "radioButton12x12";
            this.radioButton12x12.Size = new System.Drawing.Size(87, 29);
            this.radioButton12x12.TabIndex = 4;
            this.radioButton12x12.Text = "12x12";
            this.radioButton12x12.UseVisualStyleBackColor = true;
            // 
            // radioButton10x10
            // 
            this.radioButton10x10.AutoSize = true;
            this.radioButton10x10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10x10.Location = new System.Drawing.Point(74, 33);
            this.radioButton10x10.Name = "radioButton10x10";
            this.radioButton10x10.Size = new System.Drawing.Size(87, 29);
            this.radioButton10x10.TabIndex = 3;
            this.radioButton10x10.Text = "10x10";
            this.radioButton10x10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игровое поле:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 203);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton radioButton8x8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton12x12;
        private System.Windows.Forms.RadioButton radioButton10x10;
        private System.Windows.Forms.Button buttonStartVsComputer;
    }
}

