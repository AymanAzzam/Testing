using System.Collections.Generic;
using NUnit.Framework;

namespace BugSpark
{
    [TestFixture]
    public class RabinKarpTests
    {
        
        [TestCase("heÌ", "h", ExpectedResult = new int[] {0}), Author("Ayman Elakwah")]
        public int[] FindAllOccurrences_Branch_Test(string text, string pattern)
        {
            return RabinKarp.FindAllOccurrences(text, pattern).ToArray();
        }
        
        [TestCase("heÌaa", "he", ExpectedResult = new int[] {0}), Author("Ayman Elakwah")]
        [TestCase("", "", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("Ì", "h", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("h", "h", ExpectedResult = new int[] {0}), Author("Ayman Elakwah")]
        public int[] FindAllOccurrences_EPC_Test(string text, string pattern)
        {
            return RabinKarp.FindAllOccurrences(text, pattern).ToArray();
        }
        
        [TestCase("This is great", "great", ExpectedResult = new int[] {8}), Author("Ayman Elakwah")]
        [TestCase(null, "great", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("This is great", null, ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("", "hello", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("a", "a", ExpectedResult = new int[] {0}), Author("Ayman Elakwah")]
        [TestCase("ab", "b", ExpectedResult = new int[] {1}), Author("Ayman Elakwah")]
        [TestCase("hello", "", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("hello", "o", ExpectedResult = new int[] {4}), Author("Ayman Elakwah")]
        [TestCase("hello", "lo", ExpectedResult = new int[] {3}), Author("Ayman Elakwah")]
        [TestCase("hello", "how", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("hello hello", "hello", ExpectedResult = new int[] {0, 6}), Author("Ayman Elakwah")]
        [TestCase("hello", "how", ExpectedResult = new int[] {}), Author("Ayman Elakwah")]
        [TestCase("hello", "hello", ExpectedResult = new int[] {0}), Author("Ayman Elakwah")]
        public int[] FindAllOccurrences_IDM_Test(string text, string pattern)
        {
            return RabinKarp.FindAllOccurrences(text, pattern).ToArray();
        }
        
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_Branch_Test_1()
    //     {
    //         List<int> expected_output = new List<int>() {0};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("heÌ", "h"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_EPC_Test_1()
    //     {
    //         List<int> expected_output = new List<int>() {0};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("heÌaa", "he"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_EPC_Test_2()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("", ""), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_EPC_Test_3()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("Ì", "h"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_EPC_Test_4()
    //     {
    //         List<int> expected_output = new List<int>() {0};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("h", "h"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_1()
    //     {
    //         List<int> expected_output = new List<int>() {8};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("This is great", "great"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_2()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences(null, "great"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_3()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("This is great", null), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_4()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("", "hello"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_5()
    //     {
    //         List<int> expected_output = new List<int>() {0};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("a", "a"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_6()
    //     {
    //         List<int> expected_output = new List<int>() {1};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("ab", "b"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_7()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", ""), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_8()
    //     {
    //         List<int> expected_output = new List<int>() {4};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "o"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_9()
    //     {
    //         List<int> expected_output = new List<int>() {3};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "lo"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_10()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "how"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_11()
    //     {
    //         List<int> expected_output = new List<int>() {0, 6};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello hello", "hello"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_12()
    //     {
    //         List<int> expected_output = new List<int>() {};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "how"), expected_output);
    //     }
    //     
    //     [Test, Author("Ayman Elakwah")]
    //     public void FindAllOccurrences_IDM_Test_13()
    //     {
    //         List<int> expected_output = new List<int>() {0};
    //         Assert.AreEqual(RabinKarp.FindAllOccurrences("hello", "hello"), expected_output);
    //     }
    }
}