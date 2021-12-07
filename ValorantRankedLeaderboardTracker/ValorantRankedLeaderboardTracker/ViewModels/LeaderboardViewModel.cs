using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.ValRankedV1;


namespace ValorantRankedLeaderboardTracker
{
    class LeaderboardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RiotApi RiotApi { get; set; }
        public BindingList<Player> Players { get; set; }
        public string Shard { get; set; }
        public string ActId { get; set; }
        public long TotalPlayers { get; set; }

        public LeaderboardViewModel(RiotApi riotApi = null)
        {
            RiotApi = riotApi;
        }

        
    }
}
