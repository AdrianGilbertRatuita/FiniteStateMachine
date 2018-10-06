using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{
    public class RevertibleFiniteStateMachine : BaseFiniteStateMachine
    {

        private bool Revertable;

        public RevertibleFiniteStateMachine(bool CanRevert) : base()
        {

            Revertable = CanRevert;

        }

        public void RevertState()
        {

            if (Revertable)
            {

                ChangeState(PreviousState);

            }

        }

    }
}
