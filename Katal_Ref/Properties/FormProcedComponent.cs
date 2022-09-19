using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katal_Ref.Properties
{
    public partial class FormProcedComponent : Form
    {
        public FormProcedComponent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Введенные данные записываются в переменные textBox
            sqlCommand1.Parameters["@VvodMolarMassa1"].Value = textBox1.Text; 
            sqlCommand1.Parameters["@VvodMolarMassa2"].Value = textBox2.Text; 

            //Подключение к БД
            sqlConnection1.Open();

            //Активация процедуры, передача считанных textBox в SQL-запрос
            string query = $"EXEC Component {textBox1.Text}, {textBox2.Text}";

            //Передача SQL-запроса в СУБД
            SqlCommand command = new SqlCommand(query, sqlConnection1);

            //Считывание данных из БД
            SqlDataReader reader = command.ExecuteReader();

            //Создание пустого списка List 
            List<string[]> data = new List<string[]>();

            //Запись считанных данных в список List
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            //Прекращение считывания данных 
            reader.Close();

            sqlCommand1.ExecuteNonQuery();

            // Подключение к БД 
            sqlConnection1.Close();

            //Вывод списка в элементe DataGridView
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }
    }
}

