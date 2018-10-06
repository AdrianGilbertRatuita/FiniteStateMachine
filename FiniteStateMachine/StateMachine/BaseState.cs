using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineTesting.StateMachine
{
    public abstract class BaseState : IState
    {

        // Name Field
        protected string _Name;

        // State Name
        public string Name { get { return _Name; } }

        // Delegate Handlers
        public Enter Start { get; protected set; }
        public Execute Update { get; protected set; }
        public Exit End { get; protected set; }

        // Function to supply to delegates to pass
        // to deliberately empty delegates
        protected void EmptyDelegate() { }

    }


}