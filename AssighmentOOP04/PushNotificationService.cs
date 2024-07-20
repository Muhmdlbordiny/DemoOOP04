using AssighmentOOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssighmentOOP04
{
    public class PushNotificationService : INotificationService
    {
       

        public string SendNotification(string message)
        {
            return ($"Push Message is a {message}");
        }
    }
}
