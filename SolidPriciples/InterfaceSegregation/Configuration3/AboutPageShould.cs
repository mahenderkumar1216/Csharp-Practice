using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SolidPriciples.InterfaceSegregation.Configuration3
{
    public class AboutPageShould
    {
        [TestClass]
        public class Settings : IApplicationIdentitySettings
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
}