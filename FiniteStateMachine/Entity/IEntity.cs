using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.Entity
{

    /// <summary>
    /// Basic IEntity Interface
    /// <para>
    /// <see cref="EntityID"/>,
    /// <see cref="EntityName"/>
    /// </para>
    /// </summary>
    public interface IEntity
    {

        int EntityID { get; }
        string EntityName { get; set; }

    }
}
