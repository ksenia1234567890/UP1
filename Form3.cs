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
using Npgsql.Internal.TypeHandlers.NumericHandlers;
using System.Data.SqlTypes;

namespace УП_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string title, description, limitations, safety, price, locus;
        public int count = 2021;

        // Сохранение данных об аттракционе и отправка данных в БД

        private void button1_Click(object sender, EventArgs e)
        {
            // Присваивание переменным - данные в БД - значений
            
            limitations = textBox7.Text;
            safety = textBox1.Text;
            price = textBox3.Text;
            locus = textBox2.Text;


            // Создание объекта форма 2 и присваивание переменным значений из второй формы

            Form2 form2 = new Form2();
            title = form2.title;
            description = form2.description;
           
            DatabaseInsert(count, title, description, limitations, safety, price, locus);
            count++;
        }

        // Метод, работающий с БД

        public void DatabaseInsert(int count, string title, string description, string limitations, string safety, string price, string locus)
        {

            // Подключение к БД

            string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park";
            NpgsqlConnection nc = new NpgsqlConnection(path);
            nc.Open();

            // Запрос на добавление данных

            NpgsqlCommand insert_command = new NpgsqlCommand($"select attractions_i({count},{title},{description},{limitations},{safety},{price},{locus})");
            insert_command.ExecuteNonQueryAsync();
        }

        // Переход к таблице в базе данных

        private void button4_Click(object sender, EventArgs e)
        {
            // Переход на форму 4

            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        // Закрытие формы 3 и открытие формы 2

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
