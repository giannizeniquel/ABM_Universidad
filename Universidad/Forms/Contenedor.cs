using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidad.Script;
namespace Universidad.Forms
{
    public partial class Contenedor : Form
    {
        static public bool cancelarClosing = false;
        public Contenedor()
        {
            InitializeComponent();
        }
        private void AlumnoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarProfesor profesorForm = new AgregarProfesor();
            profesorForm.MdiParent = this;
            profesorForm.Show();
        }

        private void AlumnosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MostrarAlumnos mostrar = new MostrarAlumnos();
            mostrar.MdiParent = this;
            mostrar.Show();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            if (DatosEstaticos.accesoUsuario == 1)
            {
                misMateriasProfesorBt.Visible = false;
                misMaterias.Visible = false;
                calificarTs.Visible = false;
                inscribirTs.Visible = false;
            }
            else if (DatosEstaticos.accesoUsuario == 2)
            {
                alumnoTs.Visible = false;
                agregarProfesorTs.Visible = false;
                verProfesoresTs.Visible = false;
                materiasTs.Visible = false;
                inscribirTs.Visible = false;

            }
            else if (DatosEstaticos.accesoUsuario == 3)
            {
                agregarAlumnoTs.Visible = false;
                profesorTs.Visible = false;
                verAlumnosTs.Visible = false;
                verMaterias.Text = "Materias del Plan";
            }

        }
        private void Contenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logic.PreguntaCerrarVentanas(e);
        }

        private void VerMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosEstaticos.estadoCargaMaterias = 2;
            InscripcionMaterias inscripcion = new InscripcionMaterias();
            inscripcion.MdiParent = this;
            inscripcion.Show();
        }

        private void InscribirceAMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosEstaticos.estadoCargaMaterias = 1;
            InscripcionMaterias inscripcion = new InscripcionMaterias();
            inscripcion.MdiParent = this;
            inscripcion.Show();
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProfesores mostrarProfesores = new MostrarProfesores();
            mostrarProfesores.MdiParent = this;
            mostrarProfesores.Show();
        }

        private void AgeragarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoFormulario alumnoFormulario = new AlumnoFormulario();
            alumnoFormulario.MdiParent = this;
            alumnoFormulario.Show();
        }

        private void CalificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalificarAlumnos calificarAlumnos = new CalificarAlumnos();
            calificarAlumnos.MdiParent = this;
            calificarAlumnos.Show();
        }

        private void InscribirTs_Click(object sender, EventArgs e)
        {
            DatosEstaticos.estadoCargaMaterias = 2;
            InscripcionMaterias inscribirMaterias = new InscripcionMaterias();
            inscribirMaterias.MdiParent = this;
            inscribirMaterias.Show();
        }

        private void LogOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MisMateriasProfesorBt_Click(object sender, EventArgs e)
        {
            MostrarMateriaAsignada mMa = new MostrarMateriaAsignada();
            mMa.MdiParent = this;
            mMa.Show();
        }

        private void MisMaterias_Click(object sender, EventArgs e)
        {
            if (DatosEstaticos.alumnoEstatico != null)
            {
                DatosEstaticos.estadoCargaMaterias = 1;
                AlumnoMateriasForms aluMateria = new AlumnoMateriasForms();
                aluMateria.MdiParent = this;
                aluMateria.Show();
            }
        }
    }
}
