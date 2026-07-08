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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label1.Location = new Point(430, 12);
            label1.Name = "label1";
            label1.Size = new Size(210, 62);
            label1.TabIndex = 0;
            label1.Text = "Docente";
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(10, 108);
            cmbRol.Margin = new Padding(3, 4, 3, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(205, 40);
            cmbRol.TabIndex = 16;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(10, 5);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(263, 39);
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
            pnlDocente.Location = new Point(114, 136);
            pnlDocente.Margin = new Padding(3, 4, 3, 4);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(413, 265);
            pnlDocente.TabIndex = 17;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(10, 213);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(263, 39);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(10, 161);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(263, 39);
            txtTelefono.TabIndex = 5;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(10, 109);
            txtPuesto.Margin = new Padding(3, 4, 3, 4);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(263, 39);
            txtPuesto.TabIndex = 4;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreDocente.Location = new Point(10, 57);
            txtNombreDocente.Margin = new Padding(3, 4, 3, 4);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del Docente";
            txtNombreDocente.Size = new Size(263, 39);
            txtNombreDocente.TabIndex = 3;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.Honeydew;
            pnlUsuario.BorderStyle = BorderStyle.FixedSingle;
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Controls.Add(cmbRol);
            pnlUsuario.Location = new Point(576, 143);
            pnlUsuario.Margin = new Padding(3, 4, 3, 4);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(367, 258);
            pnlUsuario.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(10, 56);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(205, 39);
            txtPassword.TabIndex = 22;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(13, 4);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(205, 39);
            txtUsuario.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(114, 99);
            label9.Name = "label9";
            label9.Size = new Size(109, 32);
            label9.TabIndex = 19;
            label9.Text = "Docente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(576, 105);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 20;
            label10.Text = "Usuario";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Control;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(264, 408);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(145, 72);
            btnNuevo.TabIndex = 21;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(430, 408);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 72);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ButtonHighlight;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(606, 408);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 72);
            btnEliminar.TabIndex = 23;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtMatriculaDocente
            // 
            txtMatriculaDocente.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaDocente.Location = new Point(763, 475);
            txtMatriculaDocente.Margin = new Padding(3, 4, 3, 4);
            txtMatriculaDocente.Name = "txtMatriculaDocente";
            txtMatriculaDocente.PlaceholderText = "Buscar por Clave";
            txtMatriculaDocente.Size = new Size(254, 39);
            txtMatriculaDocente.TabIndex = 24;
            // 
            // dgvDocente
            // 
            dgvDocente.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dgvDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDocente.BackgroundColor = SystemColors.ControlLight;
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDocente.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDocente.EnableHeadersVisualStyles = false;
            dgvDocente.Location = new Point(79, 527);
            dgvDocente.Margin = new Padding(3, 4, 3, 4);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.RowTemplate.Height = 45;
            dgvDocente.Size = new Size(939, 155);
            dgvDocente.TabIndex = 25;
            dgvDocente.SelectionChanged += dgvDocente_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Docente1;
            pictureBox1.Location = new Point(675, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // frmDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1087, 685);
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
            Margin = new Padding(3, 4, 3, 4);
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