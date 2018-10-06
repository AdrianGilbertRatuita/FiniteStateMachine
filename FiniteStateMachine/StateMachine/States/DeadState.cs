using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine.States
{
    public class DeadState : BaseState
    {
        protected DeadState()
        {

            _Name = "Dead";
            Start = EmptyDelegate;
            Update = EmptyDelegate;
            End = EmptyDelegate;

        }

        public DeadState(Enter S, Execute U)
        {

            _Name = "Dead";
            Start = S;
            Update = U;
            End = EmptyDelegate;

        }

    }
}
