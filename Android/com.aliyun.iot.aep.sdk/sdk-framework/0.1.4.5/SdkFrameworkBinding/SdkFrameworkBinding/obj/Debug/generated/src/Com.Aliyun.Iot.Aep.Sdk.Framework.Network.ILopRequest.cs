using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/network/ILopRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V extends com.aliyun.iot.aep.sdk.framework.network.BaseRequest"})]
	public partial class ILopRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/network/ILopRequest", typeof (ILopRequest));
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

		protected ILopRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApiVersion;
#pragma warning disable 0169
		static Delegate GetGetApiVersionHandler ()
		{
			if (cb_getApiVersion == null)
				cb_getApiVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiVersion);
			return cb_getApiVersion;
		}

		static IntPtr n_GetApiVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setApiVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setApiVersion_Ljava_lang_String_ == null)
				cb_setApiVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiVersion_Ljava_lang_String_);
			return cb_setApiVersion_Ljava_lang_String_;
		}

		static void n_SetApiVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiVersion)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string apiVersion = JNIEnv.GetString (native_apiVersion, JniHandleOwnership.DoNotTransfer);
			__this.ApiVersion = apiVersion;
		}
#pragma warning restore 0169

		public virtual unsafe string ApiVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getApiVersion' and count(parameter)=0]"
			[Register ("getApiVersion", "()Ljava/lang/String;", "GetGetApiVersionHandler")]
			get {
				const string __id = "getApiVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='setApiVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApiVersion", "(Ljava/lang/String;)V", "GetSetApiVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setApiVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthType;
#pragma warning disable 0169
		static Delegate GetGetAuthTypeHandler ()
		{
			if (cb_getAuthType == null)
				cb_getAuthType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthType);
			return cb_getAuthType;
		}

		static IntPtr n_GetAuthType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthType);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthType_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthType_Ljava_lang_String_ == null)
				cb_setAuthType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthType_Ljava_lang_String_);
			return cb_setAuthType_Ljava_lang_String_;
		}

		static void n_SetAuthType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authType)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authType = JNIEnv.GetString (native_authType, JniHandleOwnership.DoNotTransfer);
			__this.AuthType = authType;
		}
#pragma warning restore 0169

		public virtual unsafe string AuthType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getAuthType' and count(parameter)=0]"
			[Register ("getAuthType", "()Ljava/lang/String;", "GetGetAuthTypeHandler")]
			get {
				const string __id = "getAuthType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='setAuthType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthType", "(Ljava/lang/String;)V", "GetSetAuthType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_Handler ()
		{
			if (cb_setData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_ == null)
				cb_setData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_);
			return cb_setData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_;
		}

		static void n_SetData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Data = data;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='V']]"
			[Register ("setData", "(Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;)V", "GetSetData_Lcom_aliyun_iot_aep_sdk_framework_network_BaseRequest_Handler")]
			set {
				const string __id = "setData.(Lcom/aliyun/iot/aep/sdk/framework/network/BaseRequest;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static void n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			__this.Host = host;
		}
#pragma warning restore 0169

		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				const string __id = "getHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHost", "(Ljava/lang/String;)V", "GetSetHost_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHost.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler")]
			get {
				const string __id = "getParams.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static Delegate cb_setPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPath_Ljava_lang_String_Handler ()
		{
			if (cb_setPath_Ljava_lang_String_ == null)
				cb_setPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPath_Ljava_lang_String_);
			return cb_setPath_Ljava_lang_String_;
		}

		static void n_SetPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.ILopRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.Path = path;
		}
#pragma warning restore 0169

		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.network']/class[@name='ILopRequest']/method[@name='setPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPath", "(Ljava/lang/String;)V", "GetSetPath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
