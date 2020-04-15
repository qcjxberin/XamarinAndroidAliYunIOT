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

namespace Com.Facebook.Imagepipeline.Bitmaps
{
    public partial class SimpleBitmapReleaser : global::Java.Lang.Object, global::Com.Facebook.Common.References.IResourceReleaser
    {
        public void Release(Java.Lang.Object p0)
        {
            RawRelease((global::Android.Graphics.Bitmap)p0);
        }
    }
}