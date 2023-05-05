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

        // Появление формы "Удаление аттракциона"

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog(); 
        }

        // Появление формы "Добавление аттракциона"

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        // Редактирование информации об аттракционе

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Создание объекта Форма2 и открытие формы 2 для редактирования
            
            Form5 correct = new Form5();
            correct.Text = "Редактирование аттракциона";
            TextBox search = new TextBox();
            search.Parent = correct;
            search.Location = new Point(345, 337);
            search.Size = new Size(83, 20);
            Label descr = new Label();
            descr.Parent = correct;
            descr.Location = new Point(345, 337);
            descr.Size = new Size(83, 20);
            descr.Text = "Введите ID аттракциона";
            correct.ShowDialog();

            // Редактирование
            //NpgsqlConnection nc = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park");
            //nc.Open();
            //NpgsqlCommand update_command = new NpgsqlCommand($"select attractions_u({count},{price})",nc);
            //update_command.Parameters.AddWithValue("@attraction_code", NpgsqlTypes.NpgsqlDbType.Numeric).Value = count;
            //update_command.Parameters.AddWithValue("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
        }

    }
}
