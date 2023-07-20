namespace pokemonAPP1
{
    partial class FrmAltaPokemon
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
            lblNumero = new System.Windows.Forms.Label();
            lblnombre = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtNumero = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblTipo = new System.Windows.Forms.Label();
            lblDebilidad = new System.Windows.Forms.Label();
            cboTipo = new System.Windows.Forms.ComboBox();
            cboDebilidad = new System.Windows.Forms.ComboBox();
            pbxAltaimg = new System.Windows.Forms.PictureBox();
            lblUrlimagen = new System.Windows.Forms.Label();
            txtUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxAltaimg).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = System.Drawing.Color.Turquoise;
            lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblNumero.Location = new System.Drawing.Point(35, 26);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(56, 17);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número:";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = System.Drawing.Color.Turquoise;
            lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblnombre.Location = new System.Drawing.Point(35, 74);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new System.Drawing.Size(56, 17);
            lblnombre.TabIndex = 9;
            lblnombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = System.Drawing.Color.Turquoise;
            lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblDescripcion.Location = new System.Drawing.Point(35, 122);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(74, 17);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = System.Drawing.Color.White;
            txtNumero.Location = new System.Drawing.Point(125, 20);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new System.Drawing.Size(121, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(125, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(121, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = System.Drawing.Color.White;
            txtDescripcion.Location = new System.Drawing.Point(125, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(121, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.Color.Turquoise;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAceptar.Location = new System.Drawing.Point(34, 309);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Turquoise;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancelar.Location = new System.Drawing.Point(171, 309);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = System.Drawing.Color.Turquoise;
            lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTipo.Location = new System.Drawing.Point(35, 207);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(35, 17);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            lblDebilidad.AutoSize = true;
            lblDebilidad.BackColor = System.Drawing.Color.Turquoise;
            lblDebilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblDebilidad.Location = new System.Drawing.Point(35, 254);
            lblDebilidad.Name = "lblDebilidad";
            lblDebilidad.Size = new System.Drawing.Size(62, 17);
            lblDebilidad.TabIndex = 13;
            lblDebilidad.Text = "Debilidad:";
            // 
            // cboTipo
            // 
            cboTipo.BackColor = System.Drawing.Color.White;
            cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new System.Drawing.Point(125, 207);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new System.Drawing.Size(121, 23);
            cboTipo.TabIndex = 3;
            // 
            // cboDebilidad
            // 
            cboDebilidad.BackColor = System.Drawing.Color.White;
            cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDebilidad.FormattingEnabled = true;
            cboDebilidad.Location = new System.Drawing.Point(125, 248);
            cboDebilidad.Name = "cboDebilidad";
            cboDebilidad.Size = new System.Drawing.Size(121, 23);
            cboDebilidad.TabIndex = 5;
            // 
            // pbxAltaimg
            // 
            pbxAltaimg.Location = new System.Drawing.Point(284, 20);
            pbxAltaimg.Name = "pbxAltaimg";
            pbxAltaimg.Size = new System.Drawing.Size(221, 264);
            pbxAltaimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbxAltaimg.TabIndex = 12;
            pbxAltaimg.TabStop = false;
            pbxAltaimg.Click += pictureBox1_Click;
            // 
            // lblUrlimagen
            // 
            lblUrlimagen.AutoSize = true;
            lblUrlimagen.BackColor = System.Drawing.Color.Turquoise;
            lblUrlimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblUrlimagen.Location = new System.Drawing.Point(35, 168);
            lblUrlimagen.Name = "lblUrlimagen";
            lblUrlimagen.Size = new System.Drawing.Size(70, 17);
            lblUrlimagen.TabIndex = 12;
            lblUrlimagen.Text = "Url imagen:";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new System.Drawing.Point(125, 168);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new System.Drawing.Size(121, 23);
            txtUrlImagen.TabIndex = 4;
            txtUrlImagen.Leave += txtUrlImagen_Leave;
            // 
            // FrmAltaPokemon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(511, 343);
            Controls.Add(txtUrlImagen);
            Controls.Add(lblUrlimagen);
            Controls.Add(pbxAltaimg);
            Controls.Add(cboDebilidad);
            Controls.Add(cboTipo);
            Controls.Add(lblDebilidad);
            Controls.Add(lblTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(lblDescripcion);
            Controls.Add(lblnombre);
            Controls.Add(lblNumero);
            Name = "FrmAltaPokemon";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "nuevo pokemon";
            Load += FrmAltaPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxAltaimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.PictureBox pbxAltaimg;
        private System.Windows.Forms.Label lblUrlimagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
    }
}