using System;
using System.Windows.Forms;

namespace IPC2_Practica2_202303088
{
    public partial class FormGrafica : Form
    {
        public FormGrafica()
        {
            InitializeComponent();
        }

        public void CargarImagen(string ruta)
        {
            pictureBox1.ImageLocation = ruta;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}