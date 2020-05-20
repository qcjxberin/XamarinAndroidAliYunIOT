using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RequestLine", DoNotGenerateAcw=true)]
	public sealed partial class RequestLine : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/RequestLine", typeof (RequestLine));
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

		internal RequestLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']/method[@name='get' and count(parameter)=2 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='java.net.Proxy.Type']]"
		[Register ("get", "(Lokhttp3/Request;Ljava/net/Proxy$Type;)Ljava/lang/String;", "")]
		public static unsafe string Get (global::Okhttp3.Request request, global::Java.Net.Proxy.Type proxyType)
		{
			const string __id = "get.(Lokhttp3/Request;Ljava/net/Proxy$Type;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((proxyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxyType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RequestLine']/method[@name='requestPath' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("requestPath", "(Lokhttp3/HttpUrl;)Ljava/lang/String;", "")]
		public static unsafe string RequestPath (global::Okhttp3.HttpUrl url)
		{
			const string __id = "requestPath.(Lokhttp3/HttpUrl;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
