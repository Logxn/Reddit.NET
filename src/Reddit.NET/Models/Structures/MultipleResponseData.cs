﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class MultipleResponseData
    {
        [JsonProperty("things")]
        public List<DynamicListingChild> Things;
    }
}