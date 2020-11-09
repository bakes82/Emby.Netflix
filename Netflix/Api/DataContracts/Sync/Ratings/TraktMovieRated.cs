using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Ratings
{
    public class TraktMovieRated : TraktRated
    {
        public string title { get; set; }

        public int? year { get; set; }

        public TraktMovieId ids { get; set; }
    }
}