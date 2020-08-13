using CustomViewExample;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomViewExample
{
    [Register("CustomViewProxy")]
    partial class CustomViewProxy : CustomView
    {
        public CustomViewProxy(IntPtr handle) : base(handle)
        {
        }
    }
}
