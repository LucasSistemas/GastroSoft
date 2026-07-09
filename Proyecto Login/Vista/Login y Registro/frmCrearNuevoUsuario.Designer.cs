namespace Vista
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtRepetirNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblCrearUsuarioa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMostrarNuevaContraseña = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(109, 246);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(83, 20);
            this.lblNuevaContraseña.TabIndex = 0;
            this.lblNuevaContraseña.Text = "Contraseña";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetir.Location = new System.Drawing.Point(109, 304);
            this.lblRepetir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(135, 20);
            this.lblRepetir.TabIndex = 1;
            this.lblRepetir.Text = "Repetir Contraseña";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.Green;
            this.btnCrearUsuario.Location = new System.Drawing.Point(243, 366);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(128, 49);
            this.btnCrearUsuario.TabIndex = 2;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(275, 240);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(215, 22);
            this.txtNuevaContraseña.TabIndex = 3;
            this.txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txtRepetirNuevaContraseña
            // 
            this.txtRepetirNuevaContraseña.Location = new System.Drawing.Point(275, 304);
            this.txtRepetirNuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetirNuevaContraseña.Name = "txtRepetirNuevaContraseña";
            this.txtRepetirNuevaContraseña.Size = new System.Drawing.Size(215, 22);
            this.txtRepetirNuevaContraseña.TabIndex = 4;
            this.txtRepetirNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // lblCrearUsuarioa
            // 
            this.lblCrearUsuarioa.AutoSize = true;
            this.lblCrearUsuarioa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrearUsuarioa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuarioa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCrearUsuarioa.Location = new System.Drawing.Point(137, 111);
            this.lblCrearUsuarioa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearUsuarioa.Name = "lblCrearUsuarioa";
            this.lblCrearUsuarioa.Size = new System.Drawing.Size(188, 32);
            this.lblCrearUsuarioa.TabIndex = 15;
            this.lblCrearUsuarioa.Text = "Crear Usuario a :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(275, 183);
            this.txtNuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(215, 22);
            this.txtNuevoUsuario.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre de Usuario";
            // 
            // checkMostrarNuevaContraseña
            // 
            this.checkMostrarNuevaContraseña.AutoSize = true;
            this.checkMostrarNuevaContraseña.Location = new System.Drawing.Point(346, 270);
            this.checkMostrarNuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.checkMostrarNuevaContraseña.Name = "checkMostrarNuevaContraseña";
            this.checkMostrarNuevaContraseña.Size = new System.Drawing.Size(144, 20);
            this.checkMostrarNuevaContraseña.TabIndex = 19;
            this.checkMostrarNuevaContraseña.Text = "Mostrar contraseña";
            this.checkMostrarNuevaContraseña.UseVisualStyleBackColor = true;
            this.checkMostrarNuevaContraseña.CheckedChanged += new System.EventHandler(this.checkMostrarNuevaContraseña_CheckedChanged);
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(621, 470);
            this.Controls.Add(this.checkMostrarNuevaContraseña);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCrearUsuarioa);
            this.Controls.Add(this.txtRepetirNuevaContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario | Gastrosoft";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtRepetirNuevaContraseña;
        private System.Windows.Forms.Label lblCrearUsuarioa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMostrarNuevaContraseña;
    }
}