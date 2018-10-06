using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineTesting.Entity
{
    public abstract class BaseEntity : IEntity
    {

        private static int NextID = 0;
        
        // Entity Fields
        private int _EntityID;
        private string _Entityname;

        public int EntityID { get { return _EntityID; } }
        public string EntityName { get { return _Entityname; } set { _Entityname = value; } }

        public BaseEntity(string Name)
        {

            // Set ID to NextID
            _EntityID = NextID;

            //Increment ID
            NextID++;

            // Set Entity Name
            _Entityname = Name;

        }

    }
}
