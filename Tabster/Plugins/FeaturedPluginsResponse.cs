﻿#region

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

#endregion

namespace Tabster.Plugins
{
    internal class FeaturedPlugin
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("author")]
        public string Author { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("version")]
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; private set; }

        [JsonProperty("website")]
        public string Website { get; private set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; private set; }
    }

    internal class FeaturedPluginsResponse
    {
        [JsonProperty("featured_plugins")]
        public List<FeaturedPlugin> Plugins { get; internal set; }
    }
}