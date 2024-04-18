using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void StampaArray(int[] array)
            {
                Console.Write("( ");
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(" )");
            }

            int Quadrato(int numero)
            {
                int quadratoNumber = numero * numero;

                Console.WriteLine($"il quadrato del numero {numero} é {quadratoNumber}");
                return numero;
            }
     
            int[] ElevaAlQuadrato(int[] array)
            {
                
                Console.Write("( ");

                for (int i = 0;i < array.Length;i++)
                    {
                        int quadratoNumber = array[i] * array[i];
                        Console.Write(quadratoNumber);

                        if (i < array.Length - 1)
                        {
                            Console.Write(", ");
                        }
                    }

                Console.Write(" )");

                return array;
            }

            int[] arrayNum = { 2, 6, 7, 5, 3, 9 };
            
            StampaArray(arrayNum);

            for (int i = 0; i < arrayNum.Length; i++)
            {
                Quadrato(arrayNum[i]);
            }

            ElevaAlQuadrato(arrayNum);
        }
    }
}
