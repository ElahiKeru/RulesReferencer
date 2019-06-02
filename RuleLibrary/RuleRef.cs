using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleLibrary
{
    public class RuleRef
    {
        public string Title { get; private set; }
        public string Details { get; private set; }

        public RuleRef(string title, string details)
        {
            Title = title;
            Details = details;
        }
    }
}
