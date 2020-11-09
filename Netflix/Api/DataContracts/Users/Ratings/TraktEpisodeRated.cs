using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Ratings
{
    
    public class TraktEpisodeRated : TraktRated
    {
        public TraktEpisode episode { get; set; }
    }
}