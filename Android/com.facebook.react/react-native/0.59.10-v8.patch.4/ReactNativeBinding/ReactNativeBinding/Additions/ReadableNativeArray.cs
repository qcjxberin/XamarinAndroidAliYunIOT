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
    public partial class ReadableNativeArray
    {
        public global::Com.Facebook.React.Bridge.IReadableMap GetMap(int p0) 
        {
            return RawGetMap(p0);
        }
        public global::Com.Facebook.React.Bridge.IReadableArray GetArray(int p0) 
        {
            return RawGetArray(p0);
        }
    }
}