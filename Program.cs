using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, r;
            int op;
            Console.Write("Digite o 1º valor: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                r = a + b;
                Console.WriteLine("Resultado: {0}", r);
            }
            if(op == 2)
            {
                r = a - b;
                Console.WriteLine("Resultado: {0}", r);
            }
            if (op == 3)
            {
                r = a * b;
                Console.WriteLine("Resultado: {0}", r);
            }
            if(op == 4)
            {
                r = a / b;
                Console.WriteLine("Resultado: {0}", r);
            }
            Console.WriteLine();
            Console.Write("Enter para sair");
            Console.ReadLine();
            
        }
    }
}
