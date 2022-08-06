using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSEjercicios {
    #region Contenido a estudiar
    /*
     * ¿Qué es un IEnumarable y un Enumerator?
     */
    #endregion
    internal class Empresa : IEnumerable<string> {
        public string NombreEmpresa { get; set; } = "Sara Juegos";

        private List<string> _empleados = new List<string>() {
            "Juan", "Maria", "Pablo", "Ana"
        };

        public IEnumerator<string> GetEnumerator() {
            return new EnumeradorEmpresa(_empleados);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }

    class EnumeradorEmpresa : IEnumerator<string> {
        List<string> _nombres = new List<string>();

        private int _index = -1;

        public EnumeradorEmpresa(List<string> nombres) {
            _nombres = nombres;
        }

        public bool MoveNext() {
            _index++;
            return _index < _nombres.Count;
        }

        public void Reset() {
            _index = -1;
        }

        public string Current {
            get { 
                return _nombres[_index];
            } 
        }

        public void Dispose() {
            
        }

        object IEnumerator.Current {
            get { 
                return _nombres[_index];
            } 
        }
    }
}
