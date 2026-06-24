namespace pryProyecto
{
    partial class frmTutores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutores));
			dgvTutores = new DataGridView();
			pnlPrincipal = new Panel();
			txtBuscarTutores = new TextBox();
			btnEliminar = new Button();
			btnGuardar = new Button();
			btnNuevo = new Button();
			txtCorreo = new TextBox();
			txtTelefono = new TextBox();
			txtDireccion = new TextBox();
			txtParentesco = new TextBox();
			txtNombre = new TextBox();
			lblTutor = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
			pnlPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dgvTutores
			// 
			dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTutores.Location = new Point(66, 330);
			dgvTutores.Margin = new Padding(3, 2, 3, 2);
			dgvTutores.Name = "dgvTutores";
			dgvTutores.RowHeadersWidth = 51;
			dgvTutores.Size = new Size(822, 141);
			dgvTutores.TabIndex = 0;
			// 
			// pnlPrincipal
			// 
			pnlPrincipal.BackColor = SystemColors.ScrollBar;
			pnlPrincipal.Controls.Add(txtBuscarTutores);
			pnlPrincipal.Controls.Add(btnEliminar);
			pnlPrincipal.Controls.Add(btnGuardar);
			pnlPrincipal.Controls.Add(btnNuevo);
			pnlPrincipal.Controls.Add(txtCorreo);
			pnlPrincipal.Controls.Add(txtTelefono);
			pnlPrincipal.Controls.Add(txtDireccion);
			pnlPrincipal.Controls.Add(txtParentesco);
			pnlPrincipal.Controls.Add(txtNombre);
			pnlPrincipal.Controls.Add(lblTutor);
			pnlPrincipal.Controls.Add(pictureBox1);
			pnlPrincipal.Location = new Point(66, 39);
			pnlPrincipal.Margin = new Padding(3, 2, 3, 2);
			pnlPrincipal.Name = "pnlPrincipal";
			pnlPrincipal.Size = new Size(822, 286);
			pnlPrincipal.TabIndex = 1;
			// 
			// txtBuscarTutores
			// 
			txtBuscarTutores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtBuscarTutores.Location = new Point(668, 241);
			txtBuscarTutores.Name = "txtBuscarTutores";
			txtBuscarTutores.PlaceholderText = "Buscar Tutores";
			txtBuscarTutores.Size = new Size(140, 33);
			txtBuscarTutores.TabIndex = 11;
			txtBuscarTutores.TextChanged += txtBuscarTutores_TextChanged;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = SystemColors.Control;
			btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
			btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
			btnEliminar.Location = new Point(424, 220);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(127, 54);
			btnEliminar.TabIndex = 10;
			btnEliminar.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = SystemColors.ButtonHighlight;
			btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
			btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
			btnGuardar.Location = new Point(228, 220);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(132, 54);
			btnGuardar.TabIndex = 9;
			btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnNuevo
			// 
			btnNuevo.BackColor = SystemColors.ButtonHighlight;
			btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
			btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
			btnNuevo.ForeColor = SystemColors.Control;
			btnNuevo.Location = new Point(40, 220);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(132, 54);
			btnNuevo.TabIndex = 8;
			btnNuevo.UseVisualStyleBackColor = false;
			// 
			// txtCorreo
			// 
			txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtCorreo.Location = new Point(40, 182);
			txtCorreo.Margin = new Padding(3, 2, 3, 2);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.PlaceholderText = "Correo";
			txtCorreo.Size = new Size(440, 29);
			txtCorreo.TabIndex = 7;
			// 
			// txtTelefono
			// 
			txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTelefono.Location = new Point(40, 152);
			txtTelefono.Margin = new Padding(3, 2, 3, 2);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.PlaceholderText = "Teléfono";
			txtTelefono.Size = new Size(440, 29);
			txtTelefono.TabIndex = 6;
			// 
			// txtDireccion
			// 
			txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtDireccion.Location = new Point(40, 122);
			txtDireccion.Margin = new Padding(3, 2, 3, 2);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.PlaceholderText = "Dirección";
			txtDireccion.Size = new Size(440, 29);
			txtDireccion.TabIndex = 5;
			// 
			// txtParentesco
			// 
			txtParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtParentesco.Location = new Point(40, 92);
			txtParentesco.Margin = new Padding(3, 2, 3, 2);
			txtParentesco.Name = "txtParentesco";
			txtParentesco.PlaceholderText = "Parentesco";
			txtParentesco.Size = new Size(440, 29);
			txtParentesco.TabIndex = 4;
			// 
			// txtNombre
			// 
			txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombre.Location = new Point(40, 62);
			txtNombre.Margin = new Padding(3, 2, 3, 2);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Ingrese nombre completo";
			txtNombre.Size = new Size(440, 29);
			txtNombre.TabIndex = 3;
			// 
			// lblTutor
			// 
			lblTutor.AutoSize = true;
			lblTutor.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTutor.Location = new Point(362, 13);
			lblTutor.Name = "lblTutor";
			lblTutor.Size = new Size(79, 32);
			lblTutor.TabIndex = 1;
			lblTutor.Text = "Tutor";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.tutor1;
			pictureBox1.Location = new Point(585, 76);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(140, 109);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// frmTutores
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.Contorno;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(951, 514);
			Controls.Add(pnlPrincipal);
			Controls.Add(dgvTutores);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmTutores";
			Text = "Tutores";
			((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
			pnlPrincipal.ResumeLayout(false);
			pnlPrincipal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvTutores;
        private Panel pnlPrincipal;
        private PictureBox pictureBox1;
        private Label lblTutor;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtParentesco;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
		private TextBox txtBuscarTutores;
	}
}