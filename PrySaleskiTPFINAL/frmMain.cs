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
    public partial class frmMain : Form
    {
        private access objBaseDatos;

        public frmMain()
        {
            InitializeComponent();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void barraDeEstado_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            objBaseDatos = new access();
            objBaseDatos.ConectarBD();

            lblStatus.Text = objBaseDatos.estadoDeConexion;

            lblStatus.BackColor = Color.Green;
            lblStatus.ForeColor = Color.White;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListado newobj = new frmListado();
            newobj.ShowDialog();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }
    }
}
