using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class MobileNotificationService : INotificationService
    {
        public void SendOTP(string medium)
        {
            Console.WriteLine("OTP through mobile");
        }
    }
}
