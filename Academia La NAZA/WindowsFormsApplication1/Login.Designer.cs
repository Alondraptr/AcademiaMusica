namespace Presentacion
{
    partial class Login
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
            this.pnllogin = new System.Windows.Forms.Panel();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblregistro = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnllogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnllogin
            // 
            this.pnllogin.Controls.Add(this.txtcontra);
            this.pnllogin.Controls.Add(this.txtusuario);
            this.pnllogin.Controls.Add(this.lblcontra);
            this.pnllogin.Controls.Add(this.lblusuario);
            this.pnllogin.Controls.Add(this.lblregistro);
            this.pnllogin.Controls.Add(this.btnlogin);
            this.pnllogin.Location = new System.Drawing.Point(-1, 0);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(346, 327);
            this.pnllogin.TabIndex = 0;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(117, 142);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(136, 20);
            this.txtcontra.TabIndex = 5;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(117, 94);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(136, 20);
            this.txtusuario.TabIndex = 4;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Location = new System.Drawing.Point(48, 145);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(61, 13);
            this.lblcontra.TabIndex = 3;
            this.lblcontra.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(66, 95);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistro.Location = new System.Drawing.Point(105, 28);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(134, 29);
            this.lblregistro.TabIndex = 1;
            this.lblregistro.Text = "Bienvenido";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(133, 215);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(90, 43);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 322);
            this.Controls.Add(this.pnllogin);
            this.Name = "Login";
            this.Text = "Login";
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button btnlogin;
    }
}