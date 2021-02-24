using System;

namespace Day_14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] array)
        {
            this.elements = array;
        }

        public int computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = Math.Abs(elements[elements.Length - 1] - elements[0]);
            return maximumDifference;
        }

    } // End of Difference Class
}
