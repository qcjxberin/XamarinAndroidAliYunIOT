using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Org.Mozilla.Javascript.Ast
{
    public partial class AstNode
    {
        public partial class PositionComparator 
        {
            public int Compare(Java.Lang.Object o1, Java.Lang.Object o2)             
            {
                return this.Compare(o1 as AstNode, o2 as AstNode);
            }
        }
    }
}