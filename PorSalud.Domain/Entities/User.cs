
namespace PorSalud.Domain.Entities
{
    public class User : IEntity
    {
        public virtual long Id { get; set; }
        public virtual bool IsArchived { get; set; }
        public virtual Personas Persona { get; set; }
        public virtual string Password { get; set; }
        public virtual string UserName { get; set; }
    }
}