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

namespace УП_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Выход из формы 

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Появление формы "Удаление сотрудника"

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(); 
        }

        // Появление формы "Добавление сотрудника"

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        // Редактирование информации об аттракционе

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Создание объекта Форма2 и открытие формы 2 для редактирования
            
            Form2 correct = new Form2();
            correct.Text = "Редактирование аттракциона";
            TextBox search = new TextBox();
            search.Parent = correct;
            search.Location = new Point(345, 337);
            search.Size = new Size(83, 20);
            Label descr = new Label();
            descr.Parent = correct;
            descr.Text = "Введите ID аттракциона";
            correct.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "amusement_parkDataSet.attractions". При необходимости она может быть перемещена или удалена.
            this.attractionsTableAdapter.Fill(this.amusement_parkDataSet.attractions);

        }
    }
}
