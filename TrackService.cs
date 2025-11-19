using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace F1vsGT3Web
{
    public class TrackService
    {
        private readonly List<TrackStat> _tracks = new()
        {
            new TrackStat
            {
                TrackName = "Monza",
                F1Pole = new TrackStat.PoleInfo
                {
                    Driver = "Oscar Piastri",
                    Team = "McLaren",
                    Time = "1:19.958",
                    Year = 2025
                },
                GT3Pole = new TrackStat.PoleInfo
                {
                    Driver = "Raffaele Marciello",
                    Team = "AKKA ASP (Mercedes AMG GT3)",
                    Time = "1:50.234",
                    Year = 2024
                }
            },

            new TrackStat
            {
                TrackName = "Spa-Francorchamps",
                F1Pole = new TrackStat.PoleInfo
                {
                    Driver = "Oscar Piastri",
                    Team = "McLaren",
                    Time = "1:40.510",
                    Year = 2025
                },
                GT3Pole = new TrackStat.PoleInfo
                {
                    Driver = "Franck Perera",
                    Team = "Grasser Racing Team (Lamborghini Huracán GT3)",
                    Time = "2:13.718",
                    Year = 2024
                }
            },

            new TrackStat
            {
                TrackName = "Nürburgring",
                F1Pole = new TrackStat.PoleInfo
                {
                    Driver = "Valtteri Bottas",
                    Team = "Mercedes",
                    Time = "1:25.269",
                    Year = 2020
                },
                GT3Pole = new TrackStat.PoleInfo
                {
                    Driver = "Kévin Estre / Thomas Preining / Ayhancan Güven",
                    Team = "Manthey EMA (Porsche 911 GT3 R)",
                    Time = "8:12.741",
                    Year = 2025
                }
            },

            new TrackStat
            {
                TrackName = "Red Bull Ring",
                F1Pole = new TrackStat.PoleInfo
                {
                    Driver = "Lando Norris",
                    Team = "McLaren",
                    Time = "1:03.971",
                    Year = 2025
                },
                GT3Pole = new TrackStat.PoleInfo
                {
                    Driver = "Jürgen Alzen",
                    Team = "H&R Spezialfedern (BMW M4 GT3)",
                    Time = "1:27.272",
                    Year = 2025
                }
            }
        };

        // ⬇️ Саме цього методу не вистачає
        public Task<List<TrackStat>> GetTracksAsync()
        {
            // імітація асинхронності
            return Task.FromResult(_tracks);
        }
    }
}
