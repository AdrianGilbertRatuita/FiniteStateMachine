using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{
    /// <summary>
    /// A Revertible Finite State Machine class
    /// that can rever back to a previous state
    /// </summary>
    public class RevertibleFiniteStateMachine : OneState_FiniteStateMachine
    {

        // Determines if instance can revert to previous state
        private bool Revertable;

        public RevertibleFiniteStateMachine(bool CanRevert) : base()
        {

            Revertable = CanRevert;

        }

        // Revert to previous state
        public void RevertState()
        {

            if (Revertable)
            {

                ChangeState(PreviousState);

            }

        }

    }
}
