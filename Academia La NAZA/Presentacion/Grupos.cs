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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void gruposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Grupos' table. You can move, or remove it, as needed.
            this.gruposTableAdapter.Fill(this.bDNAZA.Grupos);

        }
    }
}
