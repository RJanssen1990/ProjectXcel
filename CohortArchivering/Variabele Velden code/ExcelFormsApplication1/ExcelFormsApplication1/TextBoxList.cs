using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelFormsApplication1
{
    public class TextBoxList : CollectionBase
    {
        public void Add(TextBox tb)
        {
            List.Add(tb);
        }
    }
}
