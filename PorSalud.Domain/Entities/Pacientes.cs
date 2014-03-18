using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PorSalud.Domain.Entities
{
    public class Pacientes : IEntity
    {
        public virtual long Id { get; set; }
        public virtual bool IsArchived { get; set; }
        
    }
}
