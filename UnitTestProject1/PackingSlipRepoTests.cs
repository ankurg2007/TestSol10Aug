using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Rules_Engine;
using Infra.Entities;

namespace UnitTestProject1.UnitTests
{

    [TestClass()]
    class PackingSlipRepoTests
    {


        [TestMethod()]
        public void AddFeeVideoTest(PackingSlip p)
        {

            PackingSlipRepo packingSlipRepo = new PackingSlipRepo();
           var result = packingSlipRepo.AddFeeVideo(p);

            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void GenerateDuplicatePackingSlipTest(PackingSlip p)
        {
            PackingSlipRepo mr = new PackingSlipRepo();

            var result = mr.GenerateDuplicatePackingSlip(p);

            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void GeneratePackingSlip()
        {
            PackingSlipRepo mr = new PackingSlipRepo();

            var result = mr.GeneratePackingSlip();
        
             Assert.AreEqual(result, true);

        }




    }
}
