using System;

namespace TemperatureLibrary
{
    public class Temperature
    {
        public static bool IsSottoZero(int n)
        {
            bool resp;
            if (n < 0)
                resp = true;
            else resp = false;
            return resp;
        }
    }
}
