namespace Universidad.Forms
{
    partial class AsignarMatProfesor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet6 = new Universidad.UniversidadDataSet6();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet4 = new Universidad.UniversidadDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.salirBt = new System.Windows.Forms.Button();
            this.nombreLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matriculaLb = new System.Windows.Forms.Label();
            this.materiaTableAdapter = new Universidad.UniversidadDataSet6TableAdapters.MateriaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombremDataGridViewTextBoxColumn,
            this.duracionmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materiaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(354, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombremDataGridViewTextBoxColumn
            // 
            this.nombremDataGridViewTextBoxColumn.DataPropertyName = "nombre_m";
            this.nombremDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.nombremDataGridViewTextBoxColumn.Name = "nombremDataGridViewTextBoxColumn";
            this.nombremDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombremDataGridViewTextBoxColumn.Width = 67;
            // 
            // duracionmDataGridViewTextBoxColumn
            // 
            this.duracionmDataGridViewTextBoxColumn.DataPropertyName = "duracion_m";
            this.duracionmDataGridViewTextBoxColumn.HeaderText = "Duración de Cursado";
            this.duracionmDataGridViewTextBoxColumn.Name = "duracionmDataGridViewTextBoxColumn";
            this.duracionmDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracionmDataGridViewTextBoxColumn.Width = 86;
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "Materia";
            this.materiaBindingSource1.DataSource = this.universidadDataSet6;
            // 
            // universidadDataSet6
            // 
            this.universidadDataSet6.DataSetName = "UniversidadDataSet6";
            this.universidadDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.universidadDataSet4;
            // 
            // universidadDataSet4
            // 
            this.universidadDataSet4.DataSetName = "UniversidadDataSet4";
            this.universidadDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Asignar Materia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // salirBt
            // 
            this.salirBt.BackColor = System.Drawing.Color.IndianRed;
            this.salirBt.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.salirBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirBt.Location = new System.Drawing.Point(291, 539);
            this.salirBt.Name = "salirBt";
            this.salirBt.Size = new System.Drawing.Size(75, 23);
            this.salirBt.TabIndex = 2;
            this.salirBt.Text = "Salir";
            this.salirBt.UseVisualStyleBackColor = false;
            this.salirBt.Click += new System.EventHandler(this.SalirBt_Click);
            // 
            // nombreLb
            // 
            this.nombreLb.BackColor = System.Drawing.Color.SteelBlue;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nombreLb.Location = new System.Drawing.Point(12, 12);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(354, 33);
            this.nombreLb.TabIndex = 3;
            this.nombreLb.Text = "nombre";
            this.nombreLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(131, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Legajo:";
            // 
            // matriculaLb
            // 
            this.matriculaLb.AutoSize = true;
            this.matriculaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaLb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.matriculaLb.Location = new System.Drawing.Point(193, 57);
            this.matriculaLb.Name = "matriculaLb";
            this.matriculaLb.Size = new System.Drawing.Size(18, 20);
            this.matriculaLb.TabIndex = 5;
            this.matriculaLb.Text = "1";
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 33);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AsignarMatProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(378, 574);
            this.Controls.Add(this.matriculaLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLb);
            this.Controls.Add(this.salirBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 613);
            this.MinimumSize = new System.Drawing.Size(394, 613);
            this.Name = "AsignarMatProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarMatProfesor";
            this.Load += new System.EventHandler(this.AsignarMatProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet6)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.universidadDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UniversidadDataSet4 universidadDataSet4;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salirBt;
        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label matriculaLb;
        private UniversidadDataSet6 universidadDataSet6;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private UniversidadDataSet6TableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionmDataGridViewTextBoxColumn;
    }
}