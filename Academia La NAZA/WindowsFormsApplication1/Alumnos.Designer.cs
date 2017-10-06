namespace Presentacion
{
    partial class Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblnombre1;
            System.Windows.Forms.Label lblnombre2;
            System.Windows.Forms.Label lblapellido1;
            System.Windows.Forms.Label lblapellido2;
            System.Windows.Forms.Label lblbecaPorcentaje;
            System.Windows.Forms.Label lblbarrio;
            System.Windows.Forms.Label lbldepartamento;
            System.Windows.Forms.Label lbldirección;
            System.Windows.Forms.Label lblcel_Mov;
            System.Windows.Forms.Label lblcel_Claro;
            System.Windows.Forms.Label lbltelefono;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.lbxdireccion = new System.Windows.Forms.ListBox();
            this.txtbeca = new System.Windows.Forms.MaskedTextBox();
            this.txtcel_mov = new System.Windows.Forms.MaskedTextBox();
            this.txtcel_claro = new System.Windows.Forms.MaskedTextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDNAZA = new Datos.BDNAZADataSet();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.alumnosTableAdapter = new Datos.BDNAZADataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new Datos.BDNAZADataSetTableAdapters.TableAdapterManager();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evalucionesGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblnombre1 = new System.Windows.Forms.Label();
            lblnombre2 = new System.Windows.Forms.Label();
            lblapellido1 = new System.Windows.Forms.Label();
            lblapellido2 = new System.Windows.Forms.Label();
            lblbecaPorcentaje = new System.Windows.Forms.Label();
            lblbarrio = new System.Windows.Forms.Label();
            lbldepartamento = new System.Windows.Forms.Label();
            lbldirección = new System.Windows.Forms.Label();
            lblcel_Mov = new System.Windows.Forms.Label();
            lblcel_Claro = new System.Windows.Forms.Label();
            lbltelefono = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre1
            // 
            lblnombre1.AutoSize = true;
            lblnombre1.Location = new System.Drawing.Point(17, 21);
            lblnombre1.Name = "lblnombre1";
            lblnombre1.Size = new System.Drawing.Size(82, 13);
            lblnombre1.TabIndex = 0;
            lblnombre1.Text = "Primer Nombre :";
            // 
            // lblnombre2
            // 
            lblnombre2.AutoSize = true;
            lblnombre2.Location = new System.Drawing.Point(17, 51);
            lblnombre2.Name = "lblnombre2";
            lblnombre2.Size = new System.Drawing.Size(93, 13);
            lblnombre2.TabIndex = 2;
            lblnombre2.Text = "Segundo Nombre:";
            // 
            // lblapellido1
            // 
            lblapellido1.AutoSize = true;
            lblapellido1.Location = new System.Drawing.Point(20, 75);
            lblapellido1.Name = "lblapellido1";
            lblapellido1.Size = new System.Drawing.Size(79, 13);
            lblapellido1.TabIndex = 4;
            lblapellido1.Text = "Primer Apellido:";
            // 
            // lblapellido2
            // 
            lblapellido2.AutoSize = true;
            lblapellido2.Location = new System.Drawing.Point(17, 100);
            lblapellido2.Name = "lblapellido2";
            lblapellido2.Size = new System.Drawing.Size(93, 13);
            lblapellido2.TabIndex = 6;
            lblapellido2.Text = "Segundo Apellido:";
            // 
            // lblbecaPorcentaje
            // 
            lblbecaPorcentaje.AutoSize = true;
            lblbecaPorcentaje.Location = new System.Drawing.Point(21, 129);
            lblbecaPorcentaje.Name = "lblbecaPorcentaje";
            lblbecaPorcentaje.Size = new System.Drawing.Size(89, 13);
            lblbecaPorcentaje.TabIndex = 8;
            lblbecaPorcentaje.Text = "Beca Porcentaje:";
            // 
            // lblbarrio
            // 
            lblbarrio.AutoSize = true;
            lblbarrio.Location = new System.Drawing.Point(23, 249);
            lblbarrio.Name = "lblbarrio";
            lblbarrio.Size = new System.Drawing.Size(37, 13);
            lblbarrio.TabIndex = 16;
            lblbarrio.Text = "Barrio:";
            // 
            // lbldepartamento
            // 
            lbldepartamento.AutoSize = true;
            lbldepartamento.Location = new System.Drawing.Point(23, 282);
            lbldepartamento.Name = "lbldepartamento";
            lbldepartamento.Size = new System.Drawing.Size(77, 13);
            lbldepartamento.TabIndex = 18;
            lbldepartamento.Text = "Departamento:";
            // 
            // lbldirección
            // 
            lbldirección.AutoSize = true;
            lbldirección.Location = new System.Drawing.Point(20, 308);
            lbldirección.Name = "lbldirección";
            lbldirección.Size = new System.Drawing.Size(55, 13);
            lbldirección.TabIndex = 20;
            lbldirección.Text = "Dirección:";
            // 
            // lblcel_Mov
            // 
            lblcel_Mov.AutoSize = true;
            lblcel_Mov.Location = new System.Drawing.Point(26, 223);
            lblcel_Mov.Name = "lblcel_Mov";
            lblcel_Mov.Size = new System.Drawing.Size(49, 13);
            lblcel_Mov.TabIndex = 28;
            lblcel_Mov.Text = "Cel Mov:";
            // 
            // lblcel_Claro
            // 
            lblcel_Claro.AutoSize = true;
            lblcel_Claro.Location = new System.Drawing.Point(23, 188);
            lblcel_Claro.Name = "lblcel_Claro";
            lblcel_Claro.Size = new System.Drawing.Size(52, 13);
            lblcel_Claro.TabIndex = 27;
            lblcel_Claro.Text = "Cel Claro:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new System.Drawing.Point(23, 154);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new System.Drawing.Size(52, 13);
            lbltelefono.TabIndex = 26;
            lbltelefono.Text = "Telefono:";
            // 
            // pnlopciones
            // 
            this.pnlopciones.AllowDrop = true;
            this.pnlopciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlopciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlopciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlopciones.Location = new System.Drawing.Point(349, 84);
            this.pnlopciones.Name = "pnlopciones";
            this.pnlopciones.Size = new System.Drawing.Size(150, 254);
            this.pnlopciones.TabIndex = 0;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(19, 174);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 40);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(19, 107);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(112, 40);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(23, 35);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(112, 40);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // pnlformulario
            // 
            this.pnlformulario.Controls.Add(this.lbxdireccion);
            this.pnlformulario.Controls.Add(this.txtbeca);
            this.pnlformulario.Controls.Add(this.txtcel_mov);
            this.pnlformulario.Controls.Add(this.txtcel_claro);
            this.pnlformulario.Controls.Add(this.txttelefono);
            this.pnlformulario.Controls.Add(lblcel_Mov);
            this.pnlformulario.Controls.Add(lblcel_Claro);
            this.pnlformulario.Controls.Add(lbltelefono);
            this.pnlformulario.Controls.Add(this.cbestado);
            this.pnlformulario.Controls.Add(lbldirección);
            this.pnlformulario.Controls.Add(lbldepartamento);
            this.pnlformulario.Controls.Add(this.txtdepartamento);
            this.pnlformulario.Controls.Add(lblbarrio);
            this.pnlformulario.Controls.Add(this.txtbarrio);
            this.pnlformulario.Controls.Add(lblbecaPorcentaje);
            this.pnlformulario.Controls.Add(lblapellido2);
            this.pnlformulario.Controls.Add(this.txtapellido2);
            this.pnlformulario.Controls.Add(lblapellido1);
            this.pnlformulario.Controls.Add(this.txtapellido1);
            this.pnlformulario.Controls.Add(lblnombre2);
            this.pnlformulario.Controls.Add(this.txtnombre2);
            this.pnlformulario.Controls.Add(lblnombre1);
            this.pnlformulario.Controls.Add(this.txtnombre1);
            this.pnlformulario.Location = new System.Drawing.Point(12, 39);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(287, 402);
            this.pnlformulario.TabIndex = 1;
            // 
            // lbxdireccion
            // 
            this.lbxdireccion.Location = new System.Drawing.Point(80, 312);
            this.lbxdireccion.Name = "lbxdireccion";
            this.lbxdireccion.Size = new System.Drawing.Size(189, 43);
            this.lbxdireccion.TabIndex = 33;
            // 
            // txtbeca
            // 
            this.txtbeca.Location = new System.Drawing.Point(110, 127);
            this.txtbeca.Mask = "0%";
            this.txtbeca.Name = "txtbeca";
            this.txtbeca.Size = new System.Drawing.Size(33, 20);
            this.txtbeca.TabIndex = 32;
            // 
            // txtcel_mov
            // 
            this.txtcel_mov.Location = new System.Drawing.Point(76, 218);
            this.txtcel_mov.Mask = "0000-0000";
            this.txtcel_mov.Name = "txtcel_mov";
            this.txtcel_mov.Size = new System.Drawing.Size(67, 20);
            this.txtcel_mov.TabIndex = 31;
            // 
            // txtcel_claro
            // 
            this.txtcel_claro.Location = new System.Drawing.Point(78, 187);
            this.txtcel_claro.Mask = "0000-0000";
            this.txtcel_claro.Name = "txtcel_claro";
            this.txtcel_claro.Size = new System.Drawing.Size(65, 20);
            this.txtcel_claro.TabIndex = 30;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(80, 154);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(63, 20);
            this.txttelefono.TabIndex = 29;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumnosBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(26, 366);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(142, 24);
            this.cbestado.TabIndex = 23;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.bDNAZA;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Departamento", true));
            this.txtdepartamento.Location = new System.Drawing.Point(106, 279);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtdepartamento.TabIndex = 19;
            // 
            // txtbarrio
            // 
            this.txtbarrio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Barrio", true));
            this.txtbarrio.Location = new System.Drawing.Point(66, 246);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(100, 20);
            this.txtbarrio.TabIndex = 17;
            // 
            // txtapellido2
            // 
            this.txtapellido2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Apellido2", true));
            this.txtapellido2.Location = new System.Drawing.Point(116, 100);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(100, 20);
            this.txtapellido2.TabIndex = 7;
            // 
            // txtapellido1
            // 
            this.txtapellido1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Apellido1", true));
            this.txtapellido1.Location = new System.Drawing.Point(105, 74);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(100, 20);
            this.txtapellido1.TabIndex = 5;
            // 
            // txtnombre2
            // 
            this.txtnombre2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Nombre2", true));
            this.txtnombre2.Location = new System.Drawing.Point(116, 44);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(100, 20);
            this.txtnombre2.TabIndex = 3;
            // 
            // txtnombre1
            // 
            this.txtnombre1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Nombre1", true));
            this.txtnombre1.Location = new System.Drawing.Point(105, 18);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(100, 20);
            this.txtnombre1.TabIndex = 1;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasesTableAdapter = null;
            this.tableAdapterManager.Control_AsistenciaTableAdapter = null;
            this.tableAdapterManager.Detalle_AsistenciasTableAdapter = null;
            this.tableAdapterManager.Detalle_EvaluacionesTableAdapter = null;
            this.tableAdapterManager.Detalle_InstrumentoTableAdapter = null;
            this.tableAdapterManager.Detalle_Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.EvaluacionesTableAdapter = null;
            this.tableAdapterManager.GCPATableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.Instrumento_EvaluacionesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.Preguntas_CerradasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.Respuestas_CerradasTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Datos.BDNAZADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuario_RolesTableAdapter = null;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.secretariaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(525, 24);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem1,
            this.asistenciaToolStripMenuItem1,
            this.evalucionesGruposToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.alumnosToolStripMenuItem1.Text = "Alumnos";
            // 
            // asistenciaToolStripMenuItem1
            // 
            this.asistenciaToolStripMenuItem1.Name = "asistenciaToolStripMenuItem1";
            this.asistenciaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.asistenciaToolStripMenuItem1.Text = "Asistencia";
            // 
            // evalucionesGruposToolStripMenuItem
            // 
            this.evalucionesGruposToolStripMenuItem.Name = "evalucionesGruposToolStripMenuItem";
            this.evalucionesGruposToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.evalucionesGruposToolStripMenuItem.Text = "Evaluciones-Grupos";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.gCPAToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.profesoresToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogosToolStripMenuItem.Text = "Registros";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // gCPAToolStripMenuItem
            // 
            this.gCPAToolStripMenuItem.Name = "gCPAToolStripMenuItem";
            this.gCPAToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.gCPAToolStripMenuItem.Text = "GCPA";
            this.gCPAToolStripMenuItem.Click += new System.EventHandler(this.gCPAToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolToolStripMenuItem});
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.secretariaToolStripMenuItem.Text = "Secretaria";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            this.evaluacionesToolStripMenuItem.Click += new System.EventHandler(this.evaluacionesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 453);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private Datos.BDNAZADataSet bDNAZA;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private Datos.BDNAZADataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private Datos.BDNAZADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtbarrio;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evalucionesGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gCPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtbeca;
        private System.Windows.Forms.MaskedTextBox txtcel_mov;
        private System.Windows.Forms.MaskedTextBox txtcel_claro;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxdireccion;
    }
}