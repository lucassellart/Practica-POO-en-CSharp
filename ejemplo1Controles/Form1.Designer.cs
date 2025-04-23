namespace ejemplo1
{
    partial class Form1
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
            txtNombre = new TextBox();
            lwElementos = new ListView();
            btnAgregar = new Button();
            lblPerfilPersona = new Label();
            lblNombre = new Label();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            cbxChocolate = new CheckBox();
            rbnWizard = new RadioButton();
            rbnMuggle = new RadioButton();
            rbnSquibs = new RadioButton();
            gbxTipo = new GroupBox();
            lblColorFavorito = new Label();
            lblNumeroFavorito = new Label();
            cbxColorFav = new ComboBox();
            numNumeroFavorito = new NumericUpDown();
            btnVerPerfil = new Button();
            gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(209, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 27);
            txtNombre.TabIndex = 0;
            // 
            // lwElementos
            // 
            lwElementos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwElementos.Location = new Point(109, 460);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new Size(407, 153);
            lwElementos.TabIndex = 2;
            lwElementos.UseCompatibleStateImageBehavior = false;
            lwElementos.View = View.List;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.FlatAppearance.BorderColor = Color.Red;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(118, 619);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agre&gar:";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblPerfilPersona
            // 
            lblPerfilPersona.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPerfilPersona.AutoSize = true;
            lblPerfilPersona.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPerfilPersona.Location = new Point(136, 20);
            lblPerfilPersona.Name = "lblPerfilPersona";
            lblPerfilPersona.Size = new Size(203, 40);
            lblPerfilPersona.TabIndex = 4;
            lblPerfilPersona.Text = "Perfil Persona:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(136, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(72, 141);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(131, 20);
            lblFechaNac.TabIndex = 6;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNac.Location = new Point(209, 136);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(307, 27);
            dtpFechaNac.TabIndex = 1;
            // 
            // cbxChocolate
            // 
            cbxChocolate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxChocolate.AutoSize = true;
            cbxChocolate.Location = new Point(209, 186);
            cbxChocolate.Name = "cbxChocolate";
            cbxChocolate.Size = new Size(199, 24);
            cbxChocolate.TabIndex = 2;
            cbxChocolate.Text = "Te gusta el chocolate pa?";
            cbxChocolate.UseVisualStyleBackColor = true;
            // 
            // rbnWizard
            // 
            rbnWizard.AutoSize = true;
            rbnWizard.Checked = true;
            rbnWizard.Location = new Point(69, 35);
            rbnWizard.Name = "rbnWizard";
            rbnWizard.Size = new Size(77, 24);
            rbnWizard.TabIndex = 9;
            rbnWizard.TabStop = true;
            rbnWizard.Text = "Wizard";
            rbnWizard.UseVisualStyleBackColor = true;
            // 
            // rbnMuggle
            // 
            rbnMuggle.AutoSize = true;
            rbnMuggle.Location = new Point(201, 35);
            rbnMuggle.Name = "rbnMuggle";
            rbnMuggle.Size = new Size(81, 24);
            rbnMuggle.TabIndex = 10;
            rbnMuggle.TabStop = true;
            rbnMuggle.Text = "Muggle";
            rbnMuggle.UseVisualStyleBackColor = true;
            // 
            // rbnSquibs
            // 
            rbnSquibs.AutoSize = true;
            rbnSquibs.Location = new Point(337, 35);
            rbnSquibs.Name = "rbnSquibs";
            rbnSquibs.Size = new Size(74, 24);
            rbnSquibs.TabIndex = 11;
            rbnSquibs.TabStop = true;
            rbnSquibs.Text = "Squibs";
            rbnSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            gbxTipo.Anchor = AnchorStyles.Top;
            gbxTipo.Controls.Add(rbnSquibs);
            gbxTipo.Controls.Add(rbnWizard);
            gbxTipo.Controls.Add(rbnMuggle);
            gbxTipo.Location = new Point(72, 216);
            gbxTipo.Name = "gbxTipo";
            gbxTipo.Size = new Size(489, 90);
            gbxTipo.TabIndex = 3;
            gbxTipo.TabStop = false;
            gbxTipo.Text = "Tipo:";
            // 
            // lblColorFavorito
            // 
            lblColorFavorito.AutoSize = true;
            lblColorFavorito.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblColorFavorito.Location = new Point(136, 331);
            lblColorFavorito.Name = "lblColorFavorito";
            lblColorFavorito.Size = new Size(105, 20);
            lblColorFavorito.TabIndex = 13;
            lblColorFavorito.Text = "Color Favorito:";
            // 
            // lblNumeroFavorito
            // 
            lblNumeroFavorito.AutoSize = true;
            lblNumeroFavorito.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNumeroFavorito.Location = new Point(118, 374);
            lblNumeroFavorito.Name = "lblNumeroFavorito";
            lblNumeroFavorito.Size = new Size(123, 20);
            lblNumeroFavorito.TabIndex = 14;
            lblNumeroFavorito.Text = "Numero Favorito:";
            // 
            // cbxColorFav
            // 
            cbxColorFav.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxColorFav.FormattingEnabled = true;
            cbxColorFav.Location = new Point(247, 328);
            cbxColorFav.Name = "cbxColorFav";
            cbxColorFav.Size = new Size(269, 28);
            cbxColorFav.TabIndex = 4;
            // 
            // numNumeroFavorito
            // 
            numNumeroFavorito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numNumeroFavorito.Location = new Point(247, 372);
            numNumeroFavorito.Name = "numNumeroFavorito";
            numNumeroFavorito.Size = new Size(269, 27);
            numNumeroFavorito.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.FlatAppearance.BorderColor = Color.Teal;
            btnVerPerfil.FlatAppearance.BorderSize = 3;
            btnVerPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnVerPerfil.FlatStyle = FlatStyle.Flat;
            btnVerPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnVerPerfil.Location = new Point(118, 415);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(100, 39);
            btnVerPerfil.TabIndex = 6;
            btnVerPerfil.Text = "Ver Per&fil:";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(664, 669);
            Controls.Add(btnVerPerfil);
            Controls.Add(numNumeroFavorito);
            Controls.Add(cbxColorFav);
            Controls.Add(lblNumeroFavorito);
            Controls.Add(lblColorFavorito);
            Controls.Add(gbxTipo);
            Controls.Add(cbxChocolate);
            Controls.Add(dtpFechaNac);
            Controls.Add(lblFechaNac);
            Controls.Add(lblNombre);
            Controls.Add(lblPerfilPersona);
            Controls.Add(btnAgregar);
            Controls.Add(lwElementos);
            Controls.Add(txtNombre);
            MinimumSize = new Size(682, 180);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gbxTipo.ResumeLayout(false);
            gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ListView lwElementos;
        private Button btnAgregar;
        private Label lblPerfilPersona;
        private Label lblNombre;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private CheckBox cbxChocolate;
        private RadioButton rbnWizard;
        private RadioButton rbnMuggle;
        private RadioButton rbnSquibs;
        private GroupBox gbxTipo;
        private Label lblColorFavorito;
        private Label lblNumeroFavorito;
        private ComboBox cbxColorFav;
        private NumericUpDown numNumeroFavorito;
        private Button btnVerPerfil;
    }
}
