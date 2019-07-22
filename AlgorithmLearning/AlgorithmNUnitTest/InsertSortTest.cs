using AlgorithmBase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmNUnitTest
{
    class SortTest
    {
        private SearchFunc searchFunc;
        private SortFunc sortFunc;

        private IList<int> initList;

        private const int max = 10;
        private const int min = 3;

        [SetUp]
        public void Setup()
        {
            initList = new List<int>() { max, 10, 8, 7, 6, 3, 9, 4, 5, 5, 10, 7, 3, 5, min };

            sortFunc = new SortFunc();
            searchFunc = new SearchFunc();  
        }


        [Test]
        public void CountSortTest()
        {
            var tt = new int[initList.Count];
            sortFunc.CountSort(initList, tt);
            Assert.AreEqual(min, tt[0]);
        }

        [Test]
        public void QuickSortTest()
        {
            sortFunc.QuickSort(initList, 0, initList.Count - 1);
            Assert.AreEqual(min, initList[0]);
        }

        [Test]
        public void MaxheapifySortTest()
        {
            sortFunc.HeapSort(initList);
            Assert.AreEqual(min, initList[0]);
            var index = searchFunc.BinarySearch(initList, 10);
            Assert.AreEqual(12, index);

        }

        [Test]
        public void BubbleSortTest()
        {
            sortFunc.BubbleSort(initList);
            Assert.AreEqual(min, initList[0]);
            var index = searchFunc.BinarySearch(initList, 10);
            Assert.AreEqual(12, index);
        }

        [Test]
        public void MergeSortTest()
        {
            sortFunc.MergeSort(initList, 0, initList.Count - 1);
            Assert.AreEqual(min, initList[0]);
        }

        [Test]
        public void SelectSortTest()
        {
            sortFunc.SelectSort(initList);
            Assert.AreEqual(min, initList[0]);        
        }

        [Test]
        public void InsertSortAscTest()
        {
            sortFunc.InsertSort(initList);
            Assert.AreEqual(3, initList[0]);
        }
    }
}
