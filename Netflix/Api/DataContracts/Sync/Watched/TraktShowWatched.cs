using System.Collections.Generic;
using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Watched
{
    public class TraktShowWatched : TraktShow
    {
        public string watched_at { get; set; }

        public List<TraktSeasonWatched> seasons { get; set; }
    }
}