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
    public partial class frmDocente : Form
    {
        clsDocente docente;
        int idTutores;
        int idUsuarios;
        public frmDocente()
        {
            InitializeComponent();
            CargarGrid();

        }
        public void CargarGrid()
        {
            docente = new clsDocente();
            dgvDocente.DataSource = null;
            dgvDocente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvDocente.DataSource = docente.cargarDataGrid();

                dgvDocente.Columns["vchpassword"].Visible = false;
                dgvDocente.Columns["vchperfil"].Visible = false;
                dgvDocente.Columns["idUsuario"].Visible = false;
                txtPassword.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDocente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Identificadores
                idTutores = int.Parse(dgvDocente.CurrentRow.Cells["Clave"].Value.ToString());
                idUsuarios = int.Parse(dgvDocente.CurrentRow.Cells["idUsuario"].Value.ToString());

                // Datos del docente
                txtClave.Text = idTutores.ToString();
                txtNombreDocente.Text = dgvDocente.CurrentRow.Cells["nombre"].Value.ToString();
                txtPuesto.Text = dgvDocente.CurrentRow.Cells["puesto"].Value.ToString();
                txtTelefono.Text = dgvDocente.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvDocente.CurrentRow.Cells["Correo"].Value.ToString();

                // Datos del usuario
                txtUsuario.Text = dgvDocente.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvDocente.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbRol.Text = dgvDocente.CurrentRow.Cells["vchperfil"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }
    }
}
