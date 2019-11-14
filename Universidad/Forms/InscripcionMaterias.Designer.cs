namespace Universidad.Forms
{
    partial class InscripcionMaterias
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
            this.components = new System.ComponentModel.Container();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet2 = new Universidad.UniversidadDataSet2();
            this.universidadDataSet1 = new Universidad.UniversidadDataSet1();
            this.cursoMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoMateriaTableAdapter = new Universidad.UniversidadDataSet1TableAdapters.cursoMateriaTableAdapter();
            this.materiaTableAdapter = new Universidad.UniversidadDataSet2TableAdapters.MateriaTableAdapter();
            this.materiaLb = new System.Windows.Forms.Label();
            this.label456 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.divicionesCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.anioLb = new System.Windows.Forms.Label();
            this.cursadoLb = new System.Windows.Forms.Label();
            this.correlativaLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MateriasLb = new System.Windows.Forms.ListBox();
            this.inscribirBt = new System.Windows.Forms.Button();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.AulaCb = new System.Windows.Forms.ComboBox();
            this.nombreAlumno = new System.Windows.Forms.Label();
            this.matriculaAlumno = new System.Windows.Forms.Label();
            this.docenteDg = new System.Windows.Forms.DataGridView();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.universidadDataSet2;
            // 
            // universidadDataSet2
            // 
            this.universidadDataSet2.DataSetName = "UniversidadDataSet2";
            this.universidadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universidadDataSet1
            // 
            this.universidadDataSet1.DataSetName = "UniversidadDataSet1";
            this.universidadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoMateriaBindingSource
            // 
            this.cursoMateriaBindingSource.DataMember = "cursoMateria";
            this.cursoMateriaBindingSource.DataSource = this.universidadDataSet1;
            // 
            // cursoMateriaTableAdapter
            // 
            this.cursoMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaLb
            // 
            this.materiaLb.BackColor = System.Drawing.Color.SteelBlue;
            this.materiaLb.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiaLb.ForeColor = System.Drawing.SystemColors.Control;
            this.materiaLb.Location = new System.Drawing.Point(12, 9);
            this.materiaLb.Name = "materiaLb";
            this.materiaLb.Size = new System.Drawing.Size(848, 45);
            this.materiaLb.TabIndex = 1;
            this.materiaLb.Text = "nombre materia";
            this.materiaLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label456
            // 
            this.label456.AutoSize = true;
            this.label456.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label456.Location = new System.Drawing.Point(570, 147);
            this.label456.Name = "label456";
            this.label456.Size = new System.Drawing.Size(54, 25);
            this.label456.TabIndex = 2;
            this.label456.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "División:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cursado:";
            // 
            // divicionesCb
            // 
            this.divicionesCb.FormattingEnabled = true;
            this.divicionesCb.Location = new System.Drawing.Point(387, 150);
            this.divicionesCb.Name = "divicionesCb";
            this.divicionesCb.Size = new System.Drawing.Size(53, 21);
            this.divicionesCb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(431, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOCENTES";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correlativa:";
            // 
            // anioLb
            // 
            this.anioLb.AutoSize = true;
            this.anioLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioLb.Location = new System.Drawing.Point(630, 147);
            this.anioLb.Name = "anioLb";
            this.anioLb.Size = new System.Drawing.Size(66, 24);
            this.anioLb.TabIndex = 9;
            this.anioLb.Text = "label5";
            // 
            // cursadoLb
            // 
            this.cursadoLb.AutoSize = true;
            this.cursadoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursadoLb.Location = new System.Drawing.Point(631, 191);
            this.cursadoLb.Name = "cursadoLb";
            this.cursadoLb.Size = new System.Drawing.Size(66, 24);
            this.cursadoLb.TabIndex = 10;
            this.cursadoLb.Text = "label5";
            // 
            // correlativaLb
            // 
            this.correlativaLb.AutoSize = true;
            this.correlativaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correlativaLb.Location = new System.Drawing.Point(630, 233);
            this.correlativaLb.Name = "correlativaLb";
            this.correlativaLb.Size = new System.Drawing.Size(66, 24);
            this.correlativaLb.TabIndex = 11;
            this.correlativaLb.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(93, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "MATERIAS";
            // 
            // MateriasLb
            // 
            this.MateriasLb.FormattingEnabled = true;
            this.MateriasLb.Location = new System.Drawing.Point(39, 172);
            this.MateriasLb.Name = "MateriasLb";
            this.MateriasLb.Size = new System.Drawing.Size(223, 277);
            this.MateriasLb.TabIndex = 13;
            this.MateriasLb.SelectedIndexChanged += new System.EventHandler(this.MateriasLb_SelectedIndexChanged);
            // 
            // inscribirBt
            // 
            this.inscribirBt.BackColor = System.Drawing.Color.LightSlateGray;
            this.inscribirBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscribirBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscribirBt.ForeColor = System.Drawing.SystemColors.Control;
            this.inscribirBt.Location = new System.Drawing.Point(376, 522);
            this.inscribirBt.Name = "inscribirBt";
            this.inscribirBt.Size = new System.Drawing.Size(138, 39);
            this.inscribirBt.TabIndex = 14;
            this.inscribirBt.Text = "Inscribirse";
            this.inscribirBt.UseVisualStyleBackColor = false;
            this.inscribirBt.Click += new System.EventHandler(this.InscribirBt_Click);
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aula:";
            // 
            // AulaCb
            // 
            this.AulaCb.FormattingEnabled = true;
            this.AulaCb.Location = new System.Drawing.Point(387, 214);
            this.AulaCb.Name = "AulaCb";
            this.AulaCb.Size = new System.Drawing.Size(52, 21);
            this.AulaCb.TabIndex = 16;
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.AutoSize = true;
            this.nombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAlumno.Location = new System.Drawing.Point(130, 65);
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.Size = new System.Drawing.Size(70, 26);
            this.nombreAlumno.TabIndex = 18;
            this.nombreAlumno.Text = "label7";
            // 
            // matriculaAlumno
            // 
            this.matriculaAlumno.AutoSize = true;
            this.matriculaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaAlumno.Location = new System.Drawing.Point(570, 65);
            this.matriculaAlumno.Name = "matriculaAlumno";
            this.matriculaAlumno.Size = new System.Drawing.Size(70, 26);
            this.matriculaAlumno.TabIndex = 19;
            this.matriculaAlumno.Text = "label8";
            // 
            // docenteDg
            // 
            this.docenteDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.docenteDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.docenteDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docenteDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turno,
            this.nombreApellido});
            this.docenteDg.Location = new System.Drawing.Point(335, 346);
            this.docenteDg.Name = "docenteDg";
            this.docenteDg.Size = new System.Drawing.Size(307, 103);
            this.docenteDg.TabIndex = 23;
            // 
            // turno
            // 
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 60;
            // 
            // nombreApellido
            // 
            this.nombreApellido.HeaderText = "Nombre y Apellido";
            this.nombreApellido.Name = "nombreApellido";
            this.nombreApellido.ReadOnly = true;
            this.nombreApellido.Width = 107;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(326, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 149);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(28, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 319);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // InscripcionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 573);
            this.Controls.Add(this.docenteDg);
            this.Controls.Add(this.matriculaAlumno);
            this.Controls.Add(this.nombreAlumno);
            this.Controls.Add(this.AulaCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inscribirBt);
            this.Controls.Add(this.MateriasLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correlativaLb);
            this.Controls.Add(this.cursadoLb);
            this.Controls.Add(this.anioLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divicionesCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label456);
            this.Controls.Add(this.materiaLb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InscripcionMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscripcionMaterias";
            this.Load += new System.EventHandler(this.InscripcionMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UniversidadDataSet1 universidadDataSet1;
        private System.Windows.Forms.BindingSource cursoMateriaBindingSource;
        private UniversidadDataSet1TableAdapters.cursoMateriaTableAdapter cursoMateriaTableAdapter;
        private UniversidadDataSet2 universidadDataSet2;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private UniversidadDataSet2TableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.Label materiaLb;
        private System.Windows.Forms.Label label456;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox divicionesCb;
        private System.Windows.Forms.Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label anioLb;
        private System.Windows.Forms.Label cursadoLb;
        private System.Windows.Forms.Label correlativaLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox MateriasLb;
        private System.Windows.Forms.Button inscribirBt;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AulaCb;
        private System.Windows.Forms.Label nombreAlumno;
        private System.Windows.Forms.Label matriculaAlumno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView docenteDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellido;
    }
}