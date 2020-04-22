using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Config {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/config/GlobalConfig", DoNotGenerateAcw=true)]
	public partial class GlobalConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='API_ENV_ONLINE']"
		[Register ("API_ENV_ONLINE")]
		public const string ApiEnvOnline = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='API_ENV_PRE']"
		[Register ("API_ENV_PRE")]
		public const string ApiEnvPre = (string) "pre";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='API_ENV_TEST']"
		[Register ("API_ENV_TEST")]
		public const string ApiEnvTest = (string) "test";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='BONE_ENV_PRETEST']"
		[Register ("BONE_ENV_PRETEST")]
		public const string BoneEnvPretest = (string) "pretest";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='BONE_ENV_RELEASE']"
		[Register ("BONE_ENV_RELEASE")]
		public const string BoneEnvRelease = (string) "release";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/field[@name='BONE_ENV_TEST']"
		[Register ("BONE_ENV_TEST")]
		public const string BoneEnvTest = (string) "test";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/config/GlobalConfig", typeof (GlobalConfig));
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

		protected GlobalConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApiEnv;
#pragma warning disable 0169
		static Delegate GetGetApiEnvHandler ()
		{
			if (cb_getApiEnv == null)
				cb_getApiEnv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiEnv);
			return cb_getApiEnv;
		}

		static IntPtr n_GetApiEnv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiEnv);
		}
#pragma warning restore 0169

		static Delegate cb_setApiEnv_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiEnv_Ljava_lang_String_Handler ()
		{
			if (cb_setApiEnv_Ljava_lang_String_ == null)
				cb_setApiEnv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiEnv_Ljava_lang_String_);
			return cb_setApiEnv_Ljava_lang_String_;
		}

		static void n_SetApiEnv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiEnv)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string apiEnv = JNIEnv.GetString (native_apiEnv, JniHandleOwnership.DoNotTransfer);
			__this.ApiEnv = apiEnv;
		}
#pragma warning restore 0169

		public virtual unsafe string ApiEnv {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getApiEnv' and count(parameter)=0]"
			[Register ("getApiEnv", "()Ljava/lang/String;", "GetGetApiEnvHandler")]
			get {
				const string __id = "getApiEnv.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setApiEnv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApiEnv", "(Ljava/lang/String;)V", "GetSetApiEnv_Ljava_lang_String_Handler")]
			set {
				const string __id = "setApiEnv.(Ljava/lang/String;)V";
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

		static Delegate cb_getAuthCode;
#pragma warning disable 0169
		static Delegate GetGetAuthCodeHandler ()
		{
			if (cb_getAuthCode == null)
				cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
			return cb_getAuthCode;
		}

		static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthCode_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthCode_Ljava_lang_String_ == null)
				cb_setAuthCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthCode_Ljava_lang_String_);
			return cb_setAuthCode_Ljava_lang_String_;
		}

		static void n_SetAuthCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authCode)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authCode = JNIEnv.GetString (native_authCode, JniHandleOwnership.DoNotTransfer);
			__this.AuthCode = authCode;
		}
#pragma warning restore 0169

		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getAuthCode' and count(parameter)=0]"
			[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
			get {
				const string __id = "getAuthCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthCode", "(Ljava/lang/String;)V", "GetSetAuthCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuthCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getBoneEnv;
#pragma warning disable 0169
		static Delegate GetGetBoneEnvHandler ()
		{
			if (cb_getBoneEnv == null)
				cb_getBoneEnv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoneEnv);
			return cb_getBoneEnv;
		}

		static IntPtr n_GetBoneEnv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BoneEnv);
		}
#pragma warning restore 0169

		static Delegate cb_setBoneEnv_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBoneEnv_Ljava_lang_String_Handler ()
		{
			if (cb_setBoneEnv_Ljava_lang_String_ == null)
				cb_setBoneEnv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBoneEnv_Ljava_lang_String_);
			return cb_setBoneEnv_Ljava_lang_String_;
		}

		static void n_SetBoneEnv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boneEnv)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string boneEnv = JNIEnv.GetString (native_boneEnv, JniHandleOwnership.DoNotTransfer);
			__this.BoneEnv = boneEnv;
		}
#pragma warning restore 0169

		public virtual unsafe string BoneEnv {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getBoneEnv' and count(parameter)=0]"
			[Register ("getBoneEnv", "()Ljava/lang/String;", "GetGetBoneEnvHandler")]
			get {
				const string __id = "getBoneEnv.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setBoneEnv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBoneEnv", "(Ljava/lang/String;)V", "GetSetBoneEnv_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBoneEnv.(Ljava/lang/String;)V";
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

		public static unsafe string CentralHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getCentralHost' and count(parameter)=0]"
			[Register ("getCentralHost", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCentralHost.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		static Delegate cb_setConfig_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Ljava_util_HashMap_Handler ()
		{
			if (cb_setConfig_Ljava_util_HashMap_ == null)
				cb_setConfig_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfig_Ljava_util_HashMap_);
			return cb_setConfig_Ljava_util_HashMap_;
		}

		static void n_SetConfig_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_config, JniHandleOwnership.DoNotTransfer);
			__this.Config = config;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Ljava/util/HashMap;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setConfig", "(Ljava/util/HashMap;)V", "GetSetConfig_Ljava_util_HashMap_Handler")]
			set {
				const string __id = "setConfig.(Ljava/util/HashMap;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Country);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCountrySelectCallBack;
#pragma warning disable 0169
		static Delegate GetGetCountrySelectCallBackHandler ()
		{
			if (cb_getCountrySelectCallBack == null)
				cb_getCountrySelectCallBack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountrySelectCallBack);
			return cb_getCountrySelectCallBack;
		}

		static IntPtr n_GetCountrySelectCallBack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CountrySelectCallBack);
		}
#pragma warning restore 0169

		static Delegate cb_setCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_;
#pragma warning disable 0169
		static Delegate GetSetCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_Handler ()
		{
			if (cb_setCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ == null)
				cb_setCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_);
			return cb_setCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_;
		}

		static void n_SetCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countrySelectCallBack)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack countrySelectCallBack = (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack> (native_countrySelectCallBack, JniHandleOwnership.DoNotTransfer);
			__this.CountrySelectCallBack = countrySelectCallBack;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack CountrySelectCallBack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getCountrySelectCallBack' and count(parameter)=0]"
			[Register ("getCountrySelectCallBack", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;", "GetGetCountrySelectCallBackHandler")]
			get {
				const string __id = "getCountrySelectCallBack.()Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setCountrySelectCallBack' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySelectCallBack']]"
			[Register ("setCountrySelectCallBack", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V", "GetSetCountrySelectCallBack_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_Handler")]
			set {
				const string __id = "setCountrySelectCallBack.(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInitConfig;
#pragma warning disable 0169
		static Delegate GetGetInitConfigHandler ()
		{
			if (cb_getInitConfig == null)
				cb_getInitConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitConfig);
			return cb_getInitConfig;
		}

		static IntPtr n_GetInitConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_;
#pragma warning disable 0169
		static Delegate GetSetInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_Handler ()
		{
			if (cb_setInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_ == null)
				cb_setInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_);
			return cb_setInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_;
		}

		static void n_SetInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_initConfig)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig initConfig = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (native_initConfig, JniHandleOwnership.DoNotTransfer);
			__this.InitConfig = initConfig;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig InitConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getInitConfig' and count(parameter)=0]"
			[Register ("getInitConfig", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;", "GetGetInitConfigHandler")]
			get {
				const string __id = "getInitConfig.()Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setInitConfig' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.InitConfig']]"
			[Register ("setInitConfig", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;)V", "GetSetInitConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_InitConfig_Handler")]
			set {
				const string __id = "setInitConfig.(Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/framework/config/GlobalConfig;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/framework/config/GlobalConfig;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_setLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setLanguage_Ljava_lang_String_ == null)
				cb_setLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_setLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_language)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string language = JNIEnv.GetString (native_language, JniHandleOwnership.DoNotTransfer);
			__this.Language = language;
		}
#pragma warning restore 0169

		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLanguage.(Ljava/lang/String;)V";
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

		static Delegate cb_getRegionInfo;
#pragma warning disable 0169
		static Delegate GetGetRegionInfoHandler ()
		{
			if (cb_getRegionInfo == null)
				cb_getRegionInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegionInfo);
			return cb_getRegionInfo;
		}

		static IntPtr n_GetRegionInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegionInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_;
#pragma warning disable 0169
		static Delegate GetSetRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_Handler ()
		{
			if (cb_setRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ == null)
				cb_setRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_);
			return cb_setRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_;
		}

		static void n_SetRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_regionInfo)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo regionInfo = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo> (native_regionInfo, JniHandleOwnership.DoNotTransfer);
			__this.RegionInfo = regionInfo;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo RegionInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='getRegionInfo' and count(parameter)=0]"
			[Register ("getRegionInfo", "()Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;", "GetGetRegionInfoHandler")]
			get {
				const string __id = "getRegionInfo.()Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setRegionInfo' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.region.RegionInfo']]"
			[Register ("setRegionInfo", "(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)V", "GetSetRegionInfo_Lcom_aliyun_iot_aep_sdk_framework_region_RegionInfo_Handler")]
			set {
				const string __id = "setRegionInfo.(Lcom/aliyun/iot/aep/sdk/framework/region/RegionInfo;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_reStoreConfigs;
#pragma warning disable 0169
		static Delegate GetReStoreConfigsHandler ()
		{
			if (cb_reStoreConfigs == null)
				cb_reStoreConfigs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReStoreConfigs);
			return cb_reStoreConfigs;
		}

		static void n_ReStoreConfigs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReStoreConfigs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='reStoreConfigs' and count(parameter)=0]"
		[Register ("reStoreConfigs", "()V", "GetReStoreConfigsHandler")]
		public virtual unsafe void ReStoreConfigs ()
		{
			const string __id = "reStoreConfigs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_Handler ()
		{
			if (cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ == null)
				cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_);
			return cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_;
		}

		static void n_SetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_country, IntPtr native_callBack)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (native_country, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack callBack = (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack> (native_callBack, JniHandleOwnership.DoNotTransfer);
			__this.SetCountry (country, callBack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='setCountry' and count(parameter)=2 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country'] and parameter[2][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySetCallBack']]"
		[Register ("setCountry", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V", "GetSetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_Handler")]
		public virtual unsafe void SetCountry (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country, global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack callBack)
		{
			const string __id = "setCountry.(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((country == null) ? IntPtr.Zero : ((global::Java.Lang.Object) country).Handle);
				__args [1] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_storeConfig;
#pragma warning disable 0169
		static Delegate GetStoreConfigHandler ()
		{
			if (cb_storeConfig == null)
				cb_storeConfig = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StoreConfig);
			return cb_storeConfig;
		}

		static void n_StoreConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreConfig ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='storeConfig' and count(parameter)=0]"
		[Register ("storeConfig", "()V", "GetStoreConfigHandler")]
		public virtual unsafe void StoreConfig ()
		{
			const string __id = "storeConfig.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_storeConfigs;
#pragma warning disable 0169
		static Delegate GetStoreConfigsHandler ()
		{
			if (cb_storeConfigs == null)
				cb_storeConfigs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StoreConfigs);
			return cb_storeConfigs;
		}

		static void n_StoreConfigs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreConfigs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='storeConfigs' and count(parameter)=0]"
		[Register ("storeConfigs", "()V", "GetStoreConfigsHandler")]
		public virtual unsafe void StoreConfigs ()
		{
			const string __id = "storeConfigs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_storeCountry;
#pragma warning disable 0169
		static Delegate GetStoreCountryHandler ()
		{
			if (cb_storeCountry == null)
				cb_storeCountry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StoreCountry);
			return cb_storeCountry;
		}

		static void n_StoreCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreCountry ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='storeCountry' and count(parameter)=0]"
		[Register ("storeCountry", "()V", "GetStoreCountryHandler")]
		public virtual unsafe void StoreCountry ()
		{
			const string __id = "storeCountry.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_storeInitConfig;
#pragma warning disable 0169
		static Delegate GetStoreInitConfigHandler ()
		{
			if (cb_storeInitConfig == null)
				cb_storeInitConfig = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StoreInitConfig);
			return cb_storeInitConfig;
		}

		static void n_StoreInitConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreInitConfig ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='storeInitConfig' and count(parameter)=0]"
		[Register ("storeInitConfig", "()V", "GetStoreInitConfigHandler")]
		public virtual unsafe void StoreInitConfig ()
		{
			const string __id = "storeInitConfig.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_storeRegionInfo;
#pragma warning disable 0169
		static Delegate GetStoreRegionInfoHandler ()
		{
			if (cb_storeRegionInfo == null)
				cb_storeRegionInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StoreRegionInfo);
			return cb_storeRegionInfo;
		}

		static void n_StoreRegionInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.GlobalConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreRegionInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='GlobalConfig']/method[@name='storeRegionInfo' and count(parameter)=0]"
		[Register ("storeRegionInfo", "()V", "GetStoreRegionInfoHandler")]
		public virtual unsafe void StoreRegionInfo ()
		{
			const string __id = "storeRegionInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
