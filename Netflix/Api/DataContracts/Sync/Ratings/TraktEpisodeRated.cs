using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Ratings
{
    public class TraktEpisodeRated : TraktRated
    {
        public int? number { get; set; }

        public TraktEpisodeId ids { get; set; }
    }
}