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
            Persona persona = new Persona() { Nombre = "Cristhian", Apellido1 = "Lammoglia" };
            int numero = 10;
            Console.WriteLine("nombre :" + persona.Nombre);
            Console.WriteLine("nombre :" + numero.ToString());

            Prueba(persona, out numero);
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
