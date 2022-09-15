using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
    public class Pilas : IColleccion
    {
        public object[] lnumeros = new object[10];      
        int ultimo = 0;

        public bool estaVacia()
        {
            for (int i = 0; i < lnumeros.Length; i++)
            {
                if (lnumeros[i] == null)
                    return true;
            }
            return false;
        }

        public object extraer(int ultimo)
        {
            object ultimoObjeto;               
            ultimoObjeto = lnumeros[ultimo];
            lnumeros[ultimo] = null;
            return ultimoObjeto;               
        }

        public object primero()
        {
           return lnumeros[0];
            
        }

        public bool añadir(int numero)
        {
            if (ultimo < lnumeros.Length)
            {
                lnumeros[ultimo] = numero;
                ultimo++;
                return true;
            }
            return false;
        }
              
    }
}
