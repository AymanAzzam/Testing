using System.Collections.Generic;
using NUnit.Framework;
using BugSpark.Source;

namespace BugSpark.Tests
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
        
        [Test]
        public void FindAllOccurrences_EPC_Test_1()
        {
            List<int> expected_output = new List<int>() {0};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("heÌaa", "he"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_EPC_Test_2()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("", ""), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_EPC_Test_3()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("Ì", "h"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_EPC_Test_4()
        {
            List<int> expected_output = new List<int>() {0};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("h", "h"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_1()
        {
            List<int> expected_output = new List<int>() {8};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("This is great", "great"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_2()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences(null, "great"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_3()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("This is great", null), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_4()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("", "hello"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_5()
        {
            List<int> expected_output = new List<int>() {0};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("a", "a"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_6()
        {
            List<int> expected_output = new List<int>() {1};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("ab", "b"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_7()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", ""), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_8()
        {
            List<int> expected_output = new List<int>() {4};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "o"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_9()
        {
            List<int> expected_output = new List<int>() {3};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "lo"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_10()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "how"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_11()
        {
            List<int> expected_output = new List<int>() {0, 6};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello hello", "hello"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_12()
        {
            List<int> expected_output = new List<int>() {};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "how"), expected_output);
        }
        
        [Test]
        public void FindAllOccurrences_IDM_Test_13()
        {
            List<int> expected_output = new List<int>() {0};
            Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "hello"), expected_output);
        }
    }
}