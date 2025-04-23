namespace practica5
{
    partial class frmDatosPersonales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblApellido = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblDireccion = new Label();
            lblResultado = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtDireccion = new TextBox();
            txtResultado = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(38, 26);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 20);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(38, 102);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(49, 20);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "EDAD";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(38, 150);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "DIRECCION";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(38, 213);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(89, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "RESULTADO";
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(129, 23);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(308, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(129, 62);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(129, 99);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 7;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.Location = new Point(129, 147);
            txtDireccion.MaxLength = 50;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(308, 27);
            txtDireccion.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.CharacterCasing = CharacterCasing.Upper;
            txtResultado.Location = new Point(38, 236);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(399, 130);
            txtResultado.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(113, 386);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(95, 29);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(257, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmDatosPersonales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 448);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtResultado);
            Controls.Add(txtDireccion);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblResultado);
            Controls.Add(lblDireccion);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Name = "frmDatosPersonales";
            Text = "Datos Personales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApellido;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblResultado;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtDireccion;
        private TextBox txtResultado;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
