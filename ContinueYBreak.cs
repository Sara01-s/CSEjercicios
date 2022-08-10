using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEjercicios {
    internal class ContinueYBreak {

        public ContinueYBreak() { }

        public void Diferencia() {
            for ( int i = 0; i < 10; i++ ) {
                if ( i == 3 ) {
                    Console.Write( "CONTINUE, " );
                    continue;
                }

                Console.Write($"{i}, ");
            }

            Console.WriteLine("Saliste del for");

            for ( int i = 0; i < 10; i++ ) {
                if ( i == 3 ) {
                    Console.Write( "BREAK, " );
                    break;
                }

                Console.Write( $"{i}, " );
            }

            Console.WriteLine( "Saliste del for" );
        }
    }
}
