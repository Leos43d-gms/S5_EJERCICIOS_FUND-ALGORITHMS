using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejer01();
            Console.ReadKey();
        }
        static void Ejer01()
        {
            int codigo;
            double precio, preciofin, desc = 0;
            Console.WriteLine("Ingrese el precio del producto: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("\n1. Estudiante\n2. Empleado\n3. CLiente frecuente\nSelecciones una opcion: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
                desc = 0.10;
            else if (codigo == 2)
                desc = 0.15;
            else if (codigo == 3)
                desc = 0.20;
            else
                Console.WriteLine("Codigo de descuento no valido");

            preciofin = precio - (precio * desc);

            if (precio > 500)
                preciofin -= preciofin * 0.05;

            preciofin = Math.Round(preciofin, 2);

            Console.WriteLine($"El precio final es: S/{preciofin:F2}");
            Console.ReadKey();
            
        }
        static void Ejer2()
        {
            int nt;
            double raiz, cubo;
            Console.WriteLine("Ingrese su nota: ");
            nt = int.Parse(Console.ReadLine());

            if (nt < 0 || nt > 20)
                Console.WriteLine("Nota ingresada no valida[0-20]");
            else
                switch (nt)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("Desaprobado");
                        break;
                    case 11:
                    case 12:
                    case 13:
                        Console.WriteLine("Regular");
                        break;
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                        Console.WriteLine("Bueno");
                        break;
                    case 18:
                    case 19:
                    case 20:
                        Console.WriteLine("Excelente");
                        break;
                }
            if (nt >= 14 || nt % 2 == 0)
                Console.WriteLine("Buen desempeño con nota par");
            if (nt < 11 || nt % 2 != 0)
                Console.WriteLine("Necesita refuerzo");
            raiz = Math.Round(Math.Sqrt(nt),1);
            cubo = Math.Pow(nt, 3);

            Console.WriteLine("Nota con raiz: " + raiz);
            Console.WriteLine("Nota al cubo: " + cubo);
        }
    }
}
