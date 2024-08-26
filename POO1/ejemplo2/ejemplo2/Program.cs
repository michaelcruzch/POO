using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());


            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine(("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine);
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());


                //trabajamos

                //pido cliente nuevamente
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }

            

        }
    }
}
