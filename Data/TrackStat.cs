using System.Collections.Generic;
using System.Linq;

namespace F1vsGT3Web.Data
{
    public class TrackStat
    {
        public string TrackName { get; set; }
        public string F1Driver { get; set; }
        public string F1Team { get; set; }
        public string F1Time { get; set; }
        public int F1Year { get; set; }
        public string GT3Driver { get; set; }
        public string GT3Team { get; set; }
        public string GT3Time { get; set; }
        public int GT3Year { get; set; }
    }

    public class TrackStatsRepository
    {
        public List<TrackStat> Stats { get; set; } = new List<TrackStat>();

        public TrackStatsRepository(List<TrackStat> stats)
        {
            Stats = stats;
        }

        public TrackStat GetTrack(string trackName) =>
            Stats.FirstOrDefault(t => t.TrackName == trackName);
    }
}
