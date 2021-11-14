using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Topshelf;

namespace N2L3E3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUpdate servicio = new FileUpdate();
            var Salida = HostFactory.Run(front =>
            {
                front.RunAsLocalSystem();
                front.SetServiceName("CursoC_FileUpdate");
                front.SetDisplayName("CursoC_File Update Service");
                front.SetDescription("Servicio local de actualización de fecha y hora en un txt");

                front.Service<FileUpdate>(back =>
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