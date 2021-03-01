﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GenshinPlayerQuery.Model
{
    class WorldExploration
    {
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "exploration_percentage")]
        public int ExplorationPercentage { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
