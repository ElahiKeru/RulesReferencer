using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RuleLibrary
{
    public class RuleCollection : IEnumerable<RuleRef>
    {
        private readonly string rulePath;
        private List<RuleRef> rules;

        public List<RuleRef> Rules
        {
            get
            {
                if(rules == null)
                {
                    rules = new List<RuleRef>();
                }
                return rules;
            }
            private set
            {
                rules = value;
            }
        }

        public RuleCollection(string xmlPath)
        {
            rulePath = xmlPath;
            ProcessRulesList();
        }

        public RuleCollection()
        {

        }

        private void ProcessRulesList()
        {
            XmlDocument inputDoc = new XmlDocument();
            inputDoc.Load(rulePath);

            XmlNodeList ruleset = inputDoc.GetElementsByTagName("rule");

            foreach(XmlNode xn in ruleset)
            {
                Rules.Add(new RuleRef(xn["title"].InnerText, xn["details"].InnerText));
            }
        }

        public IEnumerator<RuleRef> GetEnumerator()
        {
            return Rules.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Rules.GetEnumerator();
        }

        public RuleRef this[string index]
        {
            get
            {
                if (rules == null) rules = new List<RuleRef>();
                RuleRef target = null;
                foreach(RuleRef r in rules)
                {
                    if (r.Title.Equals(index))
                    {
                        target = r;
                    }
                }
                return target;
            }
        }

        public RuleRef this[int index]
        {
            get
            {
                if (rules == null) rules = new List<RuleRef>();
                return rules[index];
            }
        }

        public void Add(RuleRef target)
        {
            Rules.Add(target);
        }

        public void Remove(string target)
        {
            Rules.Remove(this[target]);
        }
    }
}
