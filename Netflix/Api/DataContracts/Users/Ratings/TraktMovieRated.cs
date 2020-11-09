using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Ratings
{
    
    public class TraktMovieRated : TraktRated
    {
        public TraktMovie movie { get; set; }
    }
}