using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditing.Core
{
    public class SystemInfoContextProvider : ISystemInfoContextProvider
    {
        private readonly string assemblyVersion;
        private static readonly string machineSource = Dns.GetHostName();

        public SystemInfoContextProvider(IFileVersionProvider fileVersionProvider)
        {
            this.assemblyVersion = fileVersionProvider.GetExecutingAssemblyFileVersion();
        }

        public SystemInfoContextProvider(string assemblyVersion)
        {
            this.assemblyVersion = assemblyVersion;
        }

        public SystemInfo GetSystemInfo()
        {
            return new SystemInfo
            {
                ComponentVersion = this.assemblyVersion,
                MachineSourceId = machineSource
            };
        }
    }
}
