using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class WhatsappNotificationService : INotificationService
    {
        public void SendOTP(string medium)
        {
            Console.WriteLine("OTP through Whatsapp");
        }
    }
}
