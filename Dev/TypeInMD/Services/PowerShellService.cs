using System;
using System.Collections.Generic;
using TypeInMD.Core.Interfaces;

namespace TypeInMD.Services
{
    public class PowerShellService : IPowerShellService
    {
        public IEnumerable<string> Invoke(string script, string command, params string[] parameters)
        {
            //using var powerShell = PowerShell.Create();
            //powerShell.AddScript(script);
            //powerShell.Invoke();
            //powerShell.Commands.Clear();
            //powerShell.AddCommand(command).AddParameters(parameters);
            //var result = powerShell.Invoke();
            //return result.Select(x => x.ToString());
            throw new NotImplementedException("NotImplemented");
        }
    }
}
