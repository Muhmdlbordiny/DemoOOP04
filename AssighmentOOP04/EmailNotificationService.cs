using AssighmentOOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssighmentOOP04
{
    public class EmailNotificationService : INotificationService
    {
      public string EMail {  get; set; }
       

        public string SendNotification(string message)
        {
            return ($"Congratluation please check your Email {EMail} ,{message}");
        }
    }
}
