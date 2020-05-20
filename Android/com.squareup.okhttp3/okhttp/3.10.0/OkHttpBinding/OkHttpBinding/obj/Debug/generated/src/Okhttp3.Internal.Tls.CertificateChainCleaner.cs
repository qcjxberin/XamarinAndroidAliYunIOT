using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/CertificateChainCleaner", DoNotGenerateAcw=true)]
	public abstract partial class CertificateChainCleaner : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/CertificateChainCleaner", typeof (CertificateChainCleaner));
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

		protected CertificateChainCleaner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/constructor[@name='CertificateChainCleaner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CertificateChainCleaner ()
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

		static Delegate cb_clean_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClean_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_clean_Ljava_util_List_Ljava_lang_String_ == null)
				cb_clean_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Clean_Ljava_util_List_Ljava_lang_String_);
			return cb_clean_Ljava_util_List_Ljava_lang_String_;
		}

		static IntPtr n_Clean_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Tls.CertificateChainCleaner __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (__this.Clean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "GetClean_Ljava_util_List_Ljava_lang_String_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate...']]"
		[Register ("get", "([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/CertificateChainCleaner;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner Get (params global::Java.Security.Cert.X509Certificate[] caCerts)
		{
			const string __id = "get.([Ljava/security/cert/X509Certificate;)Lokhttp3/internal/tls/CertificateChainCleaner;";
			IntPtr native_caCerts = JNIEnv.NewArray (caCerts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_caCerts);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (caCerts != null) {
					JNIEnv.CopyArray (native_caCerts, caCerts);
					JNIEnv.DeleteLocalRef (native_caCerts);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='get' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("get", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;", "")]
		public static unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner Get (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			const string __id = "get.(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trustManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trustManager).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okhttp3/internal/tls/CertificateChainCleaner", DoNotGenerateAcw=true)]
	internal partial class CertificateChainCleanerInvoker : CertificateChainCleaner {

		public CertificateChainCleanerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/CertificateChainCleaner", typeof (CertificateChainCleanerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='CertificateChainCleaner']/method[@name='clean' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("clean", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "GetClean_Ljava_util_List_Ljava_lang_String_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Clean (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> p0, string p1)
		{
			const string __id = "clean.(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
