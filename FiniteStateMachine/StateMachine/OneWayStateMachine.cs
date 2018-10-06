using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;

namespace StateMachineTesting.StateMachine
{
    public class OneWayStateMachine : IStateMachine
    {

        private static int StateCounter = 0;

        public List<IState> States { get; protected set; }

        public IState CurrentState { get; protected set; }

        public IState PreviousState { get; protected set; }

        // OneWayStateMachine MUST start with a List that is NOT null
        public OneWayStateMachine(List<IState> StateList)
        {

            try
            {
                //
                if (States != null)
                {

                    States = StateList;
                    CurrentState = States[StateCounter];

                }
                else if (States == null)
                {

                    NullThrow();

                }

            }
            catch(StateNull StateIsNull)
            {

                while(MessageBox.Show(StateIsNull.ToString(), "StateList Null", MessageBoxButtons.OK, MessageBoxIcon.Warning) != DialogResult.OK)
                {

                    Environment.Exit(1);

                }
                
            }

        }

        public void NextState()
        {

            // Make sure state counter will not go out of bound of state list
            if (StateCounter != States.Count)
            {

                // Set current state as previous state
                PreviousState = CurrentState;

                // End Current State
                CurrentState.End();

                // Increment State Counter
                StateCounter++;

                // Set next state on the list as CurrentState
                CurrentState = States[StateCounter];

                // Start new State
                CurrentState.Start();

            }
            else if (StateCounter >= States.Count)
            {

                if (CurrentState != null)
                {

                    // 
                    PreviousState = null;

                    //
                    CurrentState.End();

                    //
                    CurrentState = null;

                }

                //
                StateCounter++;

            }

        }

        private static void NullThrow()
        {

            StateNull NullException = new StateNull("StateList cannot be null!");
            throw NullException;

        }

    }

    [Serializable]
    public class StateNull : Exception
    {
        public StateNull() { }
        public StateNull(string message) : base(message) { }
        public StateNull(string message, Exception inner) : base(message, inner) { }
        protected StateNull(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
