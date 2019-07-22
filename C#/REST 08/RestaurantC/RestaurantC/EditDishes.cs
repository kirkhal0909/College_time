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
    public partial class EditDishes : Form
    {
        public EditDishes()
        {
            InitializeComponent();
        }

        bool firstSwitchSave = true;

        bool Saved = true;
        string nameForm = "Блюда";
        bool SwitchSave = true;

        //Функция для блокировки/разблокировки сохранения
        private void SavedDataSet(bool isSaved)
        {
            if (firstSwitchSave)
            {
                this.Text = nameForm;
                блюдаBindingNavigatorSaveItem.Enabled = false;
                Saved = true;
            }
            else if (SwitchSave)
            {    
                if (isSaved)
                {   //Сделать основное название формы
                    this.Text = nameForm;
                    //Разблокировать кнопку - сохранить
                    блюдаBindingNavigatorSaveItem.Enabled = false;
                    //Разблокировать кнопку - изменить ингредиенты
                    buttonChangeИнгредиенты.Enabled = true;
                    //Разблокировать ссылку - категория
                    linkLabel1.Enabled = true;
                    //Убрать надпись об невозможности редактировать категории/ингредиенты
                    linkLabel2.Visible = false;
                    Saved = true;                    
                }
                else
                {  //Добавить в надпись формы текст
                    this.Text = nameForm + " (НЕ СОХРАНЕНО)";
                    //Заблокировать кнопку - сохранить
                    блюдаBindingNavigatorSaveItem.Enabled = true;
                    //Заблокировать кнопку - изменить ингредиенты
                    buttonChangeИнгредиенты.Enabled = false;
                    //Заблокировать ссылку - категория
                    linkLabel1.Enabled = false;
                    //Показать надпись об невозможности редактировать категории/ингредиенты
                    linkLabel2.Visible = true;
                    Saved = false;
                }
            }
        }

        private void EditDishes_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.restaurantDataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.restaurantDataSet.Блюда);

            SavedDataSet(true);
            firstSwitchSave = false;
            SwitchSave = true;
        }

        //Кнопка сохранения
        private void блюдаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Делаем фокус на таблицу блюда, чтобы сохранились последние изменения
            блюдаDataGridView.Focus();
            //Проходим по таблице блюда
            for(int row = 0; row<блюдаDataGridView.RowCount;row++)
            {   //Если есть пустое поле...
                if(блюдаDataGridView[Название_блюда.DisplayIndex,row].Value.ToString()==string.Empty)
                {
                    //то переводим курсор на ячейку, где пусто и выводим сообщение пользователю
                    блюдаDataGridView.CurrentCell = блюдаDataGridView[Название_блюда.DisplayIndex, row];
                    MessageBox.Show("Данные не сохранены!\nНазвание блюда не может быть пустым.");
                    //Завершаем функцию
                    return;
                }
            }
            //Если цикл закончился, то пустых полей нет
            
            int Position = блюдаBindingSource.Position;
            //Делаем сохранение
            this.Validate();
            this.блюдаBindingSource.EndEdit();            
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.restaurantDataSet.Блюда);
            блюдаBindingSource.Position = Position;
            SwitchSave = true;
            SavedDataSet(true);

        }

        //Кнопка добавить изображение
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //SavedDataSet(false);
                фото_блюдаPictureBox.Image = Image.FromFile(ofd.FileName);
                SavedDataSet(false);
            }
        }

        //Кнопка удалить изображение
        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            фото_блюдаPictureBox.Image = null;
            SavedDataSet(false);
            //SavedDataSet(false);
        }

        //Кнопка измененить ингредиенты
        private void buttonChangeИнгредиенты_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(блюдаDataGridView.RowCount.ToString());

            //Если блюд в таблице > 0...
            if (блюдаDataGridView.RowCount > 0)
            {
                //то открываем форму редактирования ингредиентов для выбранного блюда
                //  и передаем ID и название блюда
                string ID = блюдаDataGridView.CurrentRow.Cells[ID_блюда.DisplayIndex].Value.ToString();
                string Название = блюдаDataGridView.CurrentRow.Cells[Название_блюда.DisplayIndex].Value.ToString();
                EditIngredients formEditIngredients = new EditIngredients(ID, Название);
                formEditIngredients.ShowDialog();
            } //Иначе выводим сообщение
            else { MessageBox.Show("Сначало нужно добавить блюдо!"); }
        }

        string currentIDблюда = "0", lastIDблюда = "0";

        private void блюдаDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            //MessageBox.Show("Changed");
        }

        private void блюдоTextBox_TextChanged(object sender, EventArgs e)
        {
            SavedDataSet(false);
        }

        private void добавка_к_ценеTextBox_TextChanged(object sender, EventArgs e)
        {
            SavedDataSet(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SavedDataSet(false);
        }

        private void блюдаBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            SwitchSave = false;
        }

        private void блюдаBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            SwitchSave = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string index = "-1";
            try
            {
                index = comboBox1.SelectedValue.ToString();
            }
            catch (Exception ex) {  }
            Categories formCategories = new Categories();
            formCategories.StartPosition = FormStartPosition.Manual;
            formCategories.Left = this.Left - 8;
            formCategories.Top = this.Top + 40;
            formCategories.ShowDialog();
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.restaurantDataSet.Категории);

            for(int indexItems=0; indexItems < comboBox1.Items.Count; indexItems++)
            {
                comboBox1.SelectedIndex = indexItems;
                if(comboBox1.SelectedValue.ToString() == index)
                {
                    SavedDataSet(true);
                    return;
                }
            }
            comboBox1.SelectedIndex = int.Parse(index);
            SavedDataSet(true);
        }

        //Если пользователь хочет закрыть форму с блюдами...
        private void EditDishes_FormClosing(object sender, FormClosingEventArgs e)
        {   //то если таблица не сохранена
            if (!Saved)
            {
                //спрашиваем пользователя, хочет ли он сохранить
                DialogResult dg = MessageBox.Show("Вы хотите сохранить изменения?", "Изменения не сохранены!", MessageBoxButtons.YesNoCancel);
                if (dg == System.Windows.Forms.DialogResult.Cancel) { e.Cancel = true; }
                else if (dg == System.Windows.Forms.DialogResult.Yes) { блюдаBindingNavigatorSaveItem.PerformClick(); }
            }
        }

        //Если пользователь кликает по длинной ссылке...
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //то спрашиваем, сохранить ли изменения
            DialogResult dg = MessageBox.Show("Вы хотите сохранить изменения?", "", MessageBoxButtons.YesNo);
            if (dg == System.Windows.Forms.DialogResult.Yes) { блюдаBindingNavigatorSaveItem.PerformClick(); }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {            
            //RemoveIngredients formRemoveIngredients = new RemoveIngredients(lastIDблюда);
            //formRemoveIngredients.Show();
            //MessageBox.Show("Removed");
        }

        private void блюдаDataGridView_CurrentCellChanged_2(object sender, EventArgs e)
        {

        }

        private void блюдаDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lastIDблюда = currentIDблюда;
            currentIDблюда = блюдаDataGridView[ID_блюда.DisplayIndex, блюдаDataGridView.CurrentRow.Index].Value.ToString();
            //MessageBox.Show(lastIDблюда);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(restaurantDataSet);
        }

        private void блюдаDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SwitchSave = true;
            SavedDataSet(false);
        }

        private void блюдаDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {            
        }
    }
}
