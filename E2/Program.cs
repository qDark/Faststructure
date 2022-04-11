using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_alternativa = 0;


            do
            {
                Console.WriteLine("----ALTERNATIVAS----");

                Console.WriteLine("[1]. OPERACION");

                Console.WriteLine("[2]. SALIR");


                Console.WriteLine("Ingrese una opcíon: ");
                n_alternativa = int.Parse(Console.ReadLine());

                switch (n_alternativa)
                {

                    case 1:

                        int n1, n2;

                        OP x1, x2;

                        Console.WriteLine("Ingresar Metros: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Igresar Centimetros: ");
                        n2 = int.Parse(Console.ReadLine());

                        x1 = new OP(n1);

                        x2 = new OP(n2);

                        Console.WriteLine("La suma de metro a centimetros es: {0}", x1 + x2);

                        Console.WriteLine("La resta de metros a centimetros es: {0}", x1 - x2);

                        Console.WriteLine("La multiplicacíon de metros a centimetros es: {0} m2", x1 * x2);

                        break;
                }
            } while (n_alternativa != 2);



            Console.ReadKey();
        }
    }
}
