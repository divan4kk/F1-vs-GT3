using System.Collections.Generic;

namespace F1vsGT3Avalonia
{
    public static class TrackStatsRepository
    {
        public static List<TrackStat> Stats = new List<TrackStat>
        {
            // --- Існуючі ---
            new TrackStat
            {
                TrackName = "Autodromo Nazionale Monza",
                F1Pole = new TrackStat.PoleInfo { Driver = "Oscar Piastri", Team = "McLaren Formula 1 Team", Time = "1:19.958", Year = 2025 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Raffaele Marciello", Team = "AKKA ASP Team (Mercedes-AMG GT3)", Time = "1:50.234", Year = 2024 }
            },
            new TrackStat
            {
                TrackName = "Circuit de Spa-Francorchamps",
                F1Pole = new TrackStat.PoleInfo { Driver = "Oscar Piastri", Team = "McLaren Formula 1 Team", Time = "1:40.510", Year = 2025 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Franck Perera", Team = "Grasser Racing Team (Lamborghini Huracán GT3)", Time = "2:13.718", Year = 2024 }
            },
            new TrackStat
            {
                TrackName = "Nürburgring Grand Prix Strecke",
                F1Pole = new TrackStat.PoleInfo { Driver = "Valtteri Bottas", Team = "Mercedes-AMG Petronas Formula One Team", Time = "1:25.269", Year = 2020 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Kévin Estre / Preining / Güven", Team = "Manthey EMA (Porsche 911 GT3 R)", Time = "8:12.741", Year = 2025 }
            },
            new TrackStat
            {
                TrackName = "Red Bull Ring",
                F1Pole = new TrackStat.PoleInfo { Driver = "Lando Norris", Team = "McLaren Formula 1 Team", Time = "1:03.971", Year = 2025 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Jürgen Alzen", Team = "H&R Spezialfedern Team (BMW M4 GT3)", Time = "1:27.272", Year = 2025 }
            },

            // --- Нові треки ---
            new TrackStat
            {
                TrackName = "Silverstone Circuit",
                F1Pole = new TrackStat.PoleInfo { Driver = "Lewis Hamilton", Team = "Mercedes-AMG Petronas Formula One Team", Time = "1:24.303", Year = 2020 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "James Baldwin", Team = "McLaren 720S GT3 (British GT)", Time = "2:00.123", Year = 2020 }
            },
            new TrackStat
            {
                TrackName = "Circuit de Barcelona-Catalunya",
                F1Pole = new TrackStat.PoleInfo { Driver = "Lewis Hamilton", Team = "Mercedes-AMG Petronas Formula One Team", Time = "1:16.741", Year = 2021 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Raffaele Marciello", Team = "AKKA ASP Team (Mercedes-AMG GT3)", Time = "1:45.678", Year = 2021 }
            },
            new TrackStat
            {
                TrackName = "Circuit Paul Ricard",
                F1Pole = new TrackStat.PoleInfo { Driver = "Charles Leclerc", Team = "Scuderia Ferrari", Time = "1:30.872", Year = 2022 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Dries Vanthoor", Team = "Audi Sport Team WRT (Audi R8 LMS GT3)", Time = "1:53.456", Year = 2022 }
            },
            new TrackStat
            {
                TrackName = "Autodromo Enzo e Dino Ferrari (Imola)",
                F1Pole = new TrackStat.PoleInfo { Driver = "Max Verstappen", Team = "Red Bull Racing", Time = "1:27.999", Year = 2022 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Andrea Caldarelli", Team = "Grasser Racing Team (Lamborghini Huracán GT3)", Time = "1:41.234", Year = 2022 }
            },
            new TrackStat
            {
                TrackName = "Suzuka International Racing Course",
                F1Pole = new TrackStat.PoleInfo { Driver = "Lewis Hamilton", Team = "Mercedes-AMG Petronas Formula One Team", Time = "1:27.319", Year = 2019 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Nick Cassidy", Team = "Lexus Team KeePer TOM'S (GT3-spec)", Time = "1:45.876", Year = 2019 }
            },
            new TrackStat
            {
                TrackName = "Hockenheimring Baden-Württemberg",
                F1Pole = new TrackStat.PoleInfo { Driver = "Lewis Hamilton", Team = "Mercedes-AMG Petronas Formula One Team", Time = "1:11.212", Year = 2018 },
                GT3Pole = new TrackStat.PoleInfo { Driver = "Kelvin van der Linde", Team = "Audi Sport Team WRT (Audi R8 LMS GT3)", Time = "1:38.456", Year = 2018 }
            }
        };
    }
}