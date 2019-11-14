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
    public partial class AgregarProfesor : Form
    {
        public AgregarProfesor()
        {
            InitializeComponent();
        }

        private void AgregarProfesor_Load(object sender, EventArgs e)
        {
            CargaComboBox cargaComboBox = new CargaComboBox();
            paisCbProf.DataSource = cargaComboBox.paisesArray;
            generoCbProf.DataSource = cargaComboBox.generoComboArray;
            edadCbProf.DataSource = cargaComboBox.EdadArray;
            provinciaCbProf.DataSource = cargaComboBox.provinciasArgentinasArray;
            matriculaLbProf.Text = DatosEstaticos.clave_profesor.ToString();
        }

        private void DniTbProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void TelefonoTbProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logic.FiltrarLetras(e);
        }

        private void ProvinciaCbProf_TextChanged(object sender, EventArgs e)
        {
            if (provinciaCbProf.Text == "Chaco")
            {
                CargaComboBox cargaComboBox = new CargaComboBox();
                localidadCbProf.DataSource = cargaComboBox.localidadesChacoArgentinaArray;
            }
            else
            {
                localidadCbProf.DataSource = null;
                localidadCbProf.Items.Clear();
            }
        }

        private void AgregarProfesorDbForm()
        {
            int edadProf = int.Parse(edadCbProf.SelectedItem.ToString());

            GestionDb.CargarProfesorDb(nombreTbProf.Text, apellidoTbProf.Text, dniTbProf.Text, telefonoTbProf.Text, edadProf,
                direccionTbProf.Text, paisCbProf.SelectedItem.ToString(), provinciaCbProf.SelectedItem.ToString(),
                localidadCbProf.SelectedItem.ToString(), nacimientoDtpProf.Value.Date, generoCbProf.SelectedItem.ToString());
        }

        private void ProfCancelarBt_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                Contenedor.cancelarClosing = false;
                this.Close();
            }
            else
            {

            }
        }
        private void AgregarProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Contenedor.cancelarClosing)
            {
                Logic.PreguntaCerrarVentanas(e);
            }
            else
            {
                Contenedor.cancelarClosing = true;
            }
        }

        private void ProfAgregarBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTbProf.Text) ||
                string.IsNullOrWhiteSpace(apellidoTbProf.Text) ||
                string.IsNullOrWhiteSpace(dniTbProf.Text) ||
                string.IsNullOrWhiteSpace(telefonoTbProf.Text) ||
                string.IsNullOrWhiteSpace(direccionTbProf.Text) ||
                string.IsNullOrWhiteSpace(provinciaCbProf.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(localidadCbProf.SelectedItem.ToString()))
            {
                MessageBox.Show("Faltan rellenar campos obligatorios.", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarProfesorDbForm();

                MessageBox.Show("El profesor fue agregado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dialogResult = MessageBox.Show("¿Desea agregar otro profesor?", "Agregar Profesor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    nombreTbProf.Clear();
                    apellidoTbProf.Clear();
                    telefonoTbProf.Clear();
                    dniTbProf.Clear();
                    direccionTbProf.Clear();
                    matriculaLbProf.Text = DatosEstaticos.clave_profesor.ToString();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}