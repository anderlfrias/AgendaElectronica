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
        private string id;
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
            id = null;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            MostrarContactos(txtFiltro.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Seleccione el contacto a Editar");
            }
            else
            {
                FrmMantenimiento mantenimiento = new FrmMantenimiento(id);
                mantenimiento.Show();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimiento mantenimiento = new FrmMantenimiento();
            mantenimiento.Show();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Seleccione el contacto");
            }
            else
            {
                FrmMantenimiento mantenimiento = new FrmMantenimiento(id, true);
                mantenimiento.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                var result = MessageBox.Show("¿Esta seguro de que desea eliminar este contacto?",
                "Advertencia",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    EliminarContacto();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el contacto a eliminar");
            }
        }

        private void EliminarContacto()
        {
            var result = _negocio.Delete(id);
            MessageBox.Show(result, "Information");
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvContactos.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvContactos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
