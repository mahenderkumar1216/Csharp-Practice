using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SolidPriciples.InterfaceSegregation.Configuration1
{
    [TestClass]
    public class AboutPageShould
    {
        [TestMethod]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }
    }
}