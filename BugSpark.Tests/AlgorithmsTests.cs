using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using BugSpark.Source;

namespace BugSpark.Tests
{
    [TestFixture]
    public class AlgorithmsTests
    {
        public Algorithms algo;
        [SetUp]
        public void setup()
        {
            algo = new Algorithms();
        }
        
        [Test, Author("Ayman Azzam")]
        public void LongestMountainTest1()  //Prime Path Coverage 1
        {
            int[] a = {50, 40, 30, 35, 36};
            Assert.AreEqual(0,algo.LongestMountain(a));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LongestMountainTest2()  //Prime Path Coverage 2
        {
            int[] a = {30, 40, 35};
            Assert.AreEqual(3,algo.LongestMountain(a));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LongestMountainTest3()  //Prime Path Coverage 3
        {
            int[] a = {};
            Assert.AreEqual(0,algo.LongestMountain(a));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LongestMountainTest4()  //Prime Path Coverage 4
        {
            int[] a = {5};
            Assert.AreEqual(0,algo.LongestMountain(a));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LadderLengthTest1()  //All Combination Coverage 1
        {
            List<String> wordList = new List<string>();
            wordList.Add("Ayzan");
            wordList.Add("Shawky");
            wordList.Add("Ayzak");
            wordList.Add("Byzak");
            wordList.Add("Bzzak");
            wordList.Add("Bzzbk");
            wordList.Add("Bzzbm");
            wordList.Add("Azzbm");
            wordList.Add("Azzam");

            String beginWord = "Ayman";
            String endWord = "Azzam";
            
            Assert.AreEqual(9,algo.LadderLength(beginWord,endWord,wordList));
            // The Fault in line 51, it should be c = '!' instead of c = 'a'
        }
        
        [Test, Author("Ayman Azzam")]
        public void LadderLengthTest2()  //All Combination Coverage 2
        {
            List<String> wordList = new List<string>();
            wordList.Add("Ayzan");
            wordList.Add("Aykam");
            wordList.Add("Bzzbm");
            wordList.Add("Ayzbm");
            wordList.Add("Azzam");
            wordList.Add("");
            
            String beginWord = "Ayman";
            String endWord = "Azzam";
            
            Assert.AreEqual(0,algo.LadderLength(beginWord,endWord,wordList));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LadderLengthTest3()  //All Combination Coverage 3
        {
            List<String> wordList = new List<string>();
            wordList.Add("Aywky");
            wordList.Add("Ahawky");
            wordList.Add("Ayzam");
            wordList.Add("Shawkn");
            wordList.Add("Shamky");
            wordList.Add("Shawky");
            
            String beginWord = "Ayman";
            String endWord = "Shawky";
            
            Assert.AreEqual(0,algo.LadderLength(beginWord,endWord,wordList));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LadderLengthTest4()  //All Combination Coverage 4
        {
            List<String> wordList = new List<string>();
            wordList.Add("Ayzan");
            wordList.Add("Ayzam");
            wordList.Add("Bzzbm");
            wordList.Add("Ayzbm");
            wordList.Add("Azzbm");
            
            String beginWord = "Ayman";
            String endWord = "Azzam";
            Assert.AreEqual(0,algo.LadderLength(beginWord,endWord,wordList));
        }
        
        [Test, Author("Ayman Azzam")]
        public void LadderLengthTest5()  //All Combination Coverage 5
        {
            List<String> wordList = new List<string>();
            wordList.Add("Aywky");
            wordList.Add("Ahawky");
            wordList.Add("Ayzam");
            wordList.Add("Shawkn");
            wordList.Add("Shamky");
            
            String beginWord = "Ayman";
            String endWord = "Shawky";
            
            Assert.AreEqual(0,algo.LadderLength(beginWord,endWord,wordList));
        }

        [Test, Author("Khaled Moataz")]
        public void TwoSum_PPC_1()
        {
            int[] nums = null;
            int target = 10;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_PPC_2()
        {
            int[] nums = new int[4] {1, 2, 1, 3};
            int target = 10;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_PPC_3()
        {
            int[] nums = new int[2] {1, 1};
            int target = 5;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_PPC_4()
        {
            int[] nums = new int[2] {1, 5};
            int target = 6;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {0, 1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_ACoC_2()
        {
            int[] nums = null;
            int target = 6;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_ACoC_4()
        {
            int[] nums = new int[0] {};
            int target = 6;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_ACoC_6()
        {
            int[] nums = new int[1] {1};
            int target = 6;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_ACoC_7()
        {
            int[] nums = new int[4] {1, 2, 3, 4};
            int target = 10;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {-1, -1});
        }
        
        [Test, Author("Khaled Moataz")]
        public void TwoSum_ACoC_8()
        {
            int[] nums = new int[4] {1, 2, 3, 4};
            int target = 6;
            var result = algo.TwoSum(nums, target);
            Assert.AreEqual(result, new int[2] {1, 3});
        }
    }
}