using System.Collections.Generic;
using DomainDrivenDatabaseDeployer;
using FizzWare.NBuilder;
using MiniDropbox.Domain;
using NHibernate;
using PorSalud.Domain.Entities;

namespace PorSalud.DatabaseDeployer
{
    public class AccountSeeder : IDataSeeder
    {
        private readonly ISession _session;

        public AccountSeeder(ISession session)
        {
            _session = session;
        }

        public void Seed()
        {
            
        }
    }
}