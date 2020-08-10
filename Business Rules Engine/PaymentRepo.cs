using Infra.Interfaces;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Rules_Engine
{
    public class PaymentRepo : IPayment
    {
        public bool CommissionPayment()
        {
            Console.WriteLine("Made commission Payment");
            return true;
        }

        public bool MemberShipPaymnet()
        {
            Console.WriteLine("Made Membership Payment");
            return true;
        }

        public bool UpgradeMembershipPayment()
        {

            Console.WriteLine("Upgrade Membership Payment Recieved");

            return true;
        }
    }
}
