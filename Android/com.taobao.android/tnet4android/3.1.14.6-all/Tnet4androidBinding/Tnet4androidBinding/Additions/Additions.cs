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

namespace Org.Android.Spdy
{
    public partial class SpdyByteArray 
    {
        public int CompareTo(Java.Lang.Object o) 
        {
            return CompareTo(o as SpdyByteArray);
        }
    }
}