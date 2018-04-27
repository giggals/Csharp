namespace FestivalManager.Core.Controllers
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Contracts;
    using Entities.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Factories.Contracts;

    public class FestivalController : IFestivalController
    {
        private const string TimeFormat = "mm\\:ss";
        private const string TimeFormatLong = "{0:2D}:{1:2D}";
        private const string TimeFormatThreeDimensional = "{0:3D}:{1:3D}";

        private IInstrumentFactory instrumentFactory;
        private IPerformerFactory performerFactory;
        private ISetFactory setFactory;
        private ISongFactory songFactory;

        private readonly IStage stage;

        public FestivalController(IStage stage, IInstrumentFactory instrumentFactory,
            IPerformerFactory performerFactory, ISetFactory setFactory, ISongFactory songFactory)
        {
            this.stage = stage;
            this.instrumentFactory = instrumentFactory;
            this.performerFactory = performerFactory;
            this.setFactory = setFactory;
            this.songFactory = songFactory;
        }

        private string Report()
        {
            var result = string.Empty;

            var totalFestivalLength =new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));
           

            result += ($"Festival length: {FormatTimeSpan(totalFestivalLength)}") + "\n";

            foreach (var set in this.stage.Sets)
            {
                result += ($"--{set.Name} ({FormatTimeSpan(set.ActualDuration)}):") + "\n";

                var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);
                foreach (var performer in performersOrderedDescendingByAge)
                {
                    var instruments = string.Join(", ", performer.Instruments
                        .OrderByDescending(i => i.Wear));

                    result += ($"---{performer.Name} ({instruments})") + "\n";
                }

                if (!set.Songs.Any())
                    result += ("--No songs played") + "\n";
                else
                {
                    result += ("--Songs played:") + "\n";
                    foreach (var song in set.Songs)
                    {
                        result += ($"----{song.Name} ({song.Duration.ToString(TimeFormat)})") + "\n";
                    }
                }
            }

            return result.ToString().TrimEnd();
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            var formatted = string.Format("{0:D2}:{1:D2}", (int)timeSpan.TotalMinutes, timeSpan.Seconds);
            return formatted;
        }

        public string RegisterSet(string[] args)
        {
            string name = args[0];
            string type = args[1];

            var set = setFactory.CreateSet(name, type);
            stage.AddSet(set);

            return $"Registered {type} set";
        }

        public string SignUpPerformer(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);

            var instruments = args.Skip(2).ToList();
            IPerformer performer = null;

            if (instruments == null)
            {
                performer = this.performerFactory.CreatePerformer(name, age);
                this.stage.AddPerformer(performer);

            }
            else
            {
                var instrumenti2 = instruments
              .Select(i => this.instrumentFactory.CreateInstrument(i))
              .ToArray();

                performer = this.performerFactory.CreatePerformer(name, age);

                foreach (var instrument in instrumenti2)
                {
                    performer.AddInstrument(instrument);
                }

                this.stage.AddPerformer(performer);
            }


            return $"Registered performer {performer.Name}";
        }

        public string RegisterSong(string[] args)
        {
            return SongRegistration(args);

        }

        private string SongRegistration(string[] args)
        {
            var songName = args[0];
            var setName = TimeSpan.ParseExact(args[1], "mm\\:ss", CultureInfo.InvariantCulture);

            var song = songFactory.CreateSong(songName, setName);
            this.stage.AddSong(song);


            return $"Registered song {song.Name} ({song.Duration:mm\\:ss})";
        }


        public string AddPerformerToSet(string[] args)
        {
            return PerformerRegistration(args);
        }

        private string PerformerRegistration(string[] args)
        {
            var performerName = args[0];
            var setName = args[1];

            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException("Invalid performer provided");
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            var performer = this.stage.GetPerformer(performerName);
            var set = this.stage.GetSet(setName);

            set.AddPerformer(performer);

            return $"Added {performer.Name} to {set.Name}";
        }

        public string RepairInstruments(string[] args)
        {
            var instrumentsToRepair = this.stage.Performers
                .SelectMany(p => p.Instruments)
                .Where(i => i.Wear < 100)
                .ToArray();

            foreach (var instrument in instrumentsToRepair)
            {
                instrument.Repair();
            }

            return $"Repaired {instrumentsToRepair.Length} instruments";
        }

        public string ProduceReport()
        {
            return Report();
        }

        public string AddSongToSet(string[] args)
        {
            string songName = args[0];
            string setName = args[1];

            var set = this.stage.Sets.Where(x => x.Name == setName).FirstOrDefault();
            var song = this.stage.Songs.Where(x => x.Name == songName).FirstOrDefault();

            if (set == null)
            {
                throw new InvalidOperationException("Invalid set provided");
            }
            if (song == null)
            {
                throw new InvalidOperationException("Invalid song provided");
            }

            set.AddSong(song);

            return $"Added {song.Name} ({song.Duration:mm\\:ss}) to {set.Name}";
        }
    }
}