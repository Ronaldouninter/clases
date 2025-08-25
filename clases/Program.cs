using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case 1:

                        Console.WriteLine("Ingresa un numero");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es " + acciones.sumar (a,b));
                        break;

                     case 2:
                        Console.WriteLine("Dame un numero");
                        int a = int.Parse (Console.ReadLine());
                        Console.WriteLine("Dame otro numero");
                        int b = int.Parse((string) Console.ReadLine());
                        Console.WriteLine("La resta es " + acciones.restar(a,b));
                        break;

                    default:
                        break;
                }
            }
        }
        static int menu()
        {
            int opc;
            Console.WriteLine("1) SUMAR");
            Console.WriteLine("2) RESTAR");
            Console.WriteLine("3) MULTILPLICAR");
            Console.WriteLine("4) DIVIDIR");
            Console.WriteLine("5) SALIR");
           opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }
}
