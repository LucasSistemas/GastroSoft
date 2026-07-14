namespace Vista
{
    partial class frmBitacora
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
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.btnBuscarB = new System.Windows.Forms.Button();
            this.btnLimpiarB = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAccion = new System.Windows.Forms.ComboBox();
            this.lblConsultaBitacora = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(12, 328);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(940, 321);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.SelectionChanged += new System.EventHandler(this.dgvBitacora_SelectionChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(139, 152);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(135, 109);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(98, 20);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Fecha desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(235, 109);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDesde.Size = new System.Drawing.Size(160, 25);
            this.dtpDesde.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(529, 114);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(91, 20);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Fecha hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(637, 109);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 25);
            this.dtpHasta.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(637, 160);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(163, 25);
            this.cbTipo.TabIndex = 7;
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(637, 206);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(163, 25);
            this.cbNivel.TabIndex = 8;
            // 
            // btnBuscarB
            // 
            this.btnBuscarB.BackColor = System.Drawing.Color.White;
            this.btnBuscarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarB.Location = new System.Drawing.Point(302, 262);
            this.btnBuscarB.Name = "btnBuscarB";
            this.btnBuscarB.Size = new System.Drawing.Size(105, 35);
            this.btnBuscarB.TabIndex = 9;
            this.btnBuscarB.Text = "Buscar";
            this.btnBuscarB.UseVisualStyleBackColor = false;
            this.btnBuscarB.Click += new System.EventHandler(this.btnBuscarB_Click);
            // 
            // btnLimpiarB
            // 
            this.btnLimpiarB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarB.Location = new System.Drawing.Point(533, 262);
            this.btnLimpiarB.Name = "btnLimpiarB";
            this.btnLimpiarB.Size = new System.Drawing.Size(105, 35);
            this.btnLimpiarB.TabIndex = 11;
            this.btnLimpiarB.Text = "Limpiar";
            this.btnLimpiarB.UseVisualStyleBackColor = false;
            this.btnLimpiarB.Click += new System.EventHandler(this.btnLimpiarB_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(529, 160);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 20);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(529, 206);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(49, 20);
            this.lblNivel.TabIndex = 13;
            this.lblNivel.Text = "Nivel:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(235, 152);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(160, 25);
            this.cbUsuario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Accion:";
            // 
            // cbAccion
            // 
            this.cbAccion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccion.FormattingEnabled = true;
            this.cbAccion.Location = new System.Drawing.Point(235, 196);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(160, 25);
            this.cbAccion.TabIndex = 16;
            // 
            // lblConsultaBitacora
            // 
            this.lblConsultaBitacora.AutoSize = true;
            this.lblConsultaBitacora.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaBitacora.Location = new System.Drawing.Point(233, 37);
            this.lblConsultaBitacora.Name = "lblConsultaBitacora";
            this.lblConsultaBitacora.Size = new System.Drawing.Size(446, 31);
            this.lblConsultaBitacora.TabIndex = 17;
            this.lblConsultaBitacora.Text = "----------CONSULTA DE BITACORA----------";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(755, 663);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 36);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(964, 711);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblConsultaBitacora);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnLimpiarB);
            this.Controls.Add(this.btnBuscarB);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvBitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora | Gastrosoft";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Button btnBuscarB;
        private System.Windows.Forms.Button btnLimpiarB;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAccion;
        private System.Windows.Forms.Label lblConsultaBitacora;
        private System.Windows.Forms.Button btnVolver;
    }
}