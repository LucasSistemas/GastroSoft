namespace Vista
{
    partial class frmRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperar));
            this.lblRecuperarContraseña = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIngreseCorreo = new System.Windows.Forms.Label();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecuperarContraseña
            // 
            this.lblRecuperarContraseña.AutoSize = true;
            this.lblRecuperarContraseña.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRecuperarContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecuperarContraseña.Location = new System.Drawing.Point(311, 117);
            this.lblRecuperarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            this.lblRecuperarContraseña.Size = new System.Drawing.Size(209, 25);
            this.lblRecuperarContraseña.TabIndex = 6;
            this.lblRecuperarContraseña.Text = "Recuperar Contraseña";
            this.lblRecuperarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(595, 300);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnValidar.Size = new System.Drawing.Size(127, 36);
            this.btnValidar.TabIndex = 13;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lblIngreseCorreo
            // 
            this.lblIngreseCorreo.AutoSize = true;
            this.lblIngreseCorreo.BackColor = System.Drawing.Color.White;
            this.lblIngreseCorreo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIngreseCorreo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIngreseCorreo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngreseCorreo.Location = new System.Drawing.Point(35, 181);
            this.lblIngreseCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseCorreo.Name = "lblIngreseCorreo";
            this.lblIngreseCorreo.Size = new System.Drawing.Size(221, 21);
            this.lblIngreseCorreo.TabIndex = 8;
            this.lblIngreseCorreo.Text = "Ingrese su correo de recuperacion:";
            this.lblIngreseCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.BackColor = System.Drawing.Color.White;
            this.lblIngreseCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIngreseCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngreseCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIngreseCodigo.Location = new System.Drawing.Point(35, 295);
            this.lblIngreseCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(185, 40);
            this.lblIngreseCodigo.TabIndex = 9;
            this.lblIngreseCodigo.Text = "Ingrese el código enviado al \r\nCorreo Electrónico:";
            this.lblIngreseCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.Location = new System.Drawing.Point(303, 177);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(268, 22);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(299, 305);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(268, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCodigo.Location = new System.Drawing.Point(595, 171);
            this.btnEnviarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(127, 36);
            this.btnEnviarCodigo.TabIndex = 12;
            this.btnEnviarCodigo.Text = "Enviar codigo ";
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            // 
            // btAtras
            // 
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.ForeColor = System.Drawing.Color.Black;
            this.btAtras.Location = new System.Drawing.Point(35, 104);
            this.btAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(95, 38);
            this.btAtras.TabIndex = 38;
            this.btAtras.Text = "Volver";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // frmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(817, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.lblRecuperarContraseña);
            this.Controls.Add(this.lblIngreseCorreo);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRecuperar";
            this.Text = "Recuperar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecuperarContraseña;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIngreseCorreo;
        private System.Windows.Forms.Label lblIngreseCodigo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Button btAtras;
    }
}