using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateMachineTesting.Entity;

namespace StateMachineTesting.Entity.MortalStates
{
    public interface IMortalState
    {

        IMortal Owner { get; }

    }

}
