using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantC
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        bool Saved = true;
        string nameForm = "Продукты";

        private void SavedDataSet(bool isSaved)
        {
            if (firstSwitchSave)
            {
                this.Text = nameForm;
                продуктыBindingNavigatorSaveItem.Enabled = false;
                Saved = true;
            }
            else if (SwitchSave)
            {
                if (isSaved)
                {
                    this.Text = nameForm;
                    продуктыBindingNavigatorSaveItem.Enabled = false;
                    Saved = true;
                }
                else
                {
                    this.Text = nameForm + " (НЕ СОХРАНЕНО)";
                    продуктыBindingNavigatorSaveItem.Enabled = true;
                    Saved = false;
                }
            }
        }

        private void продуктыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int Position = продуктыBindingSource.Position;
            for (int row = 0; row < продуктыBindingSource.Count; row++)
            {
                продуктыBindingSource.Position = row;
                if (продуктTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Изменения не сохранены!\nНазвание продукта не может быть пустым.");
                    return;
                }
                else if (стоимостьTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Изменения не сохранены!\nСтоимость продукта не может быть пустым.");
                    return;
                }
            }            
                this.Validate();
                this.продуктыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.restaurantDataSet);
                this.продуктыTableAdapter.Fill(this.restaurantDataSet.Продукты);

            продуктыBindingSource.Position = Position;
            SwitchSave = true;
                SavedDataSet(true);
        }

        bool firstSwitchSave = true;
        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.restaurantDataSet.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.restaurantDataSet.Продукты);
            SavedDataSet(true);
            firstSwitchSave = false;
            SwitchSave = true;
            DisableDelete();
            //comboBoxПродукты.Focus();
            //MessageBox.Show(продуктыBindingSource.Count.ToString());
        }

        bool DeleteEnabled = true;

        private void DisableDelete()
        {
            if (ингредиентыBindingSource.Count == 0)
            {
                bindingNavigatorDeleteItem.Enabled = true;
                DeleteEnabled = true;
                bindingNavigatorDeleteItem.Text = "Удалить продукт";
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = false;
                DeleteEnabled = false;
                bindingNavigatorDeleteItem.Text = "В блюдах есть данный продукт!";
            }
        }

        private void продуктLabel_Click(object sender, EventArgs e)
        {

        }

        private void стоимостьLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            фото_продуктаPictureBox.Image = null;
            SavedDataSet(false);
        }       

        private void продуктComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxПродукты.SelectedIndex != -1)
            {
                продуктыBindingSource.Position = comboBoxПродукты.SelectedIndex;
                DisableDelete();
            }
        }

        private void продуктыBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (comboBoxПродукты.Items.Count > продуктыBindingSource.Position)
            comboBoxПродукты.SelectedIndex = продуктыBindingSource.Position;
        }

        private void стоимостьTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (key == '.') { e.KeyChar = ','; }
            else if ((key < '0') || (key > '9')) { if ((key != ',') && (key != 8) && (key != 13)) { e.KeyChar = '\0'; } }
            if ((sender as TextBox).Text.Contains(','))
            {
                if (e.KeyChar == ',') { e.KeyChar = '\0'; }
                /*else if ((key >= '0') && (key <= '9'))
                {
                    if ((sender as TextBox).Text.Length-(sender as TextBox).Text.IndexOf(',')>=3)
                    {
                        e.KeyChar = '\0';
                    }
                }*/
            }
            //if (sender as TextBox)
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SavedDataSet(false);
                фото_продуктаPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        bool SwitchSave = true;

        private void продуктыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("CurrentChanged");
            SwitchSave = true;
        }

        private void продуктыBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //MessageBox.Show("ListChanged");
            SwitchSave = false;
        }

        private void стоимостьTextBox_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("TextBoxChanged");
            SavedDataSet(false);
        }

        private void продуктыBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //DisableDelete();//MessageBox.Show("ItemChanged");
        }

        private void продуктTextBox_TextChanged(object sender, EventArgs e)
        {
            SavedDataSet(false);
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Saved)
            {
                DialogResult dg = MessageBox.Show("Вы хотите сохранить изменения?", "Изменения не сохранены!", MessageBoxButtons.YesNoCancel);
                if (dg == System.Windows.Forms.DialogResult.Cancel) { e.Cancel = true; }
                else if (dg == System.Windows.Forms.DialogResult.Yes) { продуктыBindingNavigatorSaveItem.PerformClick(); }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(ингредиентыBindingSource.Count.ToString());
        }

        private void comboBoxПродукты_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void продуктыBindingSource1_PositionChanged(object sender, EventArgs e)
        {
        }

        private void ингредиентыBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ингредиентыBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
        }

        private void ингредиентыBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            DisableDelete();
        }

        private void bindingNavigatorDeleteItem_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Paint(object sender, PaintEventArgs e)
        {
            DisableDelete();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            comboBoxПродукты.SelectedIndex = -1;
        }
    }
}
