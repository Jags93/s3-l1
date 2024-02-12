using System;
using System.Collections.Generic;

namespace es1
{


    class Program
    {
        static void Main()
        {
            var menu = new Ristorante<int, Tuple<string, decimal>> {
            {1, Tuple.Create("Coca Cola 150 ml", 2.50m)},
            {2, Tuple.Create("Insalata di pollo", 5.20m)},
            {3, Tuple.Create("Pizza Margherita", 10.00m)},
            {4, Tuple.Create("Pizza 4 Formaggi", 12.50m)},
            {5, Tuple.Create("Pz patatine fritte", 3.50m)},
            {6, Tuple.Create("Insalata di riso", 8.00m)},
            {7, Tuple.Create("Frutta di stagione", 5.00m)},
            {8, Tuple.Create("Pizza fritta", 5.00m)},
            {9, Tuple.Create("Piadina vegetariana", 6.00m)},
            {10, Tuple.Create("Panino Hamburger", 7.90m)}
        };

            var ordini = new List<int>();
            int scelta;

            while (true)
            {
                Console.WriteLine("==============MENU==============");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Item1} (€ {item.Value.Item2})");
                }
                Console.WriteLine("11: Stampa conto finale e conferma");

                Console.Write("Seleziona un'opzione (1-11): ");
                if (int.TryParse(Console.ReadLine(), out scelta) && scelta >= 1 && scelta <= 11)
                {
                    if (scelta == 11) break;
                    ordini.Add(scelta);
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }
            }

            decimal totale = 0;
            Console.WriteLine("\nRiepilogo ordine:");
            foreach (var ordine in ordini)
            {
                Console.WriteLine($"{menu[ordine].Item1}: €{menu[ordine].Item2}");
                totale += menu[ordine].Item2;
            }
            totale += 3.00m; // Aggiunta costo servizio al tavolo
            Console.WriteLine($"Costo del servizio: €3.00");
            Console.WriteLine($"Totale: €{totale}");
            Console.ReadLine();

        }
    }
}





