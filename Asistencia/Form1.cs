using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class frmAsistencia : Form
    {
        static List<RegistroAsistencia> registros = new List<RegistroAsistencia>();
        public frmAsistencia()
        {
            InitializeComponent();


        }
        private void LimpiarCampos()
        {
            txtNombreParticipante.Text = "";
        }


        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreParticipante.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Por favor, ingrese el nombre del participante.", "Error de ingreso");
                return;
            }

            DateTime fecha = DateTime.Now;


            RegistroAsistencia registro = new RegistroAsistencia(fecha, nombre);
            registro.MarcarAsistencia();
            registros.Add(registro);
            MessageBox.Show("Asistencia registrada correctamente.");
            LimpiarCampos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string reporte = "Reporte de Asistencia:\n\n";

            foreach (var registro in registros)
            {
                reporte += registro.GenerarReporte() + "\n";
            }

            MessageBox.Show(reporte, "Reporte de Asistencia");
        }
    }
}

