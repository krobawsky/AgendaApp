using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp
{
    public class Contacto
    {
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
