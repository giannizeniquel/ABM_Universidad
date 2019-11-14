namespace Universidad.Forms
{
    partial class Contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorTs = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProfesorTs = new System.Windows.Forms.ToolStripMenuItem();
            this.calificarTs = new System.Windows.Forms.ToolStripMenuItem();
            this.verProfesoresTs = new System.Windows.Forms.ToolStripMenuItem();
            this.misMateriasProfesorBt = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoTs = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoTs = new System.Windows.Forms.ToolStripMenuItem();
            this.misMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlumnosTs = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasTs = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirTs = new System.Windows.Forms.ToolStripMenuItem();
            this.verMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.agregarAlumnoToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 48);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // agregarAlumnoToolStripMenuItem
            // 
            this.agregarAlumnoToolStripMenuItem.Name = "agregarAlumnoToolStripMenuItem";
            this.agregarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.agregarAlumnoToolStripMenuItem.Text = "Agregar Alumno";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesorTs,
            this.alumnoTs,
            this.materiasTs,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click_1);
            // 
            // profesorTs
            // 
            this.profesorTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProfesorTs,
            this.calificarTs,
            this.verProfesoresTs,
            this.misMateriasProfesorBt});
            this.profesorTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profesorTs.Image = global::Universidad.Properties.Resources.Profesor_Icon;
            this.profesorTs.Name = "profesorTs";
            this.profesorTs.Size = new System.Drawing.Size(106, 24);
            this.profesorTs.Text = "Profesores";
            // 
            // agregarProfesorTs
            // 
            this.agregarProfesorTs.BackColor = System.Drawing.Color.SteelBlue;
            this.agregarProfesorTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarProfesorTs.Image = global::Universidad.Properties.Resources.NuevoEstudiante_Icon;
            this.agregarProfesorTs.Name = "agregarProfesorTs";
            this.agregarProfesorTs.Size = new System.Drawing.Size(162, 24);
            this.agregarProfesorTs.Text = "Agregar";
            this.agregarProfesorTs.Click += new System.EventHandler(this.AlumnoToolStripMenuItem_Click_1);
            // 
            // calificarTs
            // 
            this.calificarTs.BackColor = System.Drawing.Color.SteelBlue;
            this.calificarTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calificarTs.Image = global::Universidad.Properties.Resources.Incribir_Icon;
            this.calificarTs.Name = "calificarTs";
            this.calificarTs.Size = new System.Drawing.Size(162, 24);
            this.calificarTs.Text = "Calificar";
            this.calificarTs.Click += new System.EventHandler(this.CalificarToolStripMenuItem_Click);
            // 
            // verProfesoresTs
            // 
            this.verProfesoresTs.BackColor = System.Drawing.Color.SteelBlue;
            this.verProfesoresTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verProfesoresTs.Image = global::Universidad.Properties.Resources.Mostrar2_Icon;
            this.verProfesoresTs.Name = "verProfesoresTs";
            this.verProfesoresTs.Size = new System.Drawing.Size(162, 24);
            this.verProfesoresTs.Text = "Ver";
            this.verProfesoresTs.Click += new System.EventHandler(this.VerToolStripMenuItem_Click);
            // 
            // misMateriasProfesorBt
            // 
            this.misMateriasProfesorBt.Name = "misMateriasProfesorBt";
            this.misMateriasProfesorBt.Size = new System.Drawing.Size(162, 24);
            this.misMateriasProfesorBt.Text = "Mis Materias";
            this.misMateriasProfesorBt.Click += new System.EventHandler(this.MisMateriasProfesorBt_Click);
            // 
            // alumnoTs
            // 
            this.alumnoTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlumnoTs,
            this.misMaterias,
            this.verAlumnosTs});
            this.alumnoTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alumnoTs.Image = global::Universidad.Properties.Resources.Estudiante_Icon;
            this.alumnoTs.Name = "alumnoTs";
            this.alumnoTs.Size = new System.Drawing.Size(95, 24);
            this.alumnoTs.Text = "Alumnos";
            // 
            // agregarAlumnoTs
            // 
            this.agregarAlumnoTs.BackColor = System.Drawing.Color.SteelBlue;
            this.agregarAlumnoTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarAlumnoTs.Image = global::Universidad.Properties.Resources.NuevoEstudiante_Icon;
            this.agregarAlumnoTs.Name = "agregarAlumnoTs";
            this.agregarAlumnoTs.Size = new System.Drawing.Size(162, 24);
            this.agregarAlumnoTs.Text = "Ageragar";
            this.agregarAlumnoTs.Click += new System.EventHandler(this.AgeragarAlumnosToolStripMenuItem_Click);
            // 
            // misMaterias
            // 
            this.misMaterias.BackColor = System.Drawing.Color.SteelBlue;
            this.misMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.misMaterias.Image = global::Universidad.Properties.Resources.Materias_Icon;
            this.misMaterias.Name = "misMaterias";
            this.misMaterias.Size = new System.Drawing.Size(162, 24);
            this.misMaterias.Text = "Mis materias";
            this.misMaterias.Click += new System.EventHandler(this.MisMaterias_Click);
            // 
            // verAlumnosTs
            // 
            this.verAlumnosTs.BackColor = System.Drawing.Color.SteelBlue;
            this.verAlumnosTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verAlumnosTs.Image = global::Universidad.Properties.Resources.Mostrar2_Icon;
            this.verAlumnosTs.Name = "verAlumnosTs";
            this.verAlumnosTs.Size = new System.Drawing.Size(162, 24);
            this.verAlumnosTs.Text = "Ver";
            this.verAlumnosTs.Click += new System.EventHandler(this.AlumnosToolStripMenuItem1_Click_1);
            // 
            // materiasTs
            // 
            this.materiasTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirTs,
            this.verMaterias});
            this.materiasTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materiasTs.Image = global::Universidad.Properties.Resources.Materias_Icon;
            this.materiasTs.Name = "materiasTs";
            this.materiasTs.Size = new System.Drawing.Size(94, 24);
            this.materiasTs.Text = "Materias";
            // 
            // inscribirTs
            // 
            this.inscribirTs.BackColor = System.Drawing.Color.SteelBlue;
            this.inscribirTs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inscribirTs.Image = global::Universidad.Properties.Resources.Incribir_Icon;
            this.inscribirTs.Name = "inscribirTs";
            this.inscribirTs.Size = new System.Drawing.Size(124, 24);
            this.inscribirTs.Text = "Incribir";
            this.inscribirTs.Click += new System.EventHandler(this.VerMateriasToolStripMenuItem_Click);
            // 
            // verMaterias
            // 
            this.verMaterias.BackColor = System.Drawing.Color.SteelBlue;
            this.verMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verMaterias.Image = global::Universidad.Properties.Resources.Mostrar2_Icon;
            this.verMaterias.Name = "verMaterias";
            this.verMaterias.Size = new System.Drawing.Size(124, 24);
            this.verMaterias.Text = "Ver";
            this.verMaterias.Click += new System.EventHandler(this.InscribirceAMateriasToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1271, 749);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysUTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contenedor_FormClosing);
            this.Load += new System.EventHandler(this.Contenedor_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profesorTs;
        private System.Windows.Forms.ToolStripMenuItem agregarProfesorTs;
        private System.Windows.Forms.ToolStripMenuItem alumnoTs;
        private System.Windows.Forms.ToolStripMenuItem verAlumnosTs;
        private System.Windows.Forms.ToolStripMenuItem materiasTs;
        private System.Windows.Forms.ToolStripMenuItem inscribirTs;
        private System.Windows.Forms.ToolStripMenuItem verMaterias;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoTs;
        private System.Windows.Forms.ToolStripMenuItem misMaterias;
        private System.Windows.Forms.ToolStripMenuItem verProfesoresTs;
        private System.Windows.Forms.ToolStripMenuItem calificarTs;
        private System.Windows.Forms.ToolStripMenuItem misMateriasProfesorBt;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}
