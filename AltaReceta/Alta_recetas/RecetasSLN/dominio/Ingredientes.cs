using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Ingredientes
    {
        public int IngredienteID { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }

        public Ingredientes(int ingredienteID, string nombre, string unidad)
        {
            IngredienteID = ingredienteID;
            Nombre = nombre;
            Unidad = unidad;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
