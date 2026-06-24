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


	}
}

