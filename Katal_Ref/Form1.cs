using Katal_Ref.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katal_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Установка". При необходимости она может быть перемещена или удалена.
            this.установкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1._Термодин_харак_". При необходимости она может быть перемещена или удалена.
            this.термодин_харак_TableAdapter1.Fill(this.katal_Reform_DBDataSet1._Термодин_харак_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Компоненты_Установка". При необходимости она может быть перемещена или удалена.
            this.компоненты_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты_Установка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.Компоненты". При необходимости она может быть перемещена или удалена.
            this.компонентыTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1.ИзмКонц_Установка". При необходимости она может быть перемещена или удалена.
            this.измКонц_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1._Изменение_концентрации_". При необходимости она может быть перемещена или удалена.
            this.изменение_концентрации_TableAdapter1.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Установка' table. You can move, or remove it, as needed.
            this.установкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1._Термодин_харак_' table. You can move, or remove it, as needed.
            this.термодин_харак_TableAdapter1.Fill(this.katal_Reform_DBDataSet1._Термодин_харак_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Сотрудники);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Компоненты_Установка' table. You can move, or remove it, as needed.
            this.компоненты_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Компоненты' table. You can move, or remove it, as needed.
            this.компонентыTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.ИзмКонц_Установка' table. You can move, or remove it, as needed.
            this.измКонц_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1._Изменение_концентрации_' table. You can move, or remove it, as needed.
            this.изменение_концентрации_TableAdapter1.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Сотрудники);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Компоненты_Установка' table. You can move, or remove it, as needed.
            this.компоненты_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.Компоненты' table. You can move, or remove it, as needed.
            this.компонентыTableAdapter1.Fill(this.katal_Reform_DBDataSet1.Компоненты);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1.ИзмКонц_Установка' table. You can move, or remove it, as needed.
            this.измКонц_УстановкаTableAdapter1.Fill(this.katal_Reform_DBDataSet1.ИзмКонц_Установка);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet1._Изменение_концентрации_' table. You can move, or remove it, as needed.
            this.изменение_концентрации_TableAdapter1.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);

        }

        private void установкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUstanovka myForm2 = new FormUstanovka();
            myForm2.Show();
        }

        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComponent myForm3 = new FormComponent();
            myForm3.Show();
        }

        private void изменениеКонцентрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzmConcentration myForm4 = new FormIzmConcentration();
            myForm4.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSotrudniki myForm5 = new FormSotrudniki();
            myForm5.Show();
        }

        private void термодинамическиеХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTermodinHarak myForm6 = new FormTermodinHarak();
            myForm6.Show();
        }

        private void измКонцУстановкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzmConcentration_Ustanovka myForm6 = new FormIzmConcentration_Ustanovka();
            myForm6.Show();
        }

        private void компонентыУстановкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComponent_Ustanovka myForm7 = new FormComponent_Ustanovka();
            myForm7.Show();
        }

        private void работаСПроцедурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedComponent myForm8 = new FormProcedComponent();
            myForm8.Show();
        }
    }
}
