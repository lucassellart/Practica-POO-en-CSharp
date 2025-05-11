namespace ejemplo1
{
    partial class frmDiscos
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
            dgvDiscos = new DataGridView();
            pbxDiscos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDiscos).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscos
            // 
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.Location = new Point(33, 56);
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.RowHeadersWidth = 51;
            dgvDiscos.Size = new Size(803, 309);
            dgvDiscos.TabIndex = 0;
            dgvDiscos.SelectionChanged += dgvDiscos_SelectionChanged;
            // 
            // pbxDiscos
            // 
            pbxDiscos.Location = new Point(892, 56);
            pbxDiscos.Name = "pbxDiscos";
            pbxDiscos.Size = new Size(268, 309);
            pbxDiscos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxDiscos.TabIndex = 1;
            pbxDiscos.TabStop = false;
            // 
            // frmDiscos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 412);
            Controls.Add(pbxDiscos);
            Controls.Add(dgvDiscos);
            Name = "frmDiscos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discos";
            Load += frmDiscos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxDiscos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDiscos;
        private PictureBox pbxDiscos;
    }
}
