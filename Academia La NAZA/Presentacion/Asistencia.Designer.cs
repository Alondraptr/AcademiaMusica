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
            System.Windows.Forms.Label iD_ProfesorLabel;
            System.Windows.Forms.Label iD_ClaseLabel;
            System.Windows.Forms.Label iD_GrupoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.control_AsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control_AsistenciaTableAdapter = new Presentacion.BDNAZATableAdapters.Control_AsistenciaTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.txtiD_Profesor = new System.Windows.Forms.TextBox();
            this.txtiD_Clase = new System.Windows.Forms.TextBox();
            this.txtiD_Grupo = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_ProfesorLabel = new System.Windows.Forms.Label();
            iD_ClaseLabel = new System.Windows.Forms.Label();
            iD_GrupoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            this.pnlformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_AsistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(385, 38);
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
            this.pnlformulario.Controls.Add(fechaLabel);
            this.pnlformulario.Controls.Add(this.fechaDateTimePicker);
            this.pnlformulario.Controls.Add(iD_GrupoLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Grupo);
            this.pnlformulario.Controls.Add(iD_ClaseLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Clase);
            this.pnlformulario.Controls.Add(iD_ProfesorLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Profesor);
            this.pnlformulario.Location = new System.Drawing.Point(33, 64);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(325, 188);
            this.pnlformulario.TabIndex = 3;
            // 
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // control_AsistenciaBindingSource
            // 
            this.control_AsistenciaBindingSource.DataMember = "Control_Asistencia";
            this.control_AsistenciaBindingSource.DataSource = this.bDNAZA;
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
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.Tabla_ValoresTableAdapter = null;
            this.tableAdapterManager.Tipo_InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.BDNAZATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iD_ProfesorLabel
            // 
            iD_ProfesorLabel.AutoSize = true;
            iD_ProfesorLabel.Location = new System.Drawing.Point(24, 21);
            iD_ProfesorLabel.Name = "iD_ProfesorLabel";
            iD_ProfesorLabel.Size = new System.Drawing.Size(63, 13);
            iD_ProfesorLabel.TabIndex = 0;
            iD_ProfesorLabel.Text = "ID Profesor:";
            // 
            // txtiD_Profesor
            // 
            this.txtiD_Profesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.control_AsistenciaBindingSource, "ID_Profesor", true));
            this.txtiD_Profesor.Location = new System.Drawing.Point(93, 18);
            this.txtiD_Profesor.Name = "txtiD_Profesor";
            this.txtiD_Profesor.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Profesor.TabIndex = 1;
            // 
            // iD_ClaseLabel
            // 
            iD_ClaseLabel.AutoSize = true;
            iD_ClaseLabel.Location = new System.Drawing.Point(24, 60);
            iD_ClaseLabel.Name = "iD_ClaseLabel";
            iD_ClaseLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClaseLabel.TabIndex = 2;
            iD_ClaseLabel.Text = "ID Clase:";
            // 
            // txtiD_Clase
            // 
            this.txtiD_Clase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.control_AsistenciaBindingSource, "ID_Clase", true));
            this.txtiD_Clase.Location = new System.Drawing.Point(80, 57);
            this.txtiD_Clase.Name = "txtiD_Clase";
            this.txtiD_Clase.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Clase.TabIndex = 3;
            // 
            // iD_GrupoLabel
            // 
            iD_GrupoLabel.AutoSize = true;
            iD_GrupoLabel.Location = new System.Drawing.Point(21, 93);
            iD_GrupoLabel.Name = "iD_GrupoLabel";
            iD_GrupoLabel.Size = new System.Drawing.Size(53, 13);
            iD_GrupoLabel.TabIndex = 4;
            iD_GrupoLabel.Text = "ID Grupo:";
            // 
            // txtiD_Grupo
            // 
            this.txtiD_Grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.control_AsistenciaBindingSource, "ID_Grupo", true));
            this.txtiD_Grupo.Location = new System.Drawing.Point(80, 90);
            this.txtiD_Grupo.Name = "txtiD_Grupo";
            this.txtiD_Grupo.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Grupo.TabIndex = 5;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 137);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.control_AsistenciaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(70, 133);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.pnlopciones.ResumeLayout(false);
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_AsistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel pnlformulario;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource control_AsistenciaBindingSource;
        private BDNAZATableAdapters.Control_AsistenciaTableAdapter control_AsistenciaTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox txtiD_Grupo;
        private System.Windows.Forms.TextBox txtiD_Clase;
        private System.Windows.Forms.TextBox txtiD_Profesor;
    }
}