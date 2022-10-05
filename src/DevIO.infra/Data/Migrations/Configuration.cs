
using DevIO.infra.Data.Context;
using System.Data.Entity.Migrations;

namespace DevIO.infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    }
}
