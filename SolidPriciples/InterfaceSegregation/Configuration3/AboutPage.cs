using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SolidPriciples.InterfaceSegregation.Configuration3
{
    [TestClass]
    public class AboutPage
    {
        private readonly IApplicationIdentitySettings _applicationIdentitySettings;

        public AboutPage(IApplicationIdentitySettings applicationIdentitySettings)
        {
            _applicationIdentitySettings = applicationIdentitySettings;
        }

        public AboutPage() : this(Configuration1.ConfigurationSettings.Settings)
        { }
       
        public void Render(TextWriter writer)
        {
            writer.Write("{0} By {1}",
                _applicationIdentitySettings.ApplicationName,
                _applicationIdentitySettings.AuthorName);
        }
    }

    public interface IApplicationIdentitySettings
    {
        string ApplicationName { get; }
        string AuthorName { get; }
    }
}