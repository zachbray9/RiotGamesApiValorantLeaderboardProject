using System;
using System.ComponentModel;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.ValRankedV1;

namespace ValorantRankedLeaderboardTracker
{
    public partial class MainForm : Form
    {
        internal LeaderboardViewModel viewModel { get; private set; }
        public MainForm()
        {
            InitializeComponent();

            viewModel = new LeaderboardViewModel();
            viewModelBindingSource.DataSource = viewModel;
        }

        private void executeRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.RiotApi = RiotApi.NewInstance(apiKeyTextBox.Text);
                Region region = MingweiSamuel.Camille.Enums.Region.GetValorant(regionComboBox.SelectedItem.ToString());
                var leaderboard = viewModel.RiotApi.ValRankedV1.GetLeaderboard(region, "a16955a5-4ad0-f761-5e9e-389df1c892fb", 200, 0);

                viewModel.Players = new BindingList<Player>(leaderboard.Players);
                viewModel.Shard = leaderboard.Shard;
                viewModel.ActId = leaderboard.ActId;
                viewModel.TotalPlayers = leaderboard.TotalPlayers;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid query parameter", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leaderBoardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
