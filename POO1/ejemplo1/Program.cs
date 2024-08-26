using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Persona: Edad, Sueldo, Nombre

            Persona p1 = new Persona();
            p1.setEdad(20);

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());



            Botella b1 = new Botella();
            b1.Capacidad = 200;  // le escribo

            int algo = b1.Capacidad; //si lo quiero guardar en algo


            Perro pe1 = new Perro();
            pe1.Nombre = "paco";

            pe1.Color = "cafe";

            pe1.Origen = "Chile";


            Console.WriteLine("El nombre del perro es: " + pe1.Nombre);

            Console.ReadKey();
        }
    }
}
