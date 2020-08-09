﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Victoria.Converters;
using Victoria.Interfaces;

// ReSharper disable UnusedAutoPropertyAccessor.Local
namespace Victoria.Responses.Search {
    /// <summary>
    /// 
    /// </summary>
    public struct SearchResponse {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("loadType"), JsonInclude, JsonConverter(typeof(SearchStatusConverter))]
        public SearchStatus Status { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("playlistInfo"), JsonInclude]
        public SearchPlaylist SearchPlaylist { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("exception"), JsonInclude]
        public SearchException Exception { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tracks"), JsonInclude, JsonConverter(typeof(LavaTracksPropertyConverter))]
        public IReadOnlyCollection<ILavaTrack> Tracks { get; private set; }
    }
}