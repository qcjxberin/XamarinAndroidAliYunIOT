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

namespace Com.Facebook.React.Bridge
{
    public partial class ReadableNativeMap
    {
        public global::Com.Facebook.React.Bridge.IReadableMap GetMap(string p0) 
        {
            return RawGetMap(p0);
        }
    }
}