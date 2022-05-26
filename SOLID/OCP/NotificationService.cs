using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal interface INotificationService
    {
         void SendOTP(string meduim);
    }
}
