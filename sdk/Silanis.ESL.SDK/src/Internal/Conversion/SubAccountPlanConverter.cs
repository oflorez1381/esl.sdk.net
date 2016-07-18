using System;

namespace Silanis.ESL.SDK
{
    internal class SubAccountPlanConverter
    {
        private Silanis.ESL.API.SubAccountPlan apiSubAccountPlan;
        private SubAccountPlan sdkSubAccountPlan;

        internal SubAccountPlanConverter( Silanis.ESL.API.SubAccountPlan apiSubAccountPlan )
        {
            this.apiSubAccountPlan = apiSubAccountPlan;
        }

        public SubAccountPlanConverter( SubAccountPlan sdkSubAccountPlan ) 
        {
            this.sdkSubAccountPlan = sdkSubAccountPlan;
        }

        public Silanis.ESL.API.SubAccountPlan ToAPISubAccountPlan() 
        {
            if (sdkSubAccountPlan == null) 
            {
                return apiSubAccountPlan;
            }

            Silanis.ESL.API.SubAccountPlan result = new Silanis.ESL.API.SubAccountPlan();

            result.EnforceDocumentsQuota = sdkSubAccountPlan.EnforceDocumentsQuota;
            result.NumberOfDocumentsQuota = sdkSubAccountPlan.NumberOfDocumentsQuota;

            return result;
        }

        public SubAccountPlan ToSDKSubAccountPlan() 
        {
            if (apiSubAccountPlan == null)
            {
                return sdkSubAccountPlan;
            }

            return new SubAccountPlan(apiSubAccountPlan.EnforceDocumentsQuota, apiSubAccountPlan.NumberOfDocumentsQuota);
        }
    }
}

