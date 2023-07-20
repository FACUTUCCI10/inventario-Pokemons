using System;

namespace pokemonAPP1
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
            dgvPokemons = new System.Windows.Forms.DataGridView();
            pbxPokemon = new System.Windows.Forms.PictureBox();
            btnAgregar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminarFisico = new System.Windows.Forms.Button();
            btnEliminarLogico = new System.Windows.Forms.Button();
            btnFiltro = new System.Windows.Forms.Button();
            lblFiltro = new System.Windows.Forms.Label();
            txtFiltro = new System.Windows.Forms.TextBox();
            lblCriterio = new System.Windows.Forms.Label();
            cboCampo = new System.Windows.Forms.ComboBox();
            lblCampo = new System.Windows.Forms.Label();
            cboCriterio = new System.Windows.Forms.ComboBox();
            lblFiltroAvanzado = new System.Windows.Forms.Label();
            txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemons
            // 
            dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvPokemons.Location = new System.Drawing.Point(48, 56);
            dgvPokemons.MultiSelect = false;
            dgvPokemons.Name = "dgvPokemons";
            dgvPokemons.RowTemplate.Height = 25;
            dgvPokemons.Size = new System.Drawing.Size(550, 275);
            dgvPokemons.TabIndex = 0;
            dgvPokemons.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new System.Drawing.Point(614, 34);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new System.Drawing.Size(256, 297);
            pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Turquoise;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAgregar.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAgregar.Location = new System.Drawing.Point(48, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(71, 27);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = System.Drawing.Color.Turquoise;
            btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnModificar.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModificar.Location = new System.Drawing.Point(139, 347);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(71, 27);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.BackColor = System.Drawing.Color.Turquoise;
            btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminarFisico.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEliminarFisico.Location = new System.Drawing.Point(233, 347);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new System.Drawing.Size(102, 27);
            btnEliminarFisico.TabIndex = 4;
            btnEliminarFisico.Text = "Eliminar físico";
            btnEliminarFisico.UseVisualStyleBackColor = false;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.BackColor = System.Drawing.Color.Turquoise;
            btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminarLogico.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEliminarLogico.Location = new System.Drawing.Point(360, 347);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new System.Drawing.Size(121, 27);
            btnEliminarLogico.TabIndex = 5;
            btnEliminarLogico.Text = "Eliminar lógico\r\n";
            btnEliminarLogico.UseVisualStyleBackColor = false;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // btnFiltro
            // 
            btnFiltro.BackColor = System.Drawing.Color.Turquoise;
            btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFiltro.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFiltro.Location = new System.Drawing.Point(668, 411);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new System.Drawing.Size(74, 23);
            btnFiltro.TabIndex = 6;
            btnFiltro.Text = "Buscar";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFiltro.Location = new System.Drawing.Point(48, 27);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new System.Drawing.Size(44, 16);
            lblFiltro.TabIndex = 7;
            lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new System.Drawing.Point(98, 25);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new System.Drawing.Size(174, 23);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            txtFiltro.KeyPress += txtFiltro_KeyPress;
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCriterio.Location = new System.Drawing.Point(218, 414);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new System.Drawing.Size(58, 16);
            lblCriterio.TabIndex = 9;
            lblCriterio.Text = "Criterio:";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new System.Drawing.Point(72, 411);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new System.Drawing.Size(121, 23);
            cboCampo.TabIndex = 10;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCampo.Location = new System.Drawing.Point(15, 413);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new System.Drawing.Size(55, 16);
            lblCampo.TabIndex = 11;
            lblCampo.Text = "Campo:";
            lblCampo.Click += lblCampo_Click;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new System.Drawing.Point(282, 411);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new System.Drawing.Size(121, 23);
            cboCriterio.TabIndex = 12;
            // 
            // lblFiltroAvanzado
            // 
            lblFiltroAvanzado.AutoSize = true;
            lblFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFiltroAvanzado.Location = new System.Drawing.Point(429, 415);
            lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            lblFiltroAvanzado.Size = new System.Drawing.Size(108, 16);
            lblFiltroAvanzado.TabIndex = 13;
            lblFiltroAvanzado.Text = "Filtro Avanzado:";
            lblFiltroAvanzado.Click += lblFiltroAvanzado_Click;
            // 
            // txtFiltroAvanzado
            // 
            txtFiltroAvanzado.Location = new System.Drawing.Point(543, 411);
            txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            txtFiltroAvanzado.Size = new System.Drawing.Size(100, 23);
            txtFiltroAvanzado.TabIndex = 14;
            // 
            // frmPokemons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(956, 463);
            Controls.Add(txtFiltroAvanzado);
            Controls.Add(lblFiltroAvanzado);
            Controls.Add(cboCriterio);
            Controls.Add(lblCampo);
            Controls.Add(cboCampo);
            Controls.Add(lblCriterio);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnFiltro);
            Controls.Add(btnEliminarLogico);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(pbxPokemon);
            Controls.Add(dgvPokemons);
            Name = "frmPokemons";
            Text = "APP pokemons";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblFiltroAvanzado_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
    }
}
