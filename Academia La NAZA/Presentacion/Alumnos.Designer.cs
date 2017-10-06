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
            System.Windows.Forms.Label lbltelefono;
            System.Windows.Forms.Label lblcel_Claro;
            System.Windows.Forms.Label lblcel_Mov;
            System.Windows.Forms.Label lblbarrio;
            System.Windows.Forms.Label lbldepartamento;
            System.Windows.Forms.Label lbldirección;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new Presentacion.BDNAZATableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.txtbecaPorcentaje = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcel_Claro = new System.Windows.Forms.TextBox();
            this.txtcel_Mov = new System.Windows.Forms.TextBox();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtdirección = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            lblnombre1 = new System.Windows.Forms.Label();
            lblnombre2 = new System.Windows.Forms.Label();
            lblapellido1 = new System.Windows.Forms.Label();
            lblapellido2 = new System.Windows.Forms.Label();
            lblbecaPorcentaje = new System.Windows.Forms.Label();
            lbltelefono = new System.Windows.Forms.Label();
            lblcel_Claro = new System.Windows.Forms.Label();
            lblcel_Mov = new System.Windows.Forms.Label();
            lblbarrio = new System.Windows.Forms.Label();
            lbldepartamento = new System.Windows.Forms.Label();
            lbldirección = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(349, 86);
            this.pnlopciones.Name = "pnlopciones";
            this.pnlopciones.Size = new System.Drawing.Size(150, 254);
            this.pnlopciones.TabIndex = 0;
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
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(19, 107);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(112, 40);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
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
            // pnlformulario
            // 
            this.pnlformulario.Controls.Add(this.cbestado);
            this.pnlformulario.Controls.Add(lbldirección);
            this.pnlformulario.Controls.Add(this.txtdirección);
            this.pnlformulario.Controls.Add(lbldepartamento);
            this.pnlformulario.Controls.Add(this.txtdepartamento);
            this.pnlformulario.Controls.Add(lblbarrio);
            this.pnlformulario.Controls.Add(this.txtbarrio);
            this.pnlformulario.Controls.Add(lblcel_Mov);
            this.pnlformulario.Controls.Add(this.txtcel_Mov);
            this.pnlformulario.Controls.Add(lblcel_Claro);
            this.pnlformulario.Controls.Add(this.txtcel_Claro);
            this.pnlformulario.Controls.Add(lbltelefono);
            this.pnlformulario.Controls.Add(this.txttelefono);
            this.pnlformulario.Controls.Add(lblbecaPorcentaje);
            this.pnlformulario.Controls.Add(this.txtbecaPorcentaje);
            this.pnlformulario.Controls.Add(lblapellido2);
            this.pnlformulario.Controls.Add(this.txtapellido2);
            this.pnlformulario.Controls.Add(lblapellido1);
            this.pnlformulario.Controls.Add(this.txtapellido1);
            this.pnlformulario.Controls.Add(lblnombre2);
            this.pnlformulario.Controls.Add(this.txtnombre2);
            this.pnlformulario.Controls.Add(lblnombre1);
            this.pnlformulario.Controls.Add(this.txtnombre1);
            this.pnlformulario.Location = new System.Drawing.Point(16, 19);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(287, 402);
            this.pnlformulario.TabIndex = 1;
            this.pnlformulario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlformulario_Paint);
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.bDNAZA;
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
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.BDNAZATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // txtnombre1
            // 
            this.txtnombre1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Nombre1", true));
            this.txtnombre1.Location = new System.Drawing.Point(105, 18);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(100, 20);
            this.txtnombre1.TabIndex = 1;
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
            // txtnombre2
            // 
            this.txtnombre2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Nombre2", true));
            this.txtnombre2.Location = new System.Drawing.Point(116, 44);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(100, 20);
            this.txtnombre2.TabIndex = 3;
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
            // txtapellido1
            // 
            this.txtapellido1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Apellido1", true));
            this.txtapellido1.Location = new System.Drawing.Point(105, 74);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(100, 20);
            this.txtapellido1.TabIndex = 5;
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
            // txtapellido2
            // 
            this.txtapellido2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Apellido2", true));
            this.txtapellido2.Location = new System.Drawing.Point(116, 100);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(100, 20);
            this.txtapellido2.TabIndex = 7;
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
            // txtbecaPorcentaje
            // 
            this.txtbecaPorcentaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "BecaPorcentaje", true));
            this.txtbecaPorcentaje.Location = new System.Drawing.Point(116, 126);
            this.txtbecaPorcentaje.Name = "txtbecaPorcentaje";
            this.txtbecaPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtbecaPorcentaje.TabIndex = 9;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new System.Drawing.Point(23, 158);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new System.Drawing.Size(52, 13);
            lbltelefono.TabIndex = 10;
            lbltelefono.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Telefono", true));
            this.txttelefono.Location = new System.Drawing.Point(81, 155);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 11;
            // 
            // lblcel_Claro
            // 
            lblcel_Claro.AutoSize = true;
            lblcel_Claro.Location = new System.Drawing.Point(23, 191);
            lblcel_Claro.Name = "lblcel_Claro";
            lblcel_Claro.Size = new System.Drawing.Size(52, 13);
            lblcel_Claro.TabIndex = 12;
            lblcel_Claro.Text = "Cel Claro:";
            // 
            // txtcel_Claro
            // 
            this.txtcel_Claro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Cel_Claro", true));
            this.txtcel_Claro.Location = new System.Drawing.Point(81, 188);
            this.txtcel_Claro.Name = "txtcel_Claro";
            this.txtcel_Claro.Size = new System.Drawing.Size(100, 20);
            this.txtcel_Claro.TabIndex = 13;
            // 
            // lblcel_Mov
            // 
            lblcel_Mov.AutoSize = true;
            lblcel_Mov.Location = new System.Drawing.Point(23, 221);
            lblcel_Mov.Name = "lblcel_Mov";
            lblcel_Mov.Size = new System.Drawing.Size(49, 13);
            lblcel_Mov.TabIndex = 14;
            lblcel_Mov.Text = "Cel Mov:";
            // 
            // txtcel_Mov
            // 
            this.txtcel_Mov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Cel_Mov", true));
            this.txtcel_Mov.Location = new System.Drawing.Point(78, 218);
            this.txtcel_Mov.Name = "txtcel_Mov";
            this.txtcel_Mov.Size = new System.Drawing.Size(100, 20);
            this.txtcel_Mov.TabIndex = 15;
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
            // txtbarrio
            // 
            this.txtbarrio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Barrio", true));
            this.txtbarrio.Location = new System.Drawing.Point(66, 246);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(100, 20);
            this.txtbarrio.TabIndex = 17;
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
            // txtdepartamento
            // 
            this.txtdepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Departamento", true));
            this.txtdepartamento.Location = new System.Drawing.Point(106, 279);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtdepartamento.TabIndex = 19;
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
            // txtdirección
            // 
            this.txtdirección.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Dirección", true));
            this.txtdirección.Location = new System.Drawing.Point(81, 305);
            this.txtdirección.Name = "txtdirección";
            this.txtdirección.Size = new System.Drawing.Size(100, 20);
            this.txtdirección.TabIndex = 21;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumnosBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(26, 342);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(142, 24);
            this.cbestado.TabIndex = 23;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 423);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private BDNAZATableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtbecaPorcentaje;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.TextBox txtdirección;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.TextBox txtbarrio;
        private System.Windows.Forms.TextBox txtcel_Mov;
        private System.Windows.Forms.TextBox txtcel_Claro;
    }
}