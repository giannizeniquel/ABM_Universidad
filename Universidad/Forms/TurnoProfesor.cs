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
    public partial class TurnoProfesor : Form
    {
        public TurnoProfesor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool incriptoA = false;
            bool incriptoB = false;
            bool turnoTomadoa = false;
            bool turnoTomadob = false;
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                var lstProfesorMateria = db.ProfesorMateria;
                foreach (var pm in lstProfesorMateria)
                {
                    if (pm.materiaId_2 == DatosEstaticos.materiaId && pm.profesorId_1 == DatosEstaticos.profesorEstatico.profesorId)
                    {
                        if (pm.turno == "A")
                        {
                            incriptoA = true;
                        }
                        if (pm.turno == "B")
                        {
                            incriptoB = true;
                        }
                    }
                    if (pm.materiaId_2 == DatosEstaticos.materiaId)
                    {
                        if (pm.turno == "A")
                        {
                            turnoTomadoa = true;
                        }
                        if (pm.turno == "B")
                        {
                            turnoTomadob = true;
                        }
                    }
                }
            }

            if (aCb.Checked || bCb.Checked)
            {
                if (aCb.Checked)
                {
                    if (!turnoTomadoa)
                    {
                        if (!incriptoA)
                        {
                            GestionDb.AsignarMateriasProfesor(DatosEstaticos.profesorEstatico.profesorId, DatosEstaticos.materiaId, "A");
                            MessageBox.Show("Materia asignada con exito: ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: El profesor ya esta asignado a esta materia en el turno MAÑANA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: El turno ya esta asiganado a un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (bCb.Checked)
                {
                    if (!turnoTomadob)
                    {
                        if (!incriptoB)
                        {
                            GestionDb.AsignarMateriasProfesor(DatosEstaticos.profesorEstatico.profesorId, DatosEstaticos.materiaId, "B");
                            MessageBox.Show("Materia asignada con exito: ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: El profesor ya esta asignado a esta materia en el turno TARDE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: El turno ya esta asiganado a un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Seleccione un turno ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TurnoProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
