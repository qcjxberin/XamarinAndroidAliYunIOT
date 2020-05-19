using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Platform {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']"
	[global::Android.Runtime.Register ("okhttp3/internal/platform/ConscryptPlatform", DoNotGenerateAcw=true)]
	public partial class ConscryptPlatform : global::Okhttp3.Internal.Platform.Platform {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/platform/ConscryptPlatform", typeof (ConscryptPlatform));
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

		protected ConscryptPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']/method[@name='buildIfSupported' and count(parameter)=0]"
		[Register ("buildIfSupported", "()Lokhttp3/internal/platform/Platform;", "")]
		public static unsafe global::Okhttp3.Internal.Platform.Platform BuildIfSupported ()
		{
			const string __id = "buildIfSupported.()Lokhttp3/internal/platform/Platform;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
#pragma warning disable 0169
		static Delegate GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler ()
		{
			if (cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ == null)
				cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_);
			return cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
		}

		static IntPtr n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocketFactory)
		{
			global::Okhttp3.Internal.Platform.ConscryptPlatform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.ConscryptPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_sslSocketFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TrustManager (sslSocketFactory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='ConscryptPlatform']/method[@name='trustManager' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register ("trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;", "GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.IX509TrustManager TrustManager (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
		{
			const string __id = "trustManager.(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sslSocketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocketFactory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
