using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EkoopDataSync.Data
{
    public class SqlHelper
    {
        public static SqlConnection SqlCon = new SqlConnection();
        public static SqlCommand SqlCommand = new SqlCommand();
        public static SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();
        public static IDbConnection MasterConnection => new SqlConnection(new Connection().ConnectionString);
    }

    public class Connection
    {
        public string DbSource { get; set; } = ConfigurationManager.AppSettings.Get("Data Source");
        public string Database { get; set; } = ConfigurationManager.AppSettings.Get("Database");
        public string UserId { get; set; } = ConfigurationManager.AppSettings.Get("UserId");
        public string Password { get; set; } = ConfigurationManager.AppSettings.Get("Password"); 

        public string ConnectionString
        {
            get
            {
                var sqlAuth = new SqlConnectionStringBuilder
                {
                    DataSource = DbSource,
                    InitialCatalog = Database,
                    UserID = UserId,
                    Password = Password,
                    ConnectTimeout = 1000
                };

                if (!string.IsNullOrEmpty(sqlAuth.UserID)) return sqlAuth.ToString();
                var winAuth = new SqlConnectionStringBuilder
                {
                    DataSource = DbSource,
                    InitialCatalog = Database,
                    IntegratedSecurity = true
                };
                return winAuth.ToString();
            }
        }
    }    
}
