using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEjercicios {
    static class Program {
        static void Main(string[] args) {
            // Invertir array //
            // Descomentar para ver funcionamiento de Invertir un array //
            //int[] _array = {1, 2, 3};
            //ArraySort _arraySort = new ArraySort();
            //_arraySort.InvertirArray(_array);

            // Boxing y Unboxing //
            // Descomentar para ver ejemplo de boxing y unboxing
            //BoxingAndUnboxing _boxingAndUnboxing = new BoxingAndUnboxing();
            //_boxingAndUnboxing.ShowExample();

            // Enumeradores // 
            /*Empresa _empresa = new Empresa();

            foreach (var name in _empresa) {
                Console.WriteLine(name);
            }

            IEnumerable<int> GetNumbers() {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"Processed i: {i}");
                    yield return i;
                }
            }

            foreach (var num in GetNumbers()) {
                Console.WriteLine(num);
            }

            var empresa = new Empresa();

            foreach (var nombre in empresa.Where(n => n.Length > 4)) {
                Console.WriteLine(nombre);
            }*/


            var cyb = new ContinueYBreak();
            cyb.Diferencia();


        }

    }
}
