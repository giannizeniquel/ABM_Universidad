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
    public partial class ModificarProfesor : Form
    {
        public ModificarProfesor()
        {
            InitializeComponent();
        }

        private void ModificarProfesor_Load(object sender, EventArgs e)
        {
            nombreTb.Text = DatosEstaticos.profesorEstatico.nombre_p;
            edadTb.Text = DatosEstaticos.profesorEstatico.edad_p.ToString();
            nacimientoDtp.Value = (DateTime)DatosEstaticos.profesorEstatico.fechaNacimiento_p;
            telefonoTb.Text = DatosEstaticos.profesorEstatico.telefono_p;
            dniTb.Text = DatosEstaticos.profesorEstatico.dni_p;
            generoTb.Text = DatosEstaticos.profesorEstatico.genero_p;
            paisTb.Text = DatosEstaticos.profesorEstatico.pais_p;
            provinciaTb.Text = DatosEstaticos.profesorEstatico.provincia_p;
            localidadTb.Text = DatosEstaticos.profesorEstatico.localidad_p;
            direccionTb.Text = DatosEstaticos.profesorEstatico.direccion_p;
            apellidoTb.Text = DatosEstaticos.profesorEstatico.apellido_p;
            matriculaLb.Text = DatosEstaticos.profesorEstatico.profesorId.ToString();
        }

        private void GuardarBt_Click(object sender, EventArgs e)
        {
            int edadParse = int.Parse(edadTb.Text);
            if (edadParse < 21 || edadParse > 95)
            {
                MessageBox.Show("Error: El profesor debe tener una edad valida entre 21 y 95 años", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (UniversidadEntitiesSql db = new UniversidadEntitiesSql())
                {
                    profesor p = db.profesor.Find(DatosEstaticos.profesorEstatico.profesorId);
                    p.nombre_p = nombreTb.Text;
                    p.edad_p = edadParse;
                    p.fechaNacimiento_p = nacimientoDtp.Value.Date;
                    p.telefono_p = telefonoTb.Text;
                    p.dni_p = dniTb.Text;
                    p.genero_p = generoTb.Text;
                    p.pais_p = paisTb.Text;
                    p.provincia_p = provinciaTb.Text;
                    p.localidad_p = localidadTb.Text;
                    p.direccion_p = direccionTb.Text;
                    p.apellido_p = apellidoTb.Text;
                    db.SaveChanges();
                }
                MessageBox.Show("Modificaciones Guardadas con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void DniTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void TelefonoTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void EdadTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void SalirBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
