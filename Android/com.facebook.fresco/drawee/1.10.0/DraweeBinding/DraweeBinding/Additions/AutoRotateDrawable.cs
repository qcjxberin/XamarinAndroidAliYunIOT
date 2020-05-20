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

namespace Com.Facebook.Drawee.Drawable
{
    public partial class AutoRotateDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable, global::Com.Facebook.Drawee.Drawable.ICloneableDrawable, global::Java.Lang.IRunnable
    {
        public global::Android.Graphics.Drawables.Drawable CloneDrawable() 
        {
            return RawCloneDrawable();
        }
    }
}