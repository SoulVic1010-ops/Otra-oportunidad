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
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombre = new TextBox();
            lblTutor = new Label();
            pictureBox1 = new PictureBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(75, 440);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(939, 188);
            dgvTutores.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = SystemColors.ScrollBar;
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
            pnlPrincipal.Location = new Point(75, 52);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(939, 382);
            pnlPrincipal.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(46, 243);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(502, 34);
            txtCorreo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(46, 203);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(502, 34);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(46, 163);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(502, 34);
            txtDireccion.TabIndex = 5;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(46, 123);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Parentesco";
            txtParentesco.Size = new Size(502, 34);
            txtParentesco.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(46, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre completo";
            txtNombre.Size = new Size(502, 34);
            txtNombre.TabIndex = 3;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(414, 17);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(101, 41);
            lblTutor.TabIndex = 1;
            lblTutor.Text = "Tutor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tutor1;
            pictureBox1.Location = new Point(669, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonHighlight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(46, 294);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(151, 72);
            btnNuevo.TabIndex = 8;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(260, 294);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 72);
            btnGuardar.TabIndex = 9;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(485, 294);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 72);
            btnEliminar.TabIndex = 10;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Contorno;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1087, 685);
            Controls.Add(pnlPrincipal);
            Controls.Add(dgvTutores);
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
    }
}