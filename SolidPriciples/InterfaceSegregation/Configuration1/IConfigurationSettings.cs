using SolidPriciples.InterfaceSegregation.Configuration3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.InterfaceSegregation.Configuration1
{
    public interface IConfigurationSettings: IApplicationIdentitySettings
    {
       
        int CacheDuration { get; }

        // data access settings
        string DatabaseServerName { get; }
        string DatabaseName { get; }
        string DatabaseUserName { get; }
        string DatabasePassword { get; }

        // web service api settings
        string WebServiceBaseUri { get; }
    }
}
