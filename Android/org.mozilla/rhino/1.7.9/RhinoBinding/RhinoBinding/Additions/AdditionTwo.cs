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

namespace Org.Mozilla.Javascript
{
    public partial class Node 
    {
        public partial class NodeIterator 
        {
            public Java.Lang.Object Next() 
            {
                return RawNext();
            }
        }
    }
    public partial class NativeObject 
    {
        public System.Collections.ICollection EntrySet() 
        {
            return RawEntrySet() as System.Collections.ICollection;
        }
        public System.Collections.ICollection KeySet()
        {
            return RawKeySet() as System.Collections.ICollection;
        }

        public System.Collections.ICollection Values()
        {
            return RawValues() as System.Collections.ICollection;
        }
    }
}