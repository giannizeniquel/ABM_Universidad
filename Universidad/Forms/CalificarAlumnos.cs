using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidad.Entitys;
using Universidad.Script;


namespace Universidad.Forms
{
    public partial class CalificarAlumnos : Form
    {
        public CalificarAlumnos()
        {
            InitializeComponent();
        }

        private void CalificarAlumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }
        private void CargarAlumnos()
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstProfesorMateria = db.ProfesorMateria;
                var lstCursoMateria = db.cursoMateria;
                var lstconnectAll = db.connectAll;
                int count = 0;
                int countAprob = 0;
                materiasCb.Items.Clear();
                foreach (var pm in lstProfesorMateria)
                {
                    if (pm.profesorId_1 == DatosEstaticos.profesorEstatico.profesorId)
                    {
                        materiasCb.Items.Add(pm.Materia.nombre_m + ":  [" + pm.turno + "]");
                        foreach (var ca in lstconnectAll)
                        {
                            if (pm.materiaId_2 == ca.cursoMateria.materiaId_1 && pm.turno == ca.cursoMateria.curso.division_c)
                            {
                                if (ca.notaFinal < 6)
                                {
                                    alumnosDg.Rows.Add();
                                    alumnosDg[0, count].Value = ca.alumnoId_1.ToString();
                                    alumnosDg[1, count].Value = ca.alumno.apellido_a;
                                    alumnosDg[2, count].Value = ca.alumno.nombre_a;
                                    alumnosDg[3, count].Value = ca.cursoMateria.Materia.nombre_m;
                                    alumnosDg[4, count].Value = ca.parcial_1.ToString();
                                    alumnosDg[5, count].Value = ca.parcial_2.ToString();
                                    alumnosDg[6, count].Value = ca.parcial_3.ToString();
                                    alumnosDg[7, count].Value = ca.notaFinal.ToString();
                                    count++;
                                }
                                else
                                {
                                    alumnosAprobDg.Rows.Add();
                                    alumnosAprobDg[0, countAprob].Value = ca.alumnoId_1.ToString();
                                    alumnosAprobDg[1, countAprob].Value = ca.alumno.apellido_a;
                                    alumnosAprobDg[2, countAprob].Value = ca.alumno.nombre_a;
                                    alumnosAprobDg[3, countAprob].Value = ca.cursoMateria.Materia.nombre_m;
                                    alumnosAprobDg[4, countAprob].Value = ca.parcial_1.ToString();
                                    alumnosAprobDg[5, countAprob].Value = ca.parcial_2.ToString();
                                    alumnosAprobDg[6, countAprob].Value = ca.parcial_3.ToString();
                                    alumnosAprobDg[7, countAprob].Value = ca.notaFinal.ToString();
                                    countAprob++;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void MateriasCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                if (!string.IsNullOrEmpty(materiasCb.SelectedItem.ToString()))
                {
                    int count = 0;
                    alumnosDg.Rows.Clear();
                    alumnosAprobDg.Rows.Clear();
                    var lstcAll = db.connectAll;
                    string materiaNombre = "";
                    string divicionAlumnos = "";
                    int countBreakfor = 0;
                    int countAprob = 0;
                    for (int i = 0; i < materiasCb.SelectedItem.ToString().Length; i++)
                    {
                        if (materiasCb.SelectedItem.ToString()[i] != ':' && countBreakfor == 0)
                        {
                            materiaNombre = materiaNombre + materiasCb.SelectedItem.ToString()[i];
                        }
                        else
                        {
                            countBreakfor = 1;
                            if (materiasCb.SelectedItem.ToString()[i] == 'A' || materiasCb.SelectedItem.ToString()[i] == 'B')
                            {
                                divicionAlumnos = materiasCb.SelectedItem.ToString()[i].ToString();
                            }
                        }
                    }

                    foreach (var ca in lstcAll)
                    {
                        if (materiaNombre == ca.cursoMateria.Materia.nombre_m && divicionAlumnos == ca.cursoMateria.curso.division_c)
                        {
                            if (ca.notaFinal < 6)
                            {
                                alumnosDg.Rows.Add();
                                alumnosDg[0, count].Value = ca.alumnoId_1.ToString();
                                alumnosDg[1, count].Value = ca.alumno.apellido_a;
                                alumnosDg[2, count].Value = ca.alumno.nombre_a;
                                alumnosDg[3, count].Value = ca.cursoMateria.Materia.nombre_m;
                                alumnosDg[4, count].Value = ca.parcial_1.ToString();
                                alumnosDg[5, count].Value = ca.parcial_2.ToString();
                                alumnosDg[6, count].Value = ca.parcial_3.ToString();
                                alumnosDg[7, count].Value = ca.notaFinal.ToString();
                                count++;
                            }
                            else
                            {
                                alumnosAprobDg.Rows.Add();
                                alumnosAprobDg[0, countAprob].Value = ca.alumnoId_1.ToString();
                                alumnosAprobDg[1, countAprob].Value = ca.alumno.apellido_a;
                                alumnosAprobDg[2, countAprob].Value = ca.alumno.nombre_a;
                                alumnosAprobDg[3, countAprob].Value = ca.cursoMateria.Materia.nombre_m;
                                alumnosAprobDg[4, countAprob].Value = ca.parcial_1.ToString();
                                alumnosAprobDg[5, countAprob].Value = ca.parcial_2.ToString();
                                alumnosAprobDg[6, countAprob].Value = ca.parcial_3.ToString();
                                alumnosAprobDg[7, countAprob].Value = ca.notaFinal.ToString();
                                countAprob++;
                            }
                            
                        }
                        
                    }
                }
                else
                {
                    CargarAlumnos();
                }
            }
        }

        private void GuardarBt_Click(object sender, EventArgs e)
        {
            int countMensaje = 0;

            for (int i = 0; i < alumnosDg.RowCount - 1; i++)
            {
                if (!string.IsNullOrEmpty(alumnosDg[0, i].Value.ToString()))
                {
                    string matriculaString = alumnosDg[0, i].Value.ToString();
                    Console.WriteLine("ESTO ES BOLUDO : " + matriculaString);
                    int idAlumno = 0;
                    idAlumno = int.Parse(matriculaString);
                    using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                    {
                        alumno a = db.alumno.Find(idAlumno);
                        var lstConnctAll = db.connectAll;

                        foreach (var ca in lstConnctAll)
                        {
                            if (ca.alumnoId_1 == a.alumnoId)
                            {
                                if (ca.cursoMateria.Materia.nombre_m == alumnosDg[3, i].Value.ToString())
                                {
                                    if (alumnosDg[4,i].Value != null && !string.IsNullOrEmpty(alumnosDg[4, i].Value.ToString()) && float.TryParse(alumnosDg[4, i].Value.ToString(), out float p1) && float.Parse(alumnosDg[4, i].Value.ToString()) > 0 && float.Parse(alumnosDg[4, i].Value.ToString()) < 11)
                                    {
                                        ca.parcial_1 = float.Parse(alumnosDg[4, i].Value.ToString());
                                    }
                                    else
                                    {
                                        string parcial1Error = "Error: Parcial 1 del alumno: " + ca.alumno.apellido_a + " " + ca.alumno.nombre_a + " " + "debe contener numeros";
                                        MessageBox.Show(parcial1Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        countMensaje++;
                                        break;
                                    }
                                    if (alumnosDg[5, i].Value != null && !string.IsNullOrEmpty(alumnosDg[5, i].Value.ToString()) && float.TryParse(alumnosDg[5, i].Value.ToString(), out float p2) && float.Parse(alumnosDg[5, i].Value.ToString()) > 0 && float.Parse(alumnosDg[5, i].Value.ToString()) < 11)
                                    {
                                        ca.parcial_2 = float.Parse(alumnosDg[5, i].Value.ToString());

                                    }
                                    else
                                    {
                                        string parcial1Error = "Error: Parcial 2 del alumno: " + ca.alumno.apellido_a + " " + ca.alumno.nombre_a + " " + "debe contener numeros";
                                        MessageBox.Show(parcial1Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        countMensaje++;
                                        break;
                                    }
                                    if (alumnosDg[6, i].Value != null && !string.IsNullOrEmpty(alumnosDg[6, i].Value.ToString()) && float.TryParse(alumnosDg[6, i].Value.ToString(), out float p3) && float.Parse(alumnosDg[6, i].Value.ToString()) > 0 && float.Parse(alumnosDg[6, i].Value.ToString()) < 11)
                                    {
                                        ca.parcial_3 = float.Parse(alumnosDg[6, i].Value.ToString());
                                    }
                                    else
                                    {
                                        string parcial1Error = "Error: Parcial 3 del alumno: " + ca.alumno.apellido_a + " " + ca.alumno.nombre_a + " " + "debe contener numeros";
                                        MessageBox.Show(parcial1Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        countMensaje++;
                                        break;
                                    }
                                    if (alumnosDg[7, i].Value != null && !string.IsNullOrEmpty(alumnosDg[7, i].Value.ToString()) && float.TryParse(alumnosDg[7, i].Value.ToString(), out float p4) && float.Parse(alumnosDg[7, i].Value.ToString()) > 0 && float.Parse(alumnosDg[7, i].Value.ToString()) < 11)
                                    {
                                        ca.notaFinal = float.Parse(alumnosDg[7, i].Value.ToString());
                                    }
                                    else
                                    {
                                        string parcial1Error = "Error: Nota Final del alumno: " + ca.alumno.apellido_a + " " + ca.alumno.nombre_a + " " + "debe contener numeros";
                                        MessageBox.Show(parcial1Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        countMensaje++;
                                        break;
                                    }
                                }
                            }
                        }
                        db.SaveChanges();
                    }
                }
            }

            if (countMensaje == 0)
            {
                string mensajeGuardado = "Los cambios se han guardado con éxito";
                MessageBox.Show(mensajeGuardado, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void CalificarAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logic.PreguntaCerrarVentanas(e);
        }
    }
}
