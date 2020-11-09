using System.Collections.Generic;
using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Watched
{
    public class TraktSeasonWatched : TraktSeason
    {
        public string watched_at { get; set; }

        public List<TraktEpisodeWatched> episodes { get; set; }
    }
}
