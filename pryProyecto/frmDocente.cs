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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
