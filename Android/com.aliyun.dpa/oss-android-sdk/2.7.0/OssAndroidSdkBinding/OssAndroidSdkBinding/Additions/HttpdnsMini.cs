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

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils
{
    public partial class HttpdnsMini : global::Java.Lang.Object
    {                
        public partial class QueryHostTask : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable 
        {
            public Java.Lang.Object Call() 
            {
                return RawCall();
            }
        }
    }
}