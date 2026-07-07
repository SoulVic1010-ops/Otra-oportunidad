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
			cmnRol = new ComboBox();
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
			label1.Location = new Point(376, 9);
			label1.Name = "label1";
			label1.Size = new Size(166, 50);
			label1.TabIndex = 0;
			label1.Text = "Docente";
			// 
			// cmnRol
			// 
			cmnRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cmnRol.FormattingEnabled = true;
			cmnRol.Location = new Point(9, 81);
			cmnRol.Name = "cmnRol";
			cmnRol.Size = new Size(180, 33);
			cmnRol.TabIndex = 16;
			// 
			// txtClave
			// 
			txtClave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtClave.Location = new Point(9, 4);
			txtClave.Name = "txtClave";
			txtClave.PlaceholderText = "Clave";
			txtClave.Size = new Size(231, 33);
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
			pnlDocente.Location = new Point(100, 102);
			pnlDocente.Name = "pnlDocente";
			pnlDocente.Size = new Size(362, 199);
			pnlDocente.TabIndex = 17;
			// 
			// txtCorreo
			// 
			txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtCorreo.Location = new Point(9, 160);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.PlaceholderText = "Correo";
			txtCorreo.Size = new Size(231, 33);
			txtCorreo.TabIndex = 6;
			// 
			// txtTelefono
			// 
			txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTelefono.Location = new Point(9, 121);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.PlaceholderText = "Teléfono";
			txtTelefono.Size = new Size(231, 33);
			txtTelefono.TabIndex = 5;
			// 
			// txtPuesto
			// 
			txtPuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtPuesto.Location = new Point(9, 82);
			txtPuesto.Name = "txtPuesto";
			txtPuesto.PlaceholderText = "Puesto";
			txtPuesto.Size = new Size(231, 33);
			txtPuesto.TabIndex = 4;
			// 
			// txtNombreDocente
			// 
			txtNombreDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombreDocente.Location = new Point(9, 43);
			txtNombreDocente.Name = "txtNombreDocente";
			txtNombreDocente.PlaceholderText = "Nombre del Docente";
			txtNombreDocente.Size = new Size(231, 33);
			txtNombreDocente.TabIndex = 3;
			// 
			// pnlUsuario
			// 
			pnlUsuario.BackColor = Color.Honeydew;
			pnlUsuario.BorderStyle = BorderStyle.FixedSingle;
			pnlUsuario.Controls.Add(txtPassword);
			pnlUsuario.Controls.Add(txtUsuario);
			pnlUsuario.Controls.Add(cmnRol);
			pnlUsuario.Location = new Point(504, 107);
			pnlUsuario.Name = "pnlUsuario";
			pnlUsuario.Size = new Size(321, 194);
			pnlUsuario.TabIndex = 18;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtPassword.Location = new Point(9, 42);
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Password";
			txtPassword.Size = new Size(180, 33);
			txtPassword.TabIndex = 22;
			// 
			// txtUsuario
			// 
			txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtUsuario.Location = new Point(11, 3);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.PlaceholderText = "Usuario";
			txtUsuario.Size = new Size(180, 33);
			txtUsuario.TabIndex = 21;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(100, 74);
			label9.Name = "label9";
			label9.Size = new Size(86, 25);
			label9.TabIndex = 19;
			label9.Text = "Docente";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.Location = new Point(504, 79);
			label10.Name = "label10";
			label10.Size = new Size(81, 25);
			label10.TabIndex = 20;
			label10.Text = "Usuario";
			// 
			// btnNuevo
			// 
			btnNuevo.BackColor = SystemColors.Control;
			btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
			btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
			btnNuevo.Location = new Point(231, 306);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(127, 54);
			btnNuevo.TabIndex = 21;
			btnNuevo.UseVisualStyleBackColor = false;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = SystemColors.ButtonHighlight;
			btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
			btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
			btnGuardar.Location = new Point(376, 306);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(132, 54);
			btnGuardar.TabIndex = 22;
			btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = SystemColors.ButtonHighlight;
			btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
			btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
			btnEliminar.ForeColor = SystemColors.Control;
			btnEliminar.Location = new Point(530, 306);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(132, 54);
			btnEliminar.TabIndex = 23;
			btnEliminar.UseVisualStyleBackColor = false;
			// 
			// txtMatriculaDocente
			// 
			txtMatriculaDocente.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtMatriculaDocente.Location = new Point(668, 356);
			txtMatriculaDocente.Name = "txtMatriculaDocente";
			txtMatriculaDocente.PlaceholderText = "Buscar por Clave";
			txtMatriculaDocente.Size = new Size(223, 33);
			txtMatriculaDocente.TabIndex = 24;
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
			dgvDocente.Location = new Point(69, 395);
			dgvDocente.Name = "dgvDocente";
			dgvDocente.RowHeadersWidth = 51;
			dgvDocente.RowTemplate.Height = 45;
			dgvDocente.Size = new Size(822, 116);
			dgvDocente.TabIndex = 25;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Docente1;
			pictureBox1.Location = new Point(591, 9);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(127, 90);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 26;
			pictureBox1.TabStop = false;
			// 
			// frmDocente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			ClientSize = new Size(951, 514);
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
		private ComboBox cmnRol;
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