﻿using Newtonsoft.Json;
using PropertyChanged;

namespace TeamRoomPortable.Notification
{
    [ImplementPropertyChanged]
    public class BuildCompletedEventData
    {
        [JsonProperty("buildNumber")]
        public string BuildNumber { get; set; }

        [JsonProperty("buildUri")]
        public string BuildUri { get; set; }

        [JsonProperty("buildDefinition")]
        public BuildDefinition BuildDefinition { get; set; }

        [JsonProperty("buildStatus")]
        public string BuildStatus { get; set; }

        [JsonProperty("buildReason")]
        public BuildReason BuildReason { get; set; }
    }
}
