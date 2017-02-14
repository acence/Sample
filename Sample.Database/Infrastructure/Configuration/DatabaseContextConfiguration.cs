using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Database.Infrastructure.Configuration
{
    class DatabaseContextConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        public DatabaseContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
