using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RuleLibrary
{
    public class RuleCollection : IEnumerable<Rule>
    {
        private readonly string rulePath;
        private List<Rule> rules;

        public List<Rule> Rules
        {
            get
            {
                if(rules == null)
                {
                    rules = new List<Rule>();
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

            XmlNodeList rules = inputDoc.GetElementsByTagName("rule");

            foreach(XmlNode xn in rules)
            {
                Rules.Add(new Rule(xn["title"].InnerText, xn["details"].InnerText));
            }
        }

        public IEnumerator<Rule> GetEnumerator()
        {
            return Rules.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Rules.GetEnumerator();
        }

        public Rule this[string index]
        {
            get
            {
                if (rules == null) rules = new List<Rule>();
                Rule target = null;
                foreach(Rule r in rules)
                {
                    if (r.Title.Equals(index))
                    {
                        target = r;
                    }
                }
                return target;
            }
        }

        public Rule this[int index]
        {
            get
            {
                if (rules == null) rules = new List<Rule>();
                return rules[index];
            }
        }

        public void Add(Rule target)
        {
            Rules.Add(target);
        }

        public void Remove(string target)
        {
            Rules.Remove(this[target]);
        }
    }
}
