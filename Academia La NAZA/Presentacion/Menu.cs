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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos frm = new Alumnos();
            frm.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matriculas frm = new Matriculas();
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos frm = new Pagos();
            frm.Show();
        }

        private void gCPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GCPA frm = new GCPA();
            frm.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grupos frm = new Grupos();
            frm.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores frm = new Profesores();
            frm.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencia frm = new Asistencia();
            frm.Show();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluaciones frm = new Evaluaciones();
            frm.Show();
        }

       
    }
}
