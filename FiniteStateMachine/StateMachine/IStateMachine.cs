using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;

namespace StateMachineTesting.StateMachine
{
    public interface IStateMachine
    {

        List<IState> States { get; }
        IState CurrentState { get; }
        IState PreviousState { get; }

    }

}
