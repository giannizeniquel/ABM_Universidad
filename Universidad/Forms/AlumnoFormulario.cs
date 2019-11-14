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

namespace Universidad.Forms
{
    public partial class AlumnoFormulario : Form
    {
        public AlumnoFormulario()
        {
            InitializeComponent();
        }

        private void AlumnoFormulario_Load(object sender, EventArgs e)
        {
            CargaComboBox cargaComboBox = new CargaComboBox();
            generoCb.DataSource = cargaComboBox.generoComboArray;
            edadCb.DataSource = cargaComboBox.EdadArray;
            provinciasCb.DataSource = cargaComboBox.provinciasArgentinasArray;
            paisesCb.DataSource = cargaComboBox.paisesArray;
            matriculaLb.Text = DatosEstaticos.Matricula.ToString();
        }

        private void CancerlarBt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?\n Perdera los datos no guardados", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
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
        private void ProvinciasCb_TextChanged(object sender, EventArgs e)
        {
            if (provinciasCb.Text == "Chaco")
            {
                CargaComboBox cargaComboBox = new CargaComboBox();
                localidadesCb.DataSource = cargaComboBox.localidadesChacoArgentinaArray;
            }
            else
            {
                localidadesCb.DataSource = null;
                localidadesCb.Items.Clear();
            }
        }

        private void AgregarAlumnoDbForm()
        {
            string edadParseS = edadCb.SelectedItem.ToString();
            int edadParse = int.Parse(edadParseS);
            GestionDb.CargarAulumnoDb(nombreTb.Text, apellidoTb.Text, dniTb.Text, telefonoTb.Text, paisesCb.SelectedItem.ToString(), provinciasCb.SelectedItem.ToString(),
                localidadesCb.SelectedItem.ToString(),
                edadParse, generoCb.SelectedItem.ToString(), nacimientoDtp.Value.Date, direccionTb.Text);
        }
        private void AgregarBt_Click(object sender, EventArgs e)
        {
            if (nombreTb.Text == "" || nombreTb.Text == " " || apellidoTb.Text == "" || apellidoTb.Text == " " || dniTb.Text == "" || dniTb.Text == " " || telefonoTb.Text == ""
                || telefonoTb.Text == " " || direccionTb.Text == "" || direccionTb.Text == " " || provinciasCb.SelectedItem.ToString() == "" || provinciasCb.SelectedItem.ToString() == " " || localidadesCb.SelectedItem.ToString() == "" || localidadesCb.SelectedItem.ToString() == " ")
            {
                MessageBox.Show("Todos los campos deben contener valores", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarAlumnoDbForm();
                MessageBox.Show("El Alumno fue agregado con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dialogResult = MessageBox.Show("¿Desea agregar otro Alumno?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    nombreTb.Clear();
                    apellidoTb.Clear();
                    telefonoTb.Clear();
                    dniTb.Clear();
                    direccionTb.Clear();
                    matriculaLb.Text = DatosEstaticos.Matricula.ToString();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void AlumnoFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logic.PreguntaCerrarVentanas(e);
        }
    }
}
