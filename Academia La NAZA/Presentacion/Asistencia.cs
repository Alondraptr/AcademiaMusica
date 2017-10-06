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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void control_AsistenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.control_AsistenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDNAZA);

        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDNAZA.Control_Asistencia' table. You can move, or remove it, as needed.
            this.control_AsistenciaTableAdapter.Fill(this.bDNAZA.Control_Asistencia);

        }
    }
}
