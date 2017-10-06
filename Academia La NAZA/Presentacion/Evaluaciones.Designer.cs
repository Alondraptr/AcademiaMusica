namespace Presentacion
{
    partial class Evaluaciones
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
            System.Windows.Forms.Label iD_InstELabel;
            System.Windows.Forms.Label iD_AlumnoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label observacionLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionesTableAdapter = new Presentacion.BDNAZATableAdapters.EvaluacionesTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.txtiD_InstE = new System.Windows.Forms.TextBox();
            this.txtiD_Alumno = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            iD_InstELabel = new System.Windows.Forms.Label();
            iD_AlumnoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(394, 74);
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
            this.pnlformulario.Controls.Add(observacionLabel);
            this.pnlformulario.Controls.Add(this.txtobservacion);
            this.pnlformulario.Controls.Add(fechaLabel);
            this.pnlformulario.Controls.Add(this.fechaDateTimePicker);
            this.pnlformulario.Controls.Add(iD_AlumnoLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Alumno);
            this.pnlformulario.Controls.Add(iD_InstELabel);
            this.pnlformulario.Controls.Add(this.txtiD_InstE);
            this.pnlformulario.Location = new System.Drawing.Point(12, 100);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(371, 200);
            this.pnlformulario.TabIndex = 3;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.bDNAZA;
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EvaluacionesTableAdapter = this.evaluacionesTableAdapter;
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
            // iD_InstELabel
            // 
            iD_InstELabel.AutoSize = true;
            iD_InstELabel.Location = new System.Drawing.Point(23, 28);
            iD_InstELabel.Name = "iD_InstELabel";
            iD_InstELabel.Size = new System.Drawing.Size(51, 13);
            iD_InstELabel.TabIndex = 0;
            iD_InstELabel.Text = "ID Inst E:";
            // 
            // txtiD_InstE
            // 
            this.txtiD_InstE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluacionesBindingSource, "ID_InstE", true));
            this.txtiD_InstE.Location = new System.Drawing.Point(80, 25);
            this.txtiD_InstE.Name = "txtiD_InstE";
            this.txtiD_InstE.Size = new System.Drawing.Size(100, 20);
            this.txtiD_InstE.TabIndex = 1;
            // 
            // iD_AlumnoLabel
            // 
            iD_AlumnoLabel.AutoSize = true;
            iD_AlumnoLabel.Location = new System.Drawing.Point(15, 66);
            iD_AlumnoLabel.Name = "iD_AlumnoLabel";
            iD_AlumnoLabel.Size = new System.Drawing.Size(59, 13);
            iD_AlumnoLabel.TabIndex = 2;
            iD_AlumnoLabel.Text = "ID Alumno:";
            // 
            // txtiD_Alumno
            // 
            this.txtiD_Alumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluacionesBindingSource, "ID_Alumno", true));
            this.txtiD_Alumno.Location = new System.Drawing.Point(80, 63);
            this.txtiD_Alumno.Name = "txtiD_Alumno";
            this.txtiD_Alumno.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Alumno.TabIndex = 3;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(22, 100);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.evaluacionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(68, 96);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(15, 135);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(70, 13);
            observacionLabel.TabIndex = 6;
            observacionLabel.Text = "Observacion:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluacionesBindingSource, "Observacion", true));
            this.txtobservacion.Location = new System.Drawing.Point(91, 132);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(100, 20);
            this.txtobservacion.TabIndex = 7;
            // 
            // Evaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 340);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Evaluaciones";
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.Evaluaciones_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private BDNAZATableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox txtiD_Alumno;
        private System.Windows.Forms.TextBox txtiD_InstE;
    }
}