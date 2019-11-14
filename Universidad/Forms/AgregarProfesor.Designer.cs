namespace Universidad.Forms
{
    partial class AgregarProfesor
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
            this.nacimientoLbProf = new System.Windows.Forms.Label();
            this.nacimientoDtpProf = new System.Windows.Forms.DateTimePicker();
            this.matriculaLbProf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profCancelarBt = new System.Windows.Forms.Button();
            this.profAgregarBt = new System.Windows.Forms.Button();
            this.localidadCbProf = new System.Windows.Forms.ComboBox();
            this.provinciaCbProf = new System.Windows.Forms.ComboBox();
            this.paisCbProf = new System.Windows.Forms.ComboBox();
            this.generoCbProf = new System.Windows.Forms.ComboBox();
            this.edadCbProf = new System.Windows.Forms.ComboBox();
            this.direccionTbProf = new System.Windows.Forms.TextBox();
            this.telefonoTbProf = new System.Windows.Forms.TextBox();
            this.dniTbProf = new System.Windows.Forms.TextBox();
            this.apellidoTbProf = new System.Windows.Forms.TextBox();
            this.nombreTbProf = new System.Windows.Forms.TextBox();
            this.generoLbProf = new System.Windows.Forms.Label();
            this.edadLbProf = new System.Windows.Forms.Label();
            this.localidadLbProf = new System.Windows.Forms.Label();
            this.provinciaLbProf = new System.Windows.Forms.Label();
            this.paisLbProf = new System.Windows.Forms.Label();
            this.direccionLbProf = new System.Windows.Forms.Label();
            this.telefonoLbProf = new System.Windows.Forms.Label();
            this.dniLbProf = new System.Windows.Forms.Label();
            this.apellidoLbProf = new System.Windows.Forms.Label();
            this.nombreLbProf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tituloAgregProf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nacimientoLbProf
            // 
            this.nacimientoLbProf.AutoSize = true;
            this.nacimientoLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nacimientoLbProf.Location = new System.Drawing.Point(125, 341);
            this.nacimientoLbProf.Name = "nacimientoLbProf";
            this.nacimientoLbProf.Size = new System.Drawing.Size(60, 13);
            this.nacimientoLbProf.TabIndex = 51;
            this.nacimientoLbProf.Text = "Nacimiento";
            // 
            // nacimientoDtpProf
            // 
            this.nacimientoDtpProf.Location = new System.Drawing.Point(59, 357);
            this.nacimientoDtpProf.Name = "nacimientoDtpProf";
            this.nacimientoDtpProf.Size = new System.Drawing.Size(200, 20);
            this.nacimientoDtpProf.TabIndex = 46;
            // 
            // matriculaLbProf
            // 
            this.matriculaLbProf.AutoSize = true;
            this.matriculaLbProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.matriculaLbProf.Location = new System.Drawing.Point(171, 59);
            this.matriculaLbProf.Name = "matriculaLbProf";
            this.matriculaLbProf.Size = new System.Drawing.Size(64, 25);
            this.matriculaLbProf.TabIndex = 49;
            this.matriculaLbProf.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Matrícula:";
            // 
            // profCancelarBt
            // 
            this.profCancelarBt.BackColor = System.Drawing.Color.IndianRed;
            this.profCancelarBt.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.profCancelarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profCancelarBt.Location = new System.Drawing.Point(220, 426);
            this.profCancelarBt.Name = "profCancelarBt";
            this.profCancelarBt.Size = new System.Drawing.Size(75, 23);
            this.profCancelarBt.TabIndex = 48;
            this.profCancelarBt.Text = "Cancelar";
            this.profCancelarBt.UseVisualStyleBackColor = false;
            this.profCancelarBt.Click += new System.EventHandler(this.ProfCancelarBt_Click);
            // 
            // profAgregarBt
            // 
            this.profAgregarBt.BackColor = System.Drawing.Color.LightGreen;
            this.profAgregarBt.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.profAgregarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profAgregarBt.Location = new System.Drawing.Point(12, 426);
            this.profAgregarBt.Name = "profAgregarBt";
            this.profAgregarBt.Size = new System.Drawing.Size(75, 23);
            this.profAgregarBt.TabIndex = 47;
            this.profAgregarBt.Text = "Agregar";
            this.profAgregarBt.UseVisualStyleBackColor = false;
            this.profAgregarBt.Click += new System.EventHandler(this.ProfAgregarBt_Click);
            // 
            // localidadCbProf
            // 
            this.localidadCbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.localidadCbProf.FormattingEnabled = true;
            this.localidadCbProf.Location = new System.Drawing.Point(156, 308);
            this.localidadCbProf.Name = "localidadCbProf";
            this.localidadCbProf.Size = new System.Drawing.Size(139, 21);
            this.localidadCbProf.TabIndex = 45;
            // 
            // provinciaCbProf
            // 
            this.provinciaCbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.provinciaCbProf.FormattingEnabled = true;
            this.provinciaCbProf.Location = new System.Drawing.Point(12, 308);
            this.provinciaCbProf.Name = "provinciaCbProf";
            this.provinciaCbProf.Size = new System.Drawing.Size(139, 21);
            this.provinciaCbProf.TabIndex = 44;
            this.provinciaCbProf.TextChanged += new System.EventHandler(this.ProvinciaCbProf_TextChanged);
            // 
            // paisCbProf
            // 
            this.paisCbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.paisCbProf.FormattingEnabled = true;
            this.paisCbProf.Location = new System.Drawing.Point(156, 261);
            this.paisCbProf.Name = "paisCbProf";
            this.paisCbProf.Size = new System.Drawing.Size(139, 21);
            this.paisCbProf.TabIndex = 43;
            // 
            // generoCbProf
            // 
            this.generoCbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.generoCbProf.FormattingEnabled = true;
            this.generoCbProf.Location = new System.Drawing.Point(12, 261);
            this.generoCbProf.Name = "generoCbProf";
            this.generoCbProf.Size = new System.Drawing.Size(139, 21);
            this.generoCbProf.TabIndex = 42;
            // 
            // edadCbProf
            // 
            this.edadCbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.edadCbProf.FormattingEnabled = true;
            this.edadCbProf.Location = new System.Drawing.Point(156, 215);
            this.edadCbProf.Name = "edadCbProf";
            this.edadCbProf.Size = new System.Drawing.Size(139, 21);
            this.edadCbProf.TabIndex = 41;
            // 
            // direccionTbProf
            // 
            this.direccionTbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.direccionTbProf.Location = new System.Drawing.Point(12, 215);
            this.direccionTbProf.Name = "direccionTbProf";
            this.direccionTbProf.Size = new System.Drawing.Size(139, 20);
            this.direccionTbProf.TabIndex = 40;
            // 
            // telefonoTbProf
            // 
            this.telefonoTbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.telefonoTbProf.Location = new System.Drawing.Point(156, 170);
            this.telefonoTbProf.Name = "telefonoTbProf";
            this.telefonoTbProf.Size = new System.Drawing.Size(139, 20);
            this.telefonoTbProf.TabIndex = 39;
            this.telefonoTbProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTbProf_KeyPress);
            // 
            // dniTbProf
            // 
            this.dniTbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.dniTbProf.Location = new System.Drawing.Point(12, 170);
            this.dniTbProf.Name = "dniTbProf";
            this.dniTbProf.Size = new System.Drawing.Size(139, 20);
            this.dniTbProf.TabIndex = 38;
            this.dniTbProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTbProf_KeyPress);
            // 
            // apellidoTbProf
            // 
            this.apellidoTbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.apellidoTbProf.Location = new System.Drawing.Point(156, 125);
            this.apellidoTbProf.Name = "apellidoTbProf";
            this.apellidoTbProf.Size = new System.Drawing.Size(139, 20);
            this.apellidoTbProf.TabIndex = 37;
            // 
            // nombreTbProf
            // 
            this.nombreTbProf.BackColor = System.Drawing.Color.AliceBlue;
            this.nombreTbProf.Location = new System.Drawing.Point(12, 125);
            this.nombreTbProf.Name = "nombreTbProf";
            this.nombreTbProf.Size = new System.Drawing.Size(139, 20);
            this.nombreTbProf.TabIndex = 36;
            // 
            // generoLbProf
            // 
            this.generoLbProf.AutoSize = true;
            this.generoLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generoLbProf.Location = new System.Drawing.Point(56, 246);
            this.generoLbProf.Name = "generoLbProf";
            this.generoLbProf.Size = new System.Drawing.Size(42, 13);
            this.generoLbProf.TabIndex = 35;
            this.generoLbProf.Text = "Género";
            // 
            // edadLbProf
            // 
            this.edadLbProf.AutoSize = true;
            this.edadLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.edadLbProf.Location = new System.Drawing.Point(202, 199);
            this.edadLbProf.Name = "edadLbProf";
            this.edadLbProf.Size = new System.Drawing.Size(32, 13);
            this.edadLbProf.TabIndex = 34;
            this.edadLbProf.Text = "Edad";
            // 
            // localidadLbProf
            // 
            this.localidadLbProf.AutoSize = true;
            this.localidadLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.localidadLbProf.Location = new System.Drawing.Point(196, 292);
            this.localidadLbProf.Name = "localidadLbProf";
            this.localidadLbProf.Size = new System.Drawing.Size(53, 13);
            this.localidadLbProf.TabIndex = 33;
            this.localidadLbProf.Text = "Localidad";
            // 
            // provinciaLbProf
            // 
            this.provinciaLbProf.AutoSize = true;
            this.provinciaLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.provinciaLbProf.Location = new System.Drawing.Point(52, 293);
            this.provinciaLbProf.Name = "provinciaLbProf";
            this.provinciaLbProf.Size = new System.Drawing.Size(51, 13);
            this.provinciaLbProf.TabIndex = 32;
            this.provinciaLbProf.Text = "Provincia";
            // 
            // paisLbProf
            // 
            this.paisLbProf.AutoSize = true;
            this.paisLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paisLbProf.Location = new System.Drawing.Point(206, 246);
            this.paisLbProf.Name = "paisLbProf";
            this.paisLbProf.Size = new System.Drawing.Size(29, 13);
            this.paisLbProf.TabIndex = 31;
            this.paisLbProf.Text = "País";
            // 
            // direccionLbProf
            // 
            this.direccionLbProf.AutoSize = true;
            this.direccionLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.direccionLbProf.Location = new System.Drawing.Point(51, 199);
            this.direccionLbProf.Name = "direccionLbProf";
            this.direccionLbProf.Size = new System.Drawing.Size(52, 13);
            this.direccionLbProf.TabIndex = 30;
            this.direccionLbProf.Text = "Dirección";
            // 
            // telefonoLbProf
            // 
            this.telefonoLbProf.AutoSize = true;
            this.telefonoLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.telefonoLbProf.Location = new System.Drawing.Point(195, 154);
            this.telefonoLbProf.Name = "telefonoLbProf";
            this.telefonoLbProf.Size = new System.Drawing.Size(49, 13);
            this.telefonoLbProf.TabIndex = 29;
            this.telefonoLbProf.Text = "Teléfono";
            // 
            // dniLbProf
            // 
            this.dniLbProf.AutoSize = true;
            this.dniLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dniLbProf.Location = new System.Drawing.Point(63, 154);
            this.dniLbProf.Name = "dniLbProf";
            this.dniLbProf.Size = new System.Drawing.Size(26, 13);
            this.dniLbProf.TabIndex = 28;
            this.dniLbProf.Text = "DNI";
            // 
            // apellidoLbProf
            // 
            this.apellidoLbProf.AutoSize = true;
            this.apellidoLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.apellidoLbProf.Location = new System.Drawing.Point(195, 109);
            this.apellidoLbProf.Name = "apellidoLbProf";
            this.apellidoLbProf.Size = new System.Drawing.Size(54, 13);
            this.apellidoLbProf.TabIndex = 27;
            this.apellidoLbProf.Text = "Apellido/s";
            // 
            // nombreLbProf
            // 
            this.nombreLbProf.AutoSize = true;
            this.nombreLbProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nombreLbProf.Location = new System.Drawing.Point(49, 109);
            this.nombreLbProf.Name = "nombreLbProf";
            this.nombreLbProf.Size = new System.Drawing.Size(54, 13);
            this.nombreLbProf.TabIndex = 26;
            this.nombreLbProf.Text = "Nombre/s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 35);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // tituloAgregProf
            // 
            this.tituloAgregProf.AutoSize = true;
            this.tituloAgregProf.BackColor = System.Drawing.Color.SteelBlue;
            this.tituloAgregProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAgregProf.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tituloAgregProf.Location = new System.Drawing.Point(46, 12);
            this.tituloAgregProf.Name = "tituloAgregProf";
            this.tituloAgregProf.Size = new System.Drawing.Size(220, 31);
            this.tituloAgregProf.TabIndex = 53;
            this.tituloAgregProf.Text = "Agregar Profesor";
            // 
            // AgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(307, 461);
            this.Controls.Add(this.tituloAgregProf);
            this.Controls.Add(this.nacimientoLbProf);
            this.Controls.Add(this.nacimientoDtpProf);
            this.Controls.Add(this.matriculaLbProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profCancelarBt);
            this.Controls.Add(this.profAgregarBt);
            this.Controls.Add(this.localidadCbProf);
            this.Controls.Add(this.provinciaCbProf);
            this.Controls.Add(this.paisCbProf);
            this.Controls.Add(this.generoCbProf);
            this.Controls.Add(this.edadCbProf);
            this.Controls.Add(this.direccionTbProf);
            this.Controls.Add(this.telefonoTbProf);
            this.Controls.Add(this.dniTbProf);
            this.Controls.Add(this.apellidoTbProf);
            this.Controls.Add(this.nombreTbProf);
            this.Controls.Add(this.generoLbProf);
            this.Controls.Add(this.edadLbProf);
            this.Controls.Add(this.localidadLbProf);
            this.Controls.Add(this.provinciaLbProf);
            this.Controls.Add(this.paisLbProf);
            this.Controls.Add(this.direccionLbProf);
            this.Controls.Add(this.telefonoLbProf);
            this.Controls.Add(this.dniLbProf);
            this.Controls.Add(this.apellidoLbProf);
            this.Controls.Add(this.nombreLbProf);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 500);
            this.MinimumSize = new System.Drawing.Size(323, 500);
            this.Name = "AgregarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarProfesor_FormClosing);
            this.Load += new System.EventHandler(this.AgregarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nacimientoLbProf;
        private System.Windows.Forms.DateTimePicker nacimientoDtpProf;
        private System.Windows.Forms.Label matriculaLbProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profCancelarBt;
        private System.Windows.Forms.Button profAgregarBt;
        private System.Windows.Forms.ComboBox localidadCbProf;
        private System.Windows.Forms.ComboBox provinciaCbProf;
        private System.Windows.Forms.ComboBox paisCbProf;
        private System.Windows.Forms.ComboBox generoCbProf;
        private System.Windows.Forms.ComboBox edadCbProf;
        private System.Windows.Forms.TextBox direccionTbProf;
        private System.Windows.Forms.TextBox telefonoTbProf;
        private System.Windows.Forms.TextBox dniTbProf;
        private System.Windows.Forms.TextBox apellidoTbProf;
        private System.Windows.Forms.TextBox nombreTbProf;
        private System.Windows.Forms.Label generoLbProf;
        private System.Windows.Forms.Label edadLbProf;
        private System.Windows.Forms.Label localidadLbProf;
        private System.Windows.Forms.Label provinciaLbProf;
        private System.Windows.Forms.Label paisLbProf;
        private System.Windows.Forms.Label direccionLbProf;
        private System.Windows.Forms.Label telefonoLbProf;
        private System.Windows.Forms.Label dniLbProf;
        private System.Windows.Forms.Label apellidoLbProf;
        private System.Windows.Forms.Label nombreLbProf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tituloAgregProf;
    }
}