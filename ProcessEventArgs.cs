using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class ProcessEventArgs: EventArgs
    {
        public List<int> FindResult { get; set; }
        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
    }
}
