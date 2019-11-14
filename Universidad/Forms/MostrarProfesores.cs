using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using Universidad.Forms;

namespace Universidad.Forms
{
    public partial class MostrarProfesores : Form
    {
        public MostrarProfesores()
        {
            InitializeComponent();
        }

        private void MostrarProfesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet3.profesor' Puede moverla o quitarla según sea necesario.
            //this.profesorTableAdapter.Fill(this.universidadDataSet3.profesor);
            refrescar();
        }
        public void refrescar()
        {
            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
            {
                profesorBindingSource.DataSource = null;
                profesorBindingSource.DataSource = db.profesor.ToList();
            }
        }
        private void AsiganrMateriaBt_Click(object sender, EventArgs e)
        {
            profesor p = (profesor)profesorBindingSource.Current;
            if (p != null)
            {
                DatosEstaticos.profesorEstatico = p;
            }
            AsignarMatProfesor asiganar = new AsignarMatProfesor();
            asiganar.ShowDialog();
        }

        private void VerMatAsignadaBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.profesorEstatico = (profesor)profesorBindingSource.Current;
            MostrarMateriaAsignada mMa = new MostrarMateriaAsignada();
            mMa.ShowDialog();
        }

        private void ModificarProfBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.profesorEstatico = (profesor)profesorBindingSource.Current;
            ModificarProfesor mP = new ModificarProfesor();
            mP.ShowDialog();
            refrescar();
        }

    }
}

