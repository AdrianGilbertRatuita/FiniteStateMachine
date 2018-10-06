using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.StateMachine
{
    /// <summary>
    /// Finite State Machine class that can have multiple current states
    /// at a single time.
    /// </summary>
    public class ParallelStates_FiniteStateMachine : BaseFiniteStateMachine
    {

        // Collection of current states can run Parrallel to one another
        public List<IState> CurrentStates { get; protected set; }

        /// <summary>
        /// Add a State that exists within inherited <see cref="States"/> List
        /// </summary>
        /// <param name="ParallelState"></param>
        public void AddCurrentState(IState ParallelState)
        {

            // Make sure States has this the State to add to CurrentStates
            if (States.Contains(ParallelState))
            {

                // Add from CurrentStates List
                CurrentStates.Add(ParallelState);

                // Call State Start
                ParallelState.Start();

            }

        }

        /// <summary>
        /// If State Name is known and it exists within the States List.
        /// Add it to the <see cref="CurrentStates"/> List.
        /// </summary>
        /// <param name="StateName"></param>
        public void AddCurrentState(string StateName)
        {

            for(int i = 0; i < States.Count; i++)
            {

                if (States[i].Name == StateName)
                {

                    CurrentStates.Add(States[i]);

                    States[i].Start();

                }

            }

        }

        /// <summary>
        /// Remove a state that exists within <see cref="CurrentStates"/> List.
        /// </summary>
        /// <param name="ParallelState"></param>
        public void RemoveCurrentState(IState ParallelState)
        {

            // Make sure States has this the State to remove to CurrentStates
            if (CurrentStates.Contains(ParallelState))
            {

                // Remove from CurrentStates List
                CurrentStates.Remove(ParallelState);

                // Call State End
                ParallelState.End();

            }

        }

        /// <summary>
        /// Remove current state by name in <see cref="CurrentStates"/> List.
        /// </summary>
        /// <param name="StateName"></param>
        public void RemoveCurrentState(string StateName)
        {

            int StateIndex = -1;

            for (int i = 0; i < States.Count; i++)
            {

                if (CurrentStates[i].Name == StateName)
                {

                    StateIndex = i;

                    CurrentStates[i].End();

                }

            }

            if (StateIndex != -1)
            {

                CurrentStates.RemoveAt(StateIndex);

            }

        }

        /// <summary>
        /// Execute all states currently in <see cref="CurrentStates"/> List.
        /// </summary>
        public void ExecuteStates()
        {

            foreach(IState S in CurrentStates)
            {

                S.Update();

            }

        }

        /// <summary>
        /// Clear <see cref="CurrentStates"/> List.
        /// </summary>
        public void ClearCurrentStates()
        {

            CurrentStates.Clear();

        }

    }

}
