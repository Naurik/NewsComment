using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using DbUp;
using System.Reflection;
using System.Data.SqlClient;

namespace NewsComment
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStringConfiguration = ConfigurationManager.ConnectionStrings["NewsConnection"];
            var connectionString = connectionStringConfiguration.ConnectionString;

            #region Migration
            EnsureDatabase.For.SqlDatabase(connectionString);
            var upgrader = DeployChanges.To.SqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .LogToConsole()
            .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful) throw new Exception("Миграция не удалась");
            #endregion
        }
    }
}
