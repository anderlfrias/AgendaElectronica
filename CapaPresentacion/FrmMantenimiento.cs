using CapaEntidades;
using CapaNegocios;
using ControlesPersonalizados.Controles;
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

        private Contacto _entity;
        private ContactoNegocio _nContacto;

        public FrmMantenimiento(string id = null)
        {
            InitializeComponent();
            this.id = id;
           if (this.id != null)
            {
                RellenarCampos();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = (RJTextBox)sender;

            if (textBox.Texts == "Nombre")
            {
                textBox.Texts = "";
                lblNombre.Visible = true;
            }
            else if (textBox.Texts == "Apellido")
            {
                textBox.Texts = "";
                lblApellido.Visible = true;
            }
            else if (textBox.Texts == "Movil")
            {
                textBox.Texts = "";
                lblMovil.Visible = true;
            }
            else if (textBox.Texts == "Telefono")
            {
                textBox.Texts = "";
                lblTelefono.Visible = true;
            }
            else if (textBox.Texts == "Email")
            {
                textBox.Texts = "";
                lblEmail.Visible = true;
            }
            else if (textBox.Texts == "Direccion")
            {
                textBox.Texts = "";
                lblDireccion.Visible = true;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = (RJTextBox)sender;

            if(textBox.Tag.ToString() == "Nombre")
            {
                if (textBox.Texts == "Nombre" || textBox.Texts == "")
                {
                    lblNombre.Visible = false;
                    textBox.Texts = "Nombre";
                }
                else
                {
                    lblNombre.Visible = true;
                }
            }
            else if (textBox.Tag.ToString() == "Apellido")
            {
                if (textBox.Texts == "Apellido" || textBox.Texts == "")
                {
                    lblApellido.Visible = false;
                    textBox.Texts = "Apellido";
                }
                else
                {
                    lblApellido.Visible = true;
                }
            }
            else if (textBox.Tag.ToString() == "Movil")
            {
                if (textBox.Texts == "Movil" || textBox.Texts == "")
                {
                    lblMovil.Visible = false;
                    textBox.Texts = "Movil";
                }
                else
                {
                    lblMovil.Visible = true;
                }
            }
            else if (textBox.Tag.ToString() == "Telefono")
            {
                if (textBox.Texts == "Telefono" || textBox.Texts == "")
                {
                    lblTelefono.Visible = false;
                    textBox.Texts = "Telefono";
                }
                else
                {
                    lblTelefono.Visible = true;
                }
            }
            else if (textBox.Tag.ToString() == "Email")
            {
                if (textBox.Texts == "Email" || textBox.Texts == "")
                {
                    lblEmail.Visible = false;
                    textBox.Texts = "Email";
                }
                else
                {
                    lblEmail.Visible = true;
                }
            }
            else if (textBox.Tag.ToString() == "Direccion")
            {
                if (textBox.Texts == "Direccion" || textBox.Texts == "")
                {
                    lblDireccion.Visible = false;
                    textBox.Texts = "Direccion";
                }
                else
                {
                    lblDireccion.Visible = true;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = (RJTextBox)sender;

            if (textBox.Texts == ""){
                textBox.Texts = textBox.Tag.ToString();
            }
            if (textBox.Texts == "Nombre")
            {
                lblNombre.Visible = false;
                textBox.Texts = "Nombre";
            }
            else if (textBox.Texts == "Apellido")
            {
                lblApellido.Visible = false;
                textBox.Texts = "Apellido";
            }
            else if (textBox.Texts == "Movil")
            {
                lblMovil.Visible = false;
                textBox.Texts = "Movil";
            }
            else if (textBox.Texts == "Telefono")
            {
                lblTelefono.Visible = false;
                textBox.Texts = "Telefono";
            }
            else if (textBox.Texts == "Email")
            {
                lblEmail.Visible = false;
                textBox.Texts = "Email";
            }
            else if (textBox.Texts == "Direccion")
            {
                lblDireccion.Visible = false;
                textBox.Texts = "Dirrecion";
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void CrearContacto()
        {

            _entity = new Contacto();
            _nContacto = new ContactoNegocio();
            _entity.Nombre = txtNombre.Texts.ToUpper();
            _entity.Apellido = txtApellido.Texts.ToUpper();
            _entity.Movil = txtMovil.Texts.ToUpper();
            _entity.Telefono = txtTelefono.Texts.ToUpper();
            _entity.Email = txtEmail.Texts;
            _entity.Direccion = txtDireccion.Texts.ToUpper();
            _entity.FechaNacimiento = dtpFecha.Value;
            _entity.Genero = cboGenero.SelectedItem.ToString().ToUpper();
            _entity.EstadoCivil = cboEstadoCivil.SelectedItem.ToString().ToUpper();

            var result = _nContacto.Create(_entity);
            if (result == "Contacto guardado correctamente")
            {
                Limpiar();
                MessageBox.Show(result, "Informacion");
            }
            else
            {
                MessageBox.Show(result, "Error");
            }
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
            _entity.Email = txtEmail.Texts;
            _entity.Direccion = txtDireccion.Texts.ToUpper();
            _entity.FechaNacimiento = dtpFecha.Value;
            _entity.Genero = cboGenero.SelectedItem.ToString().ToUpper();
            _entity.EstadoCivil = cboEstadoCivil.SelectedItem.ToString().ToUpper();

            var result = _nContacto.Update(_entity);

            MessageBox.Show(result, "Informacion");
        }

        private void RellenarCampos()
        {
            MessageBox.Show("Updating contacto..."+id, "Informacion");
        }

        private void Limpiar()
        {
            //TextBox
            txtNombre.Texts = "Nombre";
            txtApellido.Texts = "Apellido";
            txtMovil.Texts = "Movil";
            txtTelefono.Texts = "Telefono";
            txtEmail.Texts = "Email";
            txtDireccion.Texts = "Direccion";

            //ComboBox
            cboGenero.Text = "Genero";
            cboEstadoCivil.Text = "Estado Civil";
        }
    }
}
