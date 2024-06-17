using System;
using System.Collections.Generic;

namespace KMS2_02_LE_01_01.ToDoManager
{
    public class ToDo
    {
        /// <summary>
        /// Führt die Hauptlogik des Programms aus.
        /// </summary>
        public void Run()
        {
            // Erstelle eine Liste mit Ganzzahlen
            List<int> numbers = new List<int> { -20, -10, -2, 0, 5, 10, 15, 20, -33, -46, 46, -4, 99 };

            // Definieren eines Delegaten, der für positive Zahlen „true“ zurückgibt
            Filter.FilterDelegate isPositive = number => number > 0;

            // Verwendung der FilterList-Methode aus der Filter-Klasse
            List<int> positiveNumbers = Filter.FilterList(numbers, isPositive);

            // Die gefilterte Liste ausgeben
            Console.WriteLine("Positive numbers:");
            foreach (int number in positiveNumbers) { Console.WriteLine(number); }

            Console.ReadKey();
        }
    }
}
