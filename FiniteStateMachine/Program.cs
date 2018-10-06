using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace StateMachineTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            //float Time = 0;
            //DateTime Now = DateTime.Now;

            //while (Time > -1)
            //{

            //    if (Now.Second != DateTime.Now.Second)
            //    {

            //        Time++;
            //        Now = DateTime.Now;

            //    }

            //    Console.WriteLine(Time);

            //}
            NonStaticMain NewMain = new NonStaticMain();
            NewMain.Main();

        }
    }
}
