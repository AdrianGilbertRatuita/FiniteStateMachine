using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    public interface IEntity
    {

        int EntityID { get; }
        string EntityName { get; set; }

    }
}
