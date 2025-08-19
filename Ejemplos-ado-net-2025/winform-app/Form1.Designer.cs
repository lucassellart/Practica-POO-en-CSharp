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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminarFisico = new Button();
            btnEliminarLogico = new Button();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            btnFiltro = new Button();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblFiltroAvanzado = new Label();
            cboCampo = new ComboBox();
            cboCriterio = new ComboBox();
            txtFiltroAvanzado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPokemon.Location = new Point(33, 95);
            dgvPokemon.MultiSelect = false;
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPokemon.Size = new Size(700, 342);
            dgvPokemon.TabIndex = 0;
            dgvPokemon.SelectionChanged += dgvPokemon_SelectionChanged;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(765, 134);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(275, 279);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 465);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 44);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar:";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(155, 465);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 44);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar:";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(280, 465);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(142, 44);
            btnEliminarFisico.TabIndex = 4;
            btnEliminarFisico.Text = "Eliminar Físico:";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Location = new Point(443, 465);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new Size(130, 44);
            btnEliminarLogico.TabIndex = 5;
            btnEliminarLogico.Text = "Eliminar Lógico:";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(33, 57);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(98, 20);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(137, 54);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(271, 27);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(786, 544);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(151, 42);
            btnFiltro.TabIndex = 8;
            btnFiltro.Text = "Buscar";
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(33, 555);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(60, 20);
            lblCampo.TabIndex = 9;
            lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(282, 555);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(61, 20);
            lblCriterio.TabIndex = 10;
            lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            lblFiltroAvanzado.AutoSize = true;
            lblFiltroAvanzado.Location = new Point(531, 555);
            lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            lblFiltroAvanzado.Size = new Size(46, 20);
            lblFiltroAvanzado.TabIndex = 11;
            lblFiltroAvanzado.Text = "Filtro:";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(106, 552);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(151, 28);
            cboCampo.TabIndex = 12;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(354, 552);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(151, 28);
            cboCriterio.TabIndex = 13;
            // 
            // txtFiltroAvanzado
            // 
            txtFiltroAvanzado.Location = new Point(592, 552);
            txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            txtFiltroAvanzado.Size = new Size(151, 27);
            txtFiltroAvanzado.TabIndex = 14;
            // 
            // frmPokemons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 616);
            Controls.Add(txtFiltroAvanzado);
            Controls.Add(cboCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblFiltroAvanzado);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(btnFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnEliminarLogico);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(pbxPokemon);
            Controls.Add(dgvPokemon);
            Name = "frmPokemons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemons";
            Load += frmPokemons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPokemon;
        private PictureBox pbxPokemon;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminarFisico;
        private Button btnEliminarLogico;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Button btnFiltro;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltroAvanzado;
        private ComboBox cboCampo;
        private ComboBox cboCriterio;
        private TextBox txtFiltroAvanzado;
    }
}
