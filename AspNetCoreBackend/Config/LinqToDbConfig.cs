using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreBackend.Config
{
    public class AppLinq2DBSettings : ILinqToDBSettings
    {
        private readonly string _connectionString;
        private readonly string _defaultConfiguration = "PostgreSql";
        private readonly string _defaultDataProvider = "PostgreSql";

        public AppLinq2DBSettings(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => _defaultConfiguration;

        public string DefaultDataProvider => _defaultDataProvider;

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = _defaultConfiguration,
                        ProviderName = _defaultDataProvider,
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
