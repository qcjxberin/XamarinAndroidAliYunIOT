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
    public partial class EncodedCacheKeyMultiplexProducer : global::Com.Facebook.Imagepipeline.Producers.MultiplexProducer
    {
        
        protected override Java.Lang.Object CloneOrNull(Java.Lang.Object p0)
        {
            return RawCloneOrNull((global::Com.Facebook.Imagepipeline.Image.EncodedImage)p0);
        }
        protected override Java.Lang.Object GetKey(IProducerContext p0)
        {
            return RawGetKey(p0);
        }
    }
}