using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine.States;

namespace StateMachineTesting.Entity.MortalStates
{
    public class MortalHungryState : HungryState, IMortalState
    {
        public IMortal Owner { get; private set; }

        public MortalHungryState()
        {



        }

        public void EnterHungry()
        {



        }

        public void ExecuteHungry()
        {


        }

        public void ExitHungry()
        {



        }

    }

}
