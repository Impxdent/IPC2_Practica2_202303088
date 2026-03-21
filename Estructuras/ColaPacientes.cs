using IPC2_Practica2_202303088.Modelos;

namespace IPC2_Practica2_202303088.Estructuras
{
    public class ColaPacientes
    {
        private Nodo frente;
        private Nodo final;

        public ColaPacientes()
        {
            frente=null;
            final=null;
        }
        public Nodo GetFrente()
        {
            return frente;
        }
        public void SetFrente(Nodo frente)
        {
            this.frente=frente;
        }
        public Nodo GetFinal()
        {
            return final;
        }
        public void SetFinal(Nodo final)
        {
            this.final=final;
        }
        public bool EstaVacia()
        {
            if (frente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Encolar(Paciente paciente)
        {
            Nodo nuevo=new Nodo(paciente);

            if (EstaVacia())
            {
                frente=nuevo;
                final=nuevo;
            }
            else
            {
                final.SetSiguiente(nuevo);
                final=nuevo;
            }
        }
        public Paciente Desencolar()
        {
            if (EstaVacia())
            {
                return null;
            }

            Paciente temp=frente.GetDato();
            frente=frente.GetSiguiente();

            if (frente == null)
            {
                final=null;
            }
            return temp;
        }
        public Paciente VerPrimero()
        {
            if (EstaVacia())
            {
                return null;
            }
            return frente.GetDato();
        }
        public string MostrarCola()
        {
            if (EstaVacia())
            {
                return "Cola vacia";
            }

            string resultado = "";
            Nodo actual = frente;

            while (actual != null)
            {
                resultado += actual.GetDato().GetNombre() + " -> ";
                actual = actual.GetSiguiente();
            }

            return resultado + "null";
        }
        public int CalcularTiempoEspera()
        {
            int total=0;
            Nodo actual=frente;
            while(actual != null)
            {
                total +=actual.GetDato().GetTiempoAtencion();
                actual=actual.GetSiguiente();
            }
            return total;
        }
    }
}