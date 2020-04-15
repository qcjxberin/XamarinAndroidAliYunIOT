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

namespace Com.Facebook.Imagepipeline.Producers
{
    public partial class HttpUrlConnectionNetworkFetcher : global::Com.Facebook.Imagepipeline.Producers.BaseNetworkFetcher
    {
		public override Java.Lang.Object CreateFetchState(IConsumer p0, IProducerContext p1)
		{
			return RawCreateFetchState(p0, p1);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.producers']/class[@name='HttpUrlConnectionNetworkFetcher']/method[@name='createFetchState' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.producers.Consumer&lt;com.facebook.imagepipeline.image.EncodedImage&gt;'] and parameter[2][@type='com.facebook.imagepipeline.producers.ProducerContext']]"
		[Register("createFetchState", "(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)Lcom/facebook/imagepipeline/producers/FetchState;", "GetRawCreateFetchState_Lcom_facebook_imagepipeline_producers_Consumer_Lcom_facebook_imagepipeline_producers_ProducerContext_Handler")]
		public unsafe global::Com.Facebook.Imagepipeline.Producers.FetchState RawCreateFetchState(global::Com.Facebook.Imagepipeline.Producers.IConsumer consumer, global::Com.Facebook.Imagepipeline.Producers.IProducerContext context)
		{
			const string __id = "createFetchState.(Lcom/facebook/imagepipeline/producers/Consumer;Lcom/facebook/imagepipeline/producers/ProducerContext;)Lcom/facebook/imagepipeline/producers/FetchState;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)consumer).Handle);
				__args[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Producers.FetchState>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		public override void Fetch(Java.Lang.Object p0, INetworkFetcherCallback p1)
		{
			RawFetch((global::Com.Facebook.Imagepipeline.Producers.FetchState)p0, p1);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.producers']/class[@name='HttpUrlConnectionNetworkFetcher']/method[@name='fetch' and count(parameter)=2 and parameter[1][@type='com.facebook.imagepipeline.producers.FetchState'] and parameter[2][@type='com.facebook.imagepipeline.producers.NetworkFetcher.Callback']]"
		[Register("fetch", "(Lcom/facebook/imagepipeline/producers/FetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;)V", "GetFetch_Lcom_facebook_imagepipeline_producers_FetchState_Lcom_facebook_imagepipeline_producers_NetworkFetcher_Callback_Handler")]
		public unsafe void RawFetch(global::Com.Facebook.Imagepipeline.Producers.FetchState fetchState, global::Com.Facebook.Imagepipeline.Producers.INetworkFetcherCallback @callback)
		{
			const string __id = "fetch.(Lcom/facebook/imagepipeline/producers/FetchState;Lcom/facebook/imagepipeline/producers/NetworkFetcher$Callback;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue((fetchState == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fetchState).Handle);
				__args[1] = new JniArgumentValue((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}
	}
}