using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PorSalud.Domain.Entities
{
    public class Personas : IEntity
    {
        public virtual long Id { get; set; }
        public virtual bool IsArchived { get; set; }
        public virtual string Nombres { get; set; }
        public virtual string PrimerApellido { get; set; }
        public virtual string SegundoApellido { get; set; }
        public virtual int NumeroIhss { get; set; }
        public virtual DateTime FechaIngreso { get; set; }
    }
}
