using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreBackend.Configs
{
    public class AppLinq2DBSettings : ILinqToDBSettings
    {
        private readonly string _connectionString;
        public const string DEFAULT_CONFIGURATION = "AppDB";
        public const string DEFAULT_DATA_PROVIDER = "PostgreSQL";

        public AppLinq2DBSettings(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => DEFAULT_CONFIGURATION;

        public string DefaultDataProvider => DEFAULT_DATA_PROVIDER;

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = DEFAULT_CONFIGURATION,
                        ProviderName = DEFAULT_DATA_PROVIDER,
                        ConnectionString = this._connectionString
                    };
            }
        }
    }

    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

}
