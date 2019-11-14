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
    public partial class AsignarMatProfesor : Form
    {
        public AsignarMatProfesor()
        {
            InitializeComponent();
        }

        private void AsignarMatProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet6.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.universidadDataSet6.Materia);
            nombreLb.Text = DatosEstaticos.profesorEstatico.apellido_p + " " + DatosEstaticos.profesorEstatico.nombre_p;
            matriculaLb.Text = DatosEstaticos.profesorEstatico.profesorId.ToString();
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet4.Materia' Puede moverla o quitarla según sea necesario.
            // this.materiaTableAdapter.Fill(this.universidadDataSet4.Materia);
            refrescar();
        }
        public void refrescar()
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                materiaBindingSource1.DataSource = null;
                materiaBindingSource1.DataSource = db.Materia.ToList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Materia m = (Materia)materiaBindingSource1.Current;
            DatosEstaticos.materiaId = m.materiaId;
            TurnoProfesor tp = new TurnoProfesor();
            tp.ShowDialog();
        }

        private void SalirBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
