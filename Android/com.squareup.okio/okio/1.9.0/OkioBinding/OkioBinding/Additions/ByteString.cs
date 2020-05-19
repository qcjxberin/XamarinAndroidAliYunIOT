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

namespace Okio
{
    public partial class ByteString : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            return RawCompareTo((global::Okio.ByteString)o);
        }
    }
}