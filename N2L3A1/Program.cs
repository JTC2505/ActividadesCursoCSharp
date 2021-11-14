using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Topshelf;

namespace N2L3A1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete servicio = new FileDelete();
            var Salida = HostFactory.Run(front =>
            {
                front.RunAsLocalSystem();
                front.SetServiceName("CursoC_FileDelete");
                front.SetDisplayName("CursoC_File Delete Service");
                front.SetDescription("Servicio local que elimina el archivo creado por CursoC_FileUpdate");

                front.Service<FileDelete>(back =>
                {
                    back.ConstructUsing(service => servicio);
                    back.WhenStarted(service => servicio.Inicio());
                    back.WhenStopped(service => servicio.Detener());
                });
            });

            int ValorSalida = (int)Convert.ChangeType(Salida, Salida.GetTypeCode());

            Environment.ExitCode = ValorSalida;
        }
    }
}