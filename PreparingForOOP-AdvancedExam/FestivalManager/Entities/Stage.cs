namespace FestivalManager.Entities
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class Stage : IStage
    {
        private readonly List<ISet> sets;
        private readonly List<ISong> songs;
        private readonly List<IPerformer> performers;

        public Stage()
        {
            this.sets = new List<ISet>();
            this.songs = new List<ISong>();
            this.performers = new List<IPerformer>();
        }

        public IReadOnlyCollection<ISet> Sets => this.sets;

        public IReadOnlyCollection<ISong> Songs => this.songs;

        public IReadOnlyCollection<IPerformer> Performers => this.performers;

        public void AddPerformer(IPerformer performer)
        {
            this.performers.Add(performer);
        }

        public void AddSet(ISet set)
        {
            this.sets.Add(set);
        }

        public void AddSong(ISong song)
        {
            this.songs.Add(song);
        }

        public IPerformer GetPerformer(string name)
        {
            IPerformer performer = this.performers.Where(x => x.Name == name).FirstOrDefault();

            return performer;
        }

        public ISet GetSet(string name)
        {
            return this.sets.Where(x => x.Name == name).First();
        }

        public ISong GetSong(string name)
        {
            return this.songs.Where(x => x.Name == name).First();
        }

        public bool HasPerformer(string name)
        {
            IPerformer performer = this.performers.Where(x => x.Name == name).FirstOrDefault();

            if (performer == null)
            {
                return false;
            }

            return true;
        }

        public bool HasSet(string name)
        {
            var set = this.sets.Where(x => x.Name == name).FirstOrDefault();

            if (set == null)
            {
                return false;
            }

            return true;
        }

        public bool HasSong(string name)
        {
            var song = this.sets.Where(x => x.Name == name).FirstOrDefault();

            if (song == null)
            {
                return false;
            }

            return true;
        }
    }
}
