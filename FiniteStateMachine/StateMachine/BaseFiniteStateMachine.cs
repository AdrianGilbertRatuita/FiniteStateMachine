using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{

    /// <summary>
    /// Base Finite State Machine with basic FiniteStateMachine functions
    /// </summary>
    public abstract class BaseFiniteStateMachine : IStateMachine
    {

        // All Possible States
        public List<IState> States { get; protected set; }

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

        public void RemoveState(string StateName)
        {

            int StateIndex = -1;

            for (int i = 0; i < States.Count; i++)
            {

                if (States[i].Name == StateName)
                {

                    StateIndex = i;

                }

            }

            if (StateIndex != -1)
            {

                States.RemoveAt(StateIndex);

            }

        }

        public virtual void ClearStates()
        {

            States.Clear();

        }

    }
}
