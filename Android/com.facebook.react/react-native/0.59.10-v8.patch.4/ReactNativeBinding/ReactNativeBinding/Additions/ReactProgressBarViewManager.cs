﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Facebook.React.Uimanager;

namespace Com.Facebook.React.Views.Progressbar
{
    public partial class ReactProgressBarViewManager
    {
        protected override Java.Lang.Object CreateViewInstance(ThemedReactContext p0)
        {
            return RawCreateViewInstance(p0);
        }

        public override void UpdateExtraData(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            
        }
    }
}