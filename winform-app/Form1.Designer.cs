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
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.Location = new Point(105, 87);
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.Size = new Size(563, 325);
            dgvPokemon.TabIndex = 0;
            // 
            // frmPokemons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 510);
            Controls.Add(dgvPokemon);
            Name = "frmPokemons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemons";
            Load += frmPokemons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemon;
    }
}
