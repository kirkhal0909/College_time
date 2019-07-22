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
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
        }

        bool EnableEvents = false;

        string formCaption;

        //Событие - загрузка формы
        private void Dishes_Load(object sender, EventArgs e)
        {
            //Заносим название формы в переменную
            formCaption = this.Text;
            //Запрещаем пользователю взаимодействовать с формой
            this.Enabled = false;
            //Меняем название формы
            this.Text = formCaption+" (Загрузка записей)";

            //Загружаем данные из базы данных
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.restaurantDataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.restaurantDataSet.Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.restaurantDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.restaurantDataSet.Ингредиенты);
            КатегорииComboBox.Text = "";
            EnableEvents = true;
            //Вычисляем стоимость продуктов и заполняем значения в таблицу
            FillPrices();
            //FillProducts();
            //Возвращаем название формы
            this.Text = formCaption;
            //Разрешаем пользователю взаимодействовать с формой, после всей загрузки данных
            this.Enabled = true;
        }

        float Price = 0;

        //Функция вычисления стоимости продуктов
        private void FillProducts()
        {
            Price = 0;
            int row,rowProducts;
            string idProduct;
            //Проходим по каждой строке в таблице с ингредиентами
            for (row=0;row<ингредиентыDataGridView.RowCount;row++)
            {
                //Заносим id ингредиента в переменную
                idProduct = ингредиентыDataGridView.Rows[row].Cells[Ингредиенты_ID_продукта.DisplayIndex].Value.ToString();
                //Ищем этот id в скрытой таблице с продуктами
                for(rowProducts = 0; rowProducts < продуктыDataGridView.RowCount; rowProducts++)
                {   //Если нашли, то...
                    if (idProduct == продуктыDataGridView.Rows[rowProducts].Cells[Продукт_ИД_продукта.DisplayIndex].Value.ToString())
                    {
                        //в таблице ингредиентов заносим название и вычисляем стоимость
                        ингредиентыDataGridView.Rows[row].Cells[Продукт.DisplayIndex].Value = продуктыDataGridView.Rows[rowProducts].Cells[Продукт_.DisplayIndex].Value;
                        ингредиентыDataGridView.Rows[row].Cells[Стоимость_.DisplayIndex].Value = float.Parse(продуктыDataGridView.Rows[rowProducts].Cells[Продукт_Стоимость.DisplayIndex].Value.ToString())* float.Parse(ингредиентыDataGridView.Rows[row].Cells[Ингредиенты_Количество.DisplayIndex].Value.ToString());
                        ингредиентыDataGridView.Rows[row].Cells[Фото_ингредиента.DisplayIndex].Value = продуктыDataGridView.Rows[rowProducts].Cells[Фото_продукта.DisplayIndex].Value;

                        Price = Price + float.Parse(продуктыDataGridView.Rows[rowProducts].Cells[Продукт_Стоимость.DisplayIndex].Value.ToString()) * float.Parse(ингредиентыDataGridView.Rows[row].Cells[Ингредиенты_Количество.DisplayIndex].Value.ToString());
                    }
                }
                //MessageBox.Show(idProduct);
            }
            //Стоимость выбранного блюда в таблице, выводим пользователю в label
            labelPrice.Text = "Цена\nза продукты: " + Price.ToString();
            try
            {
                labelPrice.Text = labelPrice.Text + "\nза блюдо: " + (блюдаDataGridView.Rows[блюдаBindingSource.Position].Cells[Стоимость.DisplayIndex].Value.ToString());
            }
            catch (Exception ex) { }
            //if (блюдаDataGridView.Rows[блюдаDataGridView.CurrentCell.RowIndex].Cells[Стоимость.DisplayIndex] != null)
            //labelPrice.Text = labelPrice.Text + "\nза блюдо: " + (блюдаDataGridView.Rows[блюдаDataGridView.CurrentCell.RowIndex].Cells[Стоимость.DisplayIndex].Value.ToString());
        }

        //Функция занесения стоимости пордуктов в таблицу
        private void FillPrices()
        {
            //MessageBox.Show(блюдаDataGridView.RowCount.ToString());
            int row;
            //Проходим по каждой строке таблицы блюда
            for(row=0;row< блюдаDataGridView.RowCount;row++)
            {
                блюдаBindingSource.Position = row;
                //Вычисляем стоимость выбранного блюда  таблице
                FillProducts();
                //Заносим целую стоимость продукта в таблицу
                if (блюдаDataGridView.Rows[row].Cells[Добавка_к_цене.DisplayIndex].Value.ToString() != string.Empty)
                {
                    блюдаDataGridView.Rows[row].Cells[Стоимость.DisplayIndex].Value = (Price + float.Parse(блюдаDataGridView.Rows[row].Cells[Добавка_к_цене.DisplayIndex].Value.ToString())).ToString();
                } else
                {
                    блюдаDataGridView.Rows[row].Cells[Стоимость.DisplayIndex].Value = Price;
                }

                //блюдаDataGridView.Rows
            }
            if (блюдаDataGridView.RowCount > 0)
            {
                блюдаBindingSource.Position = 0;                
            }
        }

        private void КатегорииComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //Если категория поменялась, то меняем фильтр для отображения определённых блюд
            try
            {
                блюдаBindingSource.Filter = string.Format("ID_категории={0}", КатегорииComboBox.SelectedValue.ToString());
            
            //FillProducts();
            FillPrices();
            }
            catch (Exception ex) { }
        }

        private void блюдаBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Position changed");
            //MessageBox.Show(Ингредиенты_Количество.Displayed.ToString());
            //if (ингредиентыDataGridView.Rows[0].Cells["Ингредиенты_Количество"] == null) { MessageBox.Show("null"); }
            FillProducts();
        }

        private void блюдоLabel1_TextChanged(object sender, EventArgs e)
        {
            toolTipБлюдо.SetToolTip((sender as Label), (sender as Label).Text);            
        }

        private void категорииBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //FillProducts();
            FillPrices();
        }

        private void ингредиентыDataGridView_Sorted(object sender, EventArgs e)
        {
            FillProducts();
        }


        private void блюдаDataGridView_Sorted(object sender, EventArgs e)
        {
            FillPrices();
        }

    }
}
