using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Dashboard
{
    public class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        }

        public string getConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void saveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "FirebirdSql.Data.FirebirdClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
