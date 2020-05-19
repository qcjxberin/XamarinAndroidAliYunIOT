using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']"
	[global::Android.Runtime.Register ("okhttp3/internal/tls/OkHostnameVerifier", DoNotGenerateAcw=true)]
	public sealed partial class OkHostnameVerifier : global::Java.Lang.Object, global::Javax.Net.Ssl.IHostnameVerifier {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Okhttp3.Internal.Tls.OkHostnameVerifier Instance {
			get {
				const string __id = "INSTANCE.Lokhttp3/internal/tls/OkHostnameVerifier;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.OkHostnameVerifier> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/tls/OkHostnameVerifier", typeof (OkHostnameVerifier));
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

		internal OkHostnameVerifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='allSubjectAltNames' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("allSubjectAltNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> AllSubjectAltNames (global::Java.Security.Cert.X509Certificate certificate)
		{
			const string __id = "allSubjectAltNames.(Ljava/security/cert/X509Certificate;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((certificate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.X509Certificate']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z", "")]
		public unsafe bool Verify (string host, global::Java.Security.Cert.X509Certificate certificate)
		{
			const string __id = "verify.(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue ((certificate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.net.ssl.SSLSession']]"
		[Register ("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "")]
		public unsafe bool Verify (string host, global::Javax.Net.Ssl.ISSLSession session)
		{
			const string __id = "verify.(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verifyHostname' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("verifyHostname", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe bool VerifyHostname (string hostname, string pattern)
		{
			const string __id = "verifyHostname.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_hostname);
				__args [1] = new JniArgumentValue (native_pattern);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_pattern);
			}
		}

	}
}
