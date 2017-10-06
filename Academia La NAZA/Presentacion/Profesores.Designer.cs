namespace Presentacion
{
    partial class Profesores
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
            System.Windows.Forms.Label lblcedula;
            System.Windows.Forms.Label lblnombre1;
            System.Windows.Forms.Label lblnombre2;
            System.Windows.Forms.Label lblapellido1;
            System.Windows.Forms.Label lblapellido2;
            System.Windows.Forms.Label lbltelefono;
            System.Windows.Forms.Label lblcel_Claro;
            System.Windows.Forms.Label lblcel_Mov;
            System.Windows.Forms.Label lblemail;
            System.Windows.Forms.Label lbldireccion;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDNAZA = new Presentacion.BDNAZA();
            this.txtcel_Mov = new System.Windows.Forms.TextBox();
            this.txtcel_Claro = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.profesoresTableAdapter = new Presentacion.BDNAZATableAdapters.ProfesoresTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            lblcedula = new System.Windows.Forms.Label();
            lblnombre1 = new System.Windows.Forms.Label();
            lblnombre2 = new System.Windows.Forms.Label();
            lblapellido1 = new System.Windows.Forms.Label();
            lblapellido2 = new System.Windows.Forms.Label();
            lbltelefono = new System.Windows.Forms.Label();
            lblcel_Claro = new System.Windows.Forms.Label();
            lblcel_Mov = new System.Windows.Forms.Label();
            lblemail = new System.Windows.Forms.Label();
            lbldireccion = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcedula
            // 
            lblcedula.AutoSize = true;
            lblcedula.Location = new System.Drawing.Point(12, 16);
            lblcedula.Name = "lblcedula";
            lblcedula.Size = new System.Drawing.Size(43, 13);
            lblcedula.TabIndex = 0;
            lblcedula.Text = "Cedula:";
            // 
            // lblnombre1
            // 
            lblnombre1.AutoSize = true;
            lblnombre1.Location = new System.Drawing.Point(10, 42);
            lblnombre1.Name = "lblnombre1";
            lblnombre1.Size = new System.Drawing.Size(79, 13);
            lblnombre1.TabIndex = 2;
            lblnombre1.Text = "Primer Nombre:";
            // 
            // lblnombre2
            // 
            lblnombre2.AutoSize = true;
            lblnombre2.Location = new System.Drawing.Point(10, 69);
            lblnombre2.Name = "lblnombre2";
            lblnombre2.Size = new System.Drawing.Size(93, 13);
            lblnombre2.TabIndex = 4;
            lblnombre2.Text = "Segundo Nombre:";
            // 
            // lblapellido1
            // 
            lblapellido1.AutoSize = true;
            lblapellido1.Location = new System.Drawing.Point(12, 94);
            lblapellido1.Name = "lblapellido1";
            lblapellido1.Size = new System.Drawing.Size(79, 13);
            lblapellido1.TabIndex = 6;
            lblapellido1.Text = "Primer Apellido:";
            // 
            // lblapellido2
            // 
            lblapellido2.AutoSize = true;
            lblapellido2.Location = new System.Drawing.Point(12, 120);
            lblapellido2.Name = "lblapellido2";
            lblapellido2.Size = new System.Drawing.Size(93, 13);
            lblapellido2.TabIndex = 8;
            lblapellido2.Text = "Segundo Apellido:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new System.Drawing.Point(12, 155);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new System.Drawing.Size(52, 13);
            lbltelefono.TabIndex = 10;
            lbltelefono.Text = "Telefono:";
            // 
            // lblcel_Claro
            // 
            lblcel_Claro.AutoSize = true;
            lblcel_Claro.Location = new System.Drawing.Point(12, 189);
            lblcel_Claro.Name = "lblcel_Claro";
            lblcel_Claro.Size = new System.Drawing.Size(52, 13);
            lblcel_Claro.TabIndex = 12;
            lblcel_Claro.Text = "Cel Claro:";
            // 
            // lblcel_Mov
            // 
            lblcel_Mov.AutoSize = true;
            lblcel_Mov.Location = new System.Drawing.Point(15, 224);
            lblcel_Mov.Name = "lblcel_Mov";
            lblcel_Mov.Size = new System.Drawing.Size(49, 13);
            lblcel_Mov.TabIndex = 14;
            lblcel_Mov.Text = "Cel Mov:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new System.Drawing.Point(20, 259);
            lblemail.Name = "lblemail";
            lblemail.Size = new System.Drawing.Size(35, 13);
            lblemail.TabIndex = 16;
            lblemail.Text = "Email:";
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(354, 98);
            this.pnlopciones.Name = "pnlopciones";
            this.pnlopciones.Size = new System.Drawing.Size(150, 254);
            this.pnlopciones.TabIndex = 1;
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
            this.pnlformulario.Controls.Add(this.cbestado);
            this.pnlformulario.Controls.Add(lbldireccion);
            this.pnlformulario.Controls.Add(this.txtdireccion);
            this.pnlformulario.Controls.Add(lblemail);
            this.pnlformulario.Controls.Add(this.txtemail);
            this.pnlformulario.Controls.Add(lblcel_Mov);
            this.pnlformulario.Controls.Add(this.txtcel_Mov);
            this.pnlformulario.Controls.Add(lblcel_Claro);
            this.pnlformulario.Controls.Add(this.txtcel_Claro);
            this.pnlformulario.Controls.Add(lbltelefono);
            this.pnlformulario.Controls.Add(this.txttelefono);
            this.pnlformulario.Controls.Add(lblapellido2);
            this.pnlformulario.Controls.Add(this.txtapellido2);
            this.pnlformulario.Controls.Add(lblapellido1);
            this.pnlformulario.Controls.Add(this.txtapellido1);
            this.pnlformulario.Controls.Add(lblnombre2);
            this.pnlformulario.Controls.Add(this.txtnombre2);
            this.pnlformulario.Controls.Add(lblnombre1);
            this.pnlformulario.Controls.Add(this.txtnombre1);
            this.pnlformulario.Controls.Add(lblcedula);
            this.pnlformulario.Controls.Add(this.txtcedula);
            this.pnlformulario.Location = new System.Drawing.Point(12, 16);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(281, 395);
            this.pnlformulario.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Email", true));
            this.txtemail.Location = new System.Drawing.Point(61, 256);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 17;
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "Profesores";
            this.profesoresBindingSource.DataSource = this.bDNAZA;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcel_Mov
            // 
            this.txtcel_Mov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Cel_Mov", true));
            this.txtcel_Mov.Location = new System.Drawing.Point(70, 221);
            this.txtcel_Mov.Name = "txtcel_Mov";
            this.txtcel_Mov.Size = new System.Drawing.Size(100, 20);
            this.txtcel_Mov.TabIndex = 15;
            // 
            // txtcel_Claro
            // 
            this.txtcel_Claro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Cel_Claro", true));
            this.txtcel_Claro.Location = new System.Drawing.Point(70, 186);
            this.txtcel_Claro.Name = "txtcel_Claro";
            this.txtcel_Claro.Size = new System.Drawing.Size(100, 20);
            this.txtcel_Claro.TabIndex = 13;
            // 
            // txttelefono
            // 
            this.txttelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Telefono", true));
            this.txttelefono.Location = new System.Drawing.Point(70, 152);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 11;
            // 
            // txtapellido2
            // 
            this.txtapellido2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Apellido2", true));
            this.txtapellido2.Location = new System.Drawing.Point(111, 117);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(100, 20);
            this.txtapellido2.TabIndex = 9;
            // 
            // txtapellido1
            // 
            this.txtapellido1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Apellido1", true));
            this.txtapellido1.Location = new System.Drawing.Point(97, 91);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(100, 20);
            this.txtapellido1.TabIndex = 7;
            // 
            // txtnombre2
            // 
            this.txtnombre2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Nombre2", true));
            this.txtnombre2.Location = new System.Drawing.Point(109, 65);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(100, 20);
            this.txtnombre2.TabIndex = 5;
            // 
            // txtnombre1
            // 
            this.txtnombre1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Nombre1", true));
            this.txtnombre1.Location = new System.Drawing.Point(95, 39);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(100, 20);
            this.txtnombre1.TabIndex = 3;
            // 
            // txtcedula
            // 
            this.txtcedula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Cedula", true));
            this.txtcedula.Location = new System.Drawing.Point(61, 13);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 1;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
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
            this.tableAdapterManager.ProfesoresTableAdapter = this.profesoresTableAdapter;
            this.tableAdapterManager.Respuestas_CerradasTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.BDNAZATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbldireccion
            // 
            lbldireccion.AutoSize = true;
            lbldireccion.Location = new System.Drawing.Point(15, 295);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new System.Drawing.Size(55, 13);
            lbldireccion.TabIndex = 18;
            lbldireccion.Text = "Direccion:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoresBindingSource, "Direccion", true));
            this.txtdireccion.Location = new System.Drawing.Point(76, 292);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 19;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profesoresBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(23, 337);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(138, 24);
            this.cbestado.TabIndex = 21;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 423);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private BDNAZATableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcel_Mov;
        private System.Windows.Forms.TextBox txtcel_Claro;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.CheckBox cbestado;
    }
}