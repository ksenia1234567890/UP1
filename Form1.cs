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

        // Добавление аттракциона

        private void label5_Click(object sender, EventArgs e)
        {

            // Закрытие первой формы и открытие второй
            
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        // Удаление аттракциона

        private void label6_Click(object sender, EventArgs e)
        {

            // Закрытие первой формы и открытие пятой

            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
