namespace pryProyecto
{
    partial class frmAlumnos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			txtMatricula = new TextBox();
			txtNombre = new TextBox();
			txtAPaterno = new TextBox();
			txtAMaterno = new TextBox();
			txtDireccion = new TextBox();
			txtTelefono = new TextBox();
			txtCorreo = new TextBox();
			txtPromedioBachiller = new TextBox();
			cmbTutor = new ComboBox();
			cmbCarrera = new ComboBox();
			pnlAlumno = new Panel();
			pnlUsuario = new Panel();
			cmbPerfil = new ComboBox();
			txtPassword = new TextBox();
			txtUsuario = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnEliminar = new Button();
			btnGuardar = new Button();
			btnNuevo = new Button();
			txtMatriculaAlumno = new TextBox();
			dgvAlumnos = new DataGridView();
			pcbLogo = new PictureBox();
			lblTitulo = new Label();
			pnlAlumno.SuspendLayout();
			pnlUsuario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
			SuspendLayout();
			// 
			// txtMatricula
			// 
			txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtMatricula.Location = new Point(25, 20);
			txtMatricula.Margin = new Padding(3, 2, 3, 2);
			txtMatricula.Name = "txtMatricula";
			txtMatricula.PlaceholderText = "Matricula";
			txtMatricula.Size = new Size(184, 32);
			txtMatricula.TabIndex = 0;
			// 
			// txtNombre
			// 
			txtNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtNombre.Location = new Point(25, 53);
			txtNombre.Margin = new Padding(3, 2, 3, 2);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre";
			txtNombre.Size = new Size(184, 32);
			txtNombre.TabIndex = 1;
			// 
			// txtAPaterno
			// 
			txtAPaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtAPaterno.Location = new Point(25, 86);
			txtAPaterno.Margin = new Padding(3, 2, 3, 2);
			txtAPaterno.Name = "txtAPaterno";
			txtAPaterno.PlaceholderText = "Apellido Paterno";
			txtAPaterno.Size = new Size(184, 32);
			txtAPaterno.TabIndex = 2;
			// 
			// txtAMaterno
			// 
			txtAMaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtAMaterno.Location = new Point(25, 119);
			txtAMaterno.Margin = new Padding(3, 2, 3, 2);
			txtAMaterno.Name = "txtAMaterno";
			txtAMaterno.PlaceholderText = "Apellido Materno";
			txtAMaterno.Size = new Size(184, 32);
			txtAMaterno.TabIndex = 3;
			// 
			// txtDireccion
			// 
			txtDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtDireccion.Location = new Point(25, 152);
			txtDireccion.Margin = new Padding(3, 2, 3, 2);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.PlaceholderText = "Dirreción";
			txtDireccion.Size = new Size(184, 32);
			txtDireccion.TabIndex = 4;
			// 
			// txtTelefono
			// 
			txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtTelefono.Location = new Point(214, 20);
			txtTelefono.Margin = new Padding(3, 2, 3, 2);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.PlaceholderText = "Teléfono";
			txtTelefono.Size = new Size(184, 32);
			txtTelefono.TabIndex = 5;
			// 
			// txtCorreo
			// 
			txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtCorreo.Location = new Point(214, 53);
			txtCorreo.Margin = new Padding(3, 2, 3, 2);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.PlaceholderText = "Correo";
			txtCorreo.Size = new Size(184, 32);
			txtCorreo.TabIndex = 6;
			// 
			// txtPromedioBachiller
			// 
			txtPromedioBachiller.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtPromedioBachiller.Location = new Point(214, 86);
			txtPromedioBachiller.Margin = new Padding(3, 2, 3, 2);
			txtPromedioBachiller.Name = "txtPromedioBachiller";
			txtPromedioBachiller.PlaceholderText = "Promedio Bachillerato";
			txtPromedioBachiller.Size = new Size(184, 32);
			txtPromedioBachiller.TabIndex = 7;
			// 
			// cmbTutor
			// 
			cmbTutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			cmbTutor.FormattingEnabled = true;
			cmbTutor.Location = new Point(214, 119);
			cmbTutor.Margin = new Padding(3, 2, 3, 2);
			cmbTutor.Name = "cmbTutor";
			cmbTutor.Size = new Size(184, 33);
			cmbTutor.TabIndex = 8;
			// 
			// cmbCarrera
			// 
			cmbCarrera.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			cmbCarrera.FormattingEnabled = true;
			cmbCarrera.Location = new Point(214, 153);
			cmbCarrera.Margin = new Padding(3, 2, 3, 2);
			cmbCarrera.Name = "cmbCarrera";
			cmbCarrera.Size = new Size(184, 33);
			cmbCarrera.TabIndex = 9;
			// 
			// pnlAlumno
			// 
			pnlAlumno.BackColor = Color.FromArgb(192, 192, 255);
			pnlAlumno.BorderStyle = BorderStyle.Fixed3D;
			pnlAlumno.Controls.Add(cmbCarrera);
			pnlAlumno.Controls.Add(cmbTutor);
			pnlAlumno.Controls.Add(txtPromedioBachiller);
			pnlAlumno.Controls.Add(txtCorreo);
			pnlAlumno.Controls.Add(txtTelefono);
			pnlAlumno.Controls.Add(txtDireccion);
			pnlAlumno.Controls.Add(txtAMaterno);
			pnlAlumno.Controls.Add(txtAPaterno);
			pnlAlumno.Controls.Add(txtNombre);
			pnlAlumno.Controls.Add(txtMatricula);
			pnlAlumno.Location = new Point(38, 95);
			pnlAlumno.Margin = new Padding(3, 2, 3, 2);
			pnlAlumno.Name = "pnlAlumno";
			pnlAlumno.Size = new Size(476, 194);
			pnlAlumno.TabIndex = 10;
			// 
			// pnlUsuario
			// 
			pnlUsuario.BackColor = Color.FromArgb(192, 192, 255);
			pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
			pnlUsuario.Controls.Add(cmbPerfil);
			pnlUsuario.Controls.Add(txtPassword);
			pnlUsuario.Controls.Add(txtUsuario);
			pnlUsuario.Location = new Point(580, 95);
			pnlUsuario.Margin = new Padding(3, 2, 3, 2);
			pnlUsuario.Name = "pnlUsuario";
			pnlUsuario.Size = new Size(330, 194);
			pnlUsuario.TabIndex = 11;
			// 
			// cmbPerfil
			// 
			cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			cmbPerfil.FormattingEnabled = true;
			cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
			cmbPerfil.Location = new Point(18, 80);
			cmbPerfil.Margin = new Padding(3, 2, 3, 2);
			cmbPerfil.Name = "cmbPerfil";
			cmbPerfil.Size = new Size(277, 33);
			cmbPerfil.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtPassword.Location = new Point(18, 46);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Password";
			txtPassword.Size = new Size(277, 32);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsuario
			// 
			txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			txtUsuario.Location = new Point(18, 14);
			txtUsuario.Margin = new Padding(3, 2, 3, 2);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.PlaceholderText = "Usuario";
			txtUsuario.Size = new Size(277, 32);
			txtUsuario.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			label1.Location = new Point(38, 70);
			label1.Name = "label1";
			label1.Size = new Size(83, 25);
			label1.TabIndex = 12;
			label1.Text = "Alumno";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			label2.Location = new Point(579, 70);
			label2.Name = "label2";
			label2.Size = new Size(81, 25);
			label2.TabIndex = 13;
			label2.Text = "Usuario";
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = SystemColors.ButtonHighlight;
			btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
			btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
			btnEliminar.ForeColor = SystemColors.Control;
			btnEliminar.Location = new Point(542, 293);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(132, 54);
			btnEliminar.TabIndex = 17;
			btnEliminar.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = SystemColors.ButtonHighlight;
			btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
			btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
			btnGuardar.Location = new Point(382, 293);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(132, 54);
			btnGuardar.TabIndex = 15;
			btnGuardar.UseVisualStyleBackColor = false;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnNuevo
			// 
			btnNuevo.BackColor = SystemColors.Control;
			btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
			btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
			btnNuevo.Location = new Point(210, 293);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(127, 54);
			btnNuevo.TabIndex = 14;
			btnNuevo.UseVisualStyleBackColor = false;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// txtMatriculaAlumno
			// 
			txtMatriculaAlumno.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtMatriculaAlumno.Location = new Point(673, 352);
			txtMatriculaAlumno.Name = "txtMatriculaAlumno";
			txtMatriculaAlumno.PlaceholderText = "Buscar por matricula";
			txtMatriculaAlumno.Size = new Size(223, 33);
			txtMatriculaAlumno.TabIndex = 18;
			txtMatriculaAlumno.TextChanged += txtNombreAlumno_TextChanged;
			// 
			// dgvAlumnos
			// 
			dgvAlumnos.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
			dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvAlumnos.BackgroundColor = SystemColors.ControlLight;
			dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
			dgvAlumnos.EnableHeadersVisualStyles = false;
			dgvAlumnos.Location = new Point(74, 388);
			dgvAlumnos.Name = "dgvAlumnos";
			dgvAlumnos.RowHeadersWidth = 51;
			dgvAlumnos.RowTemplate.Height = 45;
			dgvAlumnos.Size = new Size(822, 116);
			dgvAlumnos.TabIndex = 16;
			dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
			// 
			// pcbLogo
			// 
			pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
			pcbLogo.Location = new Point(542, 2);
			pcbLogo.Name = "pcbLogo";
			pcbLogo.Size = new Size(88, 63);
			pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbLogo.TabIndex = 20;
			pcbLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.BackColor = SystemColors.ButtonFace;
			lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(331, 18);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(176, 50);
			lblTitulo.TabIndex = 19;
			lblTitulo.Text = "Alumnos";
			// 
			// frmAlumnos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(951, 514);
			Controls.Add(pcbLogo);
			Controls.Add(lblTitulo);
			Controls.Add(btnEliminar);
			Controls.Add(btnGuardar);
			Controls.Add(btnNuevo);
			Controls.Add(txtMatriculaAlumno);
			Controls.Add(dgvAlumnos);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pnlUsuario);
			Controls.Add(pnlAlumno);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmAlumnos";
			Text = "Registro de alumnos";
			pnlAlumno.ResumeLayout(false);
			pnlAlumno.PerformLayout();
			pnlUsuario.ResumeLayout(false);
			pnlUsuario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachiller;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumno;
        private Panel pnlUsuario;
        private TextBox txtUsuario;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtMatriculaAlumno;
        private DataGridView dgvAlumnos;
        private PictureBox pcbLogo;
        private Label lblTitulo;
    }
}