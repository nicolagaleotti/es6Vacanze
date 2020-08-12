using System;
using System.Collections.Generic;

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

        public static int ContaSottoZero (int[] array)
        {
            int resp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    resp++;
            }
            return resp;
        }

        public static int[] Minime (int[] array)
        {
            List<int> negativi = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    negativi.Add(array[i]);
            }
            int[] resp = new int[negativi.Count];
            for (int i = 0; i < resp.Length; i ++)
            {
                resp[i] = negativi[i];
            }
            return resp;
        }
    }
}
