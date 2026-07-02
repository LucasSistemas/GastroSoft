namespace Vista
{
    partial class frmAltaEmpleadosRegistrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaEmpleadosRegistrados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAltaUsuario = new System.Windows.Forms.DataGridView();
            this.btDarAlta = new System.Windows.Forms.Button();
            this.btRechazar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btC_Rechazo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAltaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(201, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 155);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLEADOS PENDIENTES DE APROBACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visualice los usuarios registrados y autorice su acceso al sistema.";
            // 
            // dgAltaUsuario
            // 
            this.dgAltaUsuario.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgAltaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAltaUsuario.Location = new System.Drawing.Point(12, 246);
            this.dgAltaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgAltaUsuario.Name = "dgAltaUsuario";
            this.dgAltaUsuario.RowHeadersWidth = 51;
            this.dgAltaUsuario.Size = new System.Drawing.Size(689, 144);
            this.dgAltaUsuario.TabIndex = 5;
            // 
            // btDarAlta
            // 
            this.btDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDarAlta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDarAlta.ForeColor = System.Drawing.Color.Green;
            this.btDarAlta.Location = new System.Drawing.Point(264, 411);
            this.btDarAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btDarAlta.Name = "btDarAlta";
            this.btDarAlta.Size = new System.Drawing.Size(79, 39);
            this.btDarAlta.TabIndex = 7;
            this.btDarAlta.Text = "Dar alta";
            this.btDarAlta.UseVisualStyleBackColor = true;
            // 
            // btRechazar
            // 
            this.btRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRechazar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechazar.ForeColor = System.Drawing.Color.Maroon;
            this.btRechazar.Location = new System.Drawing.Point(367, 411);
            this.btRechazar.Margin = new System.Windows.Forms.Padding(4);
            this.btRechazar.Name = "btRechazar";
            this.btRechazar.Size = new System.Drawing.Size(79, 39);
            this.btRechazar.TabIndex = 8;
            this.btRechazar.Text = "Rechazar";
            this.btRechazar.UseVisualStyleBackColor = true;
            // 
            // btAtras
            // 
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(80, 738);
            this.btAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(95, 38);
            this.btAtras.TabIndex = 9;
            this.btAtras.Text = "Volver";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.Color.Blue;
            this.btActualizar.Location = new System.Drawing.Point(469, 411);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(87, 39);
            this.btActualizar.TabIndex = 10;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(583, 411);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(79, 39);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 509);
            this.textBox1.MaxLength = 500;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(689, 174);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Motivo:";
            // 
            // btC_Rechazo
            // 
            this.btC_Rechazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC_Rechazo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC_Rechazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btC_Rechazo.Location = new System.Drawing.Point(495, 734);
            this.btC_Rechazo.Name = "btC_Rechazo";
            this.btC_Rechazo.Size = new System.Drawing.Size(167, 42);
            this.btC_Rechazo.TabIndex = 14;
            this.btC_Rechazo.Text = "Confirmar rechazo";
            this.btC_Rechazo.UseVisualStyleBackColor = true;
            // 
            // frmAltaEmpleadosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 791);
            this.ControlBox = false;
            this.Controls.Add(this.btC_Rechazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btRechazar);
            this.Controls.Add(this.btDarAlta);
            this.Controls.Add(this.dgAltaUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaEmpleadosRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de usuarios | Gastrosoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAltaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgAltaUsuario;
        private System.Windows.Forms.Button btDarAlta;
        private System.Windows.Forms.Button btRechazar;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btC_Rechazo;
    }
}