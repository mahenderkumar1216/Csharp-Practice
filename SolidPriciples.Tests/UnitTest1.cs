using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPriciples.InterfaceSegregation.Configuration1;
using SolidPriciples.InterfaceSegregation.Configuration2;
namespace SolidPriciples.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void DisplayApplicationNameFromFile()
        {
            // still works via file
            ConfigurationSettings settings = new ConfigurationSettings();
            var aboutPage = new InterfaceSegregation.Configuration2.AboutPage(ConfigurationSettings.Settings); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }
    }
}
