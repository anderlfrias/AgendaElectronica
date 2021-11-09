using CapaEntidades;
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
    public partial class FrmMantenimiento : Form
    {
        private string id;
        private bool _toUpdate;
        private bool _toCreate;

        private Contacto _entity;
        private ContactoNegocio _nContacto;

        public string Id { get => id; set => id = value; }

        public FrmMantenimiento(bool toUpdate = false, bool toCreate = true)
        {
            InitializeComponent();
            _toUpdate = toUpdate;
            _toCreate = toCreate;

            if (_toUpdate)
            {
                RellenarCampos();
            }
        }

        public FrmMantenimiento()
        {
            InitializeComponent();
            _toUpdate = false;
            _toCreate = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNombre.Texts == "Nombre")
            {
                txtNombre.Texts = "";
                lblNombre.Visible = true;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "Nombre" || txtNombre.Texts == "")
            {
                lblNombre.Visible = false;
                txtNombre.Texts = "Nombre";
            }
            else
            {
                lblNombre.Visible = true;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "Nombre" || txtNombre.Texts == "")
            {
                lblNombre.Visible = false;
                txtNombre.Texts = "Nombre";
            }
        }

        
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "Apellido" || txtApellido.Texts == "")
            {
                lblApellido.Visible = false;
                txtApellido.Texts = "Apellido";
            }
            else
            {
                lblApellido.Visible = true;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "Apellido" || txtApellido.Texts == "")
            {
                lblApellido.Visible = false;
                txtApellido.Texts = "Apellido";
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtApellido.Texts == "Apellido")
            {
                txtApellido.Texts = "";
                lblApellido.Visible = true;
            }
        }

        
        private void txtMovil_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMovil.Texts == "Movil")
            {
                txtMovil.Texts = "";
                lblMovil.Visible = true;
            }
        }

        private void txtMovil_Enter(object sender, EventArgs e)
        {
            if (txtMovil.Texts == "Movil" || txtMovil.Texts == "")
            {
                lblMovil.Visible = false;
                txtMovil.Texts = "Movil";
            }
            else
            {
                lblMovil.Visible = true;
            }
        }

        private void txtMovil_Leave(object sender, EventArgs e)
        {
            if (txtMovil.Texts == "Movil" || txtMovil.Texts == "")
            {
                lblMovil.Visible = false;
                txtMovil.Texts = "Movil";
            }
        }

        
        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTelefono.Texts == "Telefono")
            {
                txtTelefono.Texts = "";
                lblTelefono.Visible = true;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Texts == "Telefono" || txtTelefono.Texts == "")
            {
                lblTelefono.Visible = false;
                txtTelefono.Texts = "Telefono";
            }
            else
            {
                lblTelefono.Visible = true;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Texts == "Telefono" || txtTelefono.Texts == "")
            {
                lblTelefono.Visible = false;
                txtTelefono.Texts = "Telefono";
            }
        }

        
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmail.Texts == "Email")
            {
                txtEmail.Texts = "";
                lblEmail.Visible = true;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "Email" || txtEmail.Texts == "")
            {
                lblEmail.Visible = false;
                txtEmail.Texts = "Email";
            }
            else
            {
                lblEmail.Visible = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "Email" || txtEmail.Texts == "")
            {
                lblEmail.Visible = false;
                txtEmail.Texts = "Email";
            }
        }

        
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Texts == "Direccion" || txtDireccion.Texts == "")
            {
                lblDireccion.Visible = false;
                txtDireccion.Texts = "Direccion";
            }
            else
            {
                lblDireccion.Visible = true;
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDireccion.Texts == "Direccion")
            {
                txtDireccion.Texts = "";
                lblDireccion.Visible = true;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Texts == "Direccion" || txtDireccion.Texts == "")
            {
                lblDireccion.Visible = false;
                txtDireccion.Texts = "Direccion";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void FormClose()
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_toCreate)
            {
                CrearContacto();
            }
        }

        private void CrearContacto()
        {

            _entity = new Contacto();
            _nContacto = new ContactoNegocio();

            _entity.Id = Id;
            _entity.Nombre = txtNombre.Texts.ToUpper();
            _entity.Apellido = txtApellido.Texts.ToUpper();
            _entity.Movil = txtMovil.Texts.ToUpper();
            _entity.Telefono = txtTelefono.Texts.ToUpper();
            _entity.Email = txtEmail.Texts.ToUpper();
            _entity.Direccion = txtDireccion.Texts.ToUpper();
            _entity.FechaNacimiento = dtpFecha.Value;
            _entity.Genero = cboGenero.SelectedItem.ToString().ToUpper();
            _entity.EstadoCivil = cboEstadoCivil.SelectedItem.ToString().ToUpper();

            var result = _nContacto.Create(_entity);

            MessageBox.Show(result, "Informacion");
        }

        private void EditarContacto()
        {
            _entity = new Contacto();
            _nContacto = new ContactoNegocio();

            _entity.Id = id;
            _entity.Nombre = txtNombre.Texts.ToUpper();
            _entity.Apellido = txtApellido.Texts.ToUpper();
            _entity.Movil = txtMovil.Texts.ToUpper();
            _entity.Telefono = txtTelefono.Texts.ToUpper();
            _entity.Email = txtEmail.Texts.ToUpper();
            _entity.Direccion = txtDireccion.Texts.ToUpper();
            _entity.FechaNacimiento = dtpFecha.Value;
            _entity.Genero = cboGenero.SelectedItem.ToString().ToUpper();
            _entity.EstadoCivil = cboEstadoCivil.SelectedItem.ToString().ToUpper();

            var result = _nContacto.Update(_entity);

            MessageBox.Show(result, "Informacion");
        }

        private void RellenarCampos()
        {
            MessageBox.Show("Updating contacto...");
        }
    }
}
