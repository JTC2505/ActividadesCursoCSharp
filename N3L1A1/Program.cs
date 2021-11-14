using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N3L1A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!Galaxias cercanas a la via lactea!");
            Galaxia Galaxia1 = new Galaxia() { Name = "Cartwheel", Description = new TipoGalaxia('L') };
            Galaxia Galaxia2 = new Galaxia() { Name = "Andromeda", Description = new TipoGalaxia('S') };
            Galaxia Galaxia3 = new Galaxia() { Name = "Maffei 1", Description = new TipoGalaxia('E') };

            var LasGalaxias = new List<Galaxia> { Galaxia1, Galaxia2, Galaxia3 };
            foreach (Galaxia LaGalaxia in LasGalaxias)
            {
                Console.WriteLine($"{LaGalaxia.Name}, {LaGalaxia.Description.MiTipoGalaxia}");
            }
            Console.ReadKey();
        }

        public class Galaxia
        {
            public string Name { get; set; }
            public TipoGalaxia Description { get; set; }
        }

        public class TipoGalaxia
        {
            private enum Tipos
            {
                Espiral, Eliptica, Lenticular
            }
            public string MiTipoGalaxia { get; set; }
            public TipoGalaxia(char Description)
            {
                if (Description == 'S')
                {
                    MiTipoGalaxia = Tipos.Espiral.ToString();
                }
                else if (Description == 'E')
                {
                    MiTipoGalaxia = Tipos.Eliptica.ToString();
                }
                else if (Description == 'L')
                {
                    MiTipoGalaxia = Tipos.Lenticular.ToString();
                }
            }
        }
    }
}