using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PorSalud.Web.Models
{
    public class AddPersonModel
    {
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int NumeroIhss { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}