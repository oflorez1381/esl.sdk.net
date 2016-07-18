using System;

namespace Silanis.ESL.SDK
{
    public class SubAccountBuilder
    {
        private string name;
        private string description;
        private SubAccountPlan plan;

        private SubAccountBuilder( string name )
        {
            this.name = name;
        }

        public static SubAccountBuilder NewSubAccount( string name ) 
        {
            return new SubAccountBuilder( name );
        }

        public SubAccountBuilder WithDescription( string description ) 
        {
            this.description = description;
            return this;
        }

        public SubAccountBuilder WithPlan( SubAccountPlan plan ) 
        {
            this.plan = plan;
            return this;
        }

        public SubAccountBuilder WithPlan( SubAccountPlanBuilder builder ) 
        {
            return WithPlan(builder.Build());
        }

        public SubAccount Build() 
        {
            SubAccount result = new SubAccount(name, description, plan);
            return result;
        }
    }
}

