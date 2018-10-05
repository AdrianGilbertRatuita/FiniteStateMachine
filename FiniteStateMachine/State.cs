using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiniteStateMachine
{
    public class State : IState
    {

        object _Owner;
        delegate void Start();
        delegate void Update();
        delegate void End();

        public object Owner { get { return _Owner; } }

        Start Enter;
        Update Execute;
        End Exit;

        State(object Source, Start S, Update U, End E)
        {

            _Owner = Source;
            Enter = S;
            Execute = U;
            Exit = E;

        }

    }
}