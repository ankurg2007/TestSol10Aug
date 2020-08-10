using Infra.Entities;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Rules_Engine
{
    public class PackingSlipRepo : IPackingSlip
    {
       
        public bool AddFeeVideo(PackingSlip P)
        {
            Console.WriteLine("Free Video Added");
            return true;
        }

        public bool GenerateDuplicatePackingSlip(PackingSlip P)
        {
            Console.WriteLine("Generated DuplicatePackingSlip");
            return true;
        }

        public bool GeneratePackingSlip()
        {
            Console.WriteLine("Generated PackingSlip");
            return true;
        }
    }
}
