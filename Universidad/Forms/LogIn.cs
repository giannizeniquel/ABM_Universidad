using System;
using System.Collections.Generic;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void IngresarBt_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < CargaComboBox.usuarioAlumno.Count; i++)
            {
                if (CargaComboBox.usuarioAlumno[i] == usuarioTb.Text)
                {
                    if (CargaComboBox.passAlumno[i] == passTb.Text)
                    {
                        if (usuarioTb.Text == "admin")
                        {
                            DatosEstaticos.accesoUsuario = 1;
                        }
                        else if (usuarioTb.Text == "profesor")
                        {
                            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                            {
                                profesor a = db.profesor.Find(3);
                                DatosEstaticos.profesorEstatico = a;
                            }
                            DatosEstaticos.accesoUsuario = 2;
                        }
                        else if (usuarioTb.Text == "36115256")
                        {
                            using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                            {
                                alumno a = db.alumno.Find(3);
                                DatosEstaticos.alumnoEstatico = a;
                            }
                            DatosEstaticos.accesoUsuario = 3;
                        }
                        Contenedor contenedor = new Contenedor();
                        this.Hide();
                        contenedor.ShowDialog();
                        count++;
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        count++;
                        break;
                    }
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Usuario no encontrado", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
