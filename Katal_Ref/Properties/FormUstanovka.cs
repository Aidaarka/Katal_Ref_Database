using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katal_Ref.Properties
{
    public partial class FormUstanovka : Form
    {
        public FormUstanovka()
        {
            InitializeComponent();
        }

        private void FormUstanovka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Установка". При необходимости она может быть перемещена или удалена.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet.Установка' table. You can move, or remove it, as needed.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.установкаBindingSource.EndEdit();
            this.установкаTableAdapter.Update(this.katal_Reform_DBDataSet1.Установка);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Наименование_установки LIKE'%" + textBox8.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Год_открытия_устанвки = " + Convert.ToInt32(textBox9.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Местоположение LIKE'%" + textBox10.Text + "%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Производительность = " + Convert.ToDouble(textBox11.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Давление = " + Convert.ToDouble(textBox12.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            установкаBindingSource.Filter = "Температура_кипения = " + Convert.ToInt32(textBox13.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            установкаBindingSource.Filter = null;
        }
    }
}
