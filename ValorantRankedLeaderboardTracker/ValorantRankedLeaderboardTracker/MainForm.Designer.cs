
namespace ValorantRankedLeaderboardTracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.leaderBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.leaderBoardListBox = new System.Windows.Forms.ListBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.rankedRatingTextBox = new System.Windows.Forms.TextBox();
            this.rankedRatingLabel = new System.Windows.Forms.Label();
            this.tagLineTextBox = new System.Windows.Forms.TextBox();
            this.tagLineLabel = new System.Windows.Forms.Label();
            this.puuidTextBox = new System.Windows.Forms.TextBox();
            this.puuidLabel = new System.Windows.Forms.Label();
            this.gameNameTextBox = new System.Windows.Forms.TextBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.numberOfWinsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfWinsLabel = new System.Windows.Forms.Label();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.queryParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.executeRequestButton = new System.Windows.Forms.Button();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.actComboBox = new System.Windows.Forms.ComboBox();
            this.actLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.leaderBoardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).BeginInit();
            this.playerDetailsGroupBox.SuspendLayout();
            this.queryParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaderBoardGroupBox
            // 
            this.leaderBoardGroupBox.Controls.Add(this.leaderBoardListBox);
            this.leaderBoardGroupBox.Location = new System.Drawing.Point(12, 117);
            this.leaderBoardGroupBox.Name = "leaderBoardGroupBox";
            this.leaderBoardGroupBox.Size = new System.Drawing.Size(274, 321);
            this.leaderBoardGroupBox.TabIndex = 0;
            this.leaderBoardGroupBox.TabStop = false;
            this.leaderBoardGroupBox.Text = "Leaderboard (Top 200)";
            // 
            // leaderBoardListBox
            // 
            this.leaderBoardListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playersBindingSource, "GameName", true));
            this.leaderBoardListBox.DataSource = this.playersBindingSource;
            this.leaderBoardListBox.DisplayMember = "GameName";
            this.leaderBoardListBox.FormattingEnabled = true;
            this.leaderBoardListBox.Location = new System.Drawing.Point(6, 19);
            this.leaderBoardListBox.Name = "leaderBoardListBox";
            this.leaderBoardListBox.Size = new System.Drawing.Size(262, 290);
            this.leaderBoardListBox.TabIndex = 0;
            this.leaderBoardListBox.ValueMember = "GameName";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.viewModelBindingSource;
            // 
            // viewModelBindingSource
            // 
            this.viewModelBindingSource.DataSource = typeof(ValorantRankedLeaderboardTracker.LeaderboardViewModel);
            // 
            // playerDetailsGroupBox
            // 
            this.playerDetailsGroupBox.Controls.Add(this.rankedRatingTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.rankedRatingLabel);
            this.playerDetailsGroupBox.Controls.Add(this.tagLineTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.tagLineLabel);
            this.playerDetailsGroupBox.Controls.Add(this.puuidTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.puuidLabel);
            this.playerDetailsGroupBox.Controls.Add(this.gameNameTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.gameNameLabel);
            this.playerDetailsGroupBox.Controls.Add(this.numberOfWinsTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.numberOfWinsLabel);
            this.playerDetailsGroupBox.Controls.Add(this.rankTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.rankLabel);
            this.playerDetailsGroupBox.Location = new System.Drawing.Point(292, 117);
            this.playerDetailsGroupBox.Name = "playerDetailsGroupBox";
            this.playerDetailsGroupBox.Size = new System.Drawing.Size(496, 321);
            this.playerDetailsGroupBox.TabIndex = 1;
            this.playerDetailsGroupBox.TabStop = false;
            this.playerDetailsGroupBox.Text = "Player Details";
            // 
            // rankedRatingTextBox
            // 
            this.rankedRatingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "RankedRating", true));
            this.rankedRatingTextBox.Location = new System.Drawing.Point(108, 234);
            this.rankedRatingTextBox.Name = "rankedRatingTextBox";
            this.rankedRatingTextBox.ReadOnly = true;
            this.rankedRatingTextBox.Size = new System.Drawing.Size(382, 20);
            this.rankedRatingTextBox.TabIndex = 11;
            // 
            // rankedRatingLabel
            // 
            this.rankedRatingLabel.AutoSize = true;
            this.rankedRatingLabel.Location = new System.Drawing.Point(6, 237);
            this.rankedRatingLabel.Name = "rankedRatingLabel";
            this.rankedRatingLabel.Size = new System.Drawing.Size(82, 13);
            this.rankedRatingLabel.TabIndex = 10;
            this.rankedRatingLabel.Text = "Ranked Rating:";
            // 
            // tagLineTextBox
            // 
            this.tagLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "TagLine", true));
            this.tagLineTextBox.Location = new System.Drawing.Point(108, 187);
            this.tagLineTextBox.Name = "tagLineTextBox";
            this.tagLineTextBox.ReadOnly = true;
            this.tagLineTextBox.Size = new System.Drawing.Size(382, 20);
            this.tagLineTextBox.TabIndex = 9;
            // 
            // tagLineLabel
            // 
            this.tagLineLabel.AutoSize = true;
            this.tagLineLabel.Location = new System.Drawing.Point(7, 187);
            this.tagLineLabel.Name = "tagLineLabel";
            this.tagLineLabel.Size = new System.Drawing.Size(52, 13);
            this.tagLineLabel.TabIndex = 8;
            this.tagLineLabel.Text = "Tag Line:";
            // 
            // puuidTextBox
            // 
            this.puuidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Puuid", true));
            this.puuidTextBox.Location = new System.Drawing.Point(108, 137);
            this.puuidTextBox.Name = "puuidTextBox";
            this.puuidTextBox.ReadOnly = true;
            this.puuidTextBox.Size = new System.Drawing.Size(382, 20);
            this.puuidTextBox.TabIndex = 7;
            // 
            // puuidLabel
            // 
            this.puuidLabel.AutoSize = true;
            this.puuidLabel.Location = new System.Drawing.Point(6, 137);
            this.puuidLabel.Name = "puuidLabel";
            this.puuidLabel.Size = new System.Drawing.Size(37, 13);
            this.puuidLabel.TabIndex = 6;
            this.puuidLabel.Text = "Puuid:";
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "GameName", true));
            this.gameNameTextBox.Location = new System.Drawing.Point(108, 84);
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.ReadOnly = true;
            this.gameNameTextBox.Size = new System.Drawing.Size(382, 20);
            this.gameNameTextBox.TabIndex = 5;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Location = new System.Drawing.Point(6, 87);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(69, 13);
            this.gameNameLabel.TabIndex = 4;
            this.gameNameLabel.Text = "Game Name:";
            // 
            // numberOfWinsTextBox
            // 
            this.numberOfWinsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "NumberOfWins", true));
            this.numberOfWinsTextBox.Location = new System.Drawing.Point(108, 283);
            this.numberOfWinsTextBox.Name = "numberOfWinsTextBox";
            this.numberOfWinsTextBox.ReadOnly = true;
            this.numberOfWinsTextBox.Size = new System.Drawing.Size(382, 20);
            this.numberOfWinsTextBox.TabIndex = 3;
            // 
            // numberOfWinsLabel
            // 
            this.numberOfWinsLabel.AutoSize = true;
            this.numberOfWinsLabel.Location = new System.Drawing.Point(7, 286);
            this.numberOfWinsLabel.Name = "numberOfWinsLabel";
            this.numberOfWinsLabel.Size = new System.Drawing.Size(86, 13);
            this.numberOfWinsLabel.TabIndex = 2;
            this.numberOfWinsLabel.Text = "Number of Wins:";
            // 
            // rankTextBox
            // 
            this.rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "LeaderboardRank", true));
            this.rankTextBox.Location = new System.Drawing.Point(108, 33);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.ReadOnly = true;
            this.rankTextBox.Size = new System.Drawing.Size(76, 20);
            this.rankTextBox.TabIndex = 1;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(6, 36);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(99, 13);
            this.rankLabel.TabIndex = 0;
            this.rankLabel.Text = "Leaderboard Rank:";
            // 
            // queryParametersGroupBox
            // 
            this.queryParametersGroupBox.Controls.Add(this.executeRequestButton);
            this.queryParametersGroupBox.Controls.Add(this.regionComboBox);
            this.queryParametersGroupBox.Controls.Add(this.regionLabel);
            this.queryParametersGroupBox.Controls.Add(this.actComboBox);
            this.queryParametersGroupBox.Controls.Add(this.actLabel);
            this.queryParametersGroupBox.Controls.Add(this.apiKeyTextBox);
            this.queryParametersGroupBox.Controls.Add(this.apiKeyLabel);
            this.queryParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.queryParametersGroupBox.Name = "queryParametersGroupBox";
            this.queryParametersGroupBox.Size = new System.Drawing.Size(776, 99);
            this.queryParametersGroupBox.TabIndex = 2;
            this.queryParametersGroupBox.TabStop = false;
            this.queryParametersGroupBox.Text = "Query Parameters";
            // 
            // executeRequestButton
            // 
            this.executeRequestButton.Location = new System.Drawing.Point(662, 70);
            this.executeRequestButton.Name = "executeRequestButton";
            this.executeRequestButton.Size = new System.Drawing.Size(108, 23);
            this.executeRequestButton.TabIndex = 6;
            this.executeRequestButton.Text = "Execute Request";
            this.executeRequestButton.UseVisualStyleBackColor = true;
            this.executeRequestButton.Click += new System.EventHandler(this.executeRequestButton_Click);
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "",
            "NA",
            "BR",
            "EU",
            "KR",
            "LATAM"});
            this.regionComboBox.Location = new System.Drawing.Point(559, 40);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(82, 21);
            this.regionComboBox.TabIndex = 5;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(509, 43);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Region:";
            // 
            // actComboBox
            // 
            this.actComboBox.FormattingEnabled = true;
            this.actComboBox.Location = new System.Drawing.Point(379, 39);
            this.actComboBox.Name = "actComboBox";
            this.actComboBox.Size = new System.Drawing.Size(100, 21);
            this.actComboBox.TabIndex = 3;
            // 
            // actLabel
            // 
            this.actLabel.AutoSize = true;
            this.actLabel.Location = new System.Drawing.Point(347, 43);
            this.actLabel.Name = "actLabel";
            this.actLabel.Size = new System.Drawing.Size(26, 13);
            this.actLabel.TabIndex = 2;
            this.actLabel.Text = "Act:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(61, 40);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(262, 20);
            this.apiKeyTextBox.TabIndex = 1;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(7, 43);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(48, 13);
            this.apiKeyLabel.TabIndex = 0;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryParametersGroupBox);
            this.Controls.Add(this.playerDetailsGroupBox);
            this.Controls.Add(this.leaderBoardGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ValorantRankedLeaderboardTracker";
            this.leaderBoardGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).EndInit();
            this.playerDetailsGroupBox.ResumeLayout(false);
            this.playerDetailsGroupBox.PerformLayout();
            this.queryParametersGroupBox.ResumeLayout(false);
            this.queryParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox leaderBoardGroupBox;
        private System.Windows.Forms.ListBox leaderBoardListBox;
        private System.Windows.Forms.GroupBox playerDetailsGroupBox;
        private System.Windows.Forms.TextBox puuidTextBox;
        private System.Windows.Forms.Label puuidLabel;
        private System.Windows.Forms.TextBox gameNameTextBox;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.TextBox numberOfWinsTextBox;
        private System.Windows.Forms.Label numberOfWinsLabel;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.GroupBox queryParametersGroupBox;
        private System.Windows.Forms.Label tagLineLabel;
        private System.Windows.Forms.TextBox rankedRatingTextBox;
        private System.Windows.Forms.Label rankedRatingLabel;
        private System.Windows.Forms.TextBox tagLineTextBox;
        private System.Windows.Forms.Button executeRequestButton;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox actComboBox;
        private System.Windows.Forms.Label actLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.BindingSource viewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
    }
}

