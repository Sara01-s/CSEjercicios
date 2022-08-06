using System;
using System.Collections.Generic;

namespace CSEjercicios {
    #region Contenido a resolver
    /*
     * Invierte un array sin crear uno nuevo
     * */
    #endregion
    internal class ArraySort {

        public ArraySort() {

        }

        public void InvertirArray(int[] array) {
            if (array is null) {
                throw new ArgumentNullException(nameof(array));
            }

            Console.WriteLine($"array normal : {String.Join(",", array)}");

            int n = 0;
            int j = array.Length - 1; // 4
            while (n < j) { // si n++ serían 4 iteraciones

                int arrayTemp = array[n];
                array[n] = array[j];
                array[j] = arrayTemp;
                n++;
                j--;

            }

            Console.WriteLine();
            Console.WriteLine($"array invertido : {String.Join(",", array)}");

        }
    }
}
