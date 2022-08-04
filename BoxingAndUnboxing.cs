namespace CSEjercicios {
    #region Contenido ha estudiar
    /* C# BOXING Y UNBOXING
     * 
     * En C# existen 3 tipos de datos: 
     * 
     * > Value types:
     *      - Simple Types
     *         \ int, float, char, bool \
     *      - Enum Types
     *      - Struct Types
     *      - Nullable Types
     *   
     * > Reference Types:
     *      - Class Types
     *      - Interface Types
     *      - Array Types
     *      - Delegate Types
     * 
     * > Pointer Types
     * 
     * * Nota: cuando una variable es declarada dentro de una Clase y fuera de un Método esta es guardada
     *         en la memoria heap ya que la Clase es Reference Type.
     * ---------------------------------------
     * > Boxing:
     *
     *   El proceso de convertir una variable Value Type (int, char etc.) en una de Reference Type (object) 
     *   se llama Boxing.
     *   En el Boxing es usado el tipo objeto (super tipo).
     *   Los Value Types se almacenan en la memoria Stack, mientras que los Reference Types se almacenan en
     *   la memoria Heap.
     *   
     * > Unboxing:
     *   
     *   El proceso de convertir una variable Reference Type en una de Value Type se llama Unboxing.
     *   Se trata de una conversión explicita.
     *   
     * Clase de Ejemplo:
     */
    #endregion

    public class BoxingAndUnboxing { // ª = Stack, º = 

        /*public static void Main(string[] args) {

            Console.WriteLine("//------Boxing------//");

            int _numInStack = 25; // 25 es asignado a num en la memoria Stack de la RAM >> numª
            object _objInHeap = _numInStack; // Boxing, num ahora está en la memoria Heap >> numº

            _numInStack = 200; // cambiamos el valor de _num a 200

            Console.WriteLine($"Value type - valor de _num es : {_numInStack}");
            Console.WriteLine($"Object type - valor de _obj es : {_objInHeap}");

            Console.WriteLine("\n");

            Console.WriteLine("//------Unboxing------//");

            int _numInStack2 = 30; // numª
            object _objInHeap2 = _numInStack2; // Boxing >> numº

            int i = (int)_objInHeap2; // Unboxing >> iª 

            Console.WriteLine($"Valor de obj : {_objInHeap2}");
            Console.WriteLine($"Valor de i : {i}");
        }*/
    }
}