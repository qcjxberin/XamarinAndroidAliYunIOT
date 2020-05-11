using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='NetworkProgressHelper']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/network/NetworkProgressHelper", DoNotGenerateAcw=true)]
	public partial class NetworkProgressHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/network/NetworkProgressHelper", typeof (NetworkProgressHelper));
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

		protected NetworkProgressHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='NetworkProgressHelper']/constructor[@name='NetworkProgressHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkProgressHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='NetworkProgressHelper']/method[@name='addProgressRequestBody' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.alibaba.sdk.android.oss.network.ExecutionContext']]"
		[Register ("addProgressRequestBody", "(Ljava/io/InputStream;JLjava/lang/String;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)Lcom/alibaba/sdk/android/oss/network/ProgressTouchableRequestBody;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody AddProgressRequestBody (global::System.IO.Stream input, long contentLength, string contentType, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context)
		{
			const string __id = "addProgressRequestBody.(Ljava/io/InputStream;JLjava/lang/String;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)Lcom/alibaba/sdk/android/oss/network/ProgressTouchableRequestBody;";
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			IntPtr native_contentType = JNIEnv.NewString (contentType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (contentLength);
				__args [2] = new JniArgumentValue (native_contentType);
				__args [3] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Network.ProgressTouchableRequestBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_contentType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.network']/class[@name='NetworkProgressHelper']/method[@name='addProgressResponseListener' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='com.alibaba.sdk.android.oss.network.ExecutionContext']]"
		[Register ("addProgressResponseListener", "(Lokhttp3/OkHttpClient;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)Lokhttp3/OkHttpClient;", "")]
		public static unsafe global::Okhttp3.OkHttpClient AddProgressResponseListener (global::Okhttp3.OkHttpClient client, global::Com.Alibaba.Sdk.Android.Oss.Network.ExecutionContext context)
		{
			const string __id = "addProgressResponseListener.(Lokhttp3/OkHttpClient;Lcom/alibaba/sdk/android/oss/network/ExecutionContext;)Lokhttp3/OkHttpClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
