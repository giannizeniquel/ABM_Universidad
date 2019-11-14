namespace Universidad.Forms
{
    partial class MostrarMateriaAsignada
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
            this.profesorMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet5 = new Universidad.UniversidadDataSet5();
            this.materiasProfesorDg = new System.Windows.Forms.DataGridView();
            this.materiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesorLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.legajoProfesorLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profesorMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasProfesorDg)).BeginInit();
            this.SuspendLayout();
            // 
            // profesorMateriaBindingSource
            // 
            this.profesorMateriaBindingSource.DataMember = "ProfesorMateria";
            this.profesorMateriaBindingSource.DataSource = this.universidadDataSet5;
            // 
            // universidadDataSet5
            // 
            this.universidadDataSet5.DataSetName = "UniversidadDataSet5";
            this.universidadDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasProfesorDg
            // 
            this.materiasProfesorDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.materiasProfesorDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.materiasProfesorDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiasProfesorDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materiaCol,
            this.turnoCol});
            this.materiasProfesorDg.Location = new System.Drawing.Point(12, 98);
            this.materiasProfesorDg.Name = "materiasProfesorDg";
            this.materiasProfesorDg.Size = new System.Drawing.Size(340, 150);
            this.materiasProfesorDg.TabIndex = 0;
            // 
            // materiaCol
            // 
            this.materiaCol.Frozen = true;
            this.materiaCol.HeaderText = "Materia";
            this.materiaCol.Name = "materiaCol";
            this.materiaCol.ReadOnly = true;
            this.materiaCol.Width = 67;
            // 
            // turnoCol
            // 
            this.turnoCol.Frozen = true;
            this.turnoCol.HeaderText = "Turno";
            this.turnoCol.Name = "turnoCol";
            this.turnoCol.ReadOnly = true;
            this.turnoCol.Width = 60;
            // 
            // nombreProfesorLb
            // 
            this.nombreProfesorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProfesorLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.nombreProfesorLb.Location = new System.Drawing.Point(12, 9);
            this.nombreProfesorLb.Name = "nombreProfesorLb";
            this.nombreProfesorLb.Size = new System.Drawing.Size(340, 31);
            this.nombreProfesorLb.TabIndex = 1;
            this.nombreProfesorLb.Text = "label1";
            this.nombreProfesorLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(142, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Legajo:";
            // 
            // legajoProfesorLb
            // 
            this.legajoProfesorLb.AutoSize = true;
            this.legajoProfesorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legajoProfesorLb.ForeColor = System.Drawing.Color.Gainsboro;
            this.legajoProfesorLb.Location = new System.Drawing.Point(204, 55);
            this.legajoProfesorLb.Name = "legajoProfesorLb";
            this.legajoProfesorLb.Size = new System.Drawing.Size(16, 18);
            this.legajoProfesorLb.TabIndex = 3;
            this.legajoProfesorLb.Text = "1";
            // 
            // MostrarMateriaAsignada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(364, 260);
            this.Controls.Add(this.legajoProfesorLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreProfesorLb);
            this.Controls.Add(this.materiasProfesorDg);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 299);
            this.MinimumSize = new System.Drawing.Size(380, 299);
            this.Name = "MostrarMateriaAsignada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarMateriaAsignada";
            this.Load += new System.EventHandler(this.MostrarMateriaAsignada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasProfesorDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UniversidadDataSet5 universidadDataSet5;
        private System.Windows.Forms.BindingSource profesorMateriaBindingSource;
        private System.Windows.Forms.DataGridView materiasProfesorDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoCol;
        private System.Windows.Forms.Label nombreProfesorLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label legajoProfesorLb;
    }
}