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

namespace Com.Aliyun.Alink.Page.RN
{
    public partial class RNActivity
    {
        public new int CheckPermission(string p0, int p1, int p2)
        {
            var cw = new ContextWrapper(this);
            var result = cw.BaseContext.CheckPermission(p0, p1, p2);
            return (int)result;
        }
        public new int CheckSelfPermission(string p0) 
        {
            var cw = new ContextWrapper(this);
            var result = cw.BaseContext.CheckSelfPermission(p0);
            return (int)result;
        }
    }
}