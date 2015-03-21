using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auditing.Core
{
    public sealed class SystemInfo
    {
        public string MachineSourceId { get; set; }

        public string ComponentVersion { get; set; }

        public override string ToString()
        {
            return string.Format("MachineSourceId: {0}, ComponentVersion: {1}", MachineSourceId, ComponentVersion);
        }
    }
}
