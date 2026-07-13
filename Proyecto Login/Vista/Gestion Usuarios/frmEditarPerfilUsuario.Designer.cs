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
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.btAtras = new System.Windows.Forms.Button();
            this.btCambiarRespuestas = new System.Windows.Forms.Button();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.tbRol = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo_P
            // 
            this.lblTitulo_P.AutoSize = true;
            this.lblTitulo_P.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_P.Location = new System.Drawing.Point(157, 0);
            this.lblTitulo_P.Name = "lblTitulo_P";
            this.lblTitulo_P.Size = new System.Drawing.Size(101, 25);
            this.lblTitulo_P.TabIndex = 1;
            this.lblTitulo_P.Text = "MI PERFIL";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(36, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.tbRol);
            this.panel1.Controls.Add(this.tbEmpleado);
            this.panel1.Controls.Add(this.lblEmpleado);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblTitulo_P);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(187, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 118);
            this.panel1.TabIndex = 12;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(36, 33);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 17);
            this.lblEmpleado.TabIndex = 8;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(36, 62);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 17);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol:";
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btCancelar.Location = new System.Drawing.Point(494, 663);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(83, 33);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(35, 663);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 40);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btGuardar_Cambios
            // 
            this.btGuardar_Cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar_Cambios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar_Cambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btGuardar_Cambios.Location = new System.Drawing.Point(228, 558);
            this.btGuardar_Cambios.Name = "btGuardar_Cambios";
            this.btGuardar_Cambios.Size = new System.Drawing.Size(127, 31);
            this.btGuardar_Cambios.TabIndex = 15;
            this.btGuardar_Cambios.Text = "Guardar cambios";
            this.btGuardar_Cambios.UseVisualStyleBackColor = true;
            this.btGuardar_Cambios.Click += new System.EventHandler(this.btGuardar_Cambios_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(20, 410);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(566, 119);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Area";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(379, 41);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(48, 13);
            this.lblPartido.TabIndex = 31;
            this.lblPartido.Text = "Partido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nacionalidad:";
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(87, 38);
            this.cbNacionalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(98, 21);
            this.cbNacionalidad.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 7;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(87, 72);
            this.cbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(99, 21);
            this.cbLocalidad.TabIndex = 32;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(4, 75);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(63, 13);
            this.lblLocalidad.TabIndex = 11;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // cbPartido
            // 
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(451, 38);
            this.cbPartido.Margin = new System.Windows.Forms.Padding(2);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(98, 21);
            this.cbPartido.TabIndex = 24;
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(262, 38);
            this.cbProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(98, 21);
            this.cbProvincia.TabIndex = 23;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(197, 41);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(61, 13);
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
            this.gpDatos.Location = new System.Drawing.Point(20, 189);
            this.gpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gpDatos.Size = new System.Drawing.Size(566, 201);
            this.gpDatos.TabIndex = 36;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos Personales";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(451, 60);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(98, 22);
            this.dtpFechaNac.TabIndex = 33;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(14, 158);
            this.lblCodigoPostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(52, 13);
            this.lblCodigoPostal.TabIndex = 32;
            this.lblCodigoPostal.Text = "C.Postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(74, 154);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(99, 22);
            this.txtCodigoPostal.TabIndex = 31;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(451, 120);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(98, 22);
            this.txtDepartamento.TabIndex = 30;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(252, 122);
            this.txtPiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(98, 22);
            this.txtPiso.TabIndex = 29;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(356, 63);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(63, 13);
            this.lblFechaNac.TabIndex = 28;
            this.lblFechaNac.Text = "Fecha Nac:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(194, 67);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 13);
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
            this.cbSexo.Location = new System.Drawing.Point(74, 60);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(98, 21);
            this.cbSexo.TabIndex = 26;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(22, 63);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 13);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(451, 90);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(98, 22);
            this.txtCalle.TabIndex = 22;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(251, 92);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(99, 22);
            this.txtMail.TabIndex = 21;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 92);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(98, 22);
            this.txtTelefono.TabIndex = 20;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(356, 125);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(88, 13);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento: ";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(197, 129);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(35, 13);
            this.lblPiso.TabIndex = 18;
            this.lblPiso.Text = "Piso: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 125);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 13);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Numero: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(74, 122);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(99, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(252, 63);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(98, 22);
            this.txtGenero.TabIndex = 14;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(451, 26);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(98, 22);
            this.txtDocumento.TabIndex = 12;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(196, 95);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 95);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(356, 95);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 13);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(356, 32);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(71, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 29);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(252, 32);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(98, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(98, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(194, 36);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // btAtras
            // 
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(20, 597);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(71, 31);
            this.btAtras.TabIndex = 38;
            this.btAtras.Text = "Volver";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click_1);
            // 
            // btCambiarRespuestas
            // 
            this.btCambiarRespuestas.Location = new System.Drawing.Point(395, 137);
            this.btCambiarRespuestas.Name = "btCambiarRespuestas";
            this.btCambiarRespuestas.Size = new System.Drawing.Size(191, 23);
            this.btCambiarRespuestas.TabIndex = 39;
            this.btCambiarRespuestas.Text = "Cambiar respuestas de seguridad";
            this.btCambiarRespuestas.UseVisualStyleBackColor = true;
            this.btCambiarRespuestas.Click += new System.EventHandler(this.btCambiarRespuestas_Click);
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(123, 34);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(135, 20);
            this.tbEmpleado.TabIndex = 9;
            // 
            // tbRol
            // 
            this.tbRol.Location = new System.Drawing.Point(123, 60);
            this.tbRol.Name = "tbRol";
            this.tbRol.Size = new System.Drawing.Size(135, 20);
            this.tbRol.TabIndex = 10;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(123, 87);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(135, 20);
            this.tbUsuario.TabIndex = 11;
            // 
            // frmEditarPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 719);
            this.Controls.Add(this.btCambiarRespuestas);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar_Cambios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnVolver;
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
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btCambiarRespuestas;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbRol;
        private System.Windows.Forms.TextBox tbEmpleado;
    }
}