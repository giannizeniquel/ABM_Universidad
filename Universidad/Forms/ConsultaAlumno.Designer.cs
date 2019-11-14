namespace Universidad.Forms
{
    partial class ConsultaAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cursandoDg = new System.Windows.Forms.DataGridView();
            this.anioCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobadoDg = new System.Windows.Forms.DataGridView();
            this.anioAprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaNomApro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidoLb = new System.Windows.Forms.Label();
            this.matriculaLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dniLb = new System.Windows.Forms.Label();
            this.telefonoLb = new System.Windows.Forms.Label();
            this.nacimientoLb = new System.Windows.Forms.Label();
            this.edadLb = new System.Windows.Forms.Label();
            this.generoLb = new System.Windows.Forms.Label();
            this.direccionLb = new System.Windows.Forms.Label();
            this.paisLb = new System.Windows.Forms.Label();
            this.provinciaLb = new System.Windows.Forms.Label();
            this.localidadLb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cursandoDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprobadoDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cursandoDg
            // 
            this.cursandoDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cursandoDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cursandoDg.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.cursandoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursandoDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioCursando,
            this.materiaCursando,
            this.estadoCursando});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cursandoDg.DefaultCellStyle = dataGridViewCellStyle5;
            this.cursandoDg.Location = new System.Drawing.Point(31, 345);
            this.cursandoDg.Name = "cursandoDg";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.cursandoDg.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cursandoDg.Size = new System.Drawing.Size(350, 150);
            this.cursandoDg.TabIndex = 3;
            // 
            // anioCursando
            // 
            this.anioCursando.Frozen = true;
            this.anioCursando.HeaderText = "AÑO";
            this.anioCursando.Name = "anioCursando";
            this.anioCursando.ReadOnly = true;
            this.anioCursando.Width = 55;
            // 
            // materiaCursando
            // 
            this.materiaCursando.Frozen = true;
            this.materiaCursando.HeaderText = "MATERIA";
            this.materiaCursando.Name = "materiaCursando";
            this.materiaCursando.ReadOnly = true;
            this.materiaCursando.Width = 80;
            // 
            // estadoCursando
            // 
            this.estadoCursando.Frozen = true;
            this.estadoCursando.HeaderText = "ESTADO";
            this.estadoCursando.Name = "estadoCursando";
            this.estadoCursando.ReadOnly = true;
            this.estadoCursando.Width = 76;
            // 
            // aprobadoDg
            // 
            this.aprobadoDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.aprobadoDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aprobadoDg.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.aprobadoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aprobadoDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioAprobado,
            this.materiaNomApro,
            this.estadoMateria});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aprobadoDg.DefaultCellStyle = dataGridViewCellStyle7;
            this.aprobadoDg.Location = new System.Drawing.Point(457, 345);
            this.aprobadoDg.Name = "aprobadoDg";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.aprobadoDg.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.aprobadoDg.Size = new System.Drawing.Size(350, 150);
            this.aprobadoDg.TabIndex = 2;
            // 
            // anioAprobado
            // 
            this.anioAprobado.Frozen = true;
            this.anioAprobado.HeaderText = "AÑO";
            this.anioAprobado.Name = "anioAprobado";
            this.anioAprobado.ReadOnly = true;
            this.anioAprobado.Width = 55;
            // 
            // materiaNomApro
            // 
            this.materiaNomApro.Frozen = true;
            this.materiaNomApro.HeaderText = "MATERIA";
            this.materiaNomApro.Name = "materiaNomApro";
            this.materiaNomApro.ReadOnly = true;
            this.materiaNomApro.Width = 80;
            // 
            // estadoMateria
            // 
            this.estadoMateria.Frozen = true;
            this.estadoMateria.HeaderText = "ESTADO";
            this.estadoMateria.Name = "estadoMateria";
            this.estadoMateria.ReadOnly = true;
            this.estadoMateria.Width = 76;
            // 
            // nombreApellidoLb
            // 
            this.nombreApellidoLb.BackColor = System.Drawing.Color.SteelBlue;
            this.nombreApellidoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreApellidoLb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nombreApellidoLb.Location = new System.Drawing.Point(0, 9);
            this.nombreApellidoLb.Name = "nombreApellidoLb";
            this.nombreApellidoLb.Size = new System.Drawing.Size(834, 33);
            this.nombreApellidoLb.TabIndex = 4;
            this.nombreApellidoLb.Text = "Nombre y Apellido";
            this.nombreApellidoLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matriculaLb
            // 
            this.matriculaLb.AutoSize = true;
            this.matriculaLb.BackColor = System.Drawing.Color.SteelBlue;
            this.matriculaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaLb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.matriculaLb.Location = new System.Drawing.Point(437, 56);
            this.matriculaLb.Name = "matriculaLb";
            this.matriculaLb.Size = new System.Drawing.Size(68, 18);
            this.matriculaLb.TabIndex = 5;
            this.matriculaLb.Text = "matricula";
            this.matriculaLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "D.N.I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Provincia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(600, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Genero";
            // 
            // dniLb
            // 
            this.dniLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dniLb.AutoSize = true;
            this.dniLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dniLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.dniLb.Location = new System.Drawing.Point(27, 143);
            this.dniLb.Margin = new System.Windows.Forms.Padding(0);
            this.dniLb.Name = "dniLb";
            this.dniLb.Size = new System.Drawing.Size(45, 20);
            this.dniLb.TabIndex = 15;
            this.dniLb.Text = "D.N.I";
            this.dniLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonoLb
            // 
            this.telefonoLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonoLb.AutoSize = true;
            this.telefonoLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telefonoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.telefonoLb.Location = new System.Drawing.Point(173, 143);
            this.telefonoLb.Margin = new System.Windows.Forms.Padding(0);
            this.telefonoLb.Name = "telefonoLb";
            this.telefonoLb.Size = new System.Drawing.Size(45, 20);
            this.telefonoLb.TabIndex = 16;
            this.telefonoLb.Text = "D.N.I";
            this.telefonoLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nacimientoLb
            // 
            this.nacimientoLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nacimientoLb.AutoSize = true;
            this.nacimientoLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nacimientoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimientoLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.nacimientoLb.Location = new System.Drawing.Point(353, 143);
            this.nacimientoLb.Margin = new System.Windows.Forms.Padding(0);
            this.nacimientoLb.Name = "nacimientoLb";
            this.nacimientoLb.Size = new System.Drawing.Size(45, 20);
            this.nacimientoLb.TabIndex = 17;
            this.nacimientoLb.Text = "D.N.I";
            this.nacimientoLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edadLb
            // 
            this.edadLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edadLb.AutoSize = true;
            this.edadLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edadLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.edadLb.Location = new System.Drawing.Point(513, 143);
            this.edadLb.Margin = new System.Windows.Forms.Padding(0);
            this.edadLb.Name = "edadLb";
            this.edadLb.Size = new System.Drawing.Size(45, 20);
            this.edadLb.TabIndex = 18;
            this.edadLb.Text = "D.N.I";
            this.edadLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generoLb
            // 
            this.generoLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generoLb.AutoSize = true;
            this.generoLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.generoLb.Location = new System.Drawing.Point(600, 143);
            this.generoLb.Margin = new System.Windows.Forms.Padding(0);
            this.generoLb.Name = "generoLb";
            this.generoLb.Size = new System.Drawing.Size(45, 20);
            this.generoLb.TabIndex = 19;
            this.generoLb.Text = "D.N.I";
            this.generoLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direccionLb
            // 
            this.direccionLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionLb.AutoSize = true;
            this.direccionLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.direccionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.direccionLb.Location = new System.Drawing.Point(703, 143);
            this.direccionLb.Margin = new System.Windows.Forms.Padding(0);
            this.direccionLb.Name = "direccionLb";
            this.direccionLb.Size = new System.Drawing.Size(45, 20);
            this.direccionLb.TabIndex = 20;
            this.direccionLb.Text = "D.N.I";
            this.direccionLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paisLb
            // 
            this.paisLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paisLb.AutoSize = true;
            this.paisLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paisLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.paisLb.Location = new System.Drawing.Point(234, 220);
            this.paisLb.Margin = new System.Windows.Forms.Padding(0);
            this.paisLb.Name = "paisLb";
            this.paisLb.Size = new System.Drawing.Size(45, 20);
            this.paisLb.TabIndex = 21;
            this.paisLb.Text = "D.N.I";
            this.paisLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // provinciaLb
            // 
            this.provinciaLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provinciaLb.AutoSize = true;
            this.provinciaLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.provinciaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.provinciaLb.Location = new System.Drawing.Point(381, 220);
            this.provinciaLb.Margin = new System.Windows.Forms.Padding(0);
            this.provinciaLb.Name = "provinciaLb";
            this.provinciaLb.Size = new System.Drawing.Size(45, 20);
            this.provinciaLb.TabIndex = 22;
            this.provinciaLb.Text = "D.N.I";
            this.provinciaLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localidadLb
            // 
            this.localidadLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localidadLb.AutoSize = true;
            this.localidadLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localidadLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.localidadLb.Location = new System.Drawing.Point(511, 220);
            this.localidadLb.Margin = new System.Windows.Forms.Padding(0);
            this.localidadLb.Name = "localidadLb";
            this.localidadLb.Size = new System.Drawing.Size(45, 20);
            this.localidadLb.TabIndex = 23;
            this.localidadLb.Text = "D.N.I";
            this.localidadLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(363, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Matricula:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(522, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Materias aprobadas";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.SteelBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(134, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "Cursando";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(2, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 0);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(448, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 209);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(22, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(366, 209);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Location = new System.Drawing.Point(0, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(834, 83);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // ConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(835, 530);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.localidadLb);
            this.Controls.Add(this.provinciaLb);
            this.Controls.Add(this.paisLb);
            this.Controls.Add(this.direccionLb);
            this.Controls.Add(this.generoLb);
            this.Controls.Add(this.edadLb);
            this.Controls.Add(this.nacimientoLb);
            this.Controls.Add(this.telefonoLb);
            this.Controls.Add(this.dniLb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matriculaLb);
            this.Controls.Add(this.nombreApellidoLb);
            this.Controls.Add(this.cursandoDg);
            this.Controls.Add(this.aprobadoDg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Alumno";
            this.Load += new System.EventHandler(this.ConsultaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursandoDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprobadoDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cursandoDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaCursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCursando;
        private System.Windows.Forms.DataGridView aprobadoDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioAprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaNomApro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMateria;
        private System.Windows.Forms.Label nombreApellidoLb;
        private System.Windows.Forms.Label matriculaLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dniLb;
        private System.Windows.Forms.Label telefonoLb;
        private System.Windows.Forms.Label nacimientoLb;
        private System.Windows.Forms.Label edadLb;
        private System.Windows.Forms.Label generoLb;
        private System.Windows.Forms.Label direccionLb;
        private System.Windows.Forms.Label paisLb;
        private System.Windows.Forms.Label provinciaLb;
        private System.Windows.Forms.Label localidadLb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}