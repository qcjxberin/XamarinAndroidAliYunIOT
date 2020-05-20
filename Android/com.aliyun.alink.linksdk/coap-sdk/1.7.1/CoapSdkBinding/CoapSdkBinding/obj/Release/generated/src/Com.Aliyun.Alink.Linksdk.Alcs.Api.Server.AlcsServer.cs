using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServer", DoNotGenerateAcw=true)]
	public partial class AlcsServer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/field[@name='mAlcsCoap']"
		[Register ("mAlcsCoap")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP MAlcsCoap {
			get {
				const string __id = "mAlcsCoap.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAP;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAP> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAlcsCoap.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAP;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/field[@name='mAlcsContext']"
		[Register ("mAlcsContext")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext MAlcsContext {
			get {
				const string __id = "mAlcsContext.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAlcsContext.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/field[@name='mServerConfig']"
		[Register ("mServerConfig")]
		protected global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig MServerConfig {
			get {
				const string __id = "mServerConfig.Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mServerConfig.Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/server/AlcsServer", typeof (AlcsServer));
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

		protected AlcsServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/constructor[@name='AlcsServer' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.server.AlcsServerConfig']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;)V", "")]
		public unsafe AlcsServer (global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getServerConfig;
#pragma warning disable 0169
		static Delegate GetGetServerConfigHandler ()
		{
			if (cb_getServerConfig == null)
				cb_getServerConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerConfig);
			return cb_getServerConfig;
		}

		static IntPtr n_GetServerConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServerConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_;
#pragma warning disable 0169
		static Delegate GetSetServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_Handler ()
		{
			if (cb_setServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_ == null)
				cb_setServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_);
			return cb_setServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_;
		}

		static void n_SetServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverConfig)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig serverConfig = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig> (native_serverConfig, JniHandleOwnership.DoNotTransfer);
			__this.ServerConfig = serverConfig;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig ServerConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='getServerConfig' and count(parameter)=0]"
			[Register ("getServerConfig", "()Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;", "GetGetServerConfigHandler")]
			get {
				const string __id = "getServerConfig.()Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServerConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='setServerConfig' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.api.server.AlcsServerConfig']]"
			[Register ("setServerConfig", "(Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;)V", "GetSetServerConfig_Lcom_aliyun_alink_linksdk_alcs_api_server_AlcsServerConfig_Handler")]
			set {
				const string __id = "setServerConfig.(Lcom/aliyun/alink/linksdk/alcs/api/server/AlcsServerConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addSvrAccessKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSvrAccessKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addSvrAccessKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addSvrAccessKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddSvrAccessKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_addSvrAccessKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddSvrAccessKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authcode, IntPtr native_secret)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authcode = JNIEnv.GetString (native_authcode, JniHandleOwnership.DoNotTransfer);
			string secret = JNIEnv.GetString (native_secret, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddSvrAccessKey (authcode, secret);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='addSvrAccessKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSvrAccessKey", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddSvrAccessKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddSvrAccessKey (string authcode, string secret)
		{
			const string __id = "addSvrAccessKey.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_authcode = JNIEnv.NewString (authcode);
			IntPtr native_secret = JNIEnv.NewString (secret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_authcode);
				__args [1] = new JniArgumentValue (native_secret);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_authcode);
				JNIEnv.DeleteLocalRef (native_secret);
			}
		}

		static Delegate cb_notifyRes_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetNotifyRes_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_notifyRes_Ljava_lang_String_arrayB == null)
				cb_notifyRes_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_NotifyRes_Ljava_lang_String_arrayB);
			return cb_notifyRes_Ljava_lang_String_arrayB;
		}

		static bool n_NotifyRes_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_payload)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.NotifyRes (path, payload);
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='notifyRes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("notifyRes", "(Ljava/lang/String;[B)Z", "GetNotifyRes_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe bool NotifyRes (string path, byte[] payload)
		{
			const string __id = "notifyRes.(Ljava/lang/String;[B)Z";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_payload);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
#pragma warning disable 0169
		static Delegate GetRegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler ()
		{
			if (cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ == null)
				cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_);
			return cb_registerAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_;
		}

		static bool n_RegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource> (native_resource, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterAllResource (resource);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='registerAllResource' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.AlcsCoAPResource']]"
		[Register ("registerAllResource", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Z", "GetRegisterAllResource_Lcom_aliyun_alink_linksdk_alcs_coap_resources_AlcsCoAPResource_Handler")]
		public virtual unsafe bool RegisterAllResource (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.AlcsCoAPResource resource)
		{
			const string __id = "registerAllResource.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/AlcsCoAPResource;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeSvrKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSvrKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeSvrKey_Ljava_lang_String_ == null)
				cb_removeSvrKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveSvrKey_Ljava_lang_String_);
			return cb_removeSvrKey_Ljava_lang_String_;
		}

		static bool n_RemoveSvrKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authcode)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authcode = JNIEnv.GetString (native_authcode, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSvrKey (authcode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='removeSvrKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSvrKey", "(Ljava/lang/String;)Z", "GetRemoveSvrKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveSvrKey (string authcode)
		{
			const string __id = "removeSvrKey.(Ljava/lang/String;)Z";
			IntPtr native_authcode = JNIEnv.NewString (authcode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_authcode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_authcode);
			}
		}

		static Delegate cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequest (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequest", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequest.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
#pragma warning disable 0169
		static Delegate GetSendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler ()
		{
			if (cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ == null)
				cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_);
			return cb_sendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_;
		}

		static long n_SendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_requestCallback)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback = (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (native_requestCallback, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.SendRequestSecure (request, requestCallback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='sendRequestSecure' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler']]"
		[Register ("sendRequestSecure", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J", "GetSendRequestSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Lcom_aliyun_alink_linksdk_alcs_coap_IAlcsCoAPReqHandler_Handler")]
		public virtual unsafe long SendRequestSecure (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest request, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler requestCallback)
		{
			const string __id = "sendRequestSecure.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;Lcom/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((requestCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponse (response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='sendResponse' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendResponse", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendResponse_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendResponse (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendResponse.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetSendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_sendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static bool n_SendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendResponseSecure (response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='sendResponseSecure' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("sendResponseSecure", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z", "GetSendResponseSecure_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler")]
		public virtual unsafe bool SendResponseSecure (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse response)
		{
			const string __id = "sendResponseSecure.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unRegisterResource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterResource_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterResource_Ljava_lang_String_ == null)
				cb_unRegisterResource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UnRegisterResource_Ljava_lang_String_);
			return cb_unRegisterResource_Ljava_lang_String_;
		}

		static bool n_UnRegisterResource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnRegisterResource (path);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='unRegisterResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterResource", "(Ljava/lang/String;)Z", "GetUnRegisterResource_Ljava_lang_String_Handler")]
		public virtual unsafe bool UnRegisterResource (string path)
		{
			const string __id = "unRegisterResource.(Ljava/lang/String;)Z";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_updateBlackList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateBlackList_Ljava_lang_String_Handler ()
		{
			if (cb_updateBlackList_Ljava_lang_String_ == null)
				cb_updateBlackList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateBlackList_Ljava_lang_String_);
			return cb_updateBlackList_Ljava_lang_String_;
		}

		static void n_UpdateBlackList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_blackList)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string blackList = JNIEnv.GetString (native_blackList, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBlackList (blackList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='updateBlackList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateBlackList", "(Ljava/lang/String;)V", "GetUpdateBlackList_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateBlackList (string blackList)
		{
			const string __id = "updateBlackList.(Ljava/lang/String;)V";
			IntPtr native_blackList = JNIEnv.NewString (blackList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_blackList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_blackList);
			}
		}

		static Delegate cb_updateSvrPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSvrPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_updateSvrPrefix_Ljava_lang_String_ == null)
				cb_updateSvrPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateSvrPrefix_Ljava_lang_String_);
			return cb_updateSvrPrefix_Ljava_lang_String_;
		}

		static bool n_UpdateSvrPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Server.AlcsServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSvrPrefix (prefix);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.server']/class[@name='AlcsServer']/method[@name='updateSvrPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSvrPrefix", "(Ljava/lang/String;)Z", "GetUpdateSvrPrefix_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateSvrPrefix (string prefix)
		{
			const string __id = "updateSvrPrefix.(Ljava/lang/String;)Z";
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_prefix);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

	}
}
