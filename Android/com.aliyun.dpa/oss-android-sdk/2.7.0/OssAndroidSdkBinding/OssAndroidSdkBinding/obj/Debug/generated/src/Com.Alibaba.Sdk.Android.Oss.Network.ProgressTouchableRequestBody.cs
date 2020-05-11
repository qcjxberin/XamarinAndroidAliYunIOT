using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ProgressTouchableRequestBody']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/network/ProgressTouchableRequestBody", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.alibaba.sdk.android.oss.model.OSSRequest"})]
	public partial class ProgressTouchableRequestBody : global::Okhttp3.RequestBody {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/network/ProgressTouchableRequestBody", typeof (ProgressTouchableRequestBody));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ProgressTouchableRequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ProgressTouchableRequestBody']/constructor[@name='ProgressTouchableRequestBody' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.oss.network.ExecutionContext']]"
		[Register (".ctor", "(Ljava/io/InputStream;JLjava/lang/String;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)V", "")]
		public unsafe ProgressTouchableRequestBody (global::System.IO.Stream input, long contentLength, string contentType, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;JLjava/lang/String;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			IntPtr native_contentType = JNIEnv.NewString (contentType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (contentLength);
				__args [2] = new JniArgumentValue (native_contentType);
				__args [3] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_contentType);
			}
		}

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ProgressTouchableRequestBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "GetContentTypeHandler")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			const string __id = "contentType.()Lokhttp3/MediaType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeTo_Lokio_BufferedSink_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Lokio_BufferedSink_Handler ()
		{
			if (cb_writeTo_Lokio_BufferedSink_ == null)
				cb_writeTo_Lokio_BufferedSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Lokio_BufferedSink_);
			return cb_writeTo_Lokio_BufferedSink_;
		}

		static void n_WriteTo_Lokio_BufferedSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sink)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.IBufferedSink sink = (global::Okio.IBufferedSink)global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (native_sink, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (sink);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='ProgressTouchableRequestBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='okio.BufferedSink']]"
		[Register ("writeTo", "(Lokio/BufferedSink;)V", "GetWriteTo_Lokio_BufferedSink_Handler")]
		public virtual unsafe void WriteTo (global::Okio.IBufferedSink sink)
		{
			const string __id = "writeTo.(Lokio/BufferedSink;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
