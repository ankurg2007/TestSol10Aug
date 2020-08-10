using Business_Rules_Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.UnitTests
{

    [TestClass()]
    class NotificationRepoTests
    {


        [TestMethod()]
        public void ActivationUpgradeNotifcationTest()
        {
            NotificationRepo notificationRepo = new NotificationRepo();

            var result = notificationRepo.ActivationUpgradeNotifcation();
            Assert.AreEqual(result, true);
        }

      
    }
}
