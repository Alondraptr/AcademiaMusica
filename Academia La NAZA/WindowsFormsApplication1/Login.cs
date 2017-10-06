using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            /**
            Ng_Usuario ngu = new Negocio.Ng_Usuario();
            Entidades.Usuarios usr = new Entidades.Usuarios();
            int x=0;
            usr.Usuario = txtusuario.Text;
            usr.Contrasena = txtcontra.Text;
            x = ngu.GuardarUsuario(usr);
            if (x > 0)
            {
                String msj = "Usuario guardado con exito!!!";
                MessageBox.Show(msj);
            }
            else
            {
                String msj = "Error al guardar usuario";
                MessageBox.Show(msj);
            }
            **/
            /**
            try
            {
                //creando la conexion
                SqlConnection miConecion = new SqlConnection(@"server=.; Initial Catalog = BDNAZA; Integrated Security=True;");
                //abriendo conexion
                miConecion.Open();

                SqlCommand comando = new SqlCommand("select usuario, contraseña from Usuarios where usuario = '" + txtusuario.Text + "'And contrasena = '" + txtcontra.Text + "' ", miConecion);

                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "Usuarios");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["Usuarios"].Rows[0];

                //evaluando que la contraseña y usuario sean correctos
                if ((txtusuario.Text == DR["usuario"].ToString()) || (txtcontra.Text == DR["contrasena"].ToString()))
                {
                    //instanciando el formulario principal
                    Menu frm = new Menu();
                    frm.Show();
                    this.Hide();
                }

            }
            catch
            {
              MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            **/
            this.Hide();
           Menu frm = new Menu();
            frm.Show();

        }


       
    }
}
