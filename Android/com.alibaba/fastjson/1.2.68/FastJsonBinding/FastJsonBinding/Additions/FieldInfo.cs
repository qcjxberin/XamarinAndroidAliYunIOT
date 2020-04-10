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
using Java.Interop;

namespace Com.Alibaba.Fastjson.Util
{    
    public partial class FieldInfo : global::Java.Lang.Object, global::Java.Lang.IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">Com.Alibaba.Fastjson.Util.FieldInfo</param>
        /// <returns></returns>
        public int CompareTo(Java.Lang.Object o)
        {
            return RawCompareTo(o as global::Com.Alibaba.Fastjson.Util.FieldInfo);
        }
    }
}