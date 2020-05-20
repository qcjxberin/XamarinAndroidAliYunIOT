using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/security/SSLSocketFactoryFactory", DoNotGenerateAcw=true)]
	public partial class SSLSocketFactoryFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='CIPHERSUITES']"
		[Register ("CIPHERSUITES")]
		public const string Ciphersuites = (string) "com.ibm.ssl.enabledCipherSuites";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='CLIENTAUTH']"
		[Register ("CLIENTAUTH")]
		public const string Clientauth = (string) "com.ibm.ssl.clientAuthentication";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='DEFAULT_PROTOCOL']"
		[Register ("DEFAULT_PROTOCOL")]
		public const string DefaultProtocol = (string) "TLS";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='JSSEPROVIDER']"
		[Register ("JSSEPROVIDER")]
		public const string Jsseprovider = (string) "com.ibm.ssl.contextProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTORE']"
		[Register ("KEYSTORE")]
		public const string Keystore = (string) "com.ibm.ssl.keyStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREMGR']"
		[Register ("KEYSTOREMGR")]
		public const string Keystoremgr = (string) "com.ibm.ssl.keyManager";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREPROVIDER']"
		[Register ("KEYSTOREPROVIDER")]
		public const string Keystoreprovider = (string) "com.ibm.ssl.keyStoreProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTOREPWD']"
		[Register ("KEYSTOREPWD")]
		public const string Keystorepwd = (string) "com.ibm.ssl.keyStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='KEYSTORETYPE']"
		[Register ("KEYSTORETYPE")]
		public const string Keystoretype = (string) "com.ibm.ssl.keyStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SSLPROTOCOL']"
		[Register ("SSLPROTOCOL")]
		public const string Sslprotocol = (string) "com.ibm.ssl.protocol";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYMGRALGO']"
		[Register ("SYSKEYMGRALGO")]
		public const string Syskeymgralgo = (string) "ssl.KeyManagerFactory.algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTORE']"
		[Register ("SYSKEYSTORE")]
		public const string Syskeystore = (string) "javax.net.ssl.keyStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTOREPWD']"
		[Register ("SYSKEYSTOREPWD")]
		public const string Syskeystorepwd = (string) "javax.net.ssl.keyStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSKEYSTORETYPE']"
		[Register ("SYSKEYSTORETYPE")]
		public const string Syskeystoretype = (string) "javax.net.ssl.keyStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTMGRALGO']"
		[Register ("SYSTRUSTMGRALGO")]
		public const string Systrustmgralgo = (string) "ssl.TrustManagerFactory.algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTORE']"
		[Register ("SYSTRUSTSTORE")]
		public const string Systruststore = (string) "javax.net.ssl.trustStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTOREPWD']"
		[Register ("SYSTRUSTSTOREPWD")]
		public const string Systruststorepwd = (string) "javax.net.ssl.trustStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='SYSTRUSTSTORETYPE']"
		[Register ("SYSTRUSTSTORETYPE")]
		public const string Systruststoretype = (string) "javax.net.ssl.trustStoreType";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTORE']"
		[Register ("TRUSTSTORE")]
		public const string Truststore = (string) "com.ibm.ssl.trustStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREMGR']"
		[Register ("TRUSTSTOREMGR")]
		public const string Truststoremgr = (string) "com.ibm.ssl.trustManager";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREPROVIDER']"
		[Register ("TRUSTSTOREPROVIDER")]
		public const string Truststoreprovider = (string) "com.ibm.ssl.trustStoreProvider";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTOREPWD']"
		[Register ("TRUSTSTOREPWD")]
		public const string Truststorepwd = (string) "com.ibm.ssl.trustStorePassword";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/field[@name='TRUSTSTORETYPE']"
		[Register ("TRUSTSTORETYPE")]
		public const string Truststoretype = (string) "com.ibm.ssl.trustStoreType";
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/security/SSLSocketFactoryFactory", typeof (SSLSocketFactoryFactory));
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

		protected SSLSocketFactoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/constructor[@name='SSLSocketFactoryFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SSLSocketFactoryFactory ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/constructor[@name='SSLSocketFactoryFactory' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.logging.Logger']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V", "")]
		public unsafe SSLSocketFactoryFactory (global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger logger)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/logging/Logger;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public static unsafe bool IsSupportedOnJVM {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='isSupportedOnJVM' and count(parameter)=0]"
			[Register ("isSupportedOnJVM", "()Z", "")]
			get {
				const string __id = "isSupportedOnJVM.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_createSocketFactory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSocketFactory_Ljava_lang_String_Handler ()
		{
			if (cb_createSocketFactory_Ljava_lang_String_ == null)
				cb_createSocketFactory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSocketFactory_Ljava_lang_String_);
			return cb_createSocketFactory_Ljava_lang_String_;
		}

		static IntPtr n_CreateSocketFactory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocketFactory (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='createSocketFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createSocketFactory", "(Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;", "GetCreateSocketFactory_Ljava_lang_String_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory CreateSocketFactory (string configID)
		{
			const string __id = "createSocketFactory.(Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='deObfuscate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deObfuscate", "(Ljava/lang/String;)[C", "")]
		public static unsafe char[] DeObfuscate (string ePassword)
		{
			const string __id = "deObfuscate.(Ljava/lang/String;)[C";
			IntPtr native_ePassword = JNIEnv.NewString (ePassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ePassword);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				JNIEnv.DeleteLocalRef (native_ePassword);
			}
		}

		static Delegate cb_getClientAuthentication_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClientAuthentication_Ljava_lang_String_Handler ()
		{
			if (cb_getClientAuthentication_Ljava_lang_String_ == null)
				cb_getClientAuthentication_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetClientAuthentication_Ljava_lang_String_);
			return cb_getClientAuthentication_Ljava_lang_String_;
		}

		static bool n_GetClientAuthentication_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetClientAuthentication (configID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getClientAuthentication' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClientAuthentication", "(Ljava/lang/String;)Z", "GetGetClientAuthentication_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetClientAuthentication (string configID)
		{
			const string __id = "getClientAuthentication.(Ljava/lang/String;)Z";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getConfiguration_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConfiguration_Ljava_lang_String_Handler ()
		{
			if (cb_getConfiguration_Ljava_lang_String_ == null)
				cb_getConfiguration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfiguration_Ljava_lang_String_);
			return cb_getConfiguration_Ljava_lang_String_;
		}

		static IntPtr n_GetConfiguration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfiguration (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getConfiguration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfiguration", "(Ljava/lang/String;)Ljava/util/Properties;", "GetGetConfiguration_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Util.Properties GetConfiguration (string configID)
		{
			const string __id = "getConfiguration.(Ljava/lang/String;)Ljava/util/Properties;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getEnabledCipherSuites_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEnabledCipherSuites_Ljava_lang_String_Handler ()
		{
			if (cb_getEnabledCipherSuites_Ljava_lang_String_ == null)
				cb_getEnabledCipherSuites_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEnabledCipherSuites_Ljava_lang_String_);
			return cb_getEnabledCipherSuites_Ljava_lang_String_;
		}

		static IntPtr n_GetEnabledCipherSuites_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetEnabledCipherSuites (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getEnabledCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEnabledCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;", "GetGetEnabledCipherSuites_Ljava_lang_String_Handler")]
		public virtual unsafe string[] GetEnabledCipherSuites (string configID)
		{
			const string __id = "getEnabledCipherSuites.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getJSSEProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetJSSEProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getJSSEProvider_Ljava_lang_String_ == null)
				cb_getJSSEProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJSSEProvider_Ljava_lang_String_);
			return cb_getJSSEProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetJSSEProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetJSSEProvider (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getJSSEProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getJSSEProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetJSSEProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetJSSEProvider (string configID)
		{
			const string __id = "getJSSEProvider.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getKeyManager_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyManager_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyManager_Ljava_lang_String_ == null)
				cb_getKeyManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyManager_Ljava_lang_String_);
			return cb_getKeyManager_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyManager_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyManager (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyManager", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyManager_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyManager (string configID)
		{
			const string __id = "getKeyManager.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getKeyStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStore_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStore_Ljava_lang_String_ == null)
				cb_getKeyStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStore_Ljava_lang_String_);
			return cb_getKeyStore_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStore (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStore", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStore_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStore (string configID)
		{
			const string __id = "getKeyStore.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getKeyStorePassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStorePassword_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStorePassword_Ljava_lang_String_ == null)
				cb_getKeyStorePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStorePassword_Ljava_lang_String_);
			return cb_getKeyStorePassword_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStorePassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetKeyStorePassword (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStorePassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStorePassword", "(Ljava/lang/String;)[C", "GetGetKeyStorePassword_Ljava_lang_String_Handler")]
		public virtual unsafe char[] GetKeyStorePassword (string configID)
		{
			const string __id = "getKeyStorePassword.(Ljava/lang/String;)[C";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getKeyStoreProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStoreProvider_Ljava_lang_String_ == null)
				cb_getKeyStoreProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStoreProvider_Ljava_lang_String_);
			return cb_getKeyStoreProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStoreProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStoreProvider (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStoreProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStoreProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStoreProvider (string configID)
		{
			const string __id = "getKeyStoreProvider.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getKeyStoreType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetKeyStoreType_Ljava_lang_String_Handler ()
		{
			if (cb_getKeyStoreType_Ljava_lang_String_ == null)
				cb_getKeyStoreType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeyStoreType_Ljava_lang_String_);
			return cb_getKeyStoreType_Ljava_lang_String_;
		}

		static IntPtr n_GetKeyStoreType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetKeyStoreType (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getKeyStoreType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeyStoreType", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetKeyStoreType_Ljava_lang_String_Handler")]
		public virtual unsafe string GetKeyStoreType (string configID)
		{
			const string __id = "getKeyStoreType.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getSSLProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSSLProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_getSSLProtocol_Ljava_lang_String_ == null)
				cb_getSSLProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSSLProtocol_Ljava_lang_String_);
			return cb_getSSLProtocol_Ljava_lang_String_;
		}

		static IntPtr n_GetSSLProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSSLProtocol (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getSSLProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSSLProtocol", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSSLProtocol_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSSLProtocol (string configID)
		{
			const string __id = "getSSLProtocol.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getTrustManager_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustManager_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustManager_Ljava_lang_String_ == null)
				cb_getTrustManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustManager_Ljava_lang_String_);
			return cb_getTrustManager_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustManager_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustManager (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustManager", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustManager_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustManager (string configID)
		{
			const string __id = "getTrustManager.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getTrustStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStore_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStore_Ljava_lang_String_ == null)
				cb_getTrustStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStore_Ljava_lang_String_);
			return cb_getTrustStore_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStore (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStore", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStore_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStore (string configID)
		{
			const string __id = "getTrustStore.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getTrustStorePassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStorePassword_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStorePassword_Ljava_lang_String_ == null)
				cb_getTrustStorePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStorePassword_Ljava_lang_String_);
			return cb_getTrustStorePassword_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStorePassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetTrustStorePassword (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStorePassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStorePassword", "(Ljava/lang/String;)[C", "GetGetTrustStorePassword_Ljava_lang_String_Handler")]
		public virtual unsafe char[] GetTrustStorePassword (string configID)
		{
			const string __id = "getTrustStorePassword.(Ljava/lang/String;)[C";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getTrustStoreProvider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStoreProvider_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStoreProvider_Ljava_lang_String_ == null)
				cb_getTrustStoreProvider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStoreProvider_Ljava_lang_String_);
			return cb_getTrustStoreProvider_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStoreProvider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStoreProvider (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStoreProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStoreProvider", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStoreProvider_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStoreProvider (string configID)
		{
			const string __id = "getTrustStoreProvider.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_getTrustStoreType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTrustStoreType_Ljava_lang_String_Handler ()
		{
			if (cb_getTrustStoreType_Ljava_lang_String_ == null)
				cb_getTrustStoreType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTrustStoreType_Ljava_lang_String_);
			return cb_getTrustStoreType_Ljava_lang_String_;
		}

		static IntPtr n_GetTrustStoreType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTrustStoreType (configID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='getTrustStoreType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTrustStoreType", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTrustStoreType_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTrustStoreType (string configID)
		{
			const string __id = "getTrustStoreType.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_initialize_Ljava_util_Properties_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_util_Properties_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Ljava_util_Properties_Ljava_lang_String_ == null)
				cb_initialize_Ljava_util_Properties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_util_Properties_Ljava_lang_String_);
			return cb_initialize_Ljava_util_Properties_Ljava_lang_String_;
		}

		static void n_Initialize_Ljava_util_Properties_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_props, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties props = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_props, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (props, configID);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Ljava/util/Properties;Ljava/lang/String;)V", "GetInitialize_Ljava_util_Properties_Ljava_lang_String_Handler")]
		public virtual unsafe void Initialize (global::Java.Util.Properties props, string configID)
		{
			const string __id = "initialize.(Ljava/util/Properties;Ljava/lang/String;)V";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((props == null) ? IntPtr.Zero : ((global::Java.Lang.Object) props).Handle);
				__args [1] = new JniArgumentValue (native_configID);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		static Delegate cb_merge_Ljava_util_Properties_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMerge_Ljava_util_Properties_Ljava_lang_String_Handler ()
		{
			if (cb_merge_Ljava_util_Properties_Ljava_lang_String_ == null)
				cb_merge_Ljava_util_Properties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Merge_Ljava_util_Properties_Ljava_lang_String_);
			return cb_merge_Ljava_util_Properties_Ljava_lang_String_;
		}

		static void n_Merge_Ljava_util_Properties_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_props, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties props = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_props, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			__this.Merge (props, configID);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("merge", "(Ljava/util/Properties;Ljava/lang/String;)V", "GetMerge_Ljava_util_Properties_Ljava_lang_String_Handler")]
		public virtual unsafe void Merge (global::Java.Util.Properties props, string configID)
		{
			const string __id = "merge.(Ljava/util/Properties;Ljava/lang/String;)V";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((props == null) ? IntPtr.Zero : ((global::Java.Lang.Object) props).Handle);
				__args [1] = new JniArgumentValue (native_configID);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='obfuscate' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("obfuscate", "([C)Ljava/lang/String;", "")]
		public static unsafe string Obfuscate (char[] password)
		{
			const string __id = "obfuscate.([C)Ljava/lang/String;";
			IntPtr native_password = JNIEnv.NewArray (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_password);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (password != null) {
					JNIEnv.CopyArray (native_password, password);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='packCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("packCipherSuites", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PackCipherSuites (string[] ciphers)
		{
			const string __id = "packCipherSuites.([Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_ciphers = JNIEnv.NewArray (ciphers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ciphers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (ciphers != null) {
					JNIEnv.CopyArray (native_ciphers, ciphers);
					JNIEnv.DeleteLocalRef (native_ciphers);
				}
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static bool n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Security.SSLSocketFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configID = JNIEnv.GetString (native_configID, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (configID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe bool Remove (string configID)
		{
			const string __id = "remove.(Ljava/lang/String;)Z";
			IntPtr native_configID = JNIEnv.NewString (configID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configID);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_configID);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='toByte' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("toByte", "([C)[B", "")]
		public static unsafe byte[] ToByte (char[] c)
		{
			const string __id = "toByte.([C)[B";
			IntPtr native_c = JNIEnv.NewArray (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='toChar' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toChar", "([B)[C", "")]
		public static unsafe char[] ToChar (byte[] b)
		{
			const string __id = "toChar.([B)[C";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.security']/class[@name='SSLSocketFactoryFactory']/method[@name='unpackCipherSuites' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unpackCipherSuites", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] UnpackCipherSuites (string ciphers)
		{
			const string __id = "unpackCipherSuites.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_ciphers = JNIEnv.NewString (ciphers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ciphers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_ciphers);
			}
		}

	}
}
