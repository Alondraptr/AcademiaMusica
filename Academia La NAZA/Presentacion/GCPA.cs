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
    public partial class GCPA : Form
    {
        public GCPA()
        {
            InitializeComponent();
        }

        private void gCPABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gCPABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void GCPA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.GCPA' table. You can move, or remove it, as needed.
            this.gCPATableAdapter.Fill(this.bDNAZA.GCPA);

        }


    }
}
