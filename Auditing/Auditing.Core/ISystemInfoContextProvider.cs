using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditing.Core
{
    public interface ISystemInfoContextProvider
    {
        SystemInfo GetSystemInfo();
    }
}
