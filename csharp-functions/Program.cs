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
                Console.WriteLine("Questo é l' array dei numeri:");
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
                Console.WriteLine("Questo é l' array dei numeri elevati al quadrato:");

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

            int sommaElementiArrayQuadrati(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = array[i] * array[i] + sum;
                }

                return sum;
            }


            // tutte le operazioni di dati


            // qui definisco l'array principale
            int[] arrayNum = { 2, 6, 7, 5, 3, 9 };
            

            // stampo l'array dei numeri interi
            StampaArray(arrayNum);


            // faccio la somma dei numeri interi
            sommaElementiArray(arrayNum);
            

            // faccio un ciclo per tutti i numeri presi singolarmente al quadrato
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Quadrato(arrayNum[i]);
            }


            // richiamo la funzione sommaElementiArrayQuadrati per l'array di numeri al quadrato e faccio la soma
            {
                int[] arrayQuadrati = ElevaAlQuadrato(arrayNum);

                int sommaQuadrati = sommaElementiArrayQuadrati(arrayQuadrati);

                Console.WriteLine($"La somma dei quadrati dei numeri é {sommaQuadrati}");
            }
        }
    }
}
