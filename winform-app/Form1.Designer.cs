namespace winform_app
{
    partial class frmPokemons
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
            dgvPokemon = new DataGridView();
            pbxPokemon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.Location = new Point(33, 49);
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.Size = new Size(704, 279);
            dgvPokemon.TabIndex = 0;
            dgvPokemon.SelectionChanged += dgvPokemon_SelectionChanged;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(762, 49);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(275, 279);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // frmPokemons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 383);
            Controls.Add(pbxPokemon);
            Controls.Add(dgvPokemon);
            Name = "frmPokemons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemons";
            Load += frmPokemons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemon;
        private PictureBox pbxPokemon;
    }
}
