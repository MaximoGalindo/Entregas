using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
    class Colas:IColleccion
    {
        List<object> lCola = new List<object>();
        
        public bool estaVacia()
        {
            for (int i = 0; i < lCola.Count; i++)
            {
                if (lCola[i] == null)
                    return true;
            }
            return false;
        }

        public object extraer(int ultimo)
        {
            object ultimaCola = null;
            for (int i = 0; i < lCola.Count; i++)
            {
                ultimaCola = lCola[ultimo];
                lCola[ultimo] = null;
            }
            return ultimaCola;
        }

        public object primero()
        {
            int primero = 0;
            object Primero = null;
            for (int i = 0; i < lCola.Count; i++)
            {
                Primero = lCola[primero];
                lCola[primero] = new object();
            }
            return Primero;
        }

        public bool añadir(int numero)
        {
                lCola.Add(numero);
                return true;
        }

    }
}
