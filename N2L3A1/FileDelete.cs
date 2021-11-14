using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace N2L3A1
{
    class FileDelete
    {
        private readonly System.Timers.Timer temporaziador;

        public FileDelete()
        {
            temporaziador = new System.Timers.Timer(3600000);
            temporaziador.AutoReset = true;
            temporaziador.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            File.Delete(@"C:\Users\estua\OneDrive\Documentos\Tareas\2021\II\Programación II\FileUpdate.txt");
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