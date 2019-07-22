using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Furniture_accounting_orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Сохранение изменений в таблицу категорий в базу данных
        private void saveCategoriesTable()
        {
            this.Validate();
            this.категорииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ordersDataSet);
        }

        //Сохранение изменений в таблицу мебель в базу данных
        private void saveFurnitureTable()
        {
            this.Validate();
            this.мебельBindingSource.EndEdit();
            this.Validate();
            this.категорииBindingSource.EndEdit();
            
            this.tableAdapterManager.UpdateAll(this.ordersDataSet);
        }

        //Загрузка данных при открытии формы  
        private void Form1_Load(object sender, EventArgs e)
        {          
            this.мебельTableAdapter.Fill(this.ordersDataSet.Мебель);            
            this.категорииTableAdapter.Fill(this.ordersDataSet.Категории);
        }

        //Кнопка добавления/редактирования категории
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string input_category = textBoxAddCategory.Text;
            if (input_category.Length==0)
            {
                MessageBox.Show("Введите название категории");
            }
            else
            {                
                if (editNowCategory)
                {
                    if (textBoxAddCategory.Text.Length > 0)
                    {
                        this.категорииTableAdapter.Fill(this.ordersDataSet.Категории);

                        категорииDataGridView.Rows[editNowCategoryPosition].Cells[dataGridViewTextBoxColumnКатегория.DisplayIndex].Value = textBoxAddCategory.Text;
                        saveCategoriesTable();
                        editCategory();
                    }
                }
                else
                {
                    категорииBindingSource.AddNew();
                    категорииDataGridView.Rows[категорииDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnКатегория.DisplayIndex].Value = input_category;
                    saveCategoriesTable();
                    textBoxAddCategory.Text = "";
                }
            }
        }
        //Кнопка удаления категории
        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            //категорииDataGridView.Rows.RemoveAt(категорииDataGridView.SelectedRows[0].Index);
            if (категорииBindingSource.Position >= 0)
            {
                if (мебельBindingSource.Count == 0)
                {
                    int position_category_remove = категорииBindingSource.Position;
                    this.категорииTableAdapter.Fill(this.ordersDataSet.Категории);
                    категорииBindingSource.RemoveAt(position_category_remove);
                    saveCategoriesTable();
                }
                else
                {
                    MessageBox.Show("Для удаления категории необходимо удалить всю мебель");
                }
            }
        }

        private bool editNowCategory = false;
        private int editNowCategoryPosition = -1;

        //Переключатель кнопок для редактирования категорий
        private void editCategory()
        {
            if (buttonEditCategory.Enabled)
            {
                buttonAddCategory.Text = "Редактировать";
                editNowCategoryPosition = категорииBindingSource.Position;
                textBoxAddCategory.Text = категорииDataGridView.Rows[editNowCategoryPosition].Cells[dataGridViewTextBoxColumnКатегория.DisplayIndex].Value.ToString();
                editNowCategory = true;                
            }
            else
            {
                buttonAddCategory.Text = "Добавить категорию";
                textBoxAddCategory.Text = "";
                editNowCategory = false;
                editNowCategoryPosition = -1;
            }
                            
            buttonEditCategory.Enabled = !buttonEditCategory.Enabled;
            buttonRemoveCategory.Enabled = !buttonRemoveCategory.Enabled;
        }

        private bool editNowFurniture = false;
        private int editNowFurniturePosition = -1;

        //Переключатель кнопок для редактирования мебели
        private void editFurniture()
        {            
            if (buttonEditFurniture.Enabled)
            {
                buttonAddFurniture.Text = "Редактировать";
                editNowFurniturePosition = мебельBindingSource.Position;
                textBoxFurnitureName.Text = мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurnitureName.DisplayIndex].Value.ToString();
                textBoxPriceFurniture.Text = мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurniturePrice.DisplayIndex].Value.ToString();
                textBoxDescriptionFurniture.Text = мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurnitureDescription.DisplayIndex].Value.ToString();
                editNowFurniture = true;
            }
            else
            {
                buttonAddFurniture.Text = "Добавить мебель";
                textBoxFurnitureName.Text = "";
                textBoxPriceFurniture.Text = "";
                textBoxDescriptionFurniture.Text = "";
                editNowFurniture = false;
                editNowFurniturePosition = -1;
            }

            buttonEditFurniture.Enabled = !buttonEditFurniture.Enabled;
            buttonRemoveFurniture.Enabled = !buttonRemoveFurniture.Enabled;
        }

        //Кнопка - редактировать категорию
        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (категорииBindingSource.Position >= 0)
            {
                editCategory();
            }
        }

        //удаление мебели
        private void buttonRemoveFurniture_Click(object sender, EventArgs e)
        {
            if (мебельBindingSource.Position >= 0)
            {                
                    int position_furniture_remove = мебельBindingSource.Position;
                    this.мебельTableAdapter.Fill(this.ordersDataSet.Мебель);
                    мебельBindingSource.RemoveAt(position_furniture_remove);
                    try
                    {
                        saveFurnitureTable();                        
                    }
                    catch
                    {
                        this.мебельTableAdapter.Fill(this.ordersDataSet.Мебель);
                        MessageBox.Show("Невозможно удалить из-за связей");                        
                    }
            }
        }

        //Добавление/редактирование мебели
        private void buttonAddFurniture_Click(object sender, EventArgs e)
        {
            string input_name = textBoxFurnitureName.Text;
            string input_price = textBoxPriceFurniture.Text;
            string input_description = textBoxDescriptionFurniture.Text;
            if (input_name.Length == 0)
            {
                MessageBox.Show("Введите название мебели");
            }
            else if(input_price.Length == 0)
            {
                MessageBox.Show("Введите стоимость мебели");
            }
            else
            {                
                if (editNowFurniture)
                {
                    this.мебельTableAdapter.Fill(this.ordersDataSet.Мебель);

                    мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurnitureDescription.DisplayIndex].Value = input_description;
                    мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurnitureName.DisplayIndex].Value = input_name;
                    мебельDataGridView.Rows[editNowFurniturePosition].Cells[dataGridViewTextBoxColumnFurniturePrice.DisplayIndex].Value = input_price;


                    saveFurnitureTable();
                    editFurniture();                    
                }
                else
                {
                    мебельBindingSource.AddNew();
                    мебельDataGridView.Rows[мебельDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnFurnitureDescription.DisplayIndex].Value = input_description;
                    мебельDataGridView.Rows[мебельDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnFurnitureName.DisplayIndex].Value = input_name;
                    мебельDataGridView.Rows[мебельDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnFurniturePrice.DisplayIndex].Value = input_price;                    
                    saveFurnitureTable();

                    textBoxFurnitureName.Text = "";
                    textBoxPriceFurniture.Text = "";
                    textBoxDescriptionFurniture.Text = "";
                }
            }
        }

        //Кнопка - Редактировать выделенную мебель
        private void buttonEditFurniture_Click(object sender, EventArgs e)
        {
            if (мебельBindingSource.Position >= 0)
            {
                editFurniture();
            }
        }
    }
}
