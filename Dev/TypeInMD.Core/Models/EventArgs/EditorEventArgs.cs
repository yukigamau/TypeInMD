using Newtonsoft.Json.Linq;

namespace TypeInMD.Core.Models
{
    public class EditorEventArgs : global::System.EventArgs
    {
        public string Name { get; }

        public JToken Args { get; }

        public EditorEventArgs(string name, JToken args)
        {
            Name = name;
            Args = args;
        }
    }
}
