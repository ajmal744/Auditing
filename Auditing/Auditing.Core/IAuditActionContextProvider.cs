using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auditing.Core
{
    public interface IAuditActionContextProvider
    {
        AuditContext GetContext();
    }
}
