namespace Presentacion
{
    partial class Pagos
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
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformularios = new System.Windows.Forms.Panel();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDNAZA = new Presentacion.BDNAZA();
            this.cbestado = new System.Windows.Forms.CheckBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtiD_Alumno = new System.Windows.Forms.TextBox();
            this.pagosTableAdapter = new Presentacion.BDNAZATableAdapters.PagosTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            iD_AlumnoLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_AlumnoLabel
            // 
            iD_AlumnoLabel.AutoSize = true;
            iD_AlumnoLabel.Location = new System.Drawing.Point(33, 34);
            iD_AlumnoLabel.Name = "iD_AlumnoLabel";
            iD_AlumnoLabel.Size = new System.Drawing.Size(59, 13);
            iD_AlumnoLabel.TabIndex = 0;
            iD_AlumnoLabel.Text = "ID Alumno:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(34, 116);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 2;
            montoLabel.Text = "Monto:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(32, 70);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha:";
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(402, 38);
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
            // pnlformularios
            // 
            this.pnlformularios.Controls.Add(fechaLabel);
            this.pnlformularios.Controls.Add(this.fechaDateTimePicker);
            this.pnlformularios.Controls.Add(this.cbestado);
            this.pnlformularios.Controls.Add(montoLabel);
            this.pnlformularios.Controls.Add(this.txtmonto);
            this.pnlformularios.Controls.Add(iD_AlumnoLabel);
            this.pnlformularios.Controls.Add(this.txtiD_Alumno);
            this.pnlformularios.Location = new System.Drawing.Point(36, 47);
            this.pnlformularios.Name = "pnlformularios";
            this.pnlformularios.Size = new System.Drawing.Size(333, 205);
            this.pnlformularios.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagosBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(78, 66);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.bDNAZA;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pagosBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(37, 163);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(143, 24);
            this.cbestado.TabIndex = 5;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // txtmonto
            // 
            this.txtmonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Monto", true));
            this.txtmonto.Location = new System.Drawing.Point(80, 113);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 3;
            // 
            // txtiD_Alumno
            // 
            this.txtiD_Alumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "ID_Alumno", true));
            this.txtiD_Alumno.Location = new System.Drawing.Point(98, 31);
            this.txtiD_Alumno.Name = "txtiD_Alumno";
            this.txtiD_Alumno.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Alumno.TabIndex = 1;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PagosTableAdapter = this.pagosTableAdapter;
            this.tableAdapterManager.Preguntas_CerradasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.Respuestas_CerradasTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.BDNAZATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 304);
            this.Controls.Add(this.pnlformularios);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformularios.ResumeLayout(false);
            this.pnlformularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformularios;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private BDNAZATableAdapters.PagosTableAdapter pagosTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtiD_Alumno;
    }
}