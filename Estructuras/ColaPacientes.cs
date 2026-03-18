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
    }
}