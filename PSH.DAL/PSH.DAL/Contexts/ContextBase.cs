using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSH.DAL.Contexts
{
    public abstract class ContextBase : DbContext, IContextBase
    {
        public ContextBase() : base("DefaultConnection"){}
    }
}
