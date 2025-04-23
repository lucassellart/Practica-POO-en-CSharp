namespace practica
{
    partial class frmPractica1
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
            btnBoton = new Button();
            lblEtiqueta = new Label();
            txtTexto = new TextBox();
            txtCajaTexto2 = new TextBox();
            SuspendLayout();
            // 
            // btnBoton
            // 
            btnBoton.BackColor = SystemColors.WindowFrame;
            btnBoton.FlatStyle = FlatStyle.Flat;
            btnBoton.Location = new Point(164, 121);
            btnBoton.Name = "btnBoton";
            btnBoton.Size = new Size(95, 36);
            btnBoton.TabIndex = 0;
            btnBoton.Text = "Botón:";
            btnBoton.UseVisualStyleBackColor = false;
            btnBoton.Click += btnBoton_Click;
            // 
            // lblEtiqueta
            // 
            lblEtiqueta.AutoSize = true;
            lblEtiqueta.BorderStyle = BorderStyle.Fixed3D;
            lblEtiqueta.Font = new Font("Castellar", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEtiqueta.ForeColor = Color.FromArgb(192, 64, 0);
            lblEtiqueta.Location = new Point(40, 129);
            lblEtiqueta.Name = "lblEtiqueta";
            lblEtiqueta.Size = new Size(107, 23);
            lblEtiqueta.TabIndex = 1;
            lblEtiqueta.Text = "Etiqueta";
            lblEtiqueta.MouseLeave += lblEtiqueta_MouseLeave;
            lblEtiqueta.MouseMove += lblEtiqueta_MouseMove;
            // 
            // txtTexto
            // 
            txtTexto.CharacterCasing = CharacterCasing.Upper;
            txtTexto.Location = new Point(285, 129);
            txtTexto.MaxLength = 100;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(192, 27);
            txtTexto.TabIndex = 2;
            txtTexto.KeyPress += txtTexto_KeyPress;
            // 
            // txtCajaTexto2
            // 
            txtCajaTexto2.Location = new Point(285, 205);
            txtCajaTexto2.Multiline = true;
            txtCajaTexto2.Name = "txtCajaTexto2";
            txtCajaTexto2.ScrollBars = ScrollBars.Both;
            txtCajaTexto2.Size = new Size(192, 136);
            txtCajaTexto2.TabIndex = 3;
            txtCajaTexto2.Leave += txtCajaTexto2_Leave;
            // 
            // frmPractica1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(572, 515);
            Controls.Add(txtCajaTexto2);
            Controls.Add(txtTexto);
            Controls.Add(lblEtiqueta);
            Controls.Add(btnBoton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPractica1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primera Práctica";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmPractica1_FormClosed;
            Load += frmPractica1_Load;
            Click += frmPractica1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBoton;
        private Label lblEtiqueta;
        private TextBox txtTexto;
        private TextBox txtCajaTexto2;
    }
}
