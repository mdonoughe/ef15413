using ef15413;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace ef15413_21
{
    [TestClass]
    public class TransactionTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            using (var context = new TestDbContext())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void Test()
        {
            using (new TransactionScope())
            {
                using (var context = new TestDbContext())
                {
                    context.Add(new TestModel());
                    context.SaveChanges();
                }
            }
        }
    }
}
