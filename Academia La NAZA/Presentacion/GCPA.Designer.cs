namespace Presentacion
{
    partial class GCPA
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
            System.Windows.Forms.Label iD_GCPALabel;
            System.Windows.Forms.Label iD_ProfesorLabel;
            System.Windows.Forms.Label iD_AlumnoLabel;
            System.Windows.Forms.Label iD_GrupoLabel;
            System.Windows.Forms.Label iD_ClaseLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.gCPABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gCPATableAdapter = new Presentacion.BDNAZATableAdapters.GCPATableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.pnlformulario = new System.Windows.Forms.Panel();
            this.txtiD_Alumno = new System.Windows.Forms.TextBox();
            this.txtiD_Profesor = new System.Windows.Forms.TextBox();
            this.txtiD_GCPA = new System.Windows.Forms.TextBox();
            this.txtiD_Grupo = new System.Windows.Forms.TextBox();
            this.txtiD_Clase = new System.Windows.Forms.TextBox();
            iD_GCPALabel = new System.Windows.Forms.Label();
            iD_ProfesorLabel = new System.Windows.Forms.Label();
            iD_AlumnoLabel = new System.Windows.Forms.Label();
            iD_GrupoLabel = new System.Windows.Forms.Label();
            iD_ClaseLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCPABindingSource)).BeginInit();
            this.pnlformulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_GCPALabel
            // 
            iD_GCPALabel.AutoSize = true;
            iD_GCPALabel.Location = new System.Drawing.Point(14, 10);
            iD_GCPALabel.Name = "iD_GCPALabel";
            iD_GCPALabel.Size = new System.Drawing.Size(53, 13);
            iD_GCPALabel.TabIndex = 0;
            iD_GCPALabel.Text = "ID GCPA:";
            // 
            // iD_ProfesorLabel
            // 
            iD_ProfesorLabel.AutoSize = true;
            iD_ProfesorLabel.Location = new System.Drawing.Point(14, 47);
            iD_ProfesorLabel.Name = "iD_ProfesorLabel";
            iD_ProfesorLabel.Size = new System.Drawing.Size(63, 13);
            iD_ProfesorLabel.TabIndex = 2;
            iD_ProfesorLabel.Text = "ID Profesor:";
            // 
            // iD_AlumnoLabel
            // 
            iD_AlumnoLabel.AutoSize = true;
            iD_AlumnoLabel.Location = new System.Drawing.Point(18, 85);
            iD_AlumnoLabel.Name = "iD_AlumnoLabel";
            iD_AlumnoLabel.Size = new System.Drawing.Size(59, 13);
            iD_AlumnoLabel.TabIndex = 4;
            iD_AlumnoLabel.Text = "ID Alumno:";
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(363, 34);
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
            // bDNAZA
            // 
            this.bDNAZA.DataSetName = "BDNAZA";
            this.bDNAZA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gCPABindingSource
            // 
            this.gCPABindingSource.DataMember = "GCPA";
            this.gCPABindingSource.DataSource = this.bDNAZA;
            // 
            // gCPATableAdapter
            // 
            this.gCPATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GCPATableAdapter = this.gCPATableAdapter;
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
            // pnlformulario
            // 
            this.pnlformulario.Controls.Add(iD_ClaseLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Clase);
            this.pnlformulario.Controls.Add(iD_GrupoLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Grupo);
            this.pnlformulario.Controls.Add(iD_AlumnoLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Alumno);
            this.pnlformulario.Controls.Add(iD_ProfesorLabel);
            this.pnlformulario.Controls.Add(this.txtiD_Profesor);
            this.pnlformulario.Controls.Add(iD_GCPALabel);
            this.pnlformulario.Controls.Add(this.txtiD_GCPA);
            this.pnlformulario.Location = new System.Drawing.Point(32, 59);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(289, 200);
            this.pnlformulario.TabIndex = 3;
            // 
            // txtiD_Alumno
            // 
            this.txtiD_Alumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gCPABindingSource, "ID_Alumno", true));
            this.txtiD_Alumno.Location = new System.Drawing.Point(83, 82);
            this.txtiD_Alumno.Name = "txtiD_Alumno";
            this.txtiD_Alumno.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Alumno.TabIndex = 5;
            // 
            // txtiD_Profesor
            // 
            this.txtiD_Profesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gCPABindingSource, "ID_Profesor", true));
            this.txtiD_Profesor.Location = new System.Drawing.Point(83, 44);
            this.txtiD_Profesor.Name = "txtiD_Profesor";
            this.txtiD_Profesor.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Profesor.TabIndex = 3;
            // 
            // txtiD_GCPA
            // 
            this.txtiD_GCPA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gCPABindingSource, "ID_GCPA", true));
            this.txtiD_GCPA.Location = new System.Drawing.Point(73, 7);
            this.txtiD_GCPA.Name = "txtiD_GCPA";
            this.txtiD_GCPA.Size = new System.Drawing.Size(100, 20);
            this.txtiD_GCPA.TabIndex = 1;
            // 
            // iD_GrupoLabel
            // 
            iD_GrupoLabel.AutoSize = true;
            iD_GrupoLabel.Location = new System.Drawing.Point(14, 124);
            iD_GrupoLabel.Name = "iD_GrupoLabel";
            iD_GrupoLabel.Size = new System.Drawing.Size(53, 13);
            iD_GrupoLabel.TabIndex = 6;
            iD_GrupoLabel.Text = "ID Grupo:";
            // 
            // txtiD_Grupo
            // 
            this.txtiD_Grupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gCPABindingSource, "ID_Grupo", true));
            this.txtiD_Grupo.Location = new System.Drawing.Point(73, 121);
            this.txtiD_Grupo.Name = "txtiD_Grupo";
            this.txtiD_Grupo.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Grupo.TabIndex = 7;
            // 
            // iD_ClaseLabel
            // 
            iD_ClaseLabel.AutoSize = true;
            iD_ClaseLabel.Location = new System.Drawing.Point(18, 163);
            iD_ClaseLabel.Name = "iD_ClaseLabel";
            iD_ClaseLabel.Size = new System.Drawing.Size(50, 13);
            iD_ClaseLabel.TabIndex = 8;
            iD_ClaseLabel.Text = "ID Clase:";
            // 
            // txtiD_Clase
            // 
            this.txtiD_Clase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gCPABindingSource, "ID_Clase", true));
            this.txtiD_Clase.Location = new System.Drawing.Point(74, 160);
            this.txtiD_Clase.Name = "txtiD_Clase";
            this.txtiD_Clase.Size = new System.Drawing.Size(100, 20);
            this.txtiD_Clase.TabIndex = 9;
            // 
            // GCPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 331);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "GCPA";
            this.Text = "GCPA";
            this.Load += new System.EventHandler(this.GCPA_Load);
            this.pnlopciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCPABindingSource)).EndInit();
            this.pnlformulario.ResumeLayout(false);
            this.pnlformulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopciones;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsertar;
        private BDNAZA bDNAZA;
        private System.Windows.Forms.BindingSource gCPABindingSource;
        private BDNAZATableAdapters.GCPATableAdapter gCPATableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlformulario;
        private System.Windows.Forms.TextBox txtiD_Alumno;
        private System.Windows.Forms.TextBox txtiD_Profesor;
        private System.Windows.Forms.TextBox txtiD_GCPA;
        private System.Windows.Forms.TextBox txtiD_Clase;
        private System.Windows.Forms.TextBox txtiD_Grupo;
    }
}