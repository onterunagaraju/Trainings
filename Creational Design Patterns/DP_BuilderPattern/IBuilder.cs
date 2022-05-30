﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BuilderPattern
{
    internal interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }
}
