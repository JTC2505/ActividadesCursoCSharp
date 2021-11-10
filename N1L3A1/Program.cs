using System;

namespace ActividadesCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Siames gato1 = new Siames("naranja");
            MaineCoon gato2 = new MaineCoon("negro", "crespo");
            Persa gato3 = new Persa("blanco", "liso", "azules");
            Console.WriteLine(gato1.Comer());
            Console.WriteLine(gato2.Maullar());
            Console.WriteLine(gato3.Dormir());
            Console.ReadKey();
        }

        abstract class Gato{
            public static int contador { get; set; }
            public string color { get; set; }
            public string tipoPelo { get; set; }
            public string colorOjos { get; set; }
            public Gato() 
            {
                contador++;
            }
            public virtual string Comer()
            {
                return "El gato esta comiendo";
            }
            public virtual string Maullar()
            {
                return "El gato esta maullando";
            }
            public virtual string Dormir()
            {
                return "El gato esta durmiendo";
            }
        }

        class Siames : Gato
        {
            public Siames()
            {
                color = "desconocido";
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Siames(string c)
            {
                color = c;
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Siames(string c, string p)
            {
                color = c;
                tipoPelo = p;
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Siames(string c, string p, string o)
            {
                color = c;
                tipoPelo = p;
                colorOjos = o;
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public override string Comer()
            {
                return $"El siames de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta comiendo";
            }
            public override string Maullar()
            {
                return $"El siames de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta maullando";
            }
            public override string Dormir()
            {
                return $"El siames de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta durmiendo";
            }
        }
        class MaineCoon : Gato
        {
            public MaineCoon()
            {
                color = "desconocido";
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public MaineCoon(string c)
            {
                color = c;
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public MaineCoon(string c, string p)
            {
                color = c;
                tipoPelo = p;
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public MaineCoon(string c, string p, string o)
            {
                color = c;
                tipoPelo = p;
                colorOjos = o;
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public override string Comer()
            {
                return $"El maine coon de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta comiendo";
            }
            public override string Maullar()
            {
                return $"El maine coon de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta maullando";
            }
            public override string Dormir()
            {
                return $"El maine coon de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta durmiendo";
            }
        }
        class Persa : Gato
        {
            public Persa()
            {
                color = "desconocido";
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Persa(string c)
            {
                color = c;
                tipoPelo = "desconocido";
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Persa(string c, string p)
            {
                color = c;
                tipoPelo = p;
                colorOjos = "desconocido";
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public Persa(string c, string p, string o)
            {
                color = c;
                tipoPelo = p;
                colorOjos = o;
                Console.WriteLine("Contador de gatos: {0}", contador);
            }
            public override string Comer()
            {
                return $"El persa de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta comiendo";
            }
            public override string Maullar()
            {
                return $"El persa de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta maullando";
            }
            public override string Dormir()
            {
                return $"El persa de color {color} con tipo de pelo {tipoPelo} y ojos de color {colorOjos} esta durmiendo";
            }
        }
    }
}