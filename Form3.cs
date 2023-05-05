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

        public string count, title, description, limitations, safety, price, locus;

        // Кнопка "Сохранить"

        // Отправка данных в БД

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Присваивание переменным - данные в БД - значений

            title = textBox7.Text;
            description = textBox1.Text;
            limitations = textBox2.Text;
            safety = textBox3.Text;
            price = textBox4.Text;
            locus = textBox5.Text;

            DatabaseInsert(count, title, description, limitations, safety, price, locus);
            MessageBox.Show("Аттракцион сохранен в базе данных");
        }


        // Метод, работающий с БД

        public void DatabaseInsert(string count, string title, string description, string limitations, string safety, string price, string locus)
        {

            // Подключение к БД

            string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park";
            NpgsqlConnection nc = new NpgsqlConnection(path);
            nc.Open();

            // Запрос на добавление данных

            NpgsqlCommand insert_command = new NpgsqlCommand($"select attractions_i({count},{title},{description},{limitations},{safety},{price},{locus})", nc);
            insert_command.Parameters.AddWithValue("@attraction_code", NpgsqlTypes.NpgsqlDbType.Numeric).Value = count;
            insert_command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Varchar).Value = title;
            insert_command.Parameters.AddWithValue("@description", NpgsqlTypes.NpgsqlDbType.Varchar).Value = description;
            insert_command.Parameters.AddWithValue("@limitations", NpgsqlTypes.NpgsqlDbType.Varchar).Value = limitations;
            insert_command.Parameters.AddWithValue("@safety", NpgsqlTypes.NpgsqlDbType.Varchar).Value = safety;
            insert_command.Parameters.AddWithValue("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
            insert_command.Parameters.AddWithValue("@locus", NpgsqlTypes.NpgsqlDbType.Varchar).Value = locus;
            int result = insert_command.ExecuteNonQuery();
            MessageBox.Show("Операция завершилась: ", result.ToString());
            nc.Close();
        }

        // Метод, проверяющий все идентификаторы

        public void CheckCount(string count)
        {
            // Подключение к БД

            NpgsqlConnection nc = new NpgsqlConnection();
            nc.Open();

            // Перебираем все ID аттракцонов

            NpgsqlCommand read_command = new NpgsqlCommand("select attarction_code from attractions");
            NpgsqlDataReader reader = read_command.ExecuteReader();

            while (reader.Read())
            {

                // Если значение из столбца равно значению пользователя - исключение

                if (reader.GetString(0)==count)
                {
                    throw new Exception("Данный идентификатор уже существует");
                }

            }
            nc.Close();
        }

        // Проверка на наличие данных

        public void CheckLines(string title, string description, string limitations, string safety, string locus)
        {
            
            // Если значение пустое - исключение
            
            if (string.IsNullOrEmpty(title)) 
            {
                throw new Exception("Аттракциону не дано название!");
            }

            if (string.IsNullOrEmpty(locus))
            {
                throw new Exception("Не указана локация");
            }

            if (string.IsNullOrEmpty(safety))
            {
                throw new Exception("Не прописаны меры безопасности");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new Exception("Нет описания аттракциона");
            }

            if (string.IsNullOrEmpty(limitations))
            {
                throw new Exception("Не указаны ограничения на посещение аттракциона");
            }
        }

        // Проверка языка

        public void CheckLanguages(string title, string description, string limitations, string safety, string locus)
        {
            string eng = "qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < eng.Length; i++)
            {
                // Если в поле есть буква англиского алфавита - исключение
                
                if (title.Contains(eng[i]))
                {
                    throw new Exception("В названии аттракциона используется английский язык");
                }
                if (description.Contains(eng[i]))
                {
                    throw new Exception("В названии аттракциона используется английский язык");
                }
                if (limitations.Contains(eng[i]))
                {
                    throw new Exception("В названии аттракциона используется английский язык");
                }
                if (safety.Contains(eng[i]))
                {
                    throw new Exception("В названии аттракциона используется английский язык");
                }
                if (locus.Contains(eng[i]))
                {
                    throw new Exception("В названии аттракциона используется английский язык");
                }
            }
        }

        // Проверка числовых полей

        public void CheckNumeric(string numeric)
        {
            string numbs = "1234567890";
            for(int i=0; i<numeric.Length;i++)
            {
                for(int j=0; j<numbs.Length;j++)
                {
                    if (numeric[i] != numbs[j])
                    {
                        throw new Exception("Некорректно прописано числовое поле");
                    }
                }
                
            }
            
        }
    }
}
