﻿using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Scrobble
{
    public class TraktScrobbleEpisode
    {
        public TraktShow show { get; set; }

        public TraktEpisode episode { get; set; }

        public float progress { get; set; }

        public string app_version { get; set; }

        public string app_date { get; set; }
    }
}