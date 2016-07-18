using System;
using Newtonsoft.Json;

namespace Silanis.ESL.API
{
    internal class SubAccountPlan
    {
        [JsonProperty("numberOfDocumentsQuota")]
        public Nullable<int> NumberOfDocumentsQuota
        {
            get; set;
        }


        [JsonProperty("enforceDocumentsQuota")]
        public Nullable<bool> EnforceDocumentsQuota
        {
            get; set;
        }
    }
}