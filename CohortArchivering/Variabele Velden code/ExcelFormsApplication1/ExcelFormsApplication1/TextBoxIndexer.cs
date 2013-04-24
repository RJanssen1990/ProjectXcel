using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormsApplication1
{
    public class TextBoxIndexer<T>
    {
        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
}
