using Business_Rules_Engine;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.UnitTests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void ActivateMembershipTest()
        {

            MembershipRepo mr = new MembershipRepo();

            var result = mr.ActivateMembership();

            Assert.AreEqual(result, true);
        }

        [TestMethod()]
        public void UpgradeMemmbershipTest()
        {

            MembershipRepo mr = new MembershipRepo();

            var result = mr.UpgradeMemmbership();

            Assert.AreEqual(result, true);


        }
    }
}



