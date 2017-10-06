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
    public partial class Evaluaciones : Form
    {
        public Evaluaciones()
        {
            InitializeComponent();
        }

        private void evaluacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.evaluacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Evaluaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Evaluaciones' table. You can move, or remove it, as needed.
            this.evaluacionesTableAdapter.Fill(this.bDNAZA.Evaluaciones);

        }
    }
}
