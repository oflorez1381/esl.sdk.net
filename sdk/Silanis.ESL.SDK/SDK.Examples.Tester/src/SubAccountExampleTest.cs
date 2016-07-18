using NUnit.Framework;
using System;
using Silanis.ESL.SDK;

namespace SDK.Examples
{
    [TestFixture()]
    public class SubAccountExampleTest
    {
        [Test()]
        public void VerifyResult()
        {
            SubAccountExample example = new SubAccountExample();
            example.Run();

            Assert.AreEqual(example.createdSubAccounts.Count, SubAccountExample.THE_NUMBER_OF_NEW_SUB_ACCOUNTS);
            foreach(Account account in example.createdSubAccounts) 
            {
                Assert.AreEqual(account.Owner, "netJenkinsUserId");
            }
        }
    }
}

