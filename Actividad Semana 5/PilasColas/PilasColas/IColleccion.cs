using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas
{
    interface IColleccion
    {
        bool estaVacia();
        object extraer(int ultimo);
        object primero();
        bool añadir(int valor);
    }
}
