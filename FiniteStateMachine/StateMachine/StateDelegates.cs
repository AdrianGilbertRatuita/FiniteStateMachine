using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineTesting.StateMachine
{

    // Delegate functions for States
    public delegate void Enter();
    public delegate void Execute();
    public delegate void Exit();

}