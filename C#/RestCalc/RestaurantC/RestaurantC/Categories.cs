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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void блюдаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.restaurantDataSet.Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.restaurantDataSet.Категории);

            //Выбираем блокировку кнопки - удалить
            категорииDataGridView_CurrentCellChanged(категорииDataGridView, null);
            formCaption = this.Text;
            DataSaved(true);
        }

        //Кнопка сохранить
        private void категорииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int Position = категорииBindingSource.Position;
            this.Validate();
            this.категорииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.restaurantDataSet.Категории);
            категорииBindingSource.Position = Position;
            DataSaved(true);
        }

        //Если пользователь отредактировал ячейку таблицы
        private void категорииDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {   
            try
            {   //то проверяем, используется ли категория в блюдах
                блюдаBindingSource.Filter = "ID_категории=" + (sender as DataGridView).Rows[(sender as DataGridView).CurrentCell.RowIndex].Cells[ID_категории.DisplayIndex].Value.ToString();
                //Если нет, то разрешаем удалить категорию
                if(блюдаBindingSource.Count == 0)
                {
                    bindingNavigatorDeleteItem.Enabled = true;
                    bindingNavigatorDeleteItem.Text = "Удалить категорию";
                    (sender as DataGridView).AllowUserToDeleteRows = true;
                    //MessageBox.Show("0 блюд");
                } //Иначе ставим запрет на удаление
                else
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                    bindingNavigatorDeleteItem.Text = "В категории есть блюда!";
                    (sender as DataGridView).AllowUserToDeleteRows = false;
                }
                bindingNavigatorAddNewItem.Enabled = true;
                if ((sender as DataGridView)[Категория.DisplayIndex, (sender as DataGridView).RowCount-1].Value.ToString() == string.Empty)
                {
                    //MessageBox.Show("null");
                    bindingNavigatorAddNewItem.Enabled = false;
                }
            }
            catch (Exception ex) { }
        }

        private void категорииDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            категорииDataGridView_CurrentCellChanged(sender, null);
            DataSaved(false);
        }

        private void категорииBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void категорииBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataSaved(false);
            //MessageBox.Show(категорииBindingSource.Count.ToString());
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void категорииDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        bool Saved = true;
        string formCaption;

        //Функция блокировки/разблокировки сохранения
        private void DataSaved(bool isSaved)
        {
            if(isSaved)
            {
                this.Text = formCaption;
                категорииBindingNavigatorSaveItem.Enabled = false;
                Saved = true;
            } else
            {
                this.Text = formCaption + " (Не сохранено)";
                категорииBindingNavigatorSaveItem.Enabled = true;
                Saved = false;
            }
        }

        private void категорииDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataSaved(false);
            //MessageBox.Show("Changed");
        }

        //Если пользователь хочет закрыть форму с категориями...
        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {   //то если таблица не сохранена
            if (!Saved)
            {   //спрашиваем пользователя, хочет ли он сохранить
                DialogResult dg = MessageBox.Show("Вы хотите сохранить изменения?", "Изменения не сохранены!", MessageBoxButtons.YesNoCancel);
                if (dg == System.Windows.Forms.DialogResult.Cancel) { e.Cancel = true; }
                else if (dg == System.Windows.Forms.DialogResult.Yes) { категорииBindingNavigatorSaveItem.PerformClick(); }
            }
        }

        private void категорииBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
