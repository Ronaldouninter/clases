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
                        int e = int.Parse (Console.ReadLine());
                        Console.WriteLine("Dame otro numero");
                        int i = int.Parse(Console.ReadLine());
                        Console.WriteLine("La resta es " + acciones.restar(e,i));
                        break;

                     case 3:
                        Console.WriteLine("Dame un numero");
                        int u = int.Parse (Console.ReadLine());
                        Console.WriteLine("Dame otro numero");
                        int o = int.Parse(Console.ReadLine());
                        Console.WriteLine("La multiplicacion es " + acciones.multiplicar(u, o));
                        break;
                        
                    case 4:
                        Console.WriteLine("Dame un numero");
                        int r = int.Parse (Console.ReadLine());
                        Console.WriteLine("Dame otro numero");
                        int m = int.Parse (Console.ReadLine());
                        Console.WriteLine("La division es "+ acciones.dividir(r,m));
                        break;
                        
                    case 5:
                        Environment.Exit(0);
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
