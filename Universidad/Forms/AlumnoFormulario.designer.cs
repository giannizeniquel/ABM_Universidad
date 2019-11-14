namespace Universidad.Forms
{
    partial class AlumnoFormulario
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
            this.Nombre_ALabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.telefonoTb = new System.Windows.Forms.TextBox();
            this.direccionTb = new System.Windows.Forms.TextBox();
            this.apellidoTb = new System.Windows.Forms.TextBox();
            this.dniTb = new System.Windows.Forms.TextBox();
            this.paisesCb = new System.Windows.Forms.ComboBox();
            this.provinciasCb = new System.Windows.Forms.ComboBox();
            this.localidadesCb = new System.Windows.Forms.ComboBox();
            this.generoCb = new System.Windows.Forms.ComboBox();
            this.edadCb = new System.Windows.Forms.ComboBox();
            this.agregarBt = new System.Windows.Forms.Button();
            this.cancerlarBt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.matriculaLb = new System.Windows.Forms.Label();
            this.nacimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre_ALabel
            // 
            this.Nombre_ALabel.AutoSize = true;
            this.Nombre_ALabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Nombre_ALabel.Location = new System.Drawing.Point(49, 109);
            this.Nombre_ALabel.Name = "Nombre_ALabel";
            this.Nombre_ALabel.Size = new System.Drawing.Size(54, 13);
            this.Nombre_ALabel.TabIndex = 0;
            this.Nombre_ALabel.Text = "Nombre/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(195, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido/s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(63, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(206, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(195, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(51, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(52, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Provincia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(196, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(202, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Edad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Location = new System.Drawing.Point(56, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Alumno";
            // 
            // nombreTb
            // 
            this.nombreTb.BackColor = System.Drawing.Color.AliceBlue;
            this.nombreTb.Location = new System.Drawing.Point(12, 125);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(139, 20);
            this.nombreTb.TabIndex = 1;
            // 
            // telefonoTb
            // 
            this.telefonoTb.BackColor = System.Drawing.Color.AliceBlue;
            this.telefonoTb.Location = new System.Drawing.Point(156, 170);
            this.telefonoTb.Name = "telefonoTb";
            this.telefonoTb.Size = new System.Drawing.Size(139, 20);
            this.telefonoTb.TabIndex = 4;
            this.telefonoTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTb_KeyPress);
            // 
            // direccionTb
            // 
            this.direccionTb.BackColor = System.Drawing.Color.AliceBlue;
            this.direccionTb.Location = new System.Drawing.Point(12, 215);
            this.direccionTb.Name = "direccionTb";
            this.direccionTb.Size = new System.Drawing.Size(139, 20);
            this.direccionTb.TabIndex = 5;
            // 
            // apellidoTb
            // 
            this.apellidoTb.BackColor = System.Drawing.Color.AliceBlue;
            this.apellidoTb.Location = new System.Drawing.Point(156, 125);
            this.apellidoTb.Name = "apellidoTb";
            this.apellidoTb.Size = new System.Drawing.Size(139, 20);
            this.apellidoTb.TabIndex = 2;
            // 
            // dniTb
            // 
            this.dniTb.BackColor = System.Drawing.Color.AliceBlue;
            this.dniTb.Location = new System.Drawing.Point(12, 170);
            this.dniTb.Name = "dniTb";
            this.dniTb.Size = new System.Drawing.Size(139, 20);
            this.dniTb.TabIndex = 3;
            this.dniTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTb_KeyPress);
            // 
            // paisesCb
            // 
            this.paisesCb.BackColor = System.Drawing.Color.AliceBlue;
            this.paisesCb.FormattingEnabled = true;
            this.paisesCb.Location = new System.Drawing.Point(156, 261);
            this.paisesCb.Name = "paisesCb";
            this.paisesCb.Size = new System.Drawing.Size(139, 21);
            this.paisesCb.TabIndex = 8;
            // 
            // provinciasCb
            // 
            this.provinciasCb.BackColor = System.Drawing.Color.AliceBlue;
            this.provinciasCb.FormattingEnabled = true;
            this.provinciasCb.Location = new System.Drawing.Point(12, 308);
            this.provinciasCb.Name = "provinciasCb";
            this.provinciasCb.Size = new System.Drawing.Size(139, 21);
            this.provinciasCb.TabIndex = 9;
            this.provinciasCb.TextChanged += new System.EventHandler(this.ProvinciasCb_TextChanged);
            // 
            // localidadesCb
            // 
            this.localidadesCb.BackColor = System.Drawing.Color.AliceBlue;
            this.localidadesCb.FormattingEnabled = true;
            this.localidadesCb.Location = new System.Drawing.Point(156, 308);
            this.localidadesCb.Name = "localidadesCb";
            this.localidadesCb.Size = new System.Drawing.Size(139, 21);
            this.localidadesCb.TabIndex = 10;
            // 
            // generoCb
            // 
            this.generoCb.BackColor = System.Drawing.Color.AliceBlue;
            this.generoCb.FormattingEnabled = true;
            this.generoCb.Location = new System.Drawing.Point(12, 261);
            this.generoCb.Name = "generoCb";
            this.generoCb.Size = new System.Drawing.Size(139, 21);
            this.generoCb.TabIndex = 7;
            // 
            // edadCb
            // 
            this.edadCb.BackColor = System.Drawing.Color.AliceBlue;
            this.edadCb.FormattingEnabled = true;
            this.edadCb.Location = new System.Drawing.Point(156, 215);
            this.edadCb.Name = "edadCb";
            this.edadCb.Size = new System.Drawing.Size(139, 21);
            this.edadCb.TabIndex = 6;
            // 
            // agregarBt
            // 
            this.agregarBt.BackColor = System.Drawing.Color.LightGreen;
            this.agregarBt.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.agregarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregarBt.Location = new System.Drawing.Point(12, 426);
            this.agregarBt.Name = "agregarBt";
            this.agregarBt.Size = new System.Drawing.Size(75, 23);
            this.agregarBt.TabIndex = 12;
            this.agregarBt.Text = "Agregar";
            this.agregarBt.UseVisualStyleBackColor = false;
            this.agregarBt.Click += new System.EventHandler(this.AgregarBt_Click);
            // 
            // cancerlarBt
            // 
            this.cancerlarBt.BackColor = System.Drawing.Color.IndianRed;
            this.cancerlarBt.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.cancerlarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancerlarBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancerlarBt.Location = new System.Drawing.Point(220, 426);
            this.cancerlarBt.Name = "cancerlarBt";
            this.cancerlarBt.Size = new System.Drawing.Size(75, 23);
            this.cancerlarBt.TabIndex = 13;
            this.cancerlarBt.Text = "Cancelar";
            this.cancerlarBt.UseVisualStyleBackColor = false;
            this.cancerlarBt.Click += new System.EventHandler(this.CancerlarBt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(61, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Matrícula:";
            // 
            // matriculaLb
            // 
            this.matriculaLb.AutoSize = true;
            this.matriculaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaLb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.matriculaLb.Location = new System.Drawing.Point(171, 59);
            this.matriculaLb.Name = "matriculaLb";
            this.matriculaLb.Size = new System.Drawing.Size(75, 25);
            this.matriculaLb.TabIndex = 29;
            this.matriculaLb.Text = "label12";
            // 
            // nacimientoDtp
            // 
            this.nacimientoDtp.Location = new System.Drawing.Point(59, 357);
            this.nacimientoDtp.Name = "nacimientoDtp";
            this.nacimientoDtp.Size = new System.Drawing.Size(200, 20);
            this.nacimientoDtp.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Location = new System.Drawing.Point(125, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nacimiento";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 35);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 35);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // AlumnoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(307, 461);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nacimientoDtp);
            this.Controls.Add(this.matriculaLb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancerlarBt);
            this.Controls.Add(this.agregarBt);
            this.Controls.Add(this.edadCb);
            this.Controls.Add(this.generoCb);
            this.Controls.Add(this.localidadesCb);
            this.Controls.Add(this.provinciasCb);
            this.Controls.Add(this.paisesCb);
            this.Controls.Add(this.dniTb);
            this.Controls.Add(this.direccionTb);
            this.Controls.Add(this.apellidoTb);
            this.Controls.Add(this.telefonoTb);
            this.Controls.Add(this.nombreTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_ALabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 500);
            this.MinimumSize = new System.Drawing.Size(323, 500);
            this.Name = "AlumnoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlumnoFormulario_FormClosing);
            this.Load += new System.EventHandler(this.AlumnoFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre_ALabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.TextBox telefonoTb;
        private System.Windows.Forms.TextBox direccionTb;
        private System.Windows.Forms.TextBox apellidoTb;
        private System.Windows.Forms.TextBox dniTb;
        private System.Windows.Forms.ComboBox paisesCb;
        private System.Windows.Forms.ComboBox provinciasCb;
        private System.Windows.Forms.ComboBox localidadesCb;
        private System.Windows.Forms.ComboBox generoCb;
        private System.Windows.Forms.ComboBox edadCb;
        private System.Windows.Forms.Button agregarBt;
        private System.Windows.Forms.Button cancerlarBt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label matriculaLb;
        private System.Windows.Forms.DateTimePicker nacimientoDtp;
        private System.Windows.Forms.Label label12;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}