namespace winform_app
{
    partial class frmAltaPokemons
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
            lblNumero = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblTipo = new Label();
            lblDebilidad = new Label();
            cbxTipo = new ComboBox();
            cbxDebilidad = new ComboBox();
            lblUrlImagen = new Label();
            txtUrlImagen = new TextBox();
            pbxUrlImagen = new PictureBox();
            btnAgregarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxUrlImagen).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(49, 47);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(29, 142);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(152, 47);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(154, 27);
            txtNumero.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(152, 139);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(154, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(49, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar:";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(198, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar:";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(72, 238);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            lblDebilidad.AutoSize = true;
            lblDebilidad.Location = new Point(40, 291);
            lblDebilidad.Name = "lblDebilidad";
            lblDebilidad.Size = new Size(78, 20);
            lblDebilidad.TabIndex = 9;
            lblDebilidad.Text = "Debilidad:";
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(155, 235);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(150, 28);
            cbxTipo.TabIndex = 4;
            // 
            // cbxDebilidad
            // 
            cbxDebilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDebilidad.FormattingEnabled = true;
            cbxDebilidad.Location = new Point(155, 283);
            cbxDebilidad.Name = "cbxDebilidad";
            cbxDebilidad.Size = new Size(151, 28);
            cbxDebilidad.TabIndex = 5;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.AutoSize = true;
            lblUrlImagen.Location = new Point(31, 190);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(85, 20);
            lblUrlImagen.TabIndex = 12;
            lblUrlImagen.Text = "Url Imagen:";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(155, 187);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(151, 27);
            txtUrlImagen.TabIndex = 3;
            txtUrlImagen.Leave += txtUrlImagen_Leave;
            // 
            // pbxUrlImagen
            // 
            pbxUrlImagen.Location = new Point(377, 50);
            pbxUrlImagen.Name = "pbxUrlImagen";
            pbxUrlImagen.Size = new Size(305, 339);
            pbxUrlImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxUrlImagen.TabIndex = 14;
            pbxUrlImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Location = new Point(324, 186);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(33, 29);
            btnAgregarImagen.TabIndex = 15;
            btnAgregarImagen.Text = "+";
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // frmAltaPokemons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 417);
            Controls.Add(btnAgregarImagen);
            Controls.Add(pbxUrlImagen);
            Controls.Add(txtUrlImagen);
            Controls.Add(lblUrlImagen);
            Controls.Add(cbxDebilidad);
            Controls.Add(cbxTipo);
            Controls.Add(lblDebilidad);
            Controls.Add(lblTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblNumero);
            MaximizeBox = false;
            Name = "frmAltaPokemons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Pokemon";
            Load += frmAltaPokemons_Load;
            ((System.ComponentModel.ISupportInitialize)pbxUrlImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblTipo;
        private Label lblDebilidad;
        private ComboBox cbxTipo;
        private ComboBox cbxDebilidad;
        private Label lblUrlImagen;
        private TextBox txtUrlImagen;
        private PictureBox pbxUrlImagen;
        private Button btnAgregarImagen;
    }
}