using NUnit.Framework;
using System;

namespace SDK.Examples
{
    [TestFixture()]
    public class AuditExampleTest
    {
        [Test()]
        public void VerifyResult()
        {
            AuditExample example = new AuditExample();
            example.Run();

            Assert.AreEqual(example.audits.Count, 0);
        }
    }
}

