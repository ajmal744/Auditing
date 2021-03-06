﻿using System.Diagnostics;
using System.Reflection;

namespace Auditing.Core
{
    public class AssemblyFileVersionProvider : IFileVersionProvider
    {
        private string executingAssemblyFileVersion = string.Empty;
        private string currentExecutingAssemblyLocation = string.Empty;

        public string CurrentAssemblyLocation
        {
            get
            {
                if (!string.IsNullOrEmpty(currentExecutingAssemblyLocation))
                {
                    return currentExecutingAssemblyLocation;
                }
                return currentExecutingAssemblyLocation = Assembly.GetExecutingAssembly().Location;
            }

            set
            {
                currentExecutingAssemblyLocation = value;
            }
        }

        public string GetExecutingAssemblyFileVersion()
        {
            if (!string.IsNullOrEmpty(executingAssemblyFileVersion))
            {
                return executingAssemblyFileVersion;
            }

            executingAssemblyFileVersion = FileVersionInfo.GetVersionInfo(CurrentAssemblyLocation).FileVersion;
            return executingAssemblyFileVersion;
        }
    }
}