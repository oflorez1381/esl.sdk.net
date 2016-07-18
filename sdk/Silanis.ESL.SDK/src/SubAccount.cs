using System;

namespace Silanis.ESL.SDK
{
    public class SubAccount
    {
        public SubAccount(string name, string description, SubAccountPlan plan) 
        {
            Name = name;
            Description = description;
            Plan = plan;
        }

        public string Name 
        { 
            get;
            set;
        }

        public string Description 
        { 
            get;
            set;
        }

        public SubAccountPlan Plan 
        {
            get;
            set;
        }
    }
}

