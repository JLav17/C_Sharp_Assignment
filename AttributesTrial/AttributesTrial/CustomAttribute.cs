using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesTrial
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple =false) ]
    class CustomAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string Version { get; }

        public CustomAttribute(string developerName, string version)
        {
            DeveloperName = developerName;
            Version = version;
        }

    }




}
