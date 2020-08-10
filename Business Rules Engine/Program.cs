using System;


namespace Business_Rules_Engine
{
   public class Program
    {
       
        
        
        static void Main(string[] args)
        {
            // call Methods as required here
            MembershipRepo membershipRepo = new MembershipRepo();
            membershipRepo.ActivateMembership();
        }
    }
}
