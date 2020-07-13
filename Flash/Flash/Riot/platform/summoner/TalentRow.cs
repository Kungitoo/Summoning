﻿using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.TalentRow")]
    public class TalentRow
    {
        [SerializedName("index")]
        public Int32 Index { get; set; }

        [SerializedName("talents")]
        public List<Talent> Talents { get; set; }

        [SerializedName("tltGroupId")]
        public Int32 TltGroupId { get; set; }

        [SerializedName("pointsToActivate")]
        public Int32 PointsToActivate { get; set; }

        [SerializedName("tltRowId")]
        public Int32 TltRowId { get; set; }
    }
}
