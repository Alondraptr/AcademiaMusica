

namespace Presentacion
{
    partial class Asistencia
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
            System.Windows.Forms.Label lblprofesor;
            System.Windows.Forms.Label lblclase;
            System.Windows.Forms.Label lblgrupo;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label lblalumno;
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.rbasistio = new System.Windows.Forms.RadioButton();
            this.cbalumno = new System.Windows.Forms.ComboBox();
            this.cbclase = new System.Windows.Forms.ComboBox();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.cbprofesor = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.control_AsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDNAZA = new Datos.BDNAZADataSet();
            this.control_AsistenciaTableAdapter = new Datos.BDNAZADataSetTableAdapters.Control_AsistenciaTableAdapter();
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
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            lblprofesor = new System.Windows.Forms.Label();
            lblclase = new System.Windows.Forms.Label();
            lblgrupo = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            lblalumno = new System.Windows.Forms.Label();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.control_AsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            this.msMenu.SuspendLayout();
            this.pnlopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblprofesor
            // 
            lblprofesor.AutoSize = true;
            lblprofesor.Location = new System.Drawing.Point(21, 65);
            lblprofesor.Name = "lblprofesor";
            lblprofesor.Size = new System.Drawing.Size(49, 13);
            lblprofesor.TabIndex = 0;
            lblprofesor.Text = "Profesor:";
            // 
            // lblclase
            // 
            lblclase.AutoSize = true;
            lblclase.Location = new System.Drawing.Point(21, 101);
            lblclase.Name = "lblclase";
            lblclase.Size = new System.Drawing.Size(36, 13);
            lblclase.TabIndex = 2;
            lblclase.Text = "Clase:";
            // 
            // lblgrupo
            // 
            lblgrupo.AutoSize = true;
            lblgrupo.Location = new System.Drawing.Point(21, 135);
            lblgrupo.Name = "lblgrupo";
            lblgrupo.Size = new System.Drawing.Size(39, 13);
            lblgrupo.TabIndex = 4;
            lblgrupo.Text = "Grupo:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 179);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha:";
            // 
            // lblalumno
            // 
            lblalumno.AutoSize = true;
            lblalumno.Location = new System.Drawing.Point(21, 28);
            lblalumno.Name = "lblalumno";
            lblalumno.Size = new System.Drawing.Size(48, 13);
            lblalumno.TabIndex = 11;
            lblalumno.Text = "Alumno: ";
            // 
            // pnlformulario
            // 
            this.pnlformulario.Controls.Add(this.rbasistio);
            this.pnlformulario.Controls.Add(this.cbalumno);
            this.pnlformulario.Controls.Add(lblalumno);
            this.pnlformulario.Controls.Add(this.cbclase);
            this.pnlformulario.Controls.Add(this.cbgrupo);
            this.pnlformulario.Controls.Add(this.cbprofesor);
            this.pnlformulario.Controls.Add(fechaLabel);
            this.pnlformulario.Controls.Add(this.fechaDateTimePicker);
            this.pnlformulario.Controls.Add(lblgrupo);
            this.pnlformulario.Controls.Add(lblclase);
            this.pnlformulario.Controls.Add(lblprofesor);
            this.pnlformulario.Location = new System.Drawing.Point(12, 38);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(349, 268);
            this.pnlformulario.TabIndex = 3;
            // 
            // rbasistio
            // 
            this.rbasistio.AutoSize = true;
            this.rbasistio.Location = new System.Drawing.Point(70, 223);
            this.rbasistio.Name = "rbasistio";
            this.rbasistio.Size = new System.Drawing.Size(55, 17);
            this.rbasistio.TabIndex = 14;
            this.rbasistio.TabStop = true;
            this.rbasistio.Text = "Asistio";
            this.rbasistio.UseVisualStyleBackColor = true;
            // 
            // cbalumno
            // 
            this.cbalumno.FormattingEnabled = true;
            this.cbalumno.Location = new System.Drawing.Point(78, 23);
            this.cbalumno.Name = "cbalumno";
            this.cbalumno.Size = new System.Drawing.Size(135, 21);
            this.cbalumno.TabIndex = 12;
            // 
            // cbclase
            // 
            this.cbclase.FormattingEnabled = true;
            this.cbclase.Location = new System.Drawing.Point(78, 99);
            this.cbclase.Name = "cbclase";
            this.cbclase.Size = new System.Drawing.Size(135, 21);
            this.cbclase.TabIndex = 10;
            // 
            // cbgrupo
            // 
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(78, 135);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(135, 21);
            this.cbgrupo.TabIndex = 9;
            // 
            // cbprofesor
            // 
            this.cbprofesor.FormattingEnabled = true;
            this.cbprofesor.Location = new System.Drawing.Point(78, 60);
            this.cbprofesor.Name = "cbprofesor";
            this.cbprofesor.Size = new System.Drawing.Size(135, 21);
            this.cbprofesor.TabIndex = 8;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.control_AsistenciaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(70, 175);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // control_AsistenciaBindingSource
            // 
            this.control_AsistenciaBindingSource.DataMember = "Control_Asistencia";
            this.control_AsistenciaBindingSource.DataSource = this.bDNAZA;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // control_AsistenciaTableAdapter
            // 
            this.control_AsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasesTableAdapter = null;
            this.tableAdapterManager.Control_AsistenciaTableAdapter = this.control_AsistenciaTableAdapter;
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
            this.msMenu.Size = new System.Drawing.Size(557, 24);
            this.msMenu.TabIndex = 4;
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
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // pnlopciones
            // 
            this.pnlopciones.AllowDrop = true;
            this.pnlopciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlopciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlopciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlopciones.Location = new System.Drawing.Point(395, 38);
            this.pnlopciones.Name = "pnlopciones";
            this.pnlopciones.Size = new System.Drawing.Size(150, 254);
            this.pnlopciones.TabIndex = 5;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(19, 145);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(112, 40);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(23, 73);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(112, 40);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 318);
            this.Controls.Add(this.pnlopciones);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pnlformulario);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.control_AsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnlopciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlformulario;
        private Datos.BDNAZADataSet bDNAZA;
        private System.Windows.Forms.BindingSource control_AsistenciaBindingSource;
        private Datos.BDNAZADataSetTableAdapters.Control_AsistenciaTableAdapter control_AsistenciaTableAdapter;
        private Datos.BDNAZADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
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
        private System.Windows.Forms.ComboBox cbclase;
        private System.Windows.Forms.ComboBox cbgrupo;
        private System.Windows.Forms.ComboBox cbprofesor;
        private System.Windows.Forms.ComboBox cbalumno;
        private System.Windows.Forms.RadioButton rbasistio;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
    }
}