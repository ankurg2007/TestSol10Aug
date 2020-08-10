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
    class PaymentRepoTests
    {
        [TestMethod()]
        public void CommissionPaymentTest()
        {

          PaymentRepo pr = new PaymentRepo();
                
          var result = pr.CommissionPayment();

          Assert.AreEqual(result, true);

        }
        [TestMethod()]
        public void MemberShipPaymnetTest()
        {
            PaymentRepo pr = new PaymentRepo();

            var result = pr.MemberShipPaymnet();

            Assert.AreEqual(result, true);

        }
        [TestMethod()]
        public void UpgradeMembershipPaymentTest()
        {
            PaymentRepo pr = new PaymentRepo();

            var result = pr.UpgradeMembershipPayment();

            Assert.AreEqual(result, true);

        }


                                    
    }
}
