using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebAppFramework.Controllers;

namespace WebAppFramework.Unit.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_Success()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.GetType(), typeof(ViewResult));
        }
    }
}
