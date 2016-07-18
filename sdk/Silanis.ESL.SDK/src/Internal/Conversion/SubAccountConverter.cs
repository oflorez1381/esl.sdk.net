using System;

namespace Silanis.ESL.SDK
{
    internal class SubAccountConverter
    {
        private Silanis.ESL.API.SubAccountRequest apiSubAccountRequest;
        private SubAccount sdkSubAccount;

        public SubAccountConverter( Silanis.ESL.API.SubAccountRequest apiSubAccountRequest )
        {
            this.apiSubAccountRequest = apiSubAccountRequest;
        }

        public SubAccountConverter( SubAccount sdkSubAccount ) 
        {
            this.sdkSubAccount = sdkSubAccount;
        }

        public Silanis.ESL.API.SubAccountRequest ToAPISubAccountRequest() 
        {
            if (sdkSubAccount == null) 
            {
                return apiSubAccountRequest;
            }

            Silanis.ESL.API.SubAccountRequest result = new Silanis.ESL.API.SubAccountRequest();

            result.Name = sdkSubAccount.Name;
            result.Description = sdkSubAccount.Description;
            result.Plan = new SubAccountPlanConverter(sdkSubAccount.Plan).ToAPISubAccountPlan();

            return result;
        }

        public SubAccount ToSDKAccount() 
        {
            if (apiSubAccountRequest == null)
            {
                return sdkSubAccount;
            }

            return SubAccountBuilder.NewSubAccount(apiSubAccountRequest.Name)
                .WithDescription(apiSubAccountRequest.Description)
                    .WithPlan(new SubAccountPlanConverter(apiSubAccountRequest.Plan).ToSDKSubAccountPlan())
                    .Build();
        }
    }
}

