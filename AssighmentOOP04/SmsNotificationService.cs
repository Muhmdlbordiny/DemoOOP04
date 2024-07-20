using AssighmentOOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssighmentOOP04
{
    public class SmsNotificationService : INotificationService
    {
        public string SMs {  get; set; }
       

        public string SendNotification(string message)
        {
            return ($"Check on SMS {SMs} , {message}");
        }
    }
}
