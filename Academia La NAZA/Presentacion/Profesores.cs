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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void profesoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Profesores' table. You can move, or remove it, as needed.
            this.profesoresTableAdapter.Fill(this.bDNAZA.Profesores);

        }

       
    }
}
