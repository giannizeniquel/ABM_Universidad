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
using Universidad.Entitys;
using System.Data.SqlClient;

namespace Universidad.Forms
{
    public partial class MostrarAlumnos : Form
    {
        public MostrarAlumnos()
        {
            InitializeComponent();
        }

        private void MostrarAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.alumno' Puede moverla o quitarla según sea necesario.
            // this.alumnoTableAdapter.Fill(this.universidadDataSet.alumno);
            refrescar();

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void refrescar()
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                alumnoBindingSource.DataSource = null;
                alumnoBindingSource.DataSource = db.alumno.ToList();
            }
        }
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            alumno a = new alumno();
            a = (alumno)alumnoBindingSource.Current;

            if (a == null)
            {
                Console.WriteLine("Es nulo boludo");
            }
            DatosEstaticos.alumnoEstatico = a;
        }


        /** Busqueda de alumnos**/
        private void BusquedaTb_KeyUp(object sender, KeyEventArgs e)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                if (busquedaTb.Text != "" && busquedaTb.Text != " ")
                {

                    List<alumno> alumnoList = new List<alumno>();
                    var lstAlumnos = db.alumno;
                    int matriculaInt = 0;
                    int.TryParse(busquedaTb.Text, out matriculaInt);
                    foreach (var a in lstAlumnos)
                    {
                        if (a.alumnoId == matriculaInt)
                        {
                            alumnoList.Add(a);
                        }
                        else if (a.dni_a == busquedaTb.Text)
                        {
                            alumnoList.Add(a);
                        }
                    }
                    alumnoBindingSource.DataSource = alumnoList;

                }
                else
                {
                    alumnoBindingSource.DataSource = db.alumno.ToList();
                }
            }
        }

        private void ConsultarBt_Click(object sender, EventArgs e)
        {
            if (alumnoBindingSource.Current != null)
            {
                alumno a = new alumno();
                a = (alumno)alumnoBindingSource.Current;

                DatosEstaticos.alumnoEstatico = a;
                ConsultaAlumno ca = new ConsultaAlumno();
                ca.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: seleccione un alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BorrarBt_Click(object sender, EventArgs e)
        {
            if (alumnoBindingSource.Current != null)
            {
                alumno a = new alumno();
                a = (alumno)alumnoBindingSource.Current;
                string mensajeString = "Esta seguro que desea eliminar a: [ " + a.apellido_a + " " + a.nombre_a + "] " + "Matricula: [" + a.alumnoId + "]";
                DialogResult dialogResult = MessageBox.Show(mensajeString, "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.OK)
                {
                    GestionDb.RemoveAlumno(a.alumnoId);
                    refrescar();
                }
            }
            else
            {
                MessageBox.Show("Error: Seleccione un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void InscribirBt_Click(object sender, EventArgs e)
        {
            if (alumnoBindingSource.Current != null)
            {
                DatosEstaticos.estadoCargaMaterias = 2;
                alumno a = new alumno();
                a = (alumno)alumnoBindingSource.Current;

                DatosEstaticos.alumnoEstatico = a;
                InscripcionMaterias im = new InscripcionMaterias();
                im.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: seleccione un alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.alumnoEstatico = (alumno)alumnoBindingSource.Current;
            ModificarAlumno mA = new ModificarAlumno();
            mA.ShowDialog();
            refrescar();
        }
    }
}
