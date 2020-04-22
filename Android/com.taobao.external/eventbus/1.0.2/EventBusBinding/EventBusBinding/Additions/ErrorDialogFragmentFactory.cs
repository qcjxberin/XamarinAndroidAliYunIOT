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

namespace DE.Greenrobot.Event.Util
{
    public abstract partial class ErrorDialogFragmentFactory
    {
        public partial class Honeycomb 
        {
            protected override Java.Lang.Object CreateErrorFragment(ThrowableFailureEvent p0, Bundle p1)
            {
                return RawCreateErrorFragment(p0, p1);
            }
        }
    }
}