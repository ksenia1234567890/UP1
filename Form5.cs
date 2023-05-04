using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using NpgsqlTypes; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Удаление аттракциона из БД

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание соединения с БД

            NpgsqlConnection delete_connect = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park");
            delete_connect.Open();

            int attraction_id = int.Parse(textBox1.Text);

            NpgsqlCommand delete_command = new NpgsqlCommand($"select attractions_d({attraction_id})" );
            delete_command.Parameters.Add($"{attraction_id}", NpgsqlDbType.Numeric).Value = attraction_id;
        }

       

    }
}
