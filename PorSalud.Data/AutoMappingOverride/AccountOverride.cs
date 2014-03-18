using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using PorSalud.Domain.Entities;

namespace PorSalud.Data.AutoMappingOverride
{
    internal class AccountOverride : IAutoMappingOverride<User>
    {
        public void Override(AutoMapping<User> mapping)
        {
            /* mapping.HasMany(x => x.Referrals)
                 .Inverse()
                 .Access.CamelCaseField(Prefix.Underscore);*/
        }
    }
}
