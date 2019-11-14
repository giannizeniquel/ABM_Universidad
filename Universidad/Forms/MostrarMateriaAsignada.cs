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
    public partial class MostrarMateriaAsignada : Form
    {
        public MostrarMateriaAsignada()
        {
            InitializeComponent();
        }

        private void MostrarMateriaAsignada_Load(object sender, EventArgs e)
        {
            nombreProfesorLb.Text = DatosEstaticos.profesorEstatico.apellido_p + " " + DatosEstaticos.profesorEstatico.nombre_p;
            legajoProfesorLb.Text = DatosEstaticos.profesorEstatico.profesorId.ToString();
            int materiaCount = 0;
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstprofesorMateria = db.ProfesorMateria;
                foreach (var pm in lstprofesorMateria)
                {
                    if (pm.profesorId_1 == DatosEstaticos.profesorEstatico.profesorId)
                    {
                        materiasProfesorDg.Rows.Add();
                        materiasProfesorDg[0, materiaCount].Value = pm.Materia.nombre_m;
                        if (pm.turno == "A")
                        {
                            materiasProfesorDg[1, materiaCount].Value = "Mañana";
                        }
                        else
                        {
                            materiasProfesorDg[1, materiaCount].Value = "Tarde";
                        }
                        materiaCount++;
                    }
                }
            }
        }
    }
}

