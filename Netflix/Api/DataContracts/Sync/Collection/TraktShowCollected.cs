﻿using System.Collections.Generic;
using Netflix.Api.DataContracts.BaseModel;

namespace Netflix.Api.DataContracts.Sync.Collection
{
    public class TraktShowCollected : TraktShow
    {
        public List<TraktSeasonCollected> seasons { get; set; }

        public class TraktSeasonCollected
        {
            public int number { get; set; }

            public List<TraktEpisodeCollected> episodes { get; set; }
        }
    }
}