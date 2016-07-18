using System;
using Newtonsoft.Json;

namespace Silanis.ESL.API
{
    internal class SubAccountRequest
    {
        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("description")]
        public string Description
        {
            get; set;
        }

        [JsonProperty("plan")]
        internal SubAccountPlan Plan
        {
            get; set;
        }
    }
}

