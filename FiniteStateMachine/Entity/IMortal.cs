using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;
using StateMachineTesting.StateMachine.States;

namespace StateMachineTesting.Entity
{
    public interface IMortal
    {

        //
        int HP { get; }
        int Hunger { get; }
        int Fatique { get; }
        int Stress { get; }
        string Name { get; }
        bool Alive { get; }
        OneWayStateMachine LivingStates { get; }
        StandardFiniteStateMachine NeedsStates { get; }

        //
        void SetupLivingStates();
        void SetupNeedsStates();

    }
}
