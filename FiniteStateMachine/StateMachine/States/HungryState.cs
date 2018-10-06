using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine.States
{
    public class HungryState : BaseState
    {
        public HungryState()
        {

            _Name = "Hungry";
            Start = EnterHungry;
            Update = UpdateHungry;
            End = ExitHungry;
            
        }

        public HungryState(Enter S, Execute U, Exit E)
        {

            _Name = "Hungry";
            Start = S;
            Update = U;
            End = E;

        }

        public void EnterHungry()
        {

            Console.WriteLine("I'm Hungry");

        }

        public void UpdateHungry()
        {

            Console.WriteLine("Feed me!");

        }

        public void ExitHungry()
        {

            Console.WriteLine("I'm not hungry anymore");

        }

    }
}
