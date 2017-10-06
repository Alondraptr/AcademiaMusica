using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;
using Negocio;


namespace Presentacion 
{
    public partial class Usuario_Rol : Form
    {
        public Usuario_Rol()
        {
            InitializeComponent();
            this.llenarcbUsuario();
            this.llenarcbRol();
        }

        #region Metodos de llenando de combobox
        public void llenarcbUsuario()
        {
            Negocio.Ng_Usuario ngu = new Negocio.Ng_Usuario();
            List<Entidades.Usuarios> listUsr = new List<Entidades.Usuarios>();
            listUsr = ngu.obtenerUsuario();
            cbUsuario.DataSource = listUsr;
            cbUsuario.DisplayMember= "Usuario";
            cbUsuario.ValueMember = "ID_Usuario";
            cbUsuario.SelectedIndex = 0;
            
        }
        public void llenarcbRol()
        {
            Negocio.Ng_Usuario_Roles ngu = new Negocio.Ng_Usuario_Roles();
            List<Entidades.Usuarios_Roles> listRol = new List<Entidades.Usuarios_Roles>();
            listRol = ngu.obtenerRol();
            cbusuarioRol.DataSource = listRol;
            cbUsuario.DisplayMember = "Rol";
            cbusuarioRol.ValueMember = "ID_URol";
            cbusuarioRol.SelectedIndex = 0;
        }
        #endregion

        #region Todas las llamadas a los frm

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
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios_Registro frm = new Usuarios_Registro();
            frm.Show();
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La elaboración de este sistema es gracias a : Douglas Prado, Ximena Silva y Alondra Téllez", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
#endregion

        
        /**
          public void llenar()
          {
             Negocio.Ng_V_Uusario_roles ngur = new  Negocio.Ng_V_Uusario_roles();
             List <Entidades.V_Uusario_roles> lvur = new List <Entidades.V_Uusario_roles>();
             lvur = ngur.Ng_V_Uusario_roles;
             dgvRolUsuario.AutoGenerateColumns=false;
             dgvRolUsuario.DataSource=lvur;
         
          }
        
         * Negocio.Ng_usario_roles ngur = new  Negocio.Ng_usario_roles();
         * Entidades.Rol_Usuario ru = new Entidades.Rol_Usuario();
         * ru.id_rol = Convert.ToInt32()this.cbroles.select;
         * ngu.nguardarRoles(ru);
         * */


    }
}
