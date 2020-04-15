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

namespace Com.Facebook.Imagepipeline.Producers
{
    public partial class PostprocessorProducer : global::Java.Lang.Object, global::Com.Facebook.Imagepipeline.Producers.IProducer
    {
        public partial class RepeatedPostprocessorConsumer : global::Com.Facebook.Imagepipeline.Producers.DelegatingConsumer, global::Com.Facebook.Imagepipeline.Request.IRepeatedPostprocessorRunner 
        {
            protected override void OnNewResultImpl(Java.Lang.Object p0, [IntDef(Flag = true, Type = "Com.Facebook.Imagepipeline.Producers.IConsumer", Fields = new[] { "IsLast", "DoNotCacheEncoded", "IsPlaceholder", "IsPartialResult", "IsResizingDone" })] int p1)
            {
                RawOnNewResultImpl((global::Com.Facebook.Common.References.CloseableReference)p0, p1);
            }
        }

        public partial class SingleUsePostprocessorConsumer : global::Com.Facebook.Imagepipeline.Producers.DelegatingConsumer
        {
            protected override void OnNewResultImpl(Java.Lang.Object p0, [IntDef(Flag = true, Type = "Com.Facebook.Imagepipeline.Producers.IConsumer", Fields = new[] { "IsLast", "DoNotCacheEncoded", "IsPlaceholder", "IsPartialResult", "IsResizingDone" })] int p1)
            {
                RawOnNewResultImpl((global::Com.Facebook.Common.References.CloseableReference)p0, p1);
            }
        }
    }    
}