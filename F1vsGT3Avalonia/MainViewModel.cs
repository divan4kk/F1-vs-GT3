using System.Collections.ObjectModel;
using System.Linq;

namespace F1vsGT3Avalonia
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<string> Tracks { get; } = new ObservableCollection<string>();

        private string selectedCarClass = "";
        public string SelectedCarClass
        {
            get => selectedCarClass;
            set { selectedCarClass = value; OnPropertyChanged(); }
        }

        private string selectedTrack = "";
        public string SelectedTrack
        {
            get => selectedTrack;
            set { selectedTrack = value; OnPropertyChanged(); }
        }

        private string speedResult;
        private string driverResult;
        private string teamResult;
        private string yearResult;

        public string SpeedResult { get => speedResult; set { speedResult = value; OnPropertyChanged(); } }
        public string DriverResult { get => driverResult; set { driverResult = value; OnPropertyChanged(); } }
        public string TeamResult { get => teamResult; set { teamResult = value; OnPropertyChanged(); } }
        public string YearResult { get => yearResult; set { yearResult = value; OnPropertyChanged(); } }

        public MainViewModel()
        {
            foreach (var t in TrackStatsRepository.Stats)
                Tracks.Add(t.TrackName);
        }

        public void Compare()
        {
            if (string.IsNullOrEmpty(SelectedCarClass) || string.IsNullOrEmpty(SelectedTrack))
            {
                SpeedResult = "Please select car class and track.";
                DriverResult = TeamResult = YearResult = "";
                return;
            }

            var stat = TrackStatsRepository.Stats.FirstOrDefault(t => t.TrackName == SelectedTrack);
            if (stat == null)
            {
                SpeedResult = $"No data for track {SelectedTrack}.";
                DriverResult = TeamResult = YearResult = "";
                return;
            }

            var p = SelectedCarClass == "F1" ? stat.F1Pole : stat.GT3Pole;
            SpeedResult = $"{SelectedCarClass} Pole Time: {p.Time}";
            DriverResult = $"Driver(s): {p.Driver}";
            TeamResult = $"Team: {p.Team}";
            YearResult = $"Year: {p.Year}";
        }
    }
}
