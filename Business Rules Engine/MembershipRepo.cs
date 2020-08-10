using Infra.Entities;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Rules_Engine
{
    public class MembershipRepo : IMembership
    {
        public Membership MemberId { get; set; }

                
        public bool ActivateMembership()
        {
            Console.WriteLine("Activated Membership Sucessfully");

            return true;
        }

        public bool UpgradeMemmbership()
        {
            Console.WriteLine("Activated Membership Sucessfully");

            return true;
        }
    }
}
