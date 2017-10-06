using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Matriculas : Form
    {
        public Matriculas()
        {
            InitializeComponent();
            this.llenarcbalumno();
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

         public void llenarcbalumno()
        {
            Negocio.Ng_Alumnos nga = new Negocio.Ng_Alumnos();
            List<Entidades.Alumnos> listAlm = new List<Entidades.Alumnos>();
            listAlm = nga.obtenerAlumno();
            cbalumno.DataSource = listAlm;
            cbalumno.DisplayMember = "Nombre1";
            cbalumno.ValueMember = "ID_Alumno";
            cbalumno.SelectedIndex = 0;

        }

        #region Todas las llamadas a los frm

         private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios_Registro frm = new Usuarios_Registro();
            frm.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
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

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos frm = new Alumnos();
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

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_Rol frm = new Usuario_Rol();
            frm.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La elaboración de este sistema es gracias a : Douglas Prado, Ximena Silva y Alondra Téllez", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

#endregion

        
    }
}
