using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EnitityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public  EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();
        //abstract method has no implementation
        //Must be implemented by the derived class/Child class
        public abstract bool Validate();
    }
}
