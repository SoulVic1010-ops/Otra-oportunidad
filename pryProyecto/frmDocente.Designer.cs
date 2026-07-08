namespace pryProyecto
{
	partial class frmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cmbRol = new ComboBox();
            txtClave = new TextBox();
            pnlDocente = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtPuesto = new TextBox();
            txtNombreDocente = new TextBox();
            pnlUsuario = new Panel();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtMatriculaDocente = new TextBox();
            dgvDocente = new DataGridView();
            pictureBox1 = new PictureBox();
            pnlDocente.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(538, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 74);
            label1.TabIndex = 0;
            label1.Text = "Docente";
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Docente", "Alumno", "Tutor", "Carrera" });
            cmbRol.Location = new Point(12, 135);
            cmbRol.Margin = new Padding(4, 5, 4, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(255, 48);
            cmbRol.TabIndex = 16;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(12, 6);
            txtClave.Margin = new Padding(4, 5, 4, 5);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(328, 45);
            txtClave.TabIndex = 2;
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = Color.Honeydew;
            pnlDocente.BorderStyle = BorderStyle.FixedSingle;
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtPuesto);
            pnlDocente.Controls.Add(txtNombreDocente);
            pnlDocente.Controls.Add(txtClave);
            pnlDocente.Location = new Point(142, 170);
            pnlDocente.Margin = new Padding(4, 5, 4, 5);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(516, 331);
            pnlDocente.TabIndex = 17;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(12, 266);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(328, 45);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(12, 201);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(328, 45);
            txtTelefono.TabIndex = 5;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(12, 136);
            txtPuesto.Margin = new Padding(4, 5, 4, 5);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(328, 45);
            txtPuesto.TabIndex = 4;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreDocente.Location = new Point(12, 71);
            txtNombreDocente.Margin = new Padding(4, 5, 4, 5);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del Docente";
            txtNombreDocente.Size = new Size(328, 45);
            txtNombreDocente.TabIndex = 3;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.Honeydew;
            pnlUsuario.BorderStyle = BorderStyle.FixedSingle;
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Controls.Add(cmbRol);
            pnlUsuario.Location = new Point(720, 179);
            pnlUsuario.Margin = new Padding(4, 5, 4, 5);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(458, 322);
            pnlUsuario.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(12, 70);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(255, 45);
            txtPassword.TabIndex = 22;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(16, 5);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(255, 45);
            txtUsuario.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(142, 124);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 40);
            label9.TabIndex = 19;
            label9.Text = "Docente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(720, 131);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(123, 40);
            label10.TabIndex = 20;
            label10.Text = "Usuario";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Control;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(330, 510);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(181, 90);
            btnNuevo.TabIndex = 21;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(538, 510);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(189, 90);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ButtonHighlight;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(758, 510);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(189, 90);
            btnEliminar.TabIndex = 23;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtMatriculaDocente
            // 
            txtMatriculaDocente.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaDocente.Location = new Point(954, 594);
            txtMatriculaDocente.Margin = new Padding(4, 5, 4, 5);
            txtMatriculaDocente.Name = "txtMatriculaDocente";
            txtMatriculaDocente.PlaceholderText = "Buscar por Clave";
            txtMatriculaDocente.Size = new Size(316, 45);
            txtMatriculaDocente.TabIndex = 24;
            txtMatriculaDocente.TextChanged += txtMatriculaDocente_TextChanged;
            // 
            // dgvDocente
            // 
            dgvDocente.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dgvDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocente.BackgroundColor = SystemColors.ControlLight;
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDocente.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDocente.EnableHeadersVisualStyles = false;
            dgvDocente.Location = new Point(99, 659);
            dgvDocente.Margin = new Padding(4, 5, 4, 5);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.RowTemplate.Height = 45;
            dgvDocente.Size = new Size(1174, 194);
            dgvDocente.TabIndex = 25;
            dgvDocente.SelectionChanged += dgvDocente_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Docente1;
            pictureBox1.Location = new Point(844, 15);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1359, 856);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDocente);
            Controls.Add(txtMatriculaDocente);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlDocente);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDocente";
            Text = "frmDocente";
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private ComboBox cmbRol;
		private TextBox txtClave;
		private Panel pnlDocente;
		private Panel pnlUsuario;
		private Label label9;
		private Label label10;
		private TextBox txtCorreo;
		private TextBox txtTelefono;
		private TextBox txtPuesto;
		private TextBox txtNombreDocente;
		private TextBox txtPassword;
		private TextBox txtUsuario;
		private Button btnNuevo;
		private Button btnGuardar;
		private Button btnEliminar;
		private TextBox txtMatriculaDocente;
		private DataGridView dgvDocente;
		private PictureBox pictureBox1;
	}
}