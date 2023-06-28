using System;
using System.Collections.Generic;
using System.Text;

namespace Semana14Carlos.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
