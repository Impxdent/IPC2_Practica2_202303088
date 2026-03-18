namespace IPC2_Practica2_202303088.Modelos
{
    public class Paciente
    {
        private string nombre;
        private int edad;
        private string especialidad;
        private int tiempoAtencion;

        public Paciente(string nombre, int edad, string especialidad, int tiempoAtencion)
        {
            this.nombre=nombre;
            this.edad=edad;
            this.especialidad=especialidad;
            this.tiempoAtencion=tiempoAtencion;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }
        public string GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad=edad;
        }
        public string GetEspecialidad()
        {
            return especialidad;
        }
        public void SetEspecialidad(string especialidad)
        {
            this.especialidad=especialidad;
        }
        public string GetTiempoAtencion()
        {
            return tiempoAtencion;
        }
        public void SetTiempoAtencion(int tiempoAtencion)
        {
            this.tiempoAtencion=tiempoAtencion;
        }
    }
}