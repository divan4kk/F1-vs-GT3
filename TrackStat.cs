namespace F1vsGT3Web
{
    public class TrackStat
    {
        public string TrackName { get; set; }

        public PoleInfo F1Pole { get; set; }
        public PoleInfo GT3Pole { get; set; }

        public class PoleInfo
        {
            public string Driver { get; set; }
            public string Team { get; set; }
            public string Time { get; set; }
            public int Year { get; set; }
        }
    }
}
