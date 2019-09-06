using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings
{
    public static class TemperatureConversions
    {
        public static double CtoF(double inTemp)
        {
            return ((inTemp * (9.0 / 5.0) + 32));
        }

        public static double FtoC(double inTemp)
        {
            return ((inTemp - 32) * (5.0 / 9.0));
        }
    }
}
