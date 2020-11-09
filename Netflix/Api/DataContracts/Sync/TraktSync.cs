using System.Collections.Generic;
using Netflix.Api.DataContracts.BaseModel;
using Netflix.Api.DataContracts.Sync.Collection;
using Netflix.Api.DataContracts.Sync.Ratings;
using Netflix.Api.DataContracts.Sync.Watched;

namespace Netflix.Api.DataContracts.Sync
{
    public class TraktSync<TMovie, TShow, TEpisode>
    {
        public List<TMovie> movies { get; set; }

        public List<TShow> shows { get; set; }

        public List<TEpisode> episodes { get; set; }
    }

    public class TraktSyncRated : TraktSync<TraktMovieRated, TraktShowRated, TraktEpisodeRated>
    {
    }

    public class TraktSyncWatched : TraktSync<TraktMovieWatched, TraktShowWatched, TraktEpisodeWatched>
    {
    }

    public class TraktSyncCollected : TraktSync<TraktMovieCollected, TraktShowCollected, TraktEpisodeCollected>
    {
    }

    public class TraktSyncUncollected : TraktSync<TraktMovie, TraktShowCollected, TraktEpisodeCollected>
    {
    }
}