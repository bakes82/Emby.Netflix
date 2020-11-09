using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Ratings
{
    
    public class TraktSeasonRated : TraktRated
    {
        public TraktSeason season { get; set; }
    }
}