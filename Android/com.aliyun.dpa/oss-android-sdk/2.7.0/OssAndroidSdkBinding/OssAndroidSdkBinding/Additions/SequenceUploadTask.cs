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

namespace Com.Alibaba.Sdk.Android.Oss.Internal
{
    public partial class SequenceUploadTask : global::Com.Alibaba.Sdk.Android.Oss.Internal.BaseMultipartUploadTask, global::Java.Util.Concurrent.ICallable
    {
        protected override global::Java.Lang.Object DoMultipartUpload() 
        {
            return RawDoMultipartUpload();
        }
    }
}