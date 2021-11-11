using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmContactos : Form
    {
        private ContactoNegocio _negocio;
        public FrmContactos()
        {
            InitializeComponent();
            _negocio = new ContactoNegocio();
            MostrarContactos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarContactos(string filtro = "")
        {
            dgvContactos.DataSource = _negocio.GetViewModel(filtro);
            dgvContactos.Columns[0].Visible = false;
            dgvContactos.ClearSelection();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            MostrarContactos(txtFiltro.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmMantenimiento mantenimiento = new FrmMantenimiento(dgvContactos.CurrentRow.Cells[0].Value.ToString());
            mantenimiento.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        }
    }
}
