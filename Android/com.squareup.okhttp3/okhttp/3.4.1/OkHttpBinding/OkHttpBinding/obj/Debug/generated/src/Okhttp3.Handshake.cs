using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']"
	[global::Android.Runtime.Register ("okhttp3/Handshake", DoNotGenerateAcw=true)]
	public sealed partial class Handshake : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Handshake", typeof (Handshake));
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

		internal Handshake (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='cipherSuite' and count(parameter)=0]"
		[Register ("cipherSuite", "()Lokhttp3/CipherSuite;", "")]
		public unsafe global::Okhttp3.CipherSuite CipherSuite ()
		{
			const string __id = "cipherSuite.()Lokhttp3/CipherSuite;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CipherSuite> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='get' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSession']]"
		[Register ("get", "(Ljavax/net/ssl/SSLSession;)Lokhttp3/Handshake;", "")]
		public static unsafe global::Okhttp3.Handshake Get (global::Javax.Net.Ssl.ISSLSession session)
		{
			const string __id = "get.(Ljavax/net/ssl/SSLSession;)Lokhttp3/Handshake;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='get' and count(parameter)=4 and parameter[1][@type='okhttp3.TlsVersion'] and parameter[2][@type='okhttp3.CipherSuite'] and parameter[3][@type='java.util.List&lt;java.security.cert.Certificate&gt;'] and parameter[4][@type='java.util.List&lt;java.security.cert.Certificate&gt;']]"
		[Register ("get", "(Lokhttp3/TlsVersion;Lokhttp3/CipherSuite;Ljava/util/List;Ljava/util/List;)Lokhttp3/Handshake;", "")]
		public static unsafe global::Okhttp3.Handshake Get (global::Okhttp3.TlsVersion tlsVersion, global::Okhttp3.CipherSuite cipherSuite, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> peerCertificates, global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> localCertificates)
		{
			const string __id = "get.(Lokhttp3/TlsVersion;Lokhttp3/CipherSuite;Ljava/util/List;Ljava/util/List;)Lokhttp3/Handshake;";
			IntPtr native_peerCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (peerCertificates);
			IntPtr native_localCertificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (localCertificates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((tlsVersion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlsVersion).Handle);
				__args [1] = new JniArgumentValue ((cipherSuite == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cipherSuite).Handle);
				__args [2] = new JniArgumentValue (native_peerCertificates);
				__args [3] = new JniArgumentValue (native_localCertificates);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_peerCertificates);
				JNIEnv.DeleteLocalRef (native_localCertificates);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='localCertificates' and count(parameter)=0]"
		[Register ("localCertificates", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> LocalCertificates ()
		{
			const string __id = "localCertificates.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='localPrincipal' and count(parameter)=0]"
		[Register ("localPrincipal", "()Ljava/security/Principal;", "")]
		public unsafe global::Java.Security.IPrincipal LocalPrincipal ()
		{
			const string __id = "localPrincipal.()Ljava/security/Principal;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='peerCertificates' and count(parameter)=0]"
		[Register ("peerCertificates", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> PeerCertificates ()
		{
			const string __id = "peerCertificates.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='peerPrincipal' and count(parameter)=0]"
		[Register ("peerPrincipal", "()Ljava/security/Principal;", "")]
		public unsafe global::Java.Security.IPrincipal PeerPrincipal ()
		{
			const string __id = "peerPrincipal.()Ljava/security/Principal;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Handshake']/method[@name='tlsVersion' and count(parameter)=0]"
		[Register ("tlsVersion", "()Lokhttp3/TlsVersion;", "")]
		public unsafe global::Okhttp3.TlsVersion TlsVersion ()
		{
			const string __id = "tlsVersion.()Lokhttp3/TlsVersion;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.TlsVersion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
