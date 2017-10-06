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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void pagosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Pagos' table. You can move, or remove it, as needed.
            this.pagosTableAdapter.Fill(this.bDNAZA.Pagos);

        }
    }
}
