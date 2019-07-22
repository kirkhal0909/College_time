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
    public partial class EditIngredients : Form
    {
        string ID, Название;
        //Принимаем параметры из формы блюд
        //  и заносим их в глобальные переменные
        public EditIngredients(string ID_блюда,string Название_блюда)
        {
            ID = ID_блюда;
            Название = Название_блюда;
            InitializeComponent();
        }
        //Кнопка сохранить
        private void блюдаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.блюдаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }
        //Зелёная кнопка добавить выбранный продукт в ингредиенты
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавляем новую строку в таблицу ингредиенты
            ингредиентыBindingSource.AddNew();
            //Заносим ID продукта в скрытый столбец
            ингредиентыDataGridView[ID_ингредиента.DisplayIndex, ингредиентыDataGridView.RowCount - 1].Value = продуктыDataGridView[ID_продукта.DisplayIndex, продуктыDataGridView.CurrentRow.Index].Value;
            //Заносим название продукта
            ингредиентыDataGridView[Ингредиент.DisplayIndex, ингредиентыDataGridView.RowCount - 1].Value = продуктыDataGridView[Продукт.DisplayIndex, продуктыDataGridView.CurrentRow.Index].Value;
            //Меняем значение столбца - количество на 0.
            //  А дальше пользователь в таблице сам может редактировать количество
            ингредиентыDataGridView[Количество_ингредиента.DisplayIndex, ингредиентыDataGridView.RowCount - 1].Value = 0;
            //MessageBox.Show(продуктыDataGridView[ID_продукта.DisplayIndex, продуктыDataGridView.RowCount- 1].Value.ToString());
        }

        private void ингредиентыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        bool Saved = true;

        //Блокировка/разблокировка кнопки - сохранить
        private void DataSaved(bool isSaved)
        {
            if (isSaved)
            {
                this.Text = Название;
                buttonSave.Enabled = false;
                Saved = true;
            }
            else
            {
                this.Text = Название + " (Не сохранено)";
                buttonSave.Enabled = true;
                Saved = false;
            }
        }

        //На загрузку формы
        private void EditIngredients_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.restaurantDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.restaurantDataSet.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.restaurantDataSet.Блюда);
            //Проходим по блюдам и ищем
            //  выделенное блюдо пользователем с формыы блюда
            //Нужно для загрузки картинки
            for (int i = 0; i < блюдаBindingSource.Count; i++)
            {
                блюдаBindingSource.Position = i;
                //MessageBox.Show(iD_блюдаTextBox.Text + " " + блюдаBindingSource.Position.ToString());
                if(iD_блюдаTextBox.Text == ID)
                {
                    break;
                }
            }
            продуктыDataGridView.Top = bindingNavigator1.Top + bindingNavigator1.Height;
            ингредиентыDataGridView.Top = продуктыDataGridView.Top + продуктыDataGridView.Height - ингредиентыDataGridView.Height;
            buttonProducts.Height = продуктыDataGridView.Top+1;
            this.Text = Название;
            FillProducts();
            DataSaved(true);
        }

        private void ингредиентыDataGridView_Sorted(object sender, EventArgs e)
        {
            FillProducts();
        }

        //Кнопка сохранить
        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ингредиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.restaurantDataSet.Ингредиенты);
            FillProducts();
            DataSaved(true);
        }

        private void ингредиентыDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {            
        }

        //Если пользователь отредактировал количество в таблице ингредиенты
        //  и оставил пустую ячейку, то ставим 0
        private void ингредиентыDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataSaved(false);
            try
            {
                if ((sender as DataGridView)[e.ColumnIndex, e.RowIndex].Value.ToString() == String.Empty)
                {
                    (sender as DataGridView)[e.ColumnIndex, e.RowIndex].Value = 0;
                }
            }
            catch(Exception ex) { }
        }

        private void ингредиентыDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataSaved(false);
        }

        //Если пользователь хочет закрыть форму с ингредиентами...
        private void EditIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {  //то если таблица не сохранена
            if (!Saved)
            {  //спрашиваем пользователя, хочет ли он сохранить
                DialogResult dg = MessageBox.Show("Вы хотите сохранить изменения?", "Изменения не сохранены!", MessageBoxButtons.YesNoCancel);
                if (dg == System.Windows.Forms.DialogResult.Cancel) { e.Cancel = true; }
                else if (dg == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Validate();
                    this.ингредиентыBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.restaurantDataSet);
                    DataSaved(true);
                }
            }
        }

        //Красная кнопка стрелка вправо
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ингредиентыDataGridView.RowCount > 0)
            { ингредиентыBindingSource.RemoveCurrent(); }
        }

        //Кнопка зелёный плюс в правом уголку
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            //Если были изменены ингредиенты, то требуем от пользователя сохранения
            // если он хочет менять список продуктов
            int Position = продуктыBindingSource.Position;
            DialogResult dg = 0;
            if (!Saved)
            {
                dg = MessageBox.Show( "Чтобы изменять продукты, необходимо сохранить изменения", "Сохранить изменения?", MessageBoxButtons.YesNo);
                if (dg == System.Windows.Forms.DialogResult.Yes) { buttonSave.PerformClick(); }
            }
            if ((Saved) || (dg == System.Windows.Forms.DialogResult.Yes))
            {   //Если изменений не было или пользователь сохранил изменения
                // то открываем форму с продуктами
                Products formProducts = new Products();
                formProducts.ShowDialog();
                // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Продукты". При необходимости она может быть перемещена или удалена.
                //Загружаем обновления данных в таблицу в форме ингредиенты
                this.продуктыTableAdapter.Fill(this.restaurantDataSet.Продукты);
                //Заполняем названия продуктов в таблице ингредиентов
                FillProducts();
            }
            if(Position <= продуктыBindingSource.Count)
            {
                продуктыBindingSource.Position = Position;
            } else if (продуктыBindingSource.Count>0)
            {
                продуктыBindingSource.Position = продуктыBindingSource.Count - 1;
            }
        }

        //Заполняем названия продуктов в таблице ингредиентов
        private void FillProducts()
        {
            string idIng;
            //Проходим по строкам таблицы ингредиентов
            for(int row=0;row<ингредиентыDataGridView.RowCount;row++)
            {
                //Берём ид продукта
                idIng = ингредиентыDataGridView[ID_ингредиента.DisplayIndex, row].Value.ToString();
                //Проходим по строкам таблицы продукты
                for (int rowProducts = 0; rowProducts < продуктыDataGridView.RowCount; rowProducts++)
                {   //Если ID совпадают
                    if(idIng == продуктыDataGridView[ID_продукта.DisplayIndex,rowProducts].Value.ToString())
                    {   //То вносим название продукта в таблицу ингредиентов
                        ингредиентыDataGridView[Ингредиент.DisplayIndex, row].Value = продуктыDataGridView[Продукт.DisplayIndex, rowProducts].Value;
                        break;
                    }
                }
            }
        }
    }
}
