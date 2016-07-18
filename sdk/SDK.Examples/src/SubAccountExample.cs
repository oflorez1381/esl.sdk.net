using System;
using System.Collections.Generic;
using Silanis.ESL.SDK;

namespace SDK.Examples
{
    public class SubAccountExample : SDKSample
    {
        public const int THE_NUMBER_OF_NEW_SUB_ACCOUNTS = 10;
        public const int THE_NUMBER_OF_NEW_SENDERS = 10;
        public IList<Account> existingSubAccounts, createdSubAccounts;

        public static void Main(string[] args)
        {
            new SubAccountExample().Run();
        }

        override public void Execute()
        {
            existingSubAccounts = eslClient.AccountService.GetSubAccounts();

            foreach(Account account in existingSubAccounts) 
            {
                eslClient.AccountService.DeleteSubAccount(account.Id);
            }

            for (int i = 0; i < THE_NUMBER_OF_NEW_SUB_ACCOUNTS; i++) 
            {
                SubAccount subAccount = SubAccountBuilder.NewSubAccount("subAccount" + i)
                        .WithDescription("This is a subAccount created using the e-SignLive SDK")
                        .WithPlan(SubAccountPlanBuilder.NewSubAccountPlan(false)
                                  .WithNumberOfDocumentsQuota(5))
                        .Build();

                string accountUid = eslClient.AccountService.CreateSubAccount(subAccount);
                for (int inx = 0; inx < THE_NUMBER_OF_NEW_SENDERS; inx++) 
                {
                    SenderInfo senderInfo = SenderInfoBuilder.NewSenderInfo(GetRandomEmail())
                            .WithCompany("eSignLive")
                            .WithName("John", "Smith")
                            .WithTitle("Managing Director")
                            .Build();
                    eslClient.AccountService.AddSenderToSubAccount(accountUid, senderInfo, SenderStatus.ACTIVE);
                }
            }

            createdSubAccounts = eslClient.AccountService.GetSubAccounts();
        }
    }
}

