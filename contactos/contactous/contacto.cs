using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactous
{
    public class contacto
    {
        public string name { get; set; }
        public string number { get; set; }

        public contacto(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public override string ToString()
        {
            return $"{name} - {number}"; // Mostrar nombre y número juntos
        }
    }
}
