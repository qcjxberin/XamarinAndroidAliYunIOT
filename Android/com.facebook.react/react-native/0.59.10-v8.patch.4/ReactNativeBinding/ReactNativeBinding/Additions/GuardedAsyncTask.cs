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
    
    public abstract partial class GuardedAsyncTask
    {
        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return RawDoInBackground(@params);
        }
    }
}