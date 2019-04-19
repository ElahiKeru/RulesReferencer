using RuleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = RuleLibrary.Rule;

namespace RulesReferencer
{
    public partial class RulesReferencer : Form
    {
        //private fields
        private RuleCollection fullRuleset;
        private RuleCollection searchedRuleset;

        /// <summary>
        /// constructor of the form
        /// </summary>
        public RulesReferencer()
        {
            InitializeComponent();
        }

        #region CustomMethods
        /// <summary>
        /// Populates the Rules ListView object with the provided RuleCollection object
        /// </summary>
        /// <param name="collection">RuleCollection to be processed into the Rules ListView object</param>
        private void PopulateRulesList(RuleCollection collection)
        {
            LVRulesList.Items.Clear();
            foreach(Rule r in collection.Rules)
            {
                LVRulesList.Items.Add(r.Title);
            }
        }

        /// <summary>
        /// Searches through the full rules collection for any Rule objects which contain the search term in their title or their text.
        /// </summary>
        /// <param name="searchTerm"></param>
        private void SearchRules(string searchTerm)
        {
            searchedRuleset = new RuleCollection();
            foreach(Rule r in fullRuleset)
            {
                if(r.Title.ToUpper().Contains(searchTerm.ToUpper()) || r.Details.ToUpper().Contains(searchTerm.ToUpper()))
                {
                    searchedRuleset.Add(r);
                }
            }
            PopulateRulesList(searchedRuleset);
        }
        #endregion

        #region Events
        private void RulesReferencer_Load(object sender, EventArgs e)
        {
            //fill the rule collection
            fullRuleset = new RuleCollection(@"DND5ERulesList.xml");

            //populate the controls
            PopulateRulesList(fullRuleset);
        }

        private void LVRulesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBRuleDetails.Text = fullRuleset[LVRulesList.FocusedItem.Text].Details;
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TBSearchTerm.Text))
            {
                SearchRules(TBSearchTerm.Text);
            }
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            TBSearchTerm.Text = "";
            PopulateRulesList(fullRuleset);
        }
        #endregion
    }
}
