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

namespace Com.Aliyun.Iot.Link.UI.Component
{
    public partial class WheelView
    {
        public override bool Selected
        {
            get
            {
                return RawSelected() == 1;
            }
        }
    }
}