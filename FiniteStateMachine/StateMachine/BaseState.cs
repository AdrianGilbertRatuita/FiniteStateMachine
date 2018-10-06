using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineTesting.StateMachine
{
    public abstract class BaseState : IState
    {

        // Owner Field
        protected string _Name;

        //
        public string Name { get { return _Name; } }

        //
        public Enter Start { get; protected set; }
        public Execute Update { get; protected set; }
        public Exit End { get; protected set; }
        protected void EmptyDelegate() { }

    }


}