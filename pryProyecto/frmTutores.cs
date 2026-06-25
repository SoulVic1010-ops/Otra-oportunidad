using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryProyecto
{
    public partial class frmTutores : Form
    {
        clsTutores tutores;
        int idTutores;

        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            tutores = new clsTutores();

            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvTutores.DataSource = tutores.cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarTutores_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                tutores.Nombretutor = txtBuscarTutores.Text;
                dgvTutores.DataSource = tutores.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutores = 0;
            txtNombre.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idTutores == 0 ? 0 : 1;
                tutores.Id_Tutores = idTutores;
                tutores.Nombretutor = txtNombre.Text;
                tutores.Parentesco1 = txtParentesco.Text;
                tutores.Telefono1 = txtTelefono.Text;
                tutores.Correo1 = txtCorreo.Text;
                string msg = tutores.GuardarActualizar(tipoOperacion);
                MessageBox.Show(msg);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            idTutores = int.Parse(dgvTutores.CurrentRow.Cells[0].Value.ToString());

            txtNombre.Text = dgvTutores.CurrentRow.Cells[1].Value.ToString();
            txtParentesco.Text = dgvTutores.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvTutores.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvTutores.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvTutores.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

