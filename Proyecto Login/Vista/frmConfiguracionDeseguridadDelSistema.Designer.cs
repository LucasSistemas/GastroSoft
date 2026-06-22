namespace Vista
{
    partial class frmConfiguracionDeseguridadDelSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionDeseguridadDelSistema));
            this.gbpoliticas = new System.Windows.Forms.GroupBox();
            this.cbNoRepetir = new System.Windows.Forms.CheckBox();
            this.cbCaracteres = new System.Windows.Forms.CheckBox();
            this.cbNumeros = new System.Windows.Forms.CheckBox();
            this.cbMayuscula = new System.Windows.Forms.CheckBox();
            this.nudLongitud = new System.Windows.Forms.NumericUpDown();
            this.lblTituloLongitud = new System.Windows.Forms.Label();
            this.rbDos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPreguntas = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rbCinco = new System.Windows.Forms.RadioButton();
            this.rbTres = new System.Windows.Forms.RadioButton();
            this.gbValidaciones = new System.Windows.Forms.GroupBox();
            this.cbValidar = new System.Windows.Forms.CheckBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbpoliticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPreguntas.SuspendLayout();
            this.gbValidaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpoliticas
            // 
            this.gbpoliticas.Controls.Add(this.cbNoRepetir);
            this.gbpoliticas.Controls.Add(this.cbCaracteres);
            this.gbpoliticas.Controls.Add(this.cbNumeros);
            this.gbpoliticas.Controls.Add(this.cbMayuscula);
            this.gbpoliticas.Controls.Add(this.nudLongitud);
            this.gbpoliticas.Controls.Add(this.lblTituloLongitud);
            this.gbpoliticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpoliticas.Location = new System.Drawing.Point(133, 178);
            this.gbpoliticas.Margin = new System.Windows.Forms.Padding(4);
            this.gbpoliticas.Name = "gbpoliticas";
            this.gbpoliticas.Padding = new System.Windows.Forms.Padding(4);
            this.gbpoliticas.Size = new System.Drawing.Size(535, 130);
            this.gbpoliticas.TabIndex = 0;
            this.gbpoliticas.TabStop = false;
            this.gbpoliticas.Text = "Politicas de contraseña";
            this.gbpoliticas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbNoRepetir
            // 
            this.cbNoRepetir.AutoSize = true;
            this.cbNoRepetir.Location = new System.Drawing.Point(209, 65);
            this.cbNoRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.cbNoRepetir.Name = "cbNoRepetir";
            this.cbNoRepetir.Size = new System.Drawing.Size(181, 24);
            this.cbNoRepetir.TabIndex = 5;
            this.cbNoRepetir.Text = "No repetir contraseñas";
            this.cbNoRepetir.UseVisualStyleBackColor = true;
            // 
            // cbCaracteres
            // 
            this.cbCaracteres.AutoSize = true;
            this.cbCaracteres.Location = new System.Drawing.Point(209, 89);
            this.cbCaracteres.Margin = new System.Windows.Forms.Padding(4);
            this.cbCaracteres.Name = "cbCaracteres";
            this.cbCaracteres.Size = new System.Drawing.Size(172, 24);
            this.cbCaracteres.TabIndex = 4;
            this.cbCaracteres.Text = "Caracteres especiales";
            this.cbCaracteres.UseVisualStyleBackColor = true;
            // 
            // cbNumeros
            // 
            this.cbNumeros.AutoSize = true;
            this.cbNumeros.Location = new System.Drawing.Point(47, 89);
            this.cbNumeros.Margin = new System.Windows.Forms.Padding(4);
            this.cbNumeros.Name = "cbNumeros";
            this.cbNumeros.Size = new System.Drawing.Size(91, 24);
            this.cbNumeros.TabIndex = 3;
            this.cbNumeros.Text = "Numeros";
            this.cbNumeros.UseVisualStyleBackColor = true;
            this.cbNumeros.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbMayuscula
            // 
            this.cbMayuscula.AutoSize = true;
            this.cbMayuscula.Location = new System.Drawing.Point(47, 65);
            this.cbMayuscula.Margin = new System.Windows.Forms.Padding(4);
            this.cbMayuscula.Name = "cbMayuscula";
            this.cbMayuscula.Size = new System.Drawing.Size(106, 24);
            this.cbMayuscula.TabIndex = 2;
            this.cbMayuscula.Text = "Mayusculas";
            this.cbMayuscula.UseVisualStyleBackColor = true;
            // 
            // nudLongitud
            // 
            this.nudLongitud.Location = new System.Drawing.Point(192, 30);
            this.nudLongitud.Margin = new System.Windows.Forms.Padding(4);
            this.nudLongitud.Name = "nudLongitud";
            this.nudLongitud.Size = new System.Drawing.Size(47, 27);
            this.nudLongitud.TabIndex = 1;
            this.nudLongitud.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLongitud.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblTituloLongitud
            // 
            this.lblTituloLongitud.AutoSize = true;
            this.lblTituloLongitud.Location = new System.Drawing.Point(40, 32);
            this.lblTituloLongitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloLongitud.Name = "lblTituloLongitud";
            this.lblTituloLongitud.Size = new System.Drawing.Size(125, 20);
            this.lblTituloLongitud.TabIndex = 0;
            this.lblTituloLongitud.Text = "Longitud minima:";
            // 
            // rbDos
            // 
            this.rbDos.AutoSize = true;
            this.rbDos.Location = new System.Drawing.Point(44, 70);
            this.rbDos.Margin = new System.Windows.Forms.Padding(4);
            this.rbDos.Name = "rbDos";
            this.rbDos.Size = new System.Drawing.Size(38, 24);
            this.rbDos.TabIndex = 2;
            this.rbDos.TabStop = true;
            this.rbDos.Text = "2";
            this.rbDos.UseVisualStyleBackColor = true;
            this.rbDos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Configuracion de seguridad del sistema";
            // 
            // gbPreguntas
            // 
            this.gbPreguntas.Controls.Add(this.lblCantidad);
            this.gbPreguntas.Controls.Add(this.rbCinco);
            this.gbPreguntas.Controls.Add(this.rbTres);
            this.gbPreguntas.Controls.Add(this.rbDos);
            this.gbPreguntas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreguntas.Location = new System.Drawing.Point(133, 343);
            this.gbPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.gbPreguntas.Name = "gbPreguntas";
            this.gbPreguntas.Padding = new System.Windows.Forms.Padding(4);
            this.gbPreguntas.Size = new System.Drawing.Size(535, 123);
            this.gbPreguntas.TabIndex = 5;
            this.gbPreguntas.TabStop = false;
            this.gbPreguntas.Text = "Preguntas de seguridad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(40, 34);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // rbCinco
            // 
            this.rbCinco.AutoSize = true;
            this.rbCinco.Location = new System.Drawing.Point(404, 70);
            this.rbCinco.Margin = new System.Windows.Forms.Padding(4);
            this.rbCinco.Name = "rbCinco";
            this.rbCinco.Size = new System.Drawing.Size(38, 24);
            this.rbCinco.TabIndex = 4;
            this.rbCinco.TabStop = true;
            this.rbCinco.Text = "5";
            this.rbCinco.UseVisualStyleBackColor = true;
            // 
            // rbTres
            // 
            this.rbTres.AutoSize = true;
            this.rbTres.Location = new System.Drawing.Point(209, 70);
            this.rbTres.Margin = new System.Windows.Forms.Padding(4);
            this.rbTres.Name = "rbTres";
            this.rbTres.Size = new System.Drawing.Size(38, 24);
            this.rbTres.TabIndex = 3;
            this.rbTres.TabStop = true;
            this.rbTres.Text = "3";
            this.rbTres.UseVisualStyleBackColor = true;
            // 
            // gbValidaciones
            // 
            this.gbValidaciones.Controls.Add(this.cbValidar);
            this.gbValidaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValidaciones.Location = new System.Drawing.Point(133, 532);
            this.gbValidaciones.Margin = new System.Windows.Forms.Padding(4);
            this.gbValidaciones.Name = "gbValidaciones";
            this.gbValidaciones.Padding = new System.Windows.Forms.Padding(4);
            this.gbValidaciones.Size = new System.Drawing.Size(535, 123);
            this.gbValidaciones.TabIndex = 7;
            this.gbValidaciones.TabStop = false;
            this.gbValidaciones.Text = "Validaciones adicionales";
            // 
            // cbValidar
            // 
            this.cbValidar.AutoSize = true;
            this.cbValidar.Location = new System.Drawing.Point(44, 57);
            this.cbValidar.Margin = new System.Windows.Forms.Padding(4);
            this.cbValidar.Name = "cbValidar";
            this.cbValidar.Size = new System.Drawing.Size(193, 24);
            this.cbValidar.TabIndex = 6;
            this.cbValidar.Text = "Validar datos personales";
            this.cbValidar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.Green;
            this.btGuardar.Location = new System.Drawing.Point(342, 663);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(131, 44);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar ";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.White;
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(133, 697);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(131, 44);
            this.btVolver.TabIndex = 9;
            this.btVolver.Text = "Vover";
            this.btVolver.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Red;
            this.btCancelar.Location = new System.Drawing.Point(537, 697);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(131, 44);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // frmConfiguracionDeseguridadDelSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 764);
            this.ControlBox = false;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.gbValidaciones);
            this.Controls.Add(this.gbPreguntas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbpoliticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfiguracionDeseguridadDelSistema";
            this.Text = "Configuracion de seguridad del sistema | Gastrosft";
            this.Load += new System.EventHandler(this.frmConfiguracionDeseguridadDelSistema_Load);
            this.gbpoliticas.ResumeLayout(false);
            this.gbpoliticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPreguntas.ResumeLayout(false);
            this.gbPreguntas.PerformLayout();
            this.gbValidaciones.ResumeLayout(false);
            this.gbValidaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpoliticas;
        private System.Windows.Forms.RadioButton rbDos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPreguntas;
        private System.Windows.Forms.GroupBox gbValidaciones;
        private System.Windows.Forms.NumericUpDown nudLongitud;
        private System.Windows.Forms.Label lblTituloLongitud;
        private System.Windows.Forms.CheckBox cbNoRepetir;
        private System.Windows.Forms.CheckBox cbCaracteres;
        private System.Windows.Forms.CheckBox cbNumeros;
        private System.Windows.Forms.CheckBox cbMayuscula;
        private System.Windows.Forms.RadioButton rbCinco;
        private System.Windows.Forms.RadioButton rbTres;
        private System.Windows.Forms.CheckBox cbValidar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btCancelar;
    }
}