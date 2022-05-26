using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder carBuilder = new Car("Ford");
            IBuilder motorCycleBuilder = new MotorCycle("Honda");

            // Making Car
            director.Construct(carBuilder);
            Product carProduct = carBuilder.GetVehicle();
            carProduct.Show();

            //Making MotorCycle
            director.Construct(motorCycleBuilder);
            Product motorCycleProduct = motorCycleBuilder.GetVehicle();
            motorCycleProduct.Show();

            Console.ReadLine();
        }


    }
}
