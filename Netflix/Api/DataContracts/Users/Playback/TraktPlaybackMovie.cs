using System;
using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Playback
{
    public class TraktPlaybackMovie
    {
        public TraktMovie movie { get; set; }

        public float progress { get; set; }

        public DateTime paused_at { get; set; }
    }
}
