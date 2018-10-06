using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.Entity
{
    public interface IEntity
    {

        int EntityID { get; }
        string EntityName { get; set; }

    }
}
