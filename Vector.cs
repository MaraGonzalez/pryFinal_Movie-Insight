using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFinal_Movie_Insight
{
    internal class Vector
    {
        public struct RegistroGenero
        {
            public Int32 Codigo;
            public string Nombre;
            public string Descripcion;

            public RegistroGenero(int codigo, string nombre, string descripcion)
            {
                Codigo = codigo;
                Nombre = nombre;
                Descripcion = descripcion;
            }
        }


        public static RegistroGenero[] Generos = new RegistroGenero[10];
        public static Int32 IND;

        public static string[] Meses = new string[12]
        {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };
    }
   
}


