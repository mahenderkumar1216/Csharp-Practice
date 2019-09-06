using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPriciples.InterfaceSegregation.Configuration1;

namespace SolidPriciples.InterfaceSegregation.Configuration2
{
    [TestClass]
    public class AboutPage
    {
        private readonly IConfigurationSettings _configurationSettings;

        public AboutPage(IConfigurationSettings configurationSettings)
        {
            _configurationSettings = configurationSettings;
        }

        public AboutPage():this(ConfigurationSettings.Settings)
        { }

        public void Render(TextWriter writer)
        {
            writer.Write("{0} By {1}",
                _configurationSettings.ApplicationName,
                _configurationSettings.AuthorName);
        }

        [TestMethod]
        public void DisplayApplicationNameFromFile()
        {
            // still works via file
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }
    }

    [TestClass]
    public class Settings : IConfigurationSettings
    {
        public string ApplicationName
        {
            get
            {
                return "TEST APP NAME";
            }
        }

        public string AuthorName
        {
            get
            {
                return "TEST AUTHOR NAME";
            }
        }

        #region Not Implemented
        public int CacheDuration => throw new NotImplementedException();

        public string DatabaseServerName => throw new NotImplementedException();

        public string DatabaseName => throw new NotImplementedException();

        public string DatabaseUserName => throw new NotImplementedException();

        public string DatabasePassword => throw new NotImplementedException();

        public string WebServiceBaseUri => throw new NotImplementedException();
#endregion

        [TestMethod]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage(new Settings());
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("TEST APP NAME By TEST AUTHOR NAME", output);
        }
    }
}