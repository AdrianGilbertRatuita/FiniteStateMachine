using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.StateMachine;
using StateMachineTesting.StateMachine.States;

namespace StateMachineTesting.Entity
{

    /// <summary>
    /// IMortal Interface
    /// Interface for Mortal Classes
    /// <see cref="HP"/>
    /// <see cref="Hunger"/>
    /// <see cref="Fatique"/>
    /// <see cref="Stress"/>
    /// <see cref="Name"/>
    /// <see cref="Alive"/>
    /// <see cref="LivingStates"/>
    /// <see cref="NeedsStates"/>
    /// <see cref="SetupLivingStates"/>
    /// <see cref="SetupNeedsStates"/>
    /// </summary>

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
        ParallelStates_FiniteStateMachine NeedsStates { get; }

        //
        void SetupLivingStates();
        void SetupNeedsStates();

    }

}
