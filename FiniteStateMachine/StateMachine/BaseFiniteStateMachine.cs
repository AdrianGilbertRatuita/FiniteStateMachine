using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{
    public abstract class BaseFiniteStateMachine : IStateMachine
    {

        // All Possible States
        public List<IState> States { get; protected set; }
        public IState CurrentState { get; protected set; }
        public IState PreviousState { get; protected set; }

        public BaseFiniteStateMachine()
        {

            States = new List<IState>();
        }

        public virtual void AddState(IState NewState)
        {

            States.Add(NewState);

        }

        public virtual void AddStates(List<IState> NewStates)
        {

            States.AddRange(NewStates);

        }

        public virtual void RemoveState(IState StateToRemove)
        {

            States.Remove(StateToRemove);

        }

        public virtual void ClearStates()
        {

            States.Clear();

        }

        public virtual void EnterState()
        {

            CurrentState.Start();

        }

        public virtual void UpdateState()
        {

            CurrentState.Update();

        }

        public virtual void ExitState()
        {

            CurrentState.End();

        }

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

    }
}
