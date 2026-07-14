namespace Vista
{
    partial class frmEditarPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPerfilUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo_P = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar_Cambios = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btCambiarRespuestas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo_P
            // 
            this.lblTitulo_P.AutoSize = true;
            this.lblTitulo_P.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_P.Location = new System.Drawing.Point(209, 0);
            this.lblTitulo_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo_P.Name = "lblTitulo_P";
            this.lblTitulo_P.Size = new System.Drawing.Size(128, 32);
            this.lblTitulo_P.TabIndex = 1;
            this.lblTitulo_P.Text = "MI PERFIL";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(48, 112);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 23);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblEmpleado);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblTitulo_P);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(249, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 144);
            this.panel1.TabIndex = 12;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(48, 41);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(95, 23);
            this.lblEmpleado.TabIndex = 8;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(48, 76);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 23);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol:";
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.Location = new System.Drawing.Point(671, 678);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(111, 41);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btGuardar_Cambios
            // 
            this.btGuardar_Cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar_Cambios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar_Cambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btGuardar_Cambios.Location = new System.Drawing.Point(325, 678);
            this.btGuardar_Cambios.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar_Cambios.Name = "btGuardar_Cambios";
            this.btGuardar_Cambios.Size = new System.Drawing.Size(180, 41);
            this.btGuardar_Cambios.TabIndex = 15;
            this.btGuardar_Cambios.Text = "Guardar cambios";
            this.btGuardar_Cambios.UseVisualStyleBackColor = true;
            this.btGuardar_Cambios.Click += new System.EventHandler(this.btnGuardar_Cambios_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.lblPartido);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbNacionalidad);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbLocalidad);
            this.groupBox2.Controls.Add(this.lblLocalidad);
            this.groupBox2.Controls.Add(this.cbPartido);
            this.groupBox2.Controls.Add(this.cbProvincia);
            this.groupBox2.Controls.Add(this.lblProvincia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(27, 505);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(755, 146);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Area";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(505, 50);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(63, 19);
            this.lblPartido.TabIndex = 31;
            this.lblPartido.Text = "Partido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nacionalidad:";
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(116, 47);
            this.cbNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(129, 27);
            this.cbNacionalidad.TabIndex = 34;
            this.cbNacionalidad.SelectedIndexChanged += new System.EventHandler(this.cbNacionalidad_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 19);
            this.label15.TabIndex = 7;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(116, 89);
            this.cbLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(131, 27);
            this.cbLocalidad.TabIndex = 32;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(5, 92);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(82, 19);
            this.lblLocalidad.TabIndex = 11;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // cbPartido
            // 
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(601, 47);
            this.cbPartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(129, 27);
            this.cbPartido.TabIndex = 24;
            this.cbPartido.SelectedIndexChanged += new System.EventHandler(this.cbPartido_SelectedIndexChanged);
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(349, 47);
            this.cbProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(129, 27);
            this.cbProvincia.TabIndex = 23;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(263, 50);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(80, 19);
            this.lblProvincia.TabIndex = 10;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // gpDatos
            // 
            this.gpDatos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gpDatos.Controls.Add(this.dtpFechaNac);
            this.gpDatos.Controls.Add(this.lblCodigoPostal);
            this.gpDatos.Controls.Add(this.txtCodigoPostal);
            this.gpDatos.Controls.Add(this.txtDepartamento);
            this.gpDatos.Controls.Add(this.txtPiso);
            this.gpDatos.Controls.Add(this.lblFechaNac);
            this.gpDatos.Controls.Add(this.lblGenero);
            this.gpDatos.Controls.Add(this.cbSexo);
            this.gpDatos.Controls.Add(this.lblSexo);
            this.gpDatos.Controls.Add(this.txtCalle);
            this.gpDatos.Controls.Add(this.txtMail);
            this.gpDatos.Controls.Add(this.txtTelefono);
            this.gpDatos.Controls.Add(this.lblDepartamento);
            this.gpDatos.Controls.Add(this.lblPiso);
            this.gpDatos.Controls.Add(this.lblNumero);
            this.gpDatos.Controls.Add(this.txtNumero);
            this.gpDatos.Controls.Add(this.txtGenero);
            this.gpDatos.Controls.Add(this.txtDocumento);
            this.gpDatos.Controls.Add(this.lblMail);
            this.gpDatos.Controls.Add(this.lblTelefono);
            this.gpDatos.Controls.Add(this.label5);
            this.gpDatos.Controls.Add(this.lblCalle);
            this.gpDatos.Controls.Add(this.lblDocumento);
            this.gpDatos.Controls.Add(this.lblNombre);
            this.gpDatos.Controls.Add(this.txtApellido);
            this.gpDatos.Controls.Add(this.txtNombre);
            this.gpDatos.Controls.Add(this.lblApellido);
            this.gpDatos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDatos.ForeColor = System.Drawing.Color.White;
            this.gpDatos.Location = new System.Drawing.Point(27, 233);
            this.gpDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpDatos.Size = new System.Drawing.Size(755, 247);
            this.gpDatos.TabIndex = 36;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos Personales";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(601, 74);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(129, 26);
            this.dtpFechaNac.TabIndex = 33;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(19, 194);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(67, 19);
            this.lblCodigoPostal.TabIndex = 32;
            this.lblCodigoPostal.Text = "C.Postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(99, 190);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(131, 26);
            this.txtCodigoPostal.TabIndex = 31;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(601, 148);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(129, 26);
            this.txtDepartamento.TabIndex = 30;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(336, 150);
            this.txtPiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(129, 26);
            this.txtPiso.TabIndex = 29;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(475, 78);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(81, 19);
            this.lblFechaNac.TabIndex = 28;
            this.lblFechaNac.Text = "Fecha Nac:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(259, 82);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 19);
            this.lblGenero.TabIndex = 27;
            this.lblGenero.Text = "Genero:";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cbSexo.Location = new System.Drawing.Point(99, 74);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(129, 27);
            this.cbSexo.TabIndex = 26;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(29, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 19);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(601, 111);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(129, 26);
            this.txtCalle.TabIndex = 22;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(335, 113);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(131, 26);
            this.txtMail.TabIndex = 21;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 113);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 26);
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(475, 154);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(114, 19);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento: ";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(263, 159);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(45, 19);
            this.lblPiso.TabIndex = 18;
            this.lblPiso.Text = "Piso: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(19, 154);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(72, 19);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Numero: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(99, 150);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(131, 26);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(336, 78);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(129, 26);
            this.txtGenero.TabIndex = 14;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(601, 32);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(129, 26);
            this.txtDocumento.TabIndex = 12;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(261, 117);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 19);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 117);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 19);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(475, 117);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(50, 19);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(475, 39);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(90, 19);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(336, 39);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 26);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(259, 44);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(27, 679);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 41);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btCambiarRespuestas
            // 
            this.btCambiarRespuestas.Location = new System.Drawing.Point(527, 169);
            this.btCambiarRespuestas.Margin = new System.Windows.Forms.Padding(4);
            this.btCambiarRespuestas.Name = "btCambiarRespuestas";
            this.btCambiarRespuestas.Size = new System.Drawing.Size(255, 28);
            this.btCambiarRespuestas.TabIndex = 39;
            this.btCambiarRespuestas.Text = "Cambiar respuestas de seguridad";
            this.btCambiarRespuestas.UseVisualStyleBackColor = true;
            this.btCambiarRespuestas.Click += new System.EventHandler(this.btnCambiarRespuestas_Click);
            // 
            // frmEditarPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 738);
            this.Controls.Add(this.btCambiarRespuestas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar_Cambios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditarPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar perfil | Gastrosft";
            this.Load += new System.EventHandler(this.frmEditarPerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo_P;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btGuardar_Cambios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNacionalidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btCambiarRespuestas;
    }
}