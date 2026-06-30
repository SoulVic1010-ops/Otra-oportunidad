using Microsoft.VisualBasic.Logging;
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
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;

        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            CargarCombos();
        }

        //Metodo para cargar el fatagriview
        public void CargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAlumnos.DataSource = alumnos.cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCombos()
        {
            alumnos = new clsAlumnos();
            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();
                //Creamos la fila de placeholder para la carrera
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idCarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);

                //Enlazamos los datos al comboBox visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombreCarrera"; //El texto visible
                cmbCarrera.ValueMember = "idCarrera"; //La llave primaria real
                cmbCarrera.SelectedIndex = 0; //Forzar a que muestre el placeholder

                
                DataTable dtTutores = alumnos.ObtenerTutores();
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "-- Selecciona un Tutor --";
                dtTutores.Rows.InsertAt(filaPTutores, 0);

                // Enlazamos los datos al comboBox visual

                cmbTutor.DataSource = dtTutores;
                cmbTutor.DisplayMember = "nombreTutor"; //El texto visible
                cmbTutor.ValueMember = "idTutor"; //La llave primaria real
                cmbTutor.SelectedIndex = 0; //Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús despegables: " + ex.Message);
            }



        }
    }
}
