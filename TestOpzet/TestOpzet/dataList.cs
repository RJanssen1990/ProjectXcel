using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TestOpzet
{
    public partial class dataList : CollectionBase
    {
        public dataList()
        { 
        
        }

        public void Add(dataClass dataclass)
        {
            List.Add(dataclass);
        }
        
        public dataClass this[int index]
        {
            get { return (dataClass)this.List[index]; }
        }
    }
}
