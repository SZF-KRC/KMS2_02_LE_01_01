using System.Collections.Generic;

namespace KMS2_02_LE_01_01.ToDoManager
{
    public class Filter
    {

        /// <summary>
        /// Delegate-Definition
        /// </summary>
        /// <param name="number">Die Ganzzahl, die gefiltert werden soll</param>
        /// <returns>Ein boolescher Wert, der angibt, ob die Zahl die Bedingung erfüllt</returns>
        public delegate bool FilterDelegate(int number);

        /// <summary>
        /// FilterList-Methode, die die Liste nach Delegaten filtert
        /// </summary>
        /// <param name="numbers">Die Liste der Ganzzahlen</param>
        /// <param name="filter">Der Delegat, der die Filterbedingung definiert</param>
        /// <returns>Eine neue Liste, die nur die Elemente enthält, für die der Delegat true zurückgibt</returns>
        public static List<int> FilterList(List<int> numbers, FilterDelegate filter)
        {
            List<int> filteredList = new List<int>();
            foreach (int number in numbers)
            {
                if (filter(number))
                {
                    filteredList.Add(number);
                }
            }
            return filteredList;
        }
    }
}
