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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Alumnos' table. You can move, or remove it, as needed.
            this.alumnosTableAdapter.Fill(this.bDNAZA.Alumnos);

        }

        private void pnlformulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
