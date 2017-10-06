namespace Presentacion
{
    partial class Matriculas
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
            System.Windows.Forms.Label iD_AlumnoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label montoLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.matriculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculasTableAdapter = new Presentacion.BDNAZATableAdapters.MatriculasTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.txtiD_Alumno = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            iD_AlumnoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(385, 52);
            this.pnlopciones.Name = "pnlopciones";
            this.pnlopciones.Size = new System.Drawing.Size(150, 254);
            this.pnlopciones.TabIndex = 2;
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
            this.pnlformulario.Controls.Add(montoLabel);
            this.pnlformulario.Controls.Add(this.txtmonto);
            this.pnlformulario.Controls.Add(fechaLabel);
            this.pnlformulario.Controls.Add(this.fechaDateTimePicker);
            this.pnlformulario.Controls.Add(iD_AlumnoLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Alumno);
            this.pnlformulario.Location = new System.Drawing.Point(25, 61);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(328, 226);
            this.pnlformulario.TabIndex = 3;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matriculasBindingSource
            // 
            this.matriculasBindingSource.DataMember = "Matriculas";
            this.matriculasBindingSource.DataSource = this.bDNAZA;
            // 
            // matriculasTableAdapter
            // 
            this.matriculasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MatriculasTableAdapter = this.matriculasTableAdapter;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.Preguntas_CerradasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.Respuestas_CerradasTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.BDNAZATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iD_AlumnoLabel
            // 
            iD_AlumnoLabel.AutoSize = true;
            iD_AlumnoLabel.Location = new System.Drawing.Point(33, 42);
            iD_AlumnoLabel.Name = "iD_AlumnoLabel";
            iD_AlumnoLabel.Size = new System.Drawing.Size(59, 13);
            iD_AlumnoLabel.TabIndex = 0;
            iD_AlumnoLabel.Text = "ID Alumno:";
            // 
            // txtiD_Alumno
            // 
            this.txtiD_Alumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "ID_Alumno", true));
            this.txtiD_Alumno.Location = new System.Drawing.Point(98, 39);
            this.txtiD_Alumno.Name = "txtiD_Alumno";
            this.txtiD_Alumno.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Alumno.TabIndex = 1;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(35, 80);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matriculasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(81, 76);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(35, 118);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 4;
            montoLabel.Text = "Monto:";
            // 
            // txtmonto
            // 
            this.txtmonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "Monto", true));
            this.txtmonto.Location = new System.Drawing.Point(81, 115);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 5;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.matriculasBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(38, 156);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(160, 24);
            this.cbestado.TabIndex = 7;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 334);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Matriculas";
            this.Text = "Matriculas";
            this.Load += new System.EventHandler(this.Matriculas_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource matriculasBindingSource;
        private BDNAZATableAdapters.MatriculasTableAdapter matriculasTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox txtiD_Alumno;
    }
}