using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace College_items
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            FormPersonal fp = new FormPersonal();
            fp.ShowDialog();
        }

        private void button_auditories_Click(object sender, EventArgs e)
        {
            Form1 fa = new Form1();
            fa.ShowDialog();
        }

        private void button_Items_Click(object sender, EventArgs e)
        {
            Form_Items fi = new Form_Items();
            fi.ShowDialog();
        }

        private void button_Type_Items_Click(object sender, EventArgs e)
        {
            Form_Type_Items fti = new Form_Type_Items();
            fti.ShowDialog();
        }

        private void button_Information_Click(object sender, EventArgs e)
        {
            Form_Information fi = new Form_Information();
            fi.ShowDialog();
        }

        private void button_add_item_Click(object sender, EventArgs e)
        {
            Form_Add_Item fai = new Form_Add_Item();
            fai.ShowDialog();
        }
    }
}
