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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutores = 0;
            idUsuarios = 0;
            docente.LimpiarPanel(pnlDocente);
            docente.LimpiarPanel(pnlUsuario);
            txtClave.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinamos el tipo de operación
                int tipoOperacion = idTutores == 0 ? 0 : 1;

                docente = new clsDocente();

                // Llenamos las propiedades del bloque docente
                docente.ClaveDocente = int.Parse(txtClave.Text);
                docente.NombreDocente = txtNombreDocente.Text;
                docente.Puesto = txtPuesto.Text;
                docente.Telefono = txtTelefono.Text;
                docente.Correo = txtCorreo.Text;

                // Llenamos las propiedades del bloque Usuario
                docente.IdUsuario = idUsuarios;
                docente.NombreUsuario = txtUsuario.Text;
                docente.Password = txtPassword.Text;
                docente.Perfil = cmbRol.Text;

                string msg = "";

                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este docente?",
                        "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resp == DialogResult.Yes)
                    {
                        msg = docente.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = docente.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estás completamente seguro de eliminar al docente con clave {idTutores}?\nEsta acción también eliminará su cuenta de usuario.",
                        "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    docente = new clsDocente();

                    docente.ClaveDocente = idTutores;
                    docente.IdUsuario = idUsuarios;

                    string resultado = docente.Eliminar();

                    MessageBox.Show(resultado, "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el registro: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
