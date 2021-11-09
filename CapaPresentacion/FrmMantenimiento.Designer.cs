namespace CapaPresentacion
{
    partial class FrmMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNombre = new ControlesPersonalizados.Controles.RJTextBox();
            this.txtApellido = new ControlesPersonalizados.Controles.RJTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtMovil = new ControlesPersonalizados.Controles.RJTextBox();
            this.txtTelefono = new ControlesPersonalizados.Controles.RJTextBox();
            this.txtDireccion = new ControlesPersonalizados.Controles.RJTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtEmail = new ControlesPersonalizados.Controles.RJTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMovil = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 21);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(31, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "MANTENIMIENTO CONTACTOS";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(12, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(208, 32);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Texts = "Nombre";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtApellido.BorderColor = System.Drawing.Color.White;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(12, 162);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(208, 32);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.Texts = "Apellido";
            this.txtApellido.UnderlinedStyle = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(12, 53);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(146, 20);
            this.lblCod.TabIndex = 7;
            this.lblCod.Text = "Contacto: COD-1234";
            // 
            // txtMovil
            // 
            this.txtMovil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMovil.BorderColor = System.Drawing.Color.White;
            this.txtMovil.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtMovil.BorderSize = 2;
            this.txtMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.ForeColor = System.Drawing.Color.White;
            this.txtMovil.Location = new System.Drawing.Point(12, 229);
            this.txtMovil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMovil.Multiline = false;
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Padding = new System.Windows.Forms.Padding(7);
            this.txtMovil.PasswordChar = false;
            this.txtMovil.Size = new System.Drawing.Size(208, 32);
            this.txtMovil.TabIndex = 8;
            this.txtMovil.Texts = "Movil";
            this.txtMovil.UnderlinedStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.White;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(12, 297);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.Size = new System.Drawing.Size(208, 32);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Texts = "Telefono";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDireccion.BorderColor = System.Drawing.Color.White;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(290, 108);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.Size = new System.Drawing.Size(237, 86);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.Texts = "Direccion";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(290, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(237, 25);
            this.dtpFecha.TabIndex = 11;
            // 
            // cboGenero
            // 
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(290, 304);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(237, 25);
            this.cboGenero.TabIndex = 12;
            this.cboGenero.Text = "Genero";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(290, 376);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(237, 25);
            this.cboEstadoCivil.TabIndex = 13;
            this.cboEstadoCivil.Text = "Estado Civil";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(12, 369);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(208, 32);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Texts = "Email";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(15, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Visible = false;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.ForeColor = System.Drawing.Color.White;
            this.lblMovil.Location = new System.Drawing.Point(15, 217);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(40, 15);
            this.lblMovil.TabIndex = 17;
            this.lblMovil.Text = "Movil:";
            this.lblMovil.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(15, 284);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(15, 354);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(287, 85);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.Visible = false;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(579, 487);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTitle;
        private ControlesPersonalizados.Controles.RJTextBox txtNombre;
        private ControlesPersonalizados.Controles.RJTextBox txtApellido;
        private System.Windows.Forms.Label lblCod;
        private ControlesPersonalizados.Controles.RJTextBox txtMovil;
        private ControlesPersonalizados.Controles.RJTextBox txtTelefono;
        private ControlesPersonalizados.Controles.RJTextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private ControlesPersonalizados.Controles.RJTextBox txtEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
    }
}