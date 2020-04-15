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

namespace Com.Facebook.Common.Executors
{
    public partial class ScheduledFutureImpl : global::Java.Lang.Object, global::Java.Util.Concurrent.IRunnableFuture, global::Java.Util.Concurrent.IScheduledFuture
    {
        public int CompareTo(Java.Lang.Object o) 
        {            
            return RawCompareTo((global::Java.Util.Concurrent.IDelayed)o);
        }
    }
}