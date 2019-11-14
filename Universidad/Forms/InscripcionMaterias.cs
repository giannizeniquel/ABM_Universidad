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
    public partial class InscripcionMaterias : Form
    {
        private List<cursoMateria> cmList = new List<cursoMateria>();
        public InscripcionMaterias()
        {
            InitializeComponent();
        }
        private void InscripcionMaterias_Load(object sender, EventArgs e)
        {
            /** CARGA PARA INSCRIPCION**/
            materiaLb.Hide();
            cursadoLb.Hide();
            anioLb.Hide();
            correlativaLb.Hide();
            nombreAlumno.Hide();
            matriculaAlumno.Hide();
            CargarMaterias();
            /** CARGA PARA INSCRIPCION**/
        }
        /** Mostramos Docentes**/
        private void MostrarDocentes(int idmateria)
        {
            docenteDg.Rows.Clear();
            int countProfesorMateria = 0;
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstprofesorMateria = db.ProfesorMateria;
                foreach (var ca in lstprofesorMateria)
                {
                    if (ca.materiaId_2 == idmateria)
                    {
                        docenteDg.Rows.Add();
                        docenteDg[0, countProfesorMateria].Value = ca.turno;
                        string nombreApellidoProfesor = ca.profesor.apellido_p + " " + ca.profesor.nombre_p;
                        docenteDg[1, countProfesorMateria].Value = nombreApellidoProfesor;
                        countProfesorMateria++;
                    }
                }
            }
        }
        /**Carga Materias funciones**/

        private void CargarMaterias()
        {
            if (DatosEstaticos.estadoCargaMaterias == 1)
            {
                MostrarTodasMaterias();
            }
            else if (DatosEstaticos.estadoCargaMaterias == 2 && DatosEstaticos.alumnoEstatico != null)
            {
                nombreAlumno.Text = DatosEstaticos.alumnoEstatico.apellido_a +", " + DatosEstaticos.alumnoEstatico.nombre_a;
                matriculaAlumno.Text = "Matricula: " + DatosEstaticos.alumnoEstatico.alumnoId.ToString();
                nombreAlumno.Show();
                matriculaAlumno.Show();
                recorrerMaterias();
            }
        }
        private void MostrarTodasMaterias()
        {
            inscribirBt.Hide();
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstCursoMateria = db.cursoMateria;
                foreach (var cm in lstCursoMateria)
                {
                    if (cm.curso.division_c == "A")
                    {
                        MateriasLb.Items.Add(cm.Materia.nombre_m);
                        cmList.Add(cm);
                    }
                }
            }
        }

        private void recorrerMaterias()
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstConnectAll = db.connectAll;
                cmList.Clear();
                bool isNewAlumno = false;
                isNewAlumno = GestionDb.EsAlumnoNuevo(DatosEstaticos.alumnoEstatico);
                var lstCursoMateria = db.cursoMateria;
                int count = 0;
                int countAgregado = 0;

                foreach (var cm in lstCursoMateria)
                {
                    if (cm.Materia.nombre_m == "Inglés I")
                    {
                        string asd = "asd";
                    }
                    if (cm.curso.division_c == "A")
                    {
                        if (isNewAlumno && DatosEstaticos.alumnoEstatico != null)
                        {
                            if (cm.curso.anio_c == 1)
                            {
                                cmList.Add(cm);
                            }
                        }
                        else if (DatosEstaticos.alumnoEstatico != null)
                        {

                            foreach (var ca in lstConnectAll)
                            {
                                if (ca.alumnoId_1 == DatosEstaticos.alumnoEstatico.alumnoId)
                                {
                                    if (ca.notaFinal >= 6)
                                    {
                                        if (cm.Materia.correlativaId == ca.cursoMateria.materiaId_1)
                                        {
                                            foreach (var ca2 in lstConnectAll)
                                            {
                                                if (ca2.cursoMateria.materiaId_1 == cm.materiaId_1)
                                                {
                                                    count++;
                                                }
                                            }
                                            if (count == 0)
                                            {
                                                cmList.Add(cm);
                                                countAgregado++;
                                            }
                                            else
                                            {
                                                count = 0;
                                            }
                                        }
                                    }
                                    if (cm.materiaId_1 == ca.cursoMateria.materiaId_1)
                                    {
                                        count++;
                                    }
                                }
                            }
                            if (cm.Materia.Materia2 == null && count == 0 && countAgregado == 0)
                            {
                                cmList.Add(cm);
                                countAgregado++;
                            }
                        }
                    }
                    countAgregado = 0;
                    count = 0;
                }
                for (int i = 0; i < cmList.Count; i++)
                {
                    MateriasLb.Items.Add(cmList[i].Materia.nombre_m);
                }
            }
        }
        /** Creo una lista para obtener el objeto del checklistBox por que no se meocurre otra manera **/
        private void MateriasLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiaLb.Show();
            cursadoLb.Show();
            anioLb.Show();
            correlativaLb.Show();

            AulaCb.Items.Clear();
            int index = MateriasLb.SelectedIndex;
            materiaLb.Text = cmList[index].Materia.nombre_m;
            cursadoLb.Text = cmList[index].Materia.duracion_m;
            anioLb.Text = cmList[index].curso.anio_c.ToString();
            if (cmList[index].Materia.Materia2 == null) { correlativaLb.Text = "Ninguna"; }
            else { correlativaLb.Text = cmList[index].Materia.Materia2.nombre_m; }

            MostrarDocentes((int)cmList[index].materiaId_1);

            CargaComboBox cargaComboBox = new CargaComboBox();
            if (cmList[index].curso.anio_c == 1)
            {
                divicionesCb.DataSource = cargaComboBox.diviciones;
                AulaCb.Items.Add(1);
                AulaCb.Items.Add(2);
            }
            else if (cmList[index].curso.anio_c == 2)
            {
                divicionesCb.DataSource = cargaComboBox.diviciones;
                AulaCb.Items.Add(3);
                AulaCb.Items.Add(4);
            }
            else if (cmList[index].curso.anio_c == 3)
            {
                divicionesCb.DataSource = cargaComboBox.diviciones;
                AulaCb.Items.Add(5);
                AulaCb.Items.Add(6);
            }
            else if (cmList[index].curso.anio_c == 4)
            {
                divicionesCb.DataSource = null;
                divicionesCb.Items.Add('A');
                AulaCb.Items.Add(7);
            }
            else if (cmList[index].curso.anio_c == 5)
            {
                divicionesCb.DataSource = null;
                divicionesCb.Items.Add('A');
                AulaCb.Items.Add(8);
            }
        }

        private void InscribirBt_Click(object sender, EventArgs e)
        {
            if (AulaCb.SelectedItem != null && !string.IsNullOrEmpty(AulaCb.SelectedItem.ToString()) && !string.IsNullOrWhiteSpace(AulaCb.SelectedItem.ToString()))
            {
                int indexCm = MateriasLb.SelectedIndex;
                int aulaId = int.Parse(AulaCb.SelectedItem.ToString());

                if (divicionesCb.SelectedItem.ToString() == "B")
                {
                    using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                    {
                        var lstCm = db.cursoMateria;
                        foreach (var cm in lstCm)
                        {
                            if (cm.Materia.materiaId == cmList[indexCm].Materia.materiaId && cm.curso.division_c == "B")
                            {
                                GestionDb.InscribirAlumnoMateria(DatosEstaticos.alumnoEstatico.alumnoId, cm.cursoMateriaId, aulaId);
                            }
                        }
                    }
                }
                else { GestionDb.InscribirAlumnoMateria(DatosEstaticos.alumnoEstatico.alumnoId, cmList[indexCm].cursoMateriaId, aulaId); }
                string incripcionMateria = "Inscripcion realizada con exito : " + cmList[indexCm].Materia.nombre_m;
                MessageBox.Show(incripcionMateria, "Inscripcion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MateriasLb.Items.Clear();
                CargarMaterias();
            }
            else
            {
                MessageBox.Show("ERROR: Seleccione un aula", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
