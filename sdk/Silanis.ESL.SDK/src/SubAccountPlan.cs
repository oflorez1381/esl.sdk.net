using System;

namespace Silanis.ESL.SDK
{
    public class SubAccountPlan
    {
        public SubAccountPlan(Nullable<bool> enforceDocumentsQuota, Nullable<int> numberOfDocumentsQuota) 
        {
            EnforceDocumentsQuota = enforceDocumentsQuota;
            NumberOfDocumentsQuota = numberOfDocumentsQuota;
        }

        public Nullable<bool> EnforceDocumentsQuota 
        { 
            get;
            set;
        }

        public Nullable<int> NumberOfDocumentsQuota 
        { 
            get;
            set;
        }
    }
}

