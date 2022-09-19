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
    public partial class FormIzmConcentration_Ustanovka : Form
    {
        public FormIzmConcentration_Ustanovka()
        {
            InitializeComponent();
        }

        private void FormIzmConcentration_Ustanovka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Установка". При необходимости она может быть перемещена или удалена.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1._Изменение_концентрации_". При необходимости она может быть перемещена или удалена.
            this.изменение_концентрации_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.ИзмКонц_Установка". При необходимости она может быть перемещена или удалена.
            this.измКонц_УстановкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet.Установка' table. You can move, or remove it, as needed.
            this.установкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet._Изменение_концентрации_' table. You can move, or remove it, as needed.
            this.изменение_концентрации_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet.ИзмКонц_Установка' table. You can move, or remove it, as needed.
            this.измКонц_УстановкаTableAdapter.Fill(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.измКонцУстановкаBindingSource.EndEdit();
            this.измКонц_УстановкаTableAdapter.Update(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);
        }
    }
}
