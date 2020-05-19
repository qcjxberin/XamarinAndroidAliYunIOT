using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.WS {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='WebSocketProtocol']"
	[global::Android.Runtime.Register ("okhttp3/internal/ws/WebSocketProtocol", DoNotGenerateAcw=true)]
	public sealed partial class WebSocketProtocol : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/WebSocketProtocol", typeof (WebSocketProtocol));
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

		internal WebSocketProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='WebSocketProtocol']/method[@name='acceptHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptHeader", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AcceptHeader (string key)
		{
			const string __id = "acceptHeader.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
