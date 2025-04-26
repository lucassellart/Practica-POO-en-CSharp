namespace ejemplo1
{
    partial class frmCalculadora
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
            txtNumUno = new TextBox();
            txtNumDos = new TextBox();
            lblTitulo = new Label();
            lblResultado = new Label();
            lblOperacion = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNumUno
            // 
            txtNumUno.Location = new Point(206, 127);
            txtNumUno.Name = "txtNumUno";
            txtNumUno.Size = new Size(125, 27);
            txtNumUno.TabIndex = 0;
            // 
            // txtNumDos
            // 
            txtNumDos.Location = new Point(206, 189);
            txtNumDos.Name = "txtNumDos";
            txtNumDos.Size = new Size(125, 27);
            txtNumDos.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(86, 64);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 28);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "La Mejor Calculadora del Mundo Mundial";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(241, 310);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(19, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "=";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(257, 166);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(19, 20);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "+";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(222, 252);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 361);
            Controls.Add(btnCalcular);
            Controls.Add(lblOperacion);
            Controls.Add(lblResultado);
            Controls.Add(lblTitulo);
            Controls.Add(txtNumDos);
            Controls.Add(txtNumUno);
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumUno;
        private TextBox txtNumDos;
        private Label lblTitulo;
        private Label lblResultado;
        private Label lblOperacion;
        private Button btnCalcular;
    }
}
