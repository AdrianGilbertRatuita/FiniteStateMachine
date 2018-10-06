using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{

    /// <summary>
    /// A finite state machine that can only have state active at a time
    /// </summary>
    public class OneState_FiniteStateMachine : BaseFiniteStateMachine
    {

        public IState CurrentState { get; protected set; }
        public IState PreviousState { get; protected set; }

        public void ExecuteCurrentState()
        {

            CurrentState.Update();

        }

        // Change Current State
        public virtual void ChangeState(IState NewState)
        {

            // Make sure NewState is in States List
            // and NewState is owned by the same Source
            if (States.Contains(NewState))
            {

                // Exit Current State
                CurrentState.End();

                // Current State is now Previous State
                PreviousState = CurrentState;

                // Passed State is now Current State
                CurrentState = NewState;

                // Current State Start
                CurrentState.Start();

            }

        }

        public virtual void ChangeState(string StateName)
        {

            for (int i = 0; i < States.Count; i++)
            {

                if (States[i].Name == StateName)
                {

                    CurrentState.End();

                    // Current State is now Previous State
                    PreviousState = CurrentState;

                    // Passed State is now Current State
                    CurrentState = States[i];

                    // Current State Start
                    CurrentState.Start();

                }

            }

        }

    }

}
