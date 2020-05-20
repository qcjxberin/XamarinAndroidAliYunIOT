using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='ConnectionSpecSelector']"
	[global::Android.Runtime.Register ("okhttp3/internal/ConnectionSpecSelector", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionSpecSelector : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ConnectionSpecSelector", typeof (ConnectionSpecSelector));
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

		internal ConnectionSpecSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal']/class[@name='ConnectionSpecSelector']/constructor[@name='ConnectionSpecSelector' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe ConnectionSpecSelector (global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_connectionSpecs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_connectionSpecs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='ConnectionSpecSelector']/method[@name='configureSecureSocket' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("configureSecureSocket", "(Ljavax/net/ssl/SSLSocket;)Lokhttp3/ConnectionSpec;", "")]
		public unsafe global::Okhttp3.ConnectionSpec ConfigureSecureSocket (global::Javax.Net.Ssl.SSLSocket sslSocket)
		{
			const string __id = "configureSecureSocket.(Ljavax/net/ssl/SSLSocket;)Lokhttp3/ConnectionSpec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sslSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocket).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='ConnectionSpecSelector']/method[@name='connectionFailed' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("connectionFailed", "(Ljava/io/IOException;)Z", "")]
		public unsafe bool ConnectionFailed (global::Java.IO.IOException e)
		{
			const string __id = "connectionFailed.(Ljava/io/IOException;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
