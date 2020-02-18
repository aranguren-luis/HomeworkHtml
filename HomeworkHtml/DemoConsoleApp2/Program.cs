using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numero = new List<int>();
            List<Persona> gente  = new List<Persona>();
            Dictionary<int, string> dicc = new Dictionary<int, string>();

            dicc.Add(100, "Lunes");
            dicc.Add(200, "Martes");
            dicc.Add(300, "Miercoles");
            dicc.Add(400, "Jueves");

            Console.WriteLine(dicc[100]);
            dicc[300] = "Viernes";
            foreach (var clave in dicc.Keys) //Para recorrer un diccionario hay que poner las .Keys las claves
            {
                Console.WriteLine("Clave {0} - Valor{1}", clave, dicc[clave]);   
            }
            Console.ReadKey();

            var p1 = new Persona() { Nombre = "Cristhian", Apellido1 = "Lammoglia" };
            gente.Add(p1);
            gente.Add(p1);
            gente.Add(p1);
            gente.Add(p1);
            gente.Add(p1);

            gente[1].Nombre = "Ana";
            Console.WriteLine(gente[0].Nombre);
            Console.WriteLine(gente[1].Nombre);

            Console.ReadKey();
            
            //Agregar elementos a una lista
            numero.Add(100);
            numero.Add(10);
            numero.Add(56);
            numero.Add(23);
            numero.Add(12);
            var array = new int[] {12, 45, 12, 3422, 0 };
            //numero.AddRange(new int[] { 12, 45, 12, 3422, 0 });
            numero.AddRange(array);

            //eliminar elementos de la lista
            numero.RemoveAt(3);

            //Recorrer la coleccion
            foreach (var valor in numero) {
                Console.WriteLine(valor);
            }
            Console.ReadKey();



            /////////////////////////////////////////////////////////////////////////////////

            Persona persona = new Persona() { Nombre = "Cristhian", Apellido1 = "Lammoglia" };
            int numero1 = 10;
            Console.WriteLine("nombre :" + persona.Nombre);
            Console.WriteLine("nombre :" + numero.ToString());

            Prueba(persona, out numero1);
            Console.WriteLine("nombre :" + persona.Nombre);
            Console.WriteLine("valor :" + numero.ToString());
            Console.ReadKey();
        }
    
    //static void Prueba(Persona p, int n)
    static void Prueba(Persona p, out int n)
    {
        p.Nombre = "Ana";
        n = 30;
    }
}
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
    }
}
