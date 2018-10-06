using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineTesting.StateMachine
{

    public interface IState
    {

        string Name { get; }
        Enter Start { get; }
        Execute Update { get; }
        Exit End { get; }

    }

}