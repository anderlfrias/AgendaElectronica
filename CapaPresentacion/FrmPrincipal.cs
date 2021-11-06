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
    public partial class FrmPrincipal : Form
    {
        private readonly ContactoNegocio _negocio;
        public FrmPrincipal()
        {
            InitializeComponent();
            _negocio = new ContactoNegocio();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var result = _negocio.Get();
            dataGridView1.DataSource = result;
        }
    }
}
