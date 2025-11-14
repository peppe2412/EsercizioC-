using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Convert.ToInt32 convertire la string in un int

            // far inserire numeri dall'utente
            Console.WriteLine("Inserisci numero");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci altro numero");
            int number2 = Convert.ToInt32(Console.ReadLine());

            /* 
             * In una divisione se il denominatore è uguale a 0, 
              eseguire l'errore specifico 
            */
            //if (number2 == 0) Console.WriteLine("Non si può dividere per zero"); return;

            //int divisionResult = number / number2;
            //Console.WriteLine("Risultato: " + divisionResult);

            // sommare i numeri inseriti dall'utente
            int summ = number + number2;

            // eseguire il risultato
            Console.WriteLine($"Risultato di {number} + {number2}: {summ}");
            Console.ReadKey();



        }
    }
}
