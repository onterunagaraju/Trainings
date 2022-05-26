using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class NotificationService
    {
        public void SendOTP(string medium)
        {
            if (medium.Equals("email"))
            {
                Console.WriteLine("OTP through email");
            }

            if (medium.Equals("phone"))
            {
                Console.WriteLine("OTP through phone");
            }

        }
    }
}
