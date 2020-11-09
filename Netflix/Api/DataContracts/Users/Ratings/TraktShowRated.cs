using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Ratings
{
    
    public class TraktShowRated : TraktRated
    {
        public TraktShow show { get; set; }
    }
}