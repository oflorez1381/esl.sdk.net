using System;

namespace Silanis.ESL.SDK
{
    public class SubAccountPlanBuilder
    {
        private Nullable<int> numberOfDocumentsQuota;
        private Nullable<bool> enforceDocumentsQuota;

        public SubAccountPlanBuilder(Nullable<bool> enforceDocumentsQuota)
        {
            this.enforceDocumentsQuota = enforceDocumentsQuota;
        }

        public static SubAccountPlanBuilder NewSubAccountPlan( Nullable<bool> enforceDocumentsQuota ) 
        {
            return new SubAccountPlanBuilder( enforceDocumentsQuota );
        }

        public SubAccountPlanBuilder WithNumberOfDocumentsQuota( Nullable<int> numberOfDocumentsQuota ) 
        {
            this.numberOfDocumentsQuota = numberOfDocumentsQuota;
            return this;
        }

        public SubAccountPlan Build() 
        {
            SubAccountPlan result = new SubAccountPlan(enforceDocumentsQuota, numberOfDocumentsQuota);
            return result;
        }
    }
}

