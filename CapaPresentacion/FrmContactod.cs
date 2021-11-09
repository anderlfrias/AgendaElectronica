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
    public partial class FrmContactod : Form
    {
        private readonly ContactoNegocio _negocio;
        public FrmContactod()
        {
            InitializeComponent();
            _negocio = new ContactoNegocio();
            MostrarContactos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarContactos()
        {
            dgvContactos.DataSource = _negocio.GetViewModel();
        }
    }
}
