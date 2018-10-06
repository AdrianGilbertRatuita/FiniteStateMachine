using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineTesting.StateMachine.States
{
    public class StressedState : BaseState
    {

        public StressedState()
        {

            _Name = "Stressed";
            Start = EnterSleepy;
            Update = UpdateSleepy;
            End = ExitSleepy;

        }

        public StressedState(Enter S, Execute U, Exit E)
        {

            _Name = "Stressed";
            Start = S;
            Update = U;
            End = E;

        }

        public void EnterSleepy()
        {

            Console.WriteLine("I'm stressed out");

        }

        public void UpdateSleepy()
        {

            Console.WriteLine("I'm still stressed!");

        }

        public void ExitSleepy()
        {

            Console.WriteLine("I'm relaxed now");

        }

    }
}