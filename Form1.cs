using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace УП_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Закрытие формы

        public void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Добавление сотрудника

        private void label5_Click(object sender, EventArgs e)
        {

            // Закрытие первой формы и открытие второй
            
            Close();
            Form2 form2 = new Form2();
            form2.Owner=this;
            form2.Show();
        }

        // Удаление сотрудника

        private void label6_Click(object sender, EventArgs e)
        {

            // Закрытие первой формы и открытие пятой

            Close();
            Form5 form5 = new Form5();
            form5.Owner = this;
            form5.Show();
        }
    }
}
