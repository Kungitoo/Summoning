﻿using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Flash.Riot.platform.summoner.maserybook
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.masterybook.MasteryBookPageDTO")]
    public class MasteryBookPageDTO
    {
        [SerializedName("talentEntries")]
        public List<TalentEntry> TalentEntries { get; set; }

        [SerializedName("pageId")]
        public Double PageId { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("current")]
        public Boolean Current { get; set; }

        [SerializedName("createDate")]
        public object CreateDate { get; set; }

        [SerializedName("summonerId")]
        public Double SummonerId { get; set; }
    }
}
