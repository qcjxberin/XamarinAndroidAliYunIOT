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

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option
{
    public partial class Option
    {
        public int CompareTo(Java.Lang.Object o)
        {
            return RawCompareTo(o as global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Option.Option);
        }
    }
}