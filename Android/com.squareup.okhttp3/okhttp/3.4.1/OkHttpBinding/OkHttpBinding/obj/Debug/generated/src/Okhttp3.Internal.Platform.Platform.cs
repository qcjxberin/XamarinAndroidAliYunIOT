using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Platform {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']"
	[global::Android.Runtime.Register ("okhttp3/internal/platform/Platform", DoNotGenerateAcw=true)]
	public partial class Platform : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 5;
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/platform/Platform", typeof (Platform));
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

		protected Platform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/constructor[@name='Platform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Platform ()
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

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				const string __id = "getPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_afterHandshake_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetAfterHandshake_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_afterHandshake_Ljavax_net_ssl_SSLSocket_ == null)
				cb_afterHandshake_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterHandshake_Ljavax_net_ssl_SSLSocket_);
			return cb_afterHandshake_Ljavax_net_ssl_SSLSocket_;
		}

		static void n_AfterHandshake_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocket)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket sslSocket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_sslSocket, JniHandleOwnership.DoNotTransfer);
			__this.AfterHandshake (sslSocket);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='afterHandshake' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("afterHandshake", "(Ljavax/net/ssl/SSLSocket;)V", "GetAfterHandshake_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual unsafe void AfterHandshake (global::Javax.Net.Ssl.SSLSocket sslSocket)
		{
			const string __id = "afterHandshake.(Ljavax/net/ssl/SSLSocket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sslSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocket).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='alpnProtocolNames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
		[Register ("alpnProtocolNames", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> AlpnProtocolNames (global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
		{
			const string __id = "alpnProtocolNames.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_protocols);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_protocols);
			}
		}

		static Delegate cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_;
#pragma warning disable 0169
		static Delegate GetBuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_Handler ()
		{
			if (cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ == null)
				cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_);
			return cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_;
		}

		static IntPtr n_BuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trustManager)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.IX509TrustManager trustManager = (global::Javax.Net.Ssl.IX509TrustManager)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (native_trustManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildCertificateChainCleaner (trustManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='buildCertificateChainCleaner' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("buildCertificateChainCleaner", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;", "GetBuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_Handler")]
		public virtual unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner BuildCertificateChainCleaner (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			const string __id = "buildCertificateChainCleaner.(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trustManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trustManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ == null)
				cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_);
			return cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_ConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocket, IntPtr native_hostname, IntPtr native_protocols)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket sslSocket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_sslSocket, JniHandleOwnership.DoNotTransfer);
			string hostname = JNIEnv.GetString (native_hostname, JniHandleOwnership.DoNotTransfer);
			var protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (native_protocols, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureTlsExtensions (sslSocket, hostname, protocols);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='configureTlsExtensions' and count(parameter)=3 and parameter[1][@type='javax.net.ssl.SSLSocket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
		[Register ("configureTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;Ljava/util/List;)V", "GetConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void ConfigureTlsExtensions (global::Javax.Net.Ssl.SSLSocket sslSocket, string hostname, global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
		{
			const string __id = "configureTlsExtensions.(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sslSocket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocket).Handle);
				__args [1] = new JniArgumentValue (native_hostname);
				__args [2] = new JniArgumentValue (native_protocols);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_protocols);
			}
		}

		static Delegate cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
#pragma warning disable 0169
		static Delegate GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler ()
		{
			if (cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I == null)
				cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I);
			return cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
		}

		static void n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_socket, IntPtr native_address, int connectTimeout)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress address = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_address, JniHandleOwnership.DoNotTransfer);
			__this.ConnectSocket (socket, address, connectTimeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='connectSocket' and count(parameter)=3 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='int']]"
		[Register ("connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V", "GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler")]
		public virtual unsafe void ConnectSocket (global::Java.Net.Socket socket, global::Java.Net.InetSocketAddress address, int connectTimeout)
		{
			const string __id = "connectSocket.(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				__args [1] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [2] = new JniArgumentValue (connectTimeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lokhttp3/internal/platform/Platform;", "")]
		public static unsafe global::Okhttp3.Internal.Platform.Platform Get ()
		{
			const string __id = "get.()Lokhttp3/internal/platform/Platform;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetGetSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ == null)
				cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSelectedProtocol_Ljavax_net_ssl_SSLSocket_);
			return cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
		}

		static IntPtr n_GetSelectedProtocol_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket socket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_socket, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSelectedProtocol (socket));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getSelectedProtocol' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("getSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)Ljava/lang/String;", "GetGetSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual unsafe string GetSelectedProtocol (global::Javax.Net.Ssl.SSLSocket socket)
		{
			const string __id = "getSelectedProtocol.(Ljavax/net/ssl/SSLSocket;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isCleartextTrafficPermitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsCleartextTrafficPermitted_Ljava_lang_String_Handler ()
		{
			if (cb_isCleartextTrafficPermitted_Ljava_lang_String_ == null)
				cb_isCleartextTrafficPermitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsCleartextTrafficPermitted_Ljava_lang_String_);
			return cb_isCleartextTrafficPermitted_Ljava_lang_String_;
		}

		static bool n_IsCleartextTrafficPermitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostname)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string hostname = JNIEnv.GetString (native_hostname, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCleartextTrafficPermitted (hostname);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='isCleartextTrafficPermitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCleartextTrafficPermitted", "(Ljava/lang/String;)Z", "GetIsCleartextTrafficPermitted_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsCleartextTrafficPermitted (string hostname)
		{
			const string __id = "isCleartextTrafficPermitted.(Ljava/lang/String;)Z";
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hostname);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
			}
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_Throwable_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Log_ILjava_lang_String_Ljava_lang_Throwable_);
			return cb_log_ILjava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int level, IntPtr native_message, IntPtr native_t)
		{
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, message, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (int level, string message, global::Java.Lang.Throwable t)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (level);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
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
			global::Okhttp3.Internal.Platform.Platform __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_sslSocketFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TrustManager (sslSocketFactory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='trustManager' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
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
