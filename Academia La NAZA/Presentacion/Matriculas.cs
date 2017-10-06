using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Matriculas : Form
    {
        public Matriculas()
        {
            InitializeComponent();
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Matriculas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Matriculas' table. You can move, or remove it, as needed.
            this.matriculasTableAdapter.Fill(this.bDNAZA.Matriculas);

        }
    }
}
