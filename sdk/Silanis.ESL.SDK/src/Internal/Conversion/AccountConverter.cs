using System;
using System.Collections.Generic;

namespace Silanis.ESL.SDK
{
    internal class AccountConverter
    {
        private Silanis.ESL.API.Account apiAccount;
        private Account sdkAccount;

        public AccountConverter( Silanis.ESL.API.Account apiAccount )
        {
            this.apiAccount = apiAccount;
        }

        public AccountConverter( Account sdkAccount ) 
        {
            this.sdkAccount = sdkAccount;
        }

        public Silanis.ESL.API.Account ToAPIAccount() 
        {
            if (sdkAccount == null) 
            {
                return apiAccount;
            }

            Silanis.ESL.API.Account result = new Silanis.ESL.API.Account();

            result.Owner = sdkAccount.Owner;
            result.Id = sdkAccount.Id;
            result.LogoUrl = sdkAccount.LogoUrl;
            result.Updated = sdkAccount.Updated;
            result.Created = sdkAccount.Created;
            result.Owner = sdkAccount.Owner;

            foreach(CustomField customField in sdkAccount.CustomFields) 
            {
                Silanis.ESL.API.CustomField apiCustomField = new CustomFieldConverter(customField).ToAPICustomField();
                result.AddCustomField(apiCustomField);
            }

            return result;
        }

        public Account ToSDKAccount() 
        {
            if (apiAccount == null)
            {
                return sdkAccount;
            }

            List<CustomField> sdkCustomFields = new List<CustomField>();
            foreach(Silanis.ESL.API.CustomField customField in apiAccount.CustomFields) 
            {
                CustomField sdkCustomField = new CustomFieldConverter(customField).ToSDKCustomField();
                sdkCustomFields.Add(sdkCustomField);
            }

            return AccountBuilder.NewAccount(apiAccount.Owner)
                    .Created(apiAccount.Created)
                    .Updated(apiAccount.Updated)
                    .WithId(apiAccount.Id)
                    .WithLogoUrl(apiAccount.LogoUrl)
                    .WithCustomFields(sdkCustomFields)
                    .Build();
        }
    }
}

