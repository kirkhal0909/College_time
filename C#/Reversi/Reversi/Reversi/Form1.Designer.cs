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
            this.panelStartGame = new System.Windows.Forms.Panel();
            this.buttonPlayerVsPC = new System.Windows.Forms.Button();
            this.buttonTwoPlayers = new System.Windows.Forms.Button();
            this.radioButton12x12 = new System.Windows.Forms.RadioButton();
            this.radioButton10x10 = new System.Windows.Forms.RadioButton();
            this.radioButton8x8 = new System.Windows.Forms.RadioButton();
            this.labelGameSize = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTestSize = new System.Windows.Forms.Panel();
            this.labelCoords = new System.Windows.Forms.Label();
            this.panelStartGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelTestSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartGame
            // 
            this.panelStartGame.BackColor = System.Drawing.SystemColors.Menu;
            this.panelStartGame.Controls.Add(this.buttonPlayerVsPC);
            this.panelStartGame.Controls.Add(this.buttonTwoPlayers);
            this.panelStartGame.Controls.Add(this.radioButton12x12);
            this.panelStartGame.Controls.Add(this.radioButton10x10);
            this.panelStartGame.Controls.Add(this.radioButton8x8);
            this.panelStartGame.Controls.Add(this.labelGameSize);
            this.panelStartGame.Location = new System.Drawing.Point(35, 2);
            this.panelStartGame.Name = "panelStartGame";
            this.panelStartGame.Size = new System.Drawing.Size(236, 152);
            this.panelStartGame.TabIndex = 0;
            // 
            // buttonPlayerVsPC
            // 
            this.buttonPlayerVsPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayerVsPC.Location = new System.Drawing.Point(9, 107);
            this.buttonPlayerVsPC.Name = "buttonPlayerVsPC";
            this.buttonPlayerVsPC.Size = new System.Drawing.Size(216, 35);
            this.buttonPlayerVsPC.TabIndex = 6;
            this.buttonPlayerVsPC.Text = "Играть против ПК";
            this.buttonPlayerVsPC.UseVisualStyleBackColor = true;
            this.buttonPlayerVsPC.Click += new System.EventHandler(this.buttonPlayerVsPC_Click);
            // 
            // buttonTwoPlayers
            // 
            this.buttonTwoPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwoPlayers.Location = new System.Drawing.Point(9, 66);
            this.buttonTwoPlayers.Name = "buttonTwoPlayers";
            this.buttonTwoPlayers.Size = new System.Drawing.Size(216, 35);
            this.buttonTwoPlayers.TabIndex = 5;
            this.buttonTwoPlayers.Text = "Играть вдвоём";
            this.buttonTwoPlayers.UseVisualStyleBackColor = true;
            this.buttonTwoPlayers.Click += new System.EventHandler(this.buttonTwoPlayers_Click);
            // 
            // radioButton12x12
            // 
            this.radioButton12x12.AutoSize = true;
            this.radioButton12x12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton12x12.Location = new System.Drawing.Point(151, 35);
            this.radioButton12x12.Name = "radioButton12x12";
            this.radioButton12x12.Size = new System.Drawing.Size(74, 24);
            this.radioButton12x12.TabIndex = 4;
            this.radioButton12x12.Text = "12x12";
            this.radioButton12x12.UseVisualStyleBackColor = true;
            // 
            // radioButton10x10
            // 
            this.radioButton10x10.AutoSize = true;
            this.radioButton10x10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10x10.Location = new System.Drawing.Point(71, 35);
            this.radioButton10x10.Name = "radioButton10x10";
            this.radioButton10x10.Size = new System.Drawing.Size(74, 24);
            this.radioButton10x10.TabIndex = 3;
            this.radioButton10x10.Text = "10x10";
            this.radioButton10x10.UseVisualStyleBackColor = true;
            // 
            // radioButton8x8
            // 
            this.radioButton8x8.AutoSize = true;
            this.radioButton8x8.Checked = true;
            this.radioButton8x8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton8x8.Location = new System.Drawing.Point(9, 35);
            this.radioButton8x8.Name = "radioButton8x8";
            this.radioButton8x8.Size = new System.Drawing.Size(56, 24);
            this.radioButton8x8.TabIndex = 2;
            this.radioButton8x8.TabStop = true;
            this.radioButton8x8.Text = "8x8";
            this.radioButton8x8.UseVisualStyleBackColor = true;
            // 
            // labelGameSize
            // 
            this.labelGameSize.AutoSize = true;
            this.labelGameSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameSize.Location = new System.Drawing.Point(9, 7);
            this.labelGameSize.Name = "labelGameSize";
            this.labelGameSize.Size = new System.Drawing.Size(144, 25);
            this.labelGameSize.TabIndex = 1;
            this.labelGameSize.Text = "Игровое поле:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 13);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // panelTestSize
            // 
            this.panelTestSize.Controls.Add(this.trackBar1);
            this.panelTestSize.Controls.Add(this.label1);
            this.panelTestSize.Location = new System.Drawing.Point(3, 9);
            this.panelTestSize.Name = "panelTestSize";
            this.panelTestSize.Size = new System.Drawing.Size(200, 100);
            this.panelTestSize.TabIndex = 3;
            this.panelTestSize.Visible = false;
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(5, 121);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(83, 17);
            this.labelCoords.TabIndex = 4;
            this.labelCoords.Text = "labelCoords";
            this.labelCoords.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 158);
            this.Controls.Add(this.panelStartGame);
            this.Controls.Add(this.panelTestSize);
            this.Controls.Add(this.labelCoords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 205);
            this.MinimumSize = new System.Drawing.Size(318, 205);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реверси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelStartGame.ResumeLayout(false);
            this.panelStartGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelTestSize.ResumeLayout(false);
            this.panelTestSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStartGame;
        private System.Windows.Forms.Label labelGameSize;
        private System.Windows.Forms.RadioButton radioButton10x10;
        private System.Windows.Forms.RadioButton radioButton8x8;
        private System.Windows.Forms.RadioButton radioButton12x12;
        private System.Windows.Forms.Button buttonPlayerVsPC;
        private System.Windows.Forms.Button buttonTwoPlayers;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTestSize;
        private System.Windows.Forms.Label labelCoords;
    }
}

