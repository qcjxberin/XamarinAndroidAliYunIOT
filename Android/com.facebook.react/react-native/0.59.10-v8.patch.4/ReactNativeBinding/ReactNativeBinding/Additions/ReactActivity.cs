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

namespace Com.Facebook.React
{
    public abstract partial class ReactActivity
    {
        public new int CheckSelfPermission(string p0)
        {
            return RawCheckSelfPermission(p0);
        }
    }
}