using System;
using System.Windows.Forms;
using IPC2_Practica2_202303088.Estructuras;
using IPC2_Practica2_202303088.Modelos;

namespace IPC2_Practica2_202303088
{
    public partial class Form1 : Form
    {
        private ColaPacientes cola = new ColaPacientes();

        public Form1()
        {
            InitializeComponent();
            CargarEspecialidades();
        }
        private void CargarEspecialidades()
        {
            cmbEspecialidad.Items.Add("Medicina General");
            cmbEspecialidad.Items.Add("Pediatría");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Dermatología");
        }
        private int ObtenerTiempo(string especialidad)
        {
            if (especialidad == "Medicina General")
                return 10;
            else if (especialidad == "Pediatría")
                return 15;
            else if (especialidad == "Ginecología")
                return 20;
            else if (especialidad == "Dermatología")
                return 25;
            else
                return 0;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad;
            string especialidad = cmbEspecialidad.Text;

            if (nombre == "" || especialidad == "" || !int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("Ingrese datos válidos");
                return;
            }
            int tiempo = ObtenerTiempo(especialidad);
            Paciente p = new Paciente(nombre, edad, especialidad, tiempo);
            cola.Encolar(p);
            MessageBox.Show("Paciente agregado correctamente");
            LimpiarCampos();
            MostrarCola();
        }
        private void MostrarCola()
        {
            listCola.Items.Clear();
            Nodo actual = cola.GetFrente();

            while (actual != null)
            {
                Paciente p = actual.GetDato();
                listCola.Items.Add(
                    p.GetNombre() + " | Edad: " + p.GetEdad() +
                    " | " + p.GetEspecialidad() +
                    " | " + p.GetTiempoAtencion() + " min"
                );
                actual = actual.GetSiguiente();
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            cmbEspecialidad.SelectedIndex = -1;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCola();
        }
    }
}