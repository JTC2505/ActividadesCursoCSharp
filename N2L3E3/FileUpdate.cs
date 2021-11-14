using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace N2L3E3
{
    class FileUpdate
    {
        private readonly System.Timers.Timer temporaziador;

        public FileUpdate()
        {
            temporaziador = new System.Timers.Timer(1000);
            temporaziador.AutoReset = true;
            temporaziador.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Users\estua\OneDrive\Documentos\Tareas\2021\II\Programación II\FileUpdate.txt", lines);
        }
        public void Inicio()
        {
            temporaziador.Start();
        }
        public void Detener()
        {
            temporaziador.Stop();
        }
    }
}