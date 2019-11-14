namespace Universidad.Forms
{
    partial class AlumnoMateriasForms
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
            this.aprobadoDg = new System.Windows.Forms.DataGridView();
            this.anioAprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaNomApro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursandoDg = new System.Windows.Forms.DataGridView();
            this.anioCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCursando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aprobadoDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursandoDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // aprobadoDg
            // 
            this.aprobadoDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.aprobadoDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aprobadoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aprobadoDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioAprobado,
            this.materiaNomApro,
            this.estadoMateria});
            this.aprobadoDg.Location = new System.Drawing.Point(12, 58);
            this.aprobadoDg.Name = "aprobadoDg";
            this.aprobadoDg.Size = new System.Drawing.Size(376, 150);
            this.aprobadoDg.TabIndex = 0;
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
            // cursandoDg
            // 
            this.cursandoDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cursandoDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cursandoDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursandoDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioCursando,
            this.materiaCursando,
            this.estadoCursando});
            this.cursandoDg.Location = new System.Drawing.Point(12, 289);
            this.cursandoDg.Name = "cursandoDg";
            this.cursandoDg.Size = new System.Drawing.Size(376, 150);
            this.cursandoDg.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(123, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aprobadas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(12, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 40);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // AlumnoMateriasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(404, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cursandoDg);
            this.Controls.Add(this.aprobadoDg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 506);
            this.MinimumSize = new System.Drawing.Size(420, 506);
            this.Name = "AlumnoMateriasForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis Materias";
            this.Load += new System.EventHandler(this.AlumnoMateriasForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aprobadoDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursandoDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aprobadoDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioAprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaNomApro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMateria;
        private System.Windows.Forms.DataGridView cursandoDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaCursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCursando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}