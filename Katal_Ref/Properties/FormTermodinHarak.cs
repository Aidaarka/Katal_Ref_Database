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
    public partial class FormTermodinHarak : Form
    {
        public FormTermodinHarak()
        {
            InitializeComponent();
        }

        private void FormTermodinHarak_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "katal_Reform_DBDataSet1._Термодин_харак_". При необходимости она может быть перемещена или удалена.
            this.термодин_харак_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Термодин_харак_);
            // TODO: This line of code loads data into the 'katal_Reform_DBDataSet._Термодин_харак_' table. You can move, or remove it, as needed.
            this.термодин_харак_TableAdapter.Fill(this.katal_Reform_DBDataSet1._Термодин_харак_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.термодинхаракBindingSource.EndEdit();
            this.термодин_харак_TableAdapter.Update(this.katal_Reform_DBDataSet1._Термодин_харак_);
        }
    }
}
