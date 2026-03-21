using System.Diagnostics;
using System.IO;
using IPC2_Practica2_202303088.Estructuras;
using IPC2_Practica2_202303088.Modelos;

namespace IPC2_Practica2_202303088.Graphviz
{
    public class Graficador
    {
        public static void GraficarCola(ColaPacientes cola)
        {
            string rutaDot = "cola.dot";
            string rutaImagen = "cola.png";

            string contenido = "digraph G {\n";
            contenido += "rankdir=LR;\n";
            contenido += "node [shape=box];\n";

            Nodo actual = cola.GetFrente();
            int tiempoAcumulado = 0;

            while (actual != null)
            {
                Paciente p = actual.GetDato();

                string etiqueta = p.GetNombre() + "\\n" +
                                p.GetEspecialidad() + "\\n" +
                                "Espera: " + tiempoAcumulado + " min\\n" +
                                "Atención: " + p.GetTiempoAtencion() + " min";

                contenido += "\"" + etiqueta + "\"";

                if (actual.GetSiguiente() != null)
                {
                    contenido += " -> ";
                }

                tiempoAcumulado += p.GetTiempoAtencion();
                actual = actual.GetSiguiente();
            }

            contenido += ";}";

            File.WriteAllText(rutaDot, contenido);

            Process proceso = new Process();
            proceso.StartInfo.FileName = "dot";
            proceso.StartInfo.Arguments = "-Tpng " + rutaDot + " -o " + rutaImagen;
            proceso.StartInfo.CreateNoWindow = true;
            proceso.StartInfo.UseShellExecute = false;

            proceso.Start();
            proceso.WaitForExit();
        }
    }
}