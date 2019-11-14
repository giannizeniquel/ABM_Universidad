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


namespace Universidad.Forms
{
    public partial class ModificarAlumno : Form
    {
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            nombreTb.Text = DatosEstaticos.alumnoEstatico.nombre_a;
            edadTb.Text = DatosEstaticos.alumnoEstatico.edad_a.ToString();
            nacimientoDtp.Value = (DateTime)DatosEstaticos.alumnoEstatico.fechaNacimiento_a;
            telefonoTb.Text = DatosEstaticos.alumnoEstatico.telefono_a;
            dniTb.Text = DatosEstaticos.alumnoEstatico.dni_a;
            generoTb.Text = DatosEstaticos.alumnoEstatico.genero_a;
            paisTb.Text = DatosEstaticos.alumnoEstatico.pais_a;
            provinciaTb.Text = DatosEstaticos.alumnoEstatico.provincia_a;
            localidadTb.Text = DatosEstaticos.alumnoEstatico.localidad_a;
            direccionTb.Text = DatosEstaticos.alumnoEstatico.direccion_a;
            apellidoTb.Text = DatosEstaticos.alumnoEstatico.apellido_a;
            matriculaLb.Text = DatosEstaticos.alumnoEstatico.alumnoId.ToString();
            /**Cargo materias del alumno**/
            int countCursado = 0;
            int countAprobado = 0;
            if (DatosEstaticos.alumnoEstatico != null)
            {
                using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                {
                    var lstCall = db.connectAll;
                    foreach (var ca in lstCall)
                    {
                        if (DatosEstaticos.alumnoEstatico.alumnoId == ca.alumnoId_1)
                        {
                            if (ca.notaFinal == 0)
                            {
                                cursandoDg.Rows.Add();
                                cursandoDg[0, countCursado].Value = ca.cursoMateria.curso.anio_c.ToString();
                                cursandoDg[1, countCursado].Value = ca.cursoMateria.Materia.nombre_m.ToString();
                                string cursadoString = "Cursa en: división [" + ca.cursoMateria.curso.division_c + "]" + " / Aula " + ca.aulaId_1.ToString() + " EDIFICIO CENTRAL";
                                cursandoDg[2, countCursado].Value = cursadoString;
                                countCursado++;
                            }
                            else if (ca.notaFinal >= 6)
                            {
                                aprobadoDg.Rows.Add();
                                aprobadoDg[0, countAprobado].Value = ca.cursoMateria.curso.anio_c.ToString();
                                aprobadoDg[1, countAprobado].Value = ca.cursoMateria.Materia.nombre_m.ToString();
                                string cursadoString = "Aprobado con : " + ca.notaFinal;
                                aprobadoDg[2, countAprobado].Value = cursadoString;
                                countAprobado++;
                            }
                        }
                    }
                }
            }
        }

        private void GuardarBt_Click(object sender, EventArgs e)
        {
            int edadParse = int.Parse(edadTb.Text);
            if (edadParse < 17 || edadParse > 95)
            {
                MessageBox.Show("Error: El alumno debe tener una edad valida entre 17 y 95 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                {
                    alumno a = db.alumno.Find(DatosEstaticos.alumnoEstatico.alumnoId);
                    a.nombre_a = nombreTb.Text;
                    a.edad_a = edadParse;
                    a.fechaNacimiento_a = nacimientoDtp.Value.Date;
                    a.telefono_a = telefonoTb.Text;
                    a.dni_a = dniTb.Text;
                    a.genero_a = generoTb.Text;
                    a.pais_a = paisTb.Text;
                    a.provincia_a = provinciaTb.Text;
                    a.localidad_a = localidadTb.Text;
                    a.direccion_a = direccionTb.Text;
                    a.apellido_a = apellidoTb.Text;
                    db.SaveChanges();
                }
                MessageBox.Show("Modificaciones Guardadas con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void EdadTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void DniTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void TelefonoTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void SalirBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
