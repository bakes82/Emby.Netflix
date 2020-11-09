using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Collection
{
    public class TraktMovieCollected : TraktMovie
    {
        public string collected_at { get; set; }

        public string media_type { get; set; }

        public string resolution { get; set; }

        public string audio { get; set; }

        public string audio_channels { get; set; }

        //public bool 3d { get; set; }
    }
}