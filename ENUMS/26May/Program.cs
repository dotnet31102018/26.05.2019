using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26May
{
    class Program
    {
        static void Main(string[] args)
        {
            LightSwitchState state = LightSwitchState.ON;
            Console.WriteLine((int)state);

            Enum.GetNames(typeof(LightSwitchState)).ToList().ForEach(s => Console.WriteLine(s));

            LightSwitchState[] arr = (LightSwitchState[] )Enum.GetValues(typeof(LightSwitchState));

            Enum.TryParse("OFF", out LightSwitchState result);
            Console.WriteLine(result);
        }
    }
}
