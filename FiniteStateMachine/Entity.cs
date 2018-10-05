using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    public class Entity : IEntity
    {
        private int _EntityID;
        private string _Entityname;

        public int EntityID { get { return _EntityID; } }

        public string EntityName { get { return _Entityname; } set { _Entityname = value; } }

    }
}
