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
    public partial class AlumnoMateriasForms : Form
    {
        public AlumnoMateriasForms()
        {
            InitializeComponent();
        }

        private void AlumnoMateriasForms_Load(object sender, EventArgs e)
        {
            int countCursado = 0;
            int countAprobado = 0;
            if (DatosEstaticos.alumnoEstatico != null) {
                using (UniversidadEntitiesSql db = new UniversidadEntitiesSql()) {
                    var lstCall = db.connectAll;
                    foreach (var ca in lstCall) {
                        if (DatosEstaticos.alumnoEstatico.alumnoId == ca.alumnoId_1) {
                            if (ca.notaFinal == 0) {
                                cursandoDg.Rows.Add();
                                cursandoDg[0, countCursado].Value = ca.cursoMateria.curso.anio_c.ToString();
                                cursandoDg[1, countCursado].Value = ca.cursoMateria.Materia.nombre_m.ToString();
                                string cursadoString = "Cursa en: división [" + ca.cursoMateria.curso.division_c + "]" + " / Aula " + ca.aulaId_1.ToString() + " EDIFICIO CENTRAL";
                                cursandoDg[2, countCursado].Value = cursadoString;
                                countCursado++;
                            } else if (ca.notaFinal >= 6) {
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
    }
}
