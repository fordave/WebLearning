using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmBase
{
    public class SearchFunc
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BinarySearch(IList<int> list, int value)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }
            if (!list.Contains(value))
                throw new Exception();

            return Binary(list, 0, list.Count - 1, value);
        }

        private int Binary(IList<int> list, int index1, int index2, int value)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }
            var m = (index1 + index2) / 2;
            if (list[m] == value)
            {
                return m;
            }
            var n = index1;
            if (list[m] < value)
            {
                n = m;
                m = index2;
            }
            return Binary(list, n, m, value);
        }


    }
}
