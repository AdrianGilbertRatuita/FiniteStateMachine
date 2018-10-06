using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;
using StateMachineTesting.StateMachine.States;

namespace StateMachineTesting.Entity.MortalStates
{
    public class MortalAliveState : AliveState, IMortalState
    {

        public IMortal Owner { get; private set; }

        public MortalAliveState(Enter S, Execute U, Exit E, IMortal Source) : base(S, U, E)
        {

            Owner = Source;

        }

        public MortalAliveState(Execute U, IMortal Source) : base(U)
        {

            Owner = Source;
            Start = EnterAlive;
            End = EnterDeath;

        }

        public void EnterAlive()
        {

            Console.WriteLine($"{Owner.Name} was born!");

        }

        public void EnterDeath()
        {

            Console.WriteLine($"{Owner.Name} is dying!");

        }


    }

}
