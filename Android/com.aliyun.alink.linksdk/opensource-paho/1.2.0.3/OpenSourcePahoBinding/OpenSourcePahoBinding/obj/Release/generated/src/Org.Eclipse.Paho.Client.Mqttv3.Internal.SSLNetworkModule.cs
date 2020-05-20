using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/SSLNetworkModule", DoNotGenerateAcw=true)]
	public partial class SSLNetworkModule : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/SSLNetworkModule", typeof (SSLNetworkModule));
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

		protected SSLNetworkModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/constructor[@name='SSLNetworkModule' and count(parameter)=4 and parameter[1][@type='javax.net.ssl.SSLSocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe SSLNetworkModule (global::Javax.Net.Ssl.SSLSocketFactory factory, string host, int port, string resourceContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_resourceContext = JNIEnv.NewString (resourceContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				__args [1] = new JniArgumentValue (native_host);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_resourceContext);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_resourceContext);
			}
		}

		static Delegate cb_getSSLHostnameVerifier;
#pragma warning disable 0169
		static Delegate GetGetSSLHostnameVerifierHandler ()
		{
			if (cb_getSSLHostnameVerifier == null)
				cb_getSSLHostnameVerifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSLHostnameVerifier);
			return cb_getSSLHostnameVerifier;
		}

		static IntPtr n_GetSSLHostnameVerifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLHostnameVerifier);
		}
#pragma warning restore 0169

		static Delegate cb_setSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
#pragma warning disable 0169
		static Delegate GetSetSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler ()
		{
			if (cb_setSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == null)
				cb_setSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_);
			return cb_setSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		}

		static void n_SetSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostnameVerifier)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier = (global::Javax.Net.Ssl.IHostnameVerifier)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (native_hostnameVerifier, JniHandleOwnership.DoNotTransfer);
			__this.SSLHostnameVerifier = hostnameVerifier;
		}
#pragma warning restore 0169

		public virtual unsafe global::Javax.Net.Ssl.IHostnameVerifier SSLHostnameVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='getSSLHostnameVerifier' and count(parameter)=0]"
			[Register ("getSSLHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "GetGetSSLHostnameVerifierHandler")]
			get {
				const string __id = "getSSLHostnameVerifier.()Ljavax/net/ssl/HostnameVerifier;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='setSSLHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
			[Register ("setSSLHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "GetSetSSLHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler")]
			set {
				const string __id = "setSSLHostnameVerifier.(Ljavax/net/ssl/HostnameVerifier;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnabledCiphers;
#pragma warning disable 0169
		static Delegate GetGetEnabledCiphersHandler ()
		{
			if (cb_getEnabledCiphers == null)
				cb_getEnabledCiphers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnabledCiphers);
			return cb_getEnabledCiphers;
		}

		static IntPtr n_GetEnabledCiphers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnabledCiphers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='getEnabledCiphers' and count(parameter)=0]"
		[Register ("getEnabledCiphers", "()[Ljava/lang/String;", "GetGetEnabledCiphersHandler")]
		public virtual unsafe string[] GetEnabledCiphers ()
		{
			const string __id = "getEnabledCiphers.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setEnabledCiphers_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEnabledCiphers_arrayLjava_lang_String_Handler ()
		{
			if (cb_setEnabledCiphers_arrayLjava_lang_String_ == null)
				cb_setEnabledCiphers_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnabledCiphers_arrayLjava_lang_String_);
			return cb_setEnabledCiphers_arrayLjava_lang_String_;
		}

		static void n_SetEnabledCiphers_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enabledCiphers)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] enabledCiphers = (string[]) JNIEnv.GetArray (native_enabledCiphers, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetEnabledCiphers (enabledCiphers);
			if (enabledCiphers != null)
				JNIEnv.CopyArray (enabledCiphers, native_enabledCiphers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='setEnabledCiphers' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setEnabledCiphers", "([Ljava/lang/String;)V", "GetSetEnabledCiphers_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetEnabledCiphers (string[] enabledCiphers)
		{
			const string __id = "setEnabledCiphers.([Ljava/lang/String;)V";
			IntPtr native_enabledCiphers = JNIEnv.NewArray (enabledCiphers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_enabledCiphers);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (enabledCiphers != null) {
					JNIEnv.CopyArray (native_enabledCiphers, enabledCiphers);
					JNIEnv.DeleteLocalRef (native_enabledCiphers);
				}
			}
		}

		static Delegate cb_setSSLhandshakeTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetSSLhandshakeTimeout_IHandler ()
		{
			if (cb_setSSLhandshakeTimeout_I == null)
				cb_setSSLhandshakeTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSSLhandshakeTimeout_I);
			return cb_setSSLhandshakeTimeout_I;
		}

		static void n_SetSSLhandshakeTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSSLhandshakeTimeout (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='setSSLhandshakeTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSSLhandshakeTimeout", "(I)V", "GetSetSSLhandshakeTimeout_IHandler")]
		public virtual unsafe void SetSSLhandshakeTimeout (int timeout)
		{
			const string __id = "setSSLhandshakeTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
