namespace ejemplo
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
            dtpFecha = new DateTimePicker();
            calFecha = new MonthCalendar();
            btnDTPfecha = new Button();
            btnCALfecha = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(112, 118);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(316, 27);
            dtpFecha.TabIndex = 0;
            // 
            // calFecha
            // 
            calFecha.Location = new Point(134, 203);
            calFecha.Name = "calFecha";
            calFecha.TabIndex = 1;
            // 
            // btnDTPfecha
            // 
            btnDTPfecha.Location = new Point(491, 119);
            btnDTPfecha.Name = "btnDTPfecha";
            btnDTPfecha.Size = new Size(94, 29);
            btnDTPfecha.TabIndex = 2;
            btnDTPfecha.Text = "Prueba 1";
            btnDTPfecha.UseVisualStyleBackColor = true;
            btnDTPfecha.Click += btnDTPfecha_Click;
            // 
            // btnCALfecha
            // 
            btnCALfecha.Location = new Point(491, 242);
            btnCALfecha.Name = "btnCALfecha";
            btnCALfecha.Size = new Size(94, 29);
            btnCALfecha.TabIndex = 3;
            btnCALfecha.Text = "Prueba 2";
            btnCALfecha.UseVisualStyleBackColor = true;
            btnCALfecha.Click += btnCALfecha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 615);
            Controls.Add(btnCALfecha);
            Controls.Add(btnDTPfecha);
            Controls.Add(calFecha);
            Controls.Add(dtpFecha);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private MonthCalendar calFecha;
        private Button btnDTPfecha;
        private Button btnCALfecha;
    }
}
