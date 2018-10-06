using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;
using StateMachineTesting.StateMachine.States;

namespace StateMachineTesting.Entity.MortalStates
{
    public class MortalDeadState : DeadState, IMortalState
    {

        public IMortal Owner { get; private set; }

        public MortalDeadState(IMortal Source) : base()
        {

            Owner = Source;
            Start = EnterDeath;
            Update = CheckDeath;

        }

        public MortalDeadState(Enter S, Execute U, IMortal Source) : base(S, U)
        {

            Owner = Source;

        }

        public void EnterDeath()
        {

            Console.WriteLine($"{Owner.Name} is Dead!");

        }

        public void CheckDeath()
        {

            Console.WriteLine($"{Owner.Name} is already dead.");

        }

    }
}
