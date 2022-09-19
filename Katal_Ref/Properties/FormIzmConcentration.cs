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
    public partial class FormIzmConcentration : Form
    {
        public FormIzmConcentration()
        {
            InitializeComponent();
        }

        private void FormIzmConcentration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1._Изменение_концентрации_". При необходимости она может быть перемещена или удалена.
            this.изменение_концентрации_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet._Изменение_концентрации_' table. You can move, or remove it, as needed.
            this.изменение_концентрации_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet._Изменение_концентрации_' table. You can move, or remove it, as needed.
            this.изменение_концентрации_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Изменение_концентрации_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изменениеконцентрацииBindingSource.EndEdit();
            this.изменение_концентрации_TableAdapter.Update(this.katal_Reform_DBDataSet1._Изменение_концентрации_);
        }
    }
}
