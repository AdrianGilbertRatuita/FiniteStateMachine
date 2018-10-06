using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine.States
{
    public class AliveState : BaseState
    {

        protected AliveState(Execute U)
        {

            _Name = "Alive";
            Update = U;

        }

        public AliveState(Enter S, Execute U, Exit E)
        {

            _Name = "Alive";
            Start = S;
            Update = U;
            End = E;

        }

    }
}
