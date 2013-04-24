using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cohort_Archivering
{
    public class ControlIndexer<T>
    {
        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
}
