namespace Presentacion
{
    partial class Grupos
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
            System.Windows.Forms.Label diaLabel;
            System.Windows.Forms.Label hora_EntradaLabel;
            System.Windows.Forms.Label iD_GrupoLabel;
            System.Windows.Forms.Label hora_SalidaLabel;
            this.pnlopciones = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.bDNAZA = new Presentacion.BDNAZA();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new Presentacion.BDNAZATableAdapters.GruposTableAdapter();
            this.tableAdapterManager = new Presentacion.BDNAZATableAdapters.TableAdapterManager();
            this.diaTextBox = new System.Windows.Forms.TextBox();
            this.hora_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.iD_GrupoTextBox = new System.Windows.Forms.TextBox();
            this.hora_SalidaTextBox = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            this.pnlformulario = new System.Windows.Forms.Panel();
            diaLabel = new System.Windows.Forms.Label();
            hora_EntradaLabel = new System.Windows.Forms.Label();
            iD_GrupoLabel = new System.Windows.Forms.Label();
            hora_SalidaLabel = new System.Windows.Forms.Label();
            this.pnlopciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.pnlformulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlopciones
            // 
            this.pnlopciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlopciones.Controls.Add(this.btneliminar);
            this.pnlopciones.Controls.Add(this.btnmodificar);
            this.pnlopciones.Controls.Add(this.btninsertar);
            this.pnlopciones.Location = new System.Drawing.Point(407, 12);
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
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.bDNAZA;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GruposTableAdapter = this.gruposTableAdapter;
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
            // diaLabel
            // 
            diaLabel.AutoSize = true;
            diaLabel.Location = new System.Drawing.Point(25, 52);
            diaLabel.Name = "diaLabel";
            diaLabel.Size = new System.Drawing.Size(26, 13);
            diaLabel.TabIndex = 3;
            diaLabel.Text = "Dia:";
            // 
            // diaTextBox
            // 
            this.diaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Dia", true));
            this.diaTextBox.Location = new System.Drawing.Point(57, 49);
            this.diaTextBox.Name = "diaTextBox";
            this.diaTextBox.Size = new System.Drawing.Size(100, 20);
            this.diaTextBox.TabIndex = 4;
            // 
            // hora_EntradaLabel
            // 
            hora_EntradaLabel.AutoSize = true;
            hora_EntradaLabel.Location = new System.Drawing.Point(25, 93);
            hora_EntradaLabel.Name = "hora_EntradaLabel";
            hora_EntradaLabel.Size = new System.Drawing.Size(73, 13);
            hora_EntradaLabel.TabIndex = 4;
            hora_EntradaLabel.Text = "Hora Entrada:";
            // 
            // hora_EntradaTextBox
            // 
            this.hora_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Hora_Entrada", true));
            this.hora_EntradaTextBox.Location = new System.Drawing.Point(104, 90);
            this.hora_EntradaTextBox.Name = "hora_EntradaTextBox";
            this.hora_EntradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hora_EntradaTextBox.TabIndex = 5;
            // 
            // iD_GrupoLabel
            // 
            iD_GrupoLabel.AutoSize = true;
            iD_GrupoLabel.Location = new System.Drawing.Point(25, 17);
            iD_GrupoLabel.Name = "iD_GrupoLabel";
            iD_GrupoLabel.Size = new System.Drawing.Size(53, 13);
            iD_GrupoLabel.TabIndex = 5;
            iD_GrupoLabel.Text = "ID Grupo:";
            // 
            // iD_GrupoTextBox
            // 
            this.iD_GrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "ID_Grupo", true));
            this.iD_GrupoTextBox.Location = new System.Drawing.Point(84, 14);
            this.iD_GrupoTextBox.Name = "iD_GrupoTextBox";
            this.iD_GrupoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_GrupoTextBox.TabIndex = 6;
            // 
            // hora_SalidaLabel
            // 
            hora_SalidaLabel.AutoSize = true;
            hora_SalidaLabel.Location = new System.Drawing.Point(25, 130);
            hora_SalidaLabel.Name = "hora_SalidaLabel";
            hora_SalidaLabel.Size = new System.Drawing.Size(65, 13);
            hora_SalidaLabel.TabIndex = 7;
            hora_SalidaLabel.Text = "Hora Salida:";
            // 
            // hora_SalidaTextBox
            // 
            this.hora_SalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Hora_Salida", true));
            this.hora_SalidaTextBox.Location = new System.Drawing.Point(96, 127);
            this.hora_SalidaTextBox.Name = "hora_SalidaTextBox";
            this.hora_SalidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hora_SalidaTextBox.TabIndex = 8;
            // 
            // cbestado
            // 
            this.cbestado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gruposBindingSource, "Estado", true));
            this.cbestado.Location = new System.Drawing.Point(28, 167);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(161, 24);
            this.cbestado.TabIndex = 10;
            this.cbestado.Text = "Activo / Inactivo";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // pnlformulario
            // 
            this.pnlformulario.Controls.Add(this.cbestado);
            this.pnlformulario.Controls.Add(hora_SalidaLabel);
            this.pnlformulario.Controls.Add(this.hora_SalidaTextBox);
            this.pnlformulario.Controls.Add(iD_GrupoLabel);
            this.pnlformulario.Controls.Add(this.iD_GrupoTextBox);
            this.pnlformulario.Controls.Add(hora_EntradaLabel);
            this.pnlformulario.Controls.Add(this.hora_EntradaTextBox);
            this.pnlformulario.Controls.Add(diaLabel);
            this.pnlformulario.Controls.Add(this.diaTextBox);
            this.pnlformulario.Location = new System.Drawing.Point(26, 32);
            this.pnlformulario.Name = "pnlformulario";
            this.pnlformulario.Size = new System.Drawing.Size(279, 218);
            this.pnlformulario.TabIndex = 11;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 290);
            this.Controls.Add(this.pnlformulario);
            this.Controls.Add(this.pnlopciones);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            this.pnlopciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDNAZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private BDNAZATableAdapters.GruposTableAdapter gruposTableAdapter;
        private BDNAZATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox diaTextBox;
        private System.Windows.Forms.TextBox hora_EntradaTextBox;
        private System.Windows.Forms.TextBox iD_GrupoTextBox;
        private System.Windows.Forms.TextBox hora_SalidaTextBox;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.Panel pnlformulario;
    }
}