using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']"
	[global::Android.Runtime.Register ("okhttp3/OkHttpClient", DoNotGenerateAcw=true)]
	public sealed partial class OkHttpClient : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Okhttp3.ICallFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']"
		[global::Android.Runtime.Register ("okhttp3/OkHttpClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/OkHttpClient$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/constructor[@name='OkHttpClient.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='addInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor']]"
			[Register ("addInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder AddInterceptor (global::Okhttp3.IInterceptor interceptor)
			{
				const string __id = "addInterceptor.(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='addNetworkInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor']]"
			[Register ("addNetworkInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder AddNetworkInterceptor (global::Okhttp3.IInterceptor interceptor)
			{
				const string __id = "addNetworkInterceptor.(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='authenticator' and count(parameter)=1 and parameter[1][@type='okhttp3.Authenticator']]"
			[Register ("authenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Authenticator (global::Okhttp3.IAuthenticator authenticator)
			{
				const string __id = "authenticator.(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((authenticator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) authenticator).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/OkHttpClient;", "")]
			public unsafe global::Okhttp3.OkHttpClient Build ()
			{
				const string __id = "build.()Lokhttp3/OkHttpClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='cache' and count(parameter)=1 and parameter[1][@type='okhttp3.Cache']]"
			[Register ("cache", "(Lokhttp3/Cache;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Cache (global::Okhttp3.Cache cache)
			{
				const string __id = "cache.(Lokhttp3/Cache;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cache).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='certificatePinner' and count(parameter)=1 and parameter[1][@type='okhttp3.CertificatePinner']]"
			[Register ("certificatePinner", "(Lokhttp3/CertificatePinner;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder CertificatePinner (global::Okhttp3.CertificatePinner certificatePinner)
			{
				const string __id = "certificatePinner.(Lokhttp3/CertificatePinner;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((certificatePinner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificatePinner).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("connectTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				const string __id = "connectTimeout.(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (timeout);
					__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectionPool' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
			[Register ("connectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectionPool (global::Okhttp3.ConnectionPool connectionPool)
			{
				const string __id = "connectionPool.(Lokhttp3/ConnectionPool;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((connectionPool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionPool).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectionSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;']]"
			[Register ("connectionSpecs", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectionSpecs (global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs)
			{
				const string __id = "connectionSpecs.(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;";
				IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_connectionSpecs);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_connectionSpecs);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='cookieJar' and count(parameter)=1 and parameter[1][@type='okhttp3.CookieJar']]"
			[Register ("cookieJar", "(Lokhttp3/CookieJar;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder CookieJar (global::Okhttp3.ICookieJar cookieJar)
			{
				const string __id = "cookieJar.(Lokhttp3/CookieJar;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cookieJar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cookieJar).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='dispatcher' and count(parameter)=1 and parameter[1][@type='okhttp3.Dispatcher']]"
			[Register ("dispatcher", "(Lokhttp3/Dispatcher;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Dispatcher (global::Okhttp3.Dispatcher dispatcher)
			{
				const string __id = "dispatcher.(Lokhttp3/Dispatcher;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispatcher).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='dns' and count(parameter)=1 and parameter[1][@type='okhttp3.Dns']]"
			[Register ("dns", "(Lokhttp3/Dns;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Dns (global::Okhttp3.IDns dns)
			{
				const string __id = "dns.(Lokhttp3/Dns;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dns == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dns).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='followRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("followRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder FollowRedirects (bool followRedirects)
			{
				const string __id = "followRedirects.(Z)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (followRedirects);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='followSslRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("followSslRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder FollowSslRedirects (bool followProtocolRedirects)
			{
				const string __id = "followSslRedirects.(Z)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (followProtocolRedirects);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='hostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
			[Register ("hostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder HostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier)
			{
				const string __id = "hostnameVerifier.(Ljavax/net/ssl/HostnameVerifier;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((hostnameVerifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hostnameVerifier).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='interceptors' and count(parameter)=0]"
			[Register ("interceptors", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> Interceptors ()
			{
				const string __id = "interceptors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='networkInterceptors' and count(parameter)=0]"
			[Register ("networkInterceptors", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> NetworkInterceptors ()
			{
				const string __id = "networkInterceptors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='protocols' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
			[Register ("protocols", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Protocols (global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
			{
				const string __id = "protocols.(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;";
				IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_protocols);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_protocols);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxy' and count(parameter)=1 and parameter[1][@type='java.net.Proxy']]"
			[Register ("proxy", "(Ljava/net/Proxy;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Proxy (global::Java.Net.Proxy proxy)
			{
				const string __id = "proxy.(Ljava/net/Proxy;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxyAuthenticator' and count(parameter)=1 and parameter[1][@type='okhttp3.Authenticator']]"
			[Register ("proxyAuthenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ProxyAuthenticator (global::Okhttp3.IAuthenticator proxyAuthenticator)
			{
				const string __id = "proxyAuthenticator.(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((proxyAuthenticator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxyAuthenticator).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxySelector' and count(parameter)=1 and parameter[1][@type='java.net.ProxySelector']]"
			[Register ("proxySelector", "(Ljava/net/ProxySelector;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ProxySelector (global::Java.Net.ProxySelector proxySelector)
			{
				const string __id = "proxySelector.(Ljava/net/ProxySelector;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((proxySelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxySelector).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='readTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("readTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ReadTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				const string __id = "readTimeout.(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (timeout);
					__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='retryOnConnectionFailure' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("retryOnConnectionFailure", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder RetryOnConnectionFailure (bool retryOnConnectionFailure)
			{
				const string __id = "retryOnConnectionFailure.(Z)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (retryOnConnectionFailure);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='socketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.SocketFactory']]"
			[Register ("socketFactory", "(Ljavax/net/SocketFactory;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder SocketFactory (global::Javax.Net.SocketFactory socketFactory)
			{
				const string __id = "socketFactory.(Ljavax/net/SocketFactory;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((socketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socketFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='sslSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
			[Register ("sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder SslSocketFactory (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
			{
				const string __id = "sslSocketFactory.(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((sslSocketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocketFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='writeTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("writeTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder WriteTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				const string __id = "writeTimeout.(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (timeout);
					__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/OkHttpClient", typeof (OkHttpClient));
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

		internal OkHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/constructor[@name='OkHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OkHttpClient ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='authenticator' and count(parameter)=0]"
		[Register ("authenticator", "()Lokhttp3/Authenticator;", "")]
		public unsafe global::Okhttp3.IAuthenticator Authenticator ()
		{
			const string __id = "authenticator.()Lokhttp3/Authenticator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lokhttp3/Cache;", "")]
		public unsafe global::Okhttp3.Cache Cache ()
		{
			const string __id = "cache.()Lokhttp3/Cache;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Cache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='certificatePinner' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectTimeoutMillis' and count(parameter)=0]"
		[Register ("connectTimeoutMillis", "()I", "")]
		public unsafe int ConnectTimeoutMillis ()
		{
			const string __id = "connectTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectionPool' and count(parameter)=0]"
		[Register ("connectionPool", "()Lokhttp3/ConnectionPool;", "")]
		public unsafe global::Okhttp3.ConnectionPool ConnectionPool ()
		{
			const string __id = "connectionPool.()Lokhttp3/ConnectionPool;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectionSpecs' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='cookieJar' and count(parameter)=0]"
		[Register ("cookieJar", "()Lokhttp3/CookieJar;", "")]
		public unsafe global::Okhttp3.ICookieJar CookieJar ()
		{
			const string __id = "cookieJar.()Lokhttp3/CookieJar;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='dispatcher' and count(parameter)=0]"
		[Register ("dispatcher", "()Lokhttp3/Dispatcher;", "")]
		public unsafe global::Okhttp3.Dispatcher Dispatcher ()
		{
			const string __id = "dispatcher.()Lokhttp3/Dispatcher;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Dispatcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='dns' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='followRedirects' and count(parameter)=0]"
		[Register ("followRedirects", "()Z", "")]
		public unsafe bool FollowRedirects ()
		{
			const string __id = "followRedirects.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='followSslRedirects' and count(parameter)=0]"
		[Register ("followSslRedirects", "()Z", "")]
		public unsafe bool FollowSslRedirects ()
		{
			const string __id = "followSslRedirects.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='hostnameVerifier' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='interceptors' and count(parameter)=0]"
		[Register ("interceptors", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> Interceptors ()
		{
			const string __id = "interceptors.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='networkInterceptors' and count(parameter)=0]"
		[Register ("networkInterceptors", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> NetworkInterceptors ()
		{
			const string __id = "networkInterceptors.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/OkHttpClient$Builder;", "")]
		public unsafe global::Okhttp3.OkHttpClient.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lokhttp3/OkHttpClient$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='newCall' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("newCall", "(Lokhttp3/Request;)Lokhttp3/Call;", "")]
		public unsafe global::Okhttp3.ICall NewCall (global::Okhttp3.Request request)
		{
			const string __id = "newCall.(Lokhttp3/Request;)Lokhttp3/Call;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='protocols' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxy' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxyAuthenticator' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxySelector' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='readTimeoutMillis' and count(parameter)=0]"
		[Register ("readTimeoutMillis", "()I", "")]
		public unsafe int ReadTimeoutMillis ()
		{
			const string __id = "readTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='retryOnConnectionFailure' and count(parameter)=0]"
		[Register ("retryOnConnectionFailure", "()Z", "")]
		public unsafe bool RetryOnConnectionFailure ()
		{
			const string __id = "retryOnConnectionFailure.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='socketFactory' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='sslSocketFactory' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='writeTimeoutMillis' and count(parameter)=0]"
		[Register ("writeTimeoutMillis", "()I", "")]
		public unsafe int WriteTimeoutMillis ()
		{
			const string __id = "writeTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
