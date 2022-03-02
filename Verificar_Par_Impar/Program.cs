using System;

namespace Verificar_Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            ParOuImpar(x);
            
        }
        public static int ParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
            return num;
        }
    }
}
