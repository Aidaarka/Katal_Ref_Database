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
    public partial class FormComponent_Ustanovka : Form
    {
        public FormComponent_Ustanovka()
        {
            InitializeComponent();
        }

        private void FormComponent_Ustanovka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Установка". При необходимости она может быть перемещена или удалена.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Компоненты_Установка". При необходимости она может быть перемещена или удалена.
            this.компоненты_УстановкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Компоненты_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet.Установка' table. You can move, or remove it, as needed.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet.Компоненты_Установка' table. You can move, or remove it, as needed.
            this.компоненты_УстановкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Компоненты_Установка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.компонентыУстановкаBindingSource.EndEdit();
            this.компоненты_УстановкаTableAdapter.Update(this.katal_Reform_DBDataSet1.Компоненты_Установка);
        }
    }
}
