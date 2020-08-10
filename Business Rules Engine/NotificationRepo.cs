using Infra.Entities;
using Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Rules_Engine
{
    public class NotificationRepo : INotifications
    {
        public Notification NotificationId { get; set; }
        public bool ActivationUpgradeNotifcation()
        {
            Console.WriteLine("Activation/Upgarde Notification Sent");
            return true;
        }
    }
}
