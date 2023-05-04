using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace УП_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       public string title,description;
       

        // Переход к таблице в базе данных

        private void button3_Click(object sender, EventArgs e)
        {

            // Переход на форму 4

            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        // Нажатие на кнопку "Далее"

        private void button1_Click(object sender, EventArgs e)
        {

            // Сохранение данных и очистка текстовых полей

            title = textBox7.Text;
            description = textBox4.Text;
            textBox7.Clear();
            textBox4.Clear();
        }
    }
}
