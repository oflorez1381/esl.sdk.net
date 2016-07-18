using System;
using System.Collections.Generic;

namespace Silanis.ESL.SDK
{
    public class Account
    {
        private List<CustomField> customFields = new List<CustomField>();

        public Nullable<DateTime> Created 
        { 
            get;
            set;
        }

        public Nullable<DateTime> Updated 
        { 
            get;
            set;
        }

        public List<CustomField> CustomFields 
        {
            get;
            set;
        }

        public void AddCustomFields (List<CustomField> customFields)
        {
            this.customFields.AddRange (customFields);
        }

        public string Id 
        {
            get;
            set;
        }

        public string LogoUrl
        {
            get;
            set;
        }

        public string Owner 
        {
            get;
            set;
        }
    }
}

