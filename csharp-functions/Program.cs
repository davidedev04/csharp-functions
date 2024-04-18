using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tutte le funzioni richieste


            // stampa array
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


            // quadrato di ogni numero presente nell'array
            int Quadrato(int numero)
            {
                int quadratoNumber = numero * numero;

                Console.WriteLine($"il quadrato del numero {numero} é {quadratoNumber}");
                return numero;
            }
     

            // array di tutti i numeri elevati al quadrato
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

                Console.WriteLine(" )");

                return array;
            }


            // somma di tutti i numeri presenti nell'array
            int sommaElementiArray(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = array[i] + sum;
                }

                Console.WriteLine($"La somma totale dei numeri é {sum}");

                return sum;
            }


            // tutte le operazioni di dati

            int[] arrayNum = { 2, 6, 7, 5, 3, 9 };
            
            StampaArray(arrayNum);

            for (int i = 0; i < arrayNum.Length; i++)
            {
                Quadrato(arrayNum[i]);
            }

            sommaElementiArray(arrayNum);

            ElevaAlQuadrato(arrayNum);
        }
    }
}
