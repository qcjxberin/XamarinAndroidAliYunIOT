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
    public abstract partial class BaseNetworkFetcher : global::Java.Lang.Object, global::Com.Facebook.Imagepipeline.Producers.INetworkFetcher
    {
        public virtual global::Java.Lang.Object CreateFetchState(global::Com.Facebook.Imagepipeline.Producers.IConsumer p0, global::Com.Facebook.Imagepipeline.Producers.IProducerContext p1) 
        {
            return null;
        }
        public virtual void Fetch(global::Java.Lang.Object p0, global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback p1) 
        {
            
        }
    }
}