using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("P30", "HUAWEI"); //creando telefonos desde su nacimiento con su marca y modelo 

            Telefono t2 = new Telefono("15", "IPHONE");

            Telefono t3 = new Telefono("16", "IPHONE");

            Telefono t4 = new Telefono("17 plus", "SAMSUNG");

            


            Console.WriteLine("la marca del primer celular es: " + t1.Marca);

            Console.WriteLine("el modelo del primer celular es: " + t1.Modelo);

            


            //t1.Marca = "iphone"         // no se puede asignar una marca ni modelo porque ya esta hecho por CONSTRUCTOR,
                                          //desde el nacimiento del telefono.

            //string algo = t1.Marca;     // pero, si puedo guardar esa marca o modelo en una Variable.



            t1.NumeroTelefonico = "912345678";  // cargando los numeros a telefonos
            t2.NumeroTelefonico = "945678933";
            t3.NumeroTelefonico = "923456789";

            Console.WriteLine("El numero del telefono del celular numero 1 es: " + t1.NumeroTelefonico);
            Console.WriteLine("El numero del telefono del celular numero 2 es: " + t2.NumeroTelefonico);


            t1.CodigoOperador = 1; // cargando numero de operador
            t2.CodigoOperador = 4;
            t3.CodigoOperador = 2;

            Console.WriteLine("El codigo de operador del telefono 1 es : " + t1.CodigoOperador);
            Console.WriteLine("El codigo de operador del telefono 2 es : " + t2.CodigoOperador);
            Console.WriteLine("El codigo de operador del telefono 3 es : " + t3.CodigoOperador);




            t1.llamar();                    //el objeto esta realizanso una accion (comportamiento del objeto)
            Console.WriteLine(t1.llamar());  //utilizanso un METODO




            Console.WriteLine(t1.llamar("MICHAEL"));  //cargando un contacto para llamar -UTILIZANDO LA SOBRECARGA DE METODO




            Console.ReadKey();

        }
    }
}
