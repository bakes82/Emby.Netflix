using System;
using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Users.Playback
{
    public class TraktPlaybackEpisode
    {
        public TraktEpisode episode { get; set; }

        public float progress { get; set; }

        public DateTime paused_at { get; set; }
    }
}
