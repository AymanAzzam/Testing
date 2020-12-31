using System.Collections.Generic;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class RabinKarpTests
    {
        [Test]
        public void FindAllOccurrences_Branch_Test_1()
        {
            List<int> expected_output = new List<int>() {0};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("heÌ", "h"), expected_output);
        }
    }
}