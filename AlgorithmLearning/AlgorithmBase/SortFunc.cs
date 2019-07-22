using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmBase
{
    public class SortFunc
    {
        #region heapsort      

        /// <summary>
        /// l=left (i)
        /// r=right(i)
        /// if l<=A.length and A[l]>A[i] then
        ///     largest=l
        /// else then
        ///     largest=i
        /// endif
        /// if  r<= A.length and A[r]> A[largest] then
        ///     largest=r
        /// endif
        /// if  largest !=i
        ///     exchange A[i] and A[largest]
        ///     max-heapify(A,largest)
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index"></param>
        private void MaxHeapify(IList<int> list, int index)
        {
            if (list == null)
            {
                throw new ArgumentException();
            }
            var l = index << 1;
            var r = l + 1;
            var largest = index;
            if (l < heapSize && list[l] > list[index])
            {
                largest = l;
            }
            if (r < heapSize && list[r] > list[largest])
            {
                largest = r;
            }
            if (largest != index)
            {
                Swap(list, largest, index);
                MaxHeapify(list, largest);
            }
        }

        private int heapSize = 0;

        private void BuildMaxheap(IList<int> list)
        {
            if (list == null)
            {
                throw new ArgumentException();
            }
            heapSize = list.Count;
            for (var i = list.Count / 2; i >= 0; i--)
            {
                MaxHeapify(list, i);
            }
        }

        public void HeapSort(IList<int> list)
        {
            if (list == null)
            {
                throw new ArgumentException();
            }
            BuildMaxheap(list);
            for (var i = list.Count - 1; i > 0; i--)
            {
                Swap(list, 0, i);
                heapSize--;
                MaxHeapify(list, 0);
            }
        }

        #endregion


        #region quicksort

        /// <summary>
        /// if initIndex< endIndex
        ///     midIndex=partition(list,initIndex,endIndex)
        ///     quickSort(list,initIndex,midIndex-1)
        ///     quickSort(list,midIndex+1,endIndex)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="initIndex"></param>
        /// <param name="endIndex"></param>
        public void QuickSort(IList<int> list, int initIndex, int endIndex)
        {
            if (list == null)
                throw new ArgumentNullException();

            if (initIndex >= endIndex)
                return;

            var midIndex = Partition(list, initIndex, endIndex);
            QuickSort(list, initIndex, midIndex - 1);
            QuickSort(list, midIndex + 1, endIndex);
        }

        /// <summary>
        /// x=list[endIndex]
        ///  i=initIndex-1
        ///  for j=initIdex to endIndex-1
        ///     if  list[j] <=x then
        ///         i++
        ///         exchange list[i] and list[j]
        ///      endif
        ///  exchange list[i+1] and list[j]
        ///  return i+1;
        /// </summary>
        /// <param name="list"></param>
        /// <param name="initIdex"></param>
        /// <param name="endIndex"></param>
        private int Partition(IList<int> list, int initIdex, int endIndex)
        {
            if (list == null)
                throw new ArgumentNullException();

            var end = list[endIndex];
            var i = initIdex - 1;
            for (var j = initIdex; j < endIndex; j++)
            {
                if (list[j] <= end)
                {
                    i++;
                    Swap(list, i, j);
                }
            }
            Swap(list, i + 1, endIndex);
            return i + 1;
        }

        private void Swap(IList<int> list, int index, int largest)
        {
            if (index == largest)
                return;

            list[index] = list[index] + list[largest];
            list[largest] = list[index] - list[largest];
            list[index] = list[index] - list[largest];
        }

        #endregion

        #region countsort

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="list1"></param>
        public void CountSort(IList<int> list, IList<int> list1)
        {
            var max = list.Max();
            var array = new int[max + 1];
            var array1 = new int[max];
            for (int i = 0; i < list.Count; i++)
            {
                array[list[i]]++;
            }
            for (int i = 1; i < max + 1; i++)
            {
                array[i] += array[i - 1];
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                list1[array[list[i]] - 1] = list[i];
                array[list[i]]--;
            }

        }

        #endregion

        #region selectsort

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public void SelectSort(IList<int> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (var i = 0; i < list.Count - 1; i++)
            {
                for (var j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
        }

        #endregion

        #region insertsort

        /// <summary>
        /// for i=1 to list.count-1
        ///    key=list[i]
        ///    j=i-1
        ///    for  j down to 0 
        ///      if key >list[j] then
        ///         list[j+1] = list[j]
        ///         j--
        ///      end if
        ///    list[j+1]=key 
        /// </summary>
        /// <param name="list"></param>
        public void InsertSort(IList<int> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (var i = 1; i < list.Count; i++)
            {
                var key = list[i];
                var j = i - 1;
                while (j > -1 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }

        #endregion

        #region bubblesort

        /// <summary>
        /// for i=0 to initList.count-1
        ///     for j=0 to initList.count-2-i
        ///         if initList[j]>initList[j+1] then
        ///             swap initList[j] initList[j+1]
        ///          j++
        ///     i++
        /// </summary>
        /// <param name="initList"></param>
        public void BubbleSort(IList<int> initList)
        {
            if (initList == null)
            {
                throw new ArgumentNullException();
            }
            for (var i = 0; i < initList.Count; i++)
            {
                var flag = false;
                for (var j = 0; j < initList.Count - 1 - i; j++)
                {
                    if (initList[j] > initList[j + 1])
                    {
                        initList[j] = initList[j] ^ initList[j + 1];
                        initList[j + 1] ^= initList[j];
                        initList[j] ^= initList[j + 1];
                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }

        #endregion

        #region mergesort

        /// <summary>
        /// length1=index2-index1+1
        /// length2=index3-index2
        /// let L[length1],R[length2] be new array
        /// for i=0 to lengh1
        ///     L[i]=initList[index1+i]
        /// for j=0 to length2
        ///     R[j]=initList[index2+j]
        /// i=0 j=0
        /// for k=index1 to index3
        ///     if L[i] <= R[j] then
        ///         initList[k]=L[i]
        ///         i++
        ///      else then
        ///         initList[k]== R[j] 
        ///         j++
        ///      endif
        /// </summary>
        /// <param name="initList"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <param name="index3"></param>
        private void Merge(IList<int> initList, int index1, int index2, int index3)
        {
            var length1 = index2 - index1 + 1;
            var length2 = index3 - index2;
            var L = new List<int>() { };
            var R = new List<int>() { };
            for (var i = 0; i < length1; i++)
            {
                L.Add(initList[index1 + i]);
            }
            L.Add(int.MaxValue);
            for (var i = 0; i < length2; i++)
            {
                R.Add(initList[index2 + i + 1]);
            }
            R.Add(int.MaxValue);
            var m = 0;
            var n = 0;

            for (var k = index1; k < index3 + 1; k++)
            {
                if (L[m] <= R[n])
                {
                    initList[k] = L[m];
                    m++;
                }
                else
                {
                    initList[k] = R[n];
                    n++;
                }
            }

        }

        public void MergeSort(IList<int> initList, int index1, int index2)
        {
            if (initList == null)
                throw new ArgumentNullException(nameof(initList));

            if (index1 < index2)
            {
                var index = (index1 + index2) / 2;
                MergeSort(initList, index1, index);
                MergeSort(initList, index + 1, index2);
                Merge(initList, index1, index, index2);
            }
        }

        #endregion
    }
}
