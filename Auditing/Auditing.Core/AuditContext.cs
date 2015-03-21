using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditing.Core
{
    public abstract class AuditContext
    {
        protected AuditContext(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }

        public abstract SystemInfo SystemInfo { get; set; }
    }
}
