using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SolidPriciples.InterfaceSegregation.Configuration1
{
    public class ConfigurationSettings : ConfigurationSection, IConfigurationSettings
    {
        private static ConfigurationSettings _configurationSettings = ConfigurationManager.GetSection("ConfigurationSettings") as ConfigurationSettings;

        public static ConfigurationSettings Settings
        {
            get
            {
                return _configurationSettings;
            }
        }

        [ConfigurationProperty("ApplicationName", IsRequired = true)]

        public string ApplicationName
        {
            get
            {
                return (string)this["ApplicationName"];
            }
            set
            {
                this["ApplicationName"] = value;
            }
        }

        [ConfigurationProperty("AuthorName", IsRequired = true)]
        public string AuthorName
        {
            get
            {
                return (string)this["AuthorName"];
            }
            set { this["AuthorName"] = value; }
        }

        [ConfigurationProperty("CacheDuration", IsRequired = true)]
        public int CacheDuration
        {
            get { return 0; }
        }

        [ConfigurationProperty("DatabaseServerName", IsRequired = true)]
        public string DatabaseServerName
        {
            get
            {
                return (string)this["DatabaseServerName"];
            }
            set { this["DatabaseServerName"] = value; }
        }

        [ConfigurationProperty("DatabaseName", IsRequired = true)]
        public string DatabaseName
        {
            get
            {
                return (string)this["DatabaseName"];
            }
            set { this["DatabaseName"] = value; }
        }

        [ConfigurationProperty("DatabaseUserName", IsRequired = true)]
        public string DatabaseUserName
        {
            get
            {
                return (string)this["DatabaseUserName"];
            }
            set { this["DatabaseUserName"] = value; }
        }

        [ConfigurationProperty("DatabasePassword", IsRequired = true)]
        public string DatabasePassword
        {
            get
            {
                return (string)this["DatabasePassword"];
            }
            set { this["DatabasePassword"] = value; }
        }

        [ConfigurationProperty("WebServiceBaseUri", IsRequired = true)]
        public string WebServiceBaseUri
        {
            get
            {
                return (string)this["WebServiceBaseUri"];
            }
            set { this["WebServiceBaseUri"] = value; }
        }
    }
}