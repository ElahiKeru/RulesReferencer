namespace RulesReferencer
{
    partial class RulesReferencer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBSearchTerm = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.LVRulesList = new System.Windows.Forms.ListView();
            this.LBLSearch = new System.Windows.Forms.Label();
            this.TBRuleDetails = new System.Windows.Forms.TextBox();
            this.BTNClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBSearchTerm
            // 
            this.TBSearchTerm.Location = new System.Drawing.Point(12, 33);
            this.TBSearchTerm.Name = "TBSearchTerm";
            this.TBSearchTerm.Size = new System.Drawing.Size(182, 22);
            this.TBSearchTerm.TabIndex = 0;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(200, 33);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 23);
            this.BTNSearch.TabIndex = 1;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // LVRulesList
            // 
            this.LVRulesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVRulesList.Location = new System.Drawing.Point(12, 61);
            this.LVRulesList.Name = "LVRulesList";
            this.LVRulesList.Size = new System.Drawing.Size(182, 464);
            this.LVRulesList.TabIndex = 2;
            this.LVRulesList.UseCompatibleStateImageBehavior = false;
            this.LVRulesList.View = System.Windows.Forms.View.List;
            this.LVRulesList.SelectedIndexChanged += new System.EventHandler(this.LVRulesList_SelectedIndexChanged);
            // 
            // LBLSearch
            // 
            this.LBLSearch.AutoSize = true;
            this.LBLSearch.Location = new System.Drawing.Point(13, 13);
            this.LBLSearch.Name = "LBLSearch";
            this.LBLSearch.Size = new System.Drawing.Size(57, 17);
            this.LBLSearch.TabIndex = 4;
            this.LBLSearch.Text = "Search:";
            // 
            // TBRuleDetails
            // 
            this.TBRuleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBRuleDetails.Location = new System.Drawing.Point(201, 62);
            this.TBRuleDetails.Multiline = true;
            this.TBRuleDetails.Name = "TBRuleDetails";
            this.TBRuleDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBRuleDetails.Size = new System.Drawing.Size(833, 463);
            this.TBRuleDetails.TabIndex = 5;
            // 
            // BTNClear
            // 
            this.BTNClear.Location = new System.Drawing.Point(282, 32);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(75, 23);
            this.BTNClear.TabIndex = 6;
            this.BTNClear.Text = "Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // RulesReferencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 537);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.TBRuleDetails);
            this.Controls.Add(this.LBLSearch);
            this.Controls.Add(this.LVRulesList);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.TBSearchTerm);
            this.Name = "RulesReferencer";
            this.Text = "D&D 5E Rules Reference";
            this.Load += new System.EventHandler(this.RulesReferencer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSearchTerm;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.ListView LVRulesList;
        private System.Windows.Forms.Label LBLSearch;
        private System.Windows.Forms.TextBox TBRuleDetails;
        private System.Windows.Forms.Button BTNClear;
    }
}

