using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Watched
{
    public class TraktMovieWatched : TraktMovie
    {
        public string watched_at { get; set; }
    }
}