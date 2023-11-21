using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySaleskiTPFINAL
{
    public partial class frmRegistro : Form
    {
        access objaccess;
        public frmRegistro()
        {
            InitializeComponent();
            objaccess = new access();
            objaccess.ConectarBD();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string ciudad = txtCiudad.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(ciudad) || string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objaccess.RegistrarEmpleado(nombre, apellido, ciudad, direccion);
            string mensaje = $"¡Registro exitoso!\nNombre: {nombre}\nApellido: {apellido}\nCiudad: {ciudad}\nDirección: {direccion}\nTeléfono: {telefono}";
            MessageBox.Show(mensaje, "¡Registro Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
        }
    }
}
