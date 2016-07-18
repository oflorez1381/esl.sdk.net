using System;
using System.Collections.Generic;

namespace Silanis.ESL.SDK
{
    public class AccountBuilder
    {
        private Nullable<DateTime> created;
        private Nullable<DateTime> updated;
        private string id;
        private string logoUrl;
        private string owner;
        private List<CustomField> customFields = new List<CustomField>();


        private AccountBuilder( string owner )
        {
            this.owner = owner;
        }

        public static AccountBuilder NewAccount( string owner ) 
        {
            return new AccountBuilder( owner );
        }

        public AccountBuilder Created( Nullable<DateTime> created ) 
        {
            this.created = created;
            return this;
        }

        public AccountBuilder Updated( Nullable<DateTime> updated ) 
        {
            this.updated = updated;
            return this;
        }

        public AccountBuilder WithId( string id ) 
        {
            this.id = id;
            return this;
        }

        public AccountBuilder WithLogoUrl( string logoUrl ) 
        {
            this.logoUrl = logoUrl;
            return this;
        }

        public AccountBuilder WithCustomField( CustomField customField ) 
        {
            this.customFields.Add(customField);
            return this;
        }

        public AccountBuilder WithCustomFields( List<CustomField> customFields ) 
        {
            this.customFields.AddRange(customFields);
            return this;
        }

        public Account Build() 
        {
            Account result = new Account();
            result.Created = created;
            result.Updated = updated;
            result.Id = id;
            result.LogoUrl = logoUrl;
            result.Owner = owner;
            result.CustomFields = customFields;
            return result;
        }
    }
}

