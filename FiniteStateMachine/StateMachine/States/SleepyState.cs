using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiniteStateMachine.Entity;

namespace StateMachineTesting.StateMachine.States
{
    public class SleepyState : BaseState
    {

        public SleepyState()
        {

            _Name = "Sleepy";
            Start = EnterSleepy;
            Update = UpdateSleepy;
            End = ExitSleepy;

        }

        public SleepyState(Enter S, Execute U, Exit E)
        {

            _Name = "Sleepy";
            Start = S;
            Update = U;
            End = E;

        }

        public void EnterSleepy()
        {

            Console.WriteLine("I'm getting Sleepy");
            
        }

        public void UpdateSleepy()
        {

            Console.WriteLine("I need to sleep!");

        }

        public void ExitSleepy()
        {

            Console.WriteLine("I'm wide awake now");

        }

    }

}
