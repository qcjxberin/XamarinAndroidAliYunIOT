using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Address']"
	[global::Android.Runtime.Register ("okhttp3/Address", DoNotGenerateAcw=true)]
	public sealed partial class Address : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Address", typeof (Address));
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

		internal Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Address']/constructor[@name='Address' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='okhttp3.Dns'] and parameter[4][@type='javax.net.SocketFactory'] and parameter[5][@type='javax.net.ssl.SSLSocketFactory'] and parameter[6][@type='javax.net.ssl.HostnameVerifier'] and parameter[7][@type='okhttp3.CertificatePinner'] and parameter[8][@type='okhttp3.Authenticator'] and parameter[9][@type='java.net.Proxy'] and parameter[10][@type='java.util.List&lt;okhttp3.Protocol&gt;'] and parameter[11][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;'] and parameter[12][@type='java.net.ProxySelector']]"
		[Register (".ctor", "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V", "")]
		public unsafe Address (string uriHost, int uriPort, global::Okhttp3.IDns dns, global::Javax.Net.SocketFactory socketFactory, global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory, global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier, global::Okhttp3.CertificatePinner certificatePinner, global::Okhttp3.IAuthenticator proxyAuthenticator, global::Java.Net.Proxy proxy, global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols, global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs, global::Java.Net.ProxySelector proxySelector)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ILokhttp3/Dns;Ljavax/net/SocketFactory;Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/HostnameVerifier;Lokhttp3/CertificatePinner;Lokhttp3/Authenticator;Ljava/net/Proxy;Ljava/util/List;Ljava/util/List;Ljava/net/ProxySelector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_uriHost = JNIEnv.NewString (uriHost);
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (native_uriHost);
				__args [1] = new JniArgumentValue (uriPort);
				__args [2] = new JniArgumentValue ((dns == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dns).Handle);
				__args [3] = new JniArgumentValue ((socketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socketFactory).Handle);
				__args [4] = new JniArgumentValue ((sslSocketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocketFactory).Handle);
				__args [5] = new JniArgumentValue ((hostnameVerifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hostnameVerifier).Handle);
				__args [6] = new JniArgumentValue ((certificatePinner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificatePinner).Handle);
				__args [7] = new JniArgumentValue ((proxyAuthenticator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxyAuthenticator).Handle);
				__args [8] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				__args [9] = new JniArgumentValue (native_protocols);
				__args [10] = new JniArgumentValue (native_connectionSpecs);
				__args [11] = new JniArgumentValue ((proxySelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxySelector).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uriHost);
				JNIEnv.DeleteLocalRef (native_protocols);
				JNIEnv.DeleteLocalRef (native_connectionSpecs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='certificatePinner' and count(parameter)=0]"
		[Register ("certificatePinner", "()Lokhttp3/CertificatePinner;", "")]
		public unsafe global::Okhttp3.CertificatePinner CertificatePinner ()
		{
			const string __id = "certificatePinner.()Lokhttp3/CertificatePinner;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='connectionSpecs' and count(parameter)=0]"
		[Register ("connectionSpecs", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> ConnectionSpecs ()
		{
			const string __id = "connectionSpecs.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='dns' and count(parameter)=0]"
		[Register ("dns", "()Lokhttp3/Dns;", "")]
		public unsafe global::Okhttp3.IDns Dns ()
		{
			const string __id = "dns.()Lokhttp3/Dns;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='hostnameVerifier' and count(parameter)=0]"
		[Register ("hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "")]
		public unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier ()
		{
			const string __id = "hostnameVerifier.()Ljavax/net/ssl/HostnameVerifier;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='protocols' and count(parameter)=0]"
		[Register ("protocols", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.Protocol> Protocols ()
		{
			const string __id = "protocols.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxy' and count(parameter)=0]"
		[Register ("proxy", "()Ljava/net/Proxy;", "")]
		public unsafe global::Java.Net.Proxy Proxy ()
		{
			const string __id = "proxy.()Ljava/net/Proxy;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxyAuthenticator' and count(parameter)=0]"
		[Register ("proxyAuthenticator", "()Lokhttp3/Authenticator;", "")]
		public unsafe global::Okhttp3.IAuthenticator ProxyAuthenticator ()
		{
			const string __id = "proxyAuthenticator.()Lokhttp3/Authenticator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='proxySelector' and count(parameter)=0]"
		[Register ("proxySelector", "()Ljava/net/ProxySelector;", "")]
		public unsafe global::Java.Net.ProxySelector ProxySelector ()
		{
			const string __id = "proxySelector.()Ljava/net/ProxySelector;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.ProxySelector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='socketFactory' and count(parameter)=0]"
		[Register ("socketFactory", "()Ljavax/net/SocketFactory;", "")]
		public unsafe global::Javax.Net.SocketFactory SocketFactory ()
		{
			const string __id = "socketFactory.()Ljavax/net/SocketFactory;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='sslSocketFactory' and count(parameter)=0]"
		[Register ("sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "")]
		public unsafe global::Javax.Net.Ssl.SSLSocketFactory SslSocketFactory ()
		{
			const string __id = "sslSocketFactory.()Ljavax/net/ssl/SSLSocketFactory;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Address']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Url ()
		{
			const string __id = "url.()Lokhttp3/HttpUrl;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
