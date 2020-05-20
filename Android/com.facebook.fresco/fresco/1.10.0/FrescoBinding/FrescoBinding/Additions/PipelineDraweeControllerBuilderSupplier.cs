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

namespace Com.Facebook.Drawee.Backends.Pipeline
{
    
    public partial class PipelineDraweeControllerBuilderSupplier : global::Java.Lang.Object, global::Com.Facebook.Common.Internal.ISupplier
    {
        public Java.Lang.Object Get()
        {
            return RawGet();
        }
    }
}