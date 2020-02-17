using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio;
using Universidad;
using Alumno = Universidad.Alumno;



namespace DemoConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var alumnoDemo = new Alumno()
            {
                Nombre = "Daniel",
                Apellido1 = "Lam",
                Edad = 18
            };

            float[] notas = new float[] { 
                5.98f, 10.0f, 5.09f, 8.99f, 7};


            Console.WriteLine("Mayor de Edad: " + alumnoDemo.MayorDeEdad(17));
            Console.WriteLine("Media: " + alumnoDemo.CalcularMedia(notas));


            Alumno[] alumnos = new Alumno[5];
            alumnos[2] = new Alumno() { Nombre="Cris", Apellido1="Contreras"};

            var alumnos2 = new Alumno[] {
                new Alumno(){Nombre="A", Apellido1="B"},
                new Alumno(){Nombre="C", Apellido1="D"},
                new Alumno(){Nombre="E", Apellido1="F"},
                new Alumno(){Nombre="G", Apellido1="H"},

            };

            for (var c = 0; c < alumnos2.Length; c++)
            {
                Console.WriteLine("Posiciones:{0} - Valor{1} ", c, alumnos2[c].Nombre + alumnos2[c].Apellido1);
            };

            foreach (var item in alumnos2)
            {
                Console.WriteLine("Posiciones:{0} ", item.Nombre+" "+item.Apellido1);
            };

            var dias = new string[]{
                "Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"
            };

            for (var c = 0; c < dias.Length; c++)
            {
                Console.WriteLine("Posiciones:{0} - Valor{1} ", c, dias[c]);
            };

            foreach(var dia in dias)
            {
                Console.WriteLine("Posiciones:{0} ", dia);
            };

            Console.ReadKey();

            //Colegio.Alumno alumno = new Colegio.Alumno(); ---> cuando no se declaran en el using 

            //Cuando hay ambiguedad se tiene que especificar de donde proviene el objeto ejemp: 
            Alumno alumno = new Alumno();
            alumno.Nombre = "Cristhian";
            alumno.Apellido1 = "Lammoglia";

            Alumno alumno1 = new Alumno()
            {
                Nombre = "Cristhian", Apellido1 = "Lammoglia", Edad = 27
            };

            var alumno2 = new Alumno()
            { Nombre = "Cristhian", Apellido1 = "Lammoglia", Edad = 27 };

            object alumno3 = new Alumno()
            { Nombre = "Cristhian", Apellido1 = "Lammoglia", Edad = 27 };

            dynamic alumno4 = new Alumno()
            { Nombre = "Cristhian", Apellido1 = "Lammoglia", Edad = 27};

            Console.WriteLine("Nombre: ", alumno.Nombre);
            Console.WriteLine("Nombre: ", alumno1.Nombre);
            Console.WriteLine("Nombre: ", alumno2.Nombre);
            //Console.WriteLine("Nombre: ", alumno3.Nombre);
            //(Alumno)alumno3 convierte el objeto para poder acceder a sus miembros 
            Console.WriteLine("Nombre: ", ((Alumno)alumno3).Nombre);
            Console.WriteLine("Tipo: ", alumno3.GetType().ToString());
            Console.WriteLine("Nombre: ", alumno4.Nombre);
        }
    }
}

namespace Colegio {
    public class Alumno { }
}

namespace Universidad {
    public class Alumno {
        public string Nombre;
        public string Apellido1 { get; set; }
        public string Apellido2{ get; set; }
        public byte Edad { get; set; }
        public void Limpiar() { }

        public float CalcularMedia(float[] notas) {
            float media = 0;
            for (var z = 0; z < notas.Length; z++)
            {
                media += notas[z];
            };
            media = media / notas.Length;
            //notas.Average;
            //return notas.Average;
            return media;
        }

        public bool MayorDeEdad(int limite) {
            if (Edad >= limite) return true;
            else return false;
        }
        public Alumno() { }
        ~Alumno() { } 
    }
}