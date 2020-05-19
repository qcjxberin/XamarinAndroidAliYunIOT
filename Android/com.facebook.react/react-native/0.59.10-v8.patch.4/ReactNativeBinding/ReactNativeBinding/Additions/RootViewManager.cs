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

namespace Com.Facebook.React.Uimanager
{
    public partial class RootViewManager
    {
        protected override Java.Lang.Object CreateViewInstance(ThemedReactContext p0)
        {
            return RawCreateViewInstance(p0);
        }
    }
}