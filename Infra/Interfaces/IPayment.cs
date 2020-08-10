using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Interfaces
{
   public interface IPayment
    {

        bool CommissionPayment();


        bool MemberShipPaymnet();

        bool UpgradeMembershipPayment();
      


                          
    }
}
