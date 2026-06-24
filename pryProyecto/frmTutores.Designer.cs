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
            dgvTutores = new DataGridView();
            pnlPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            lblTutor = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pnlPrincipal.Controls.Add(pictureBox2);
            pnlPrincipal.Controls.Add(lblTutor);
            pnlPrincipal.Controls.Add(pictureBox1);
            pnlPrincipal.Location = new Point(75, 52);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(939, 324);
            pnlPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(785, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(414, 17);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(132, 41);
            lblTutor.TabIndex = 1;
            lblTutor.Text = "Tutores";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(63, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTutores;
        private Panel pnlPrincipal;
        private PictureBox pictureBox1;
        private Label lblTutor;
        private PictureBox pictureBox2;
    }
}