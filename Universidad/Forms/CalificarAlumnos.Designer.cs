namespace Universidad.Forms
{
    partial class CalificarAlumnos
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
            this.alumnosDg = new System.Windows.Forms.DataGridView();
            this.matriculaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiasProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiasCb = new System.Windows.Forms.ComboBox();
            this.guardarBt = new System.Windows.Forms.Button();
            this.alumnosAprobDg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosAprobDg)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDg
            // 
            this.alumnosDg.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.alumnosDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaA,
            this.apellidoA,
            this.nombreA,
            this.materiasProfesor,
            this.parcial1,
            this.parcial2,
            this.parcial3,
            this.notaFinal});
            this.alumnosDg.Location = new System.Drawing.Point(12, 44);
            this.alumnosDg.Name = "alumnosDg";
            this.alumnosDg.Size = new System.Drawing.Size(981, 194);
            this.alumnosDg.TabIndex = 0;
            // 
            // matriculaA
            // 
            this.matriculaA.HeaderText = "Matricula";
            this.matriculaA.Name = "matriculaA";
            this.matriculaA.ReadOnly = true;
            // 
            // apellidoA
            // 
            this.apellidoA.HeaderText = "Apellido";
            this.apellidoA.Name = "apellidoA";
            this.apellidoA.ReadOnly = true;
            // 
            // nombreA
            // 
            this.nombreA.HeaderText = "Nombre";
            this.nombreA.Name = "nombreA";
            this.nombreA.ReadOnly = true;
            // 
            // materiasProfesor
            // 
            this.materiasProfesor.HeaderText = "Materia";
            this.materiasProfesor.Name = "materiasProfesor";
            this.materiasProfesor.ReadOnly = true;
            // 
            // parcial1
            // 
            this.parcial1.HeaderText = "Parcial 1";
            this.parcial1.Name = "parcial1";
            // 
            // parcial2
            // 
            this.parcial2.HeaderText = "Parcial 2";
            this.parcial2.Name = "parcial2";
            // 
            // parcial3
            // 
            this.parcial3.HeaderText = "Parcial 3";
            this.parcial3.Name = "parcial3";
            // 
            // notaFinal
            // 
            this.notaFinal.HeaderText = "Nota Final";
            this.notaFinal.Name = "notaFinal";
            // 
            // materiasCb
            // 
            this.materiasCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasCb.FormattingEnabled = true;
            this.materiasCb.Location = new System.Drawing.Point(577, 12);
            this.materiasCb.Name = "materiasCb";
            this.materiasCb.Size = new System.Drawing.Size(416, 26);
            this.materiasCb.TabIndex = 1;
            this.materiasCb.SelectedIndexChanged += new System.EventHandler(this.MateriasCb_SelectedIndexChanged);
            // 
            // guardarBt
            // 
            this.guardarBt.BackColor = System.Drawing.Color.LightGreen;
            this.guardarBt.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.guardarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBt.Location = new System.Drawing.Point(12, 478);
            this.guardarBt.Name = "guardarBt";
            this.guardarBt.Size = new System.Drawing.Size(75, 23);
            this.guardarBt.TabIndex = 2;
            this.guardarBt.Text = "Guardar";
            this.guardarBt.UseVisualStyleBackColor = false;
            this.guardarBt.Click += new System.EventHandler(this.GuardarBt_Click);
            // 
            // alumnosAprobDg
            // 
            this.alumnosAprobDg.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.alumnosAprobDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosAprobDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.alumnosAprobDg.Location = new System.Drawing.Point(12, 244);
            this.alumnosAprobDg.Name = "alumnosAprobDg";
            this.alumnosAprobDg.Size = new System.Drawing.Size(981, 194);
            this.alumnosAprobDg.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Materia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Parcial 1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Parcial 2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Parcial 3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Nota Final";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(918, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CalificarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1005, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alumnosAprobDg);
            this.Controls.Add(this.guardarBt);
            this.Controls.Add(this.materiasCb);
            this.Controls.Add(this.alumnosDg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalificarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalificarAlumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalificarAlumnos_FormClosing);
            this.Load += new System.EventHandler(this.CalificarAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosAprobDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alumnosDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreA;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiasProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial3;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFinal;
        private System.Windows.Forms.ComboBox materiasCb;
        private System.Windows.Forms.Button guardarBt;
        private System.Windows.Forms.DataGridView alumnosAprobDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
    }
}