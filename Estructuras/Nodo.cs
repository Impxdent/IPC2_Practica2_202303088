using IPC2_Practica2_202303088.Modelos;

namespace IPC2_Practica2_202303088.Estructuras
{
    public class Nodo
    {
        private Paciente dato;
        private Nodo siguiente;

        public Nodo(Paciente paciente)
        {
            this.dato=paciente;
            this.siguiente=null;
        }
        public Paciente GetDato()
        {
            return dato;
        }
        public void SetDato(Paciente dato)
        {
            this.dato=dato;
        }
        public Nodo GetSiguiente()
        {
            return siguiente;
        }
        public void SetSiguiente(Nodo siguiente)
        {
            this.siguiente=siguiente;
        }
    }
}