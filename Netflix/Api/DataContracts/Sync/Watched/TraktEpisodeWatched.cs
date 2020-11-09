using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Watched
{
    public class TraktEpisodeWatched : TraktEpisode
    {
        public string watched_at { get; set; }
    }
}