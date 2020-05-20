using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageImpl", DoNotGenerateAcw=true)]
	public partial class IoTCredentialManageImpl : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/field[@name='APP_DATA_FILE']"
		[Register ("APP_DATA_FILE")]
		public const string AppDataFile = (string) "APP_DATA_FILE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/field[@name='COMPANY_TYPE']"
		[Register ("COMPANY_TYPE")]
		public const string CompanyType = (string) "company";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/field[@name='DefaultDailyALiYunCreateIotTokenRequestHost']"
		[Register ("DefaultDailyALiYunCreateIotTokenRequestHost")]
		public static string DefaultDailyALiYunCreateIotTokenRequestHost {
			get {
				const string __id = "DefaultDailyALiYunCreateIotTokenRequestHost.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DefaultDailyALiYunCreateIotTokenRequestHost.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/field[@name='KEY_ACCOUNT_TYPE']"
		[Register ("KEY_ACCOUNT_TYPE")]
		public const string KeyAccountType = (string) "KEY_ACCOUNT_TYPE";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/field[@name='appKey']"
		[Register ("appKey")]
		public static string AppKey {
			get {
				const string __id = "appKey.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "appKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageImpl", typeof (IoTCredentialManageImpl));
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

		protected IoTCredentialManageImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccountType;
#pragma warning disable 0169
		static Delegate GetGetAccountTypeHandler ()
		{
			if (cb_getAccountType == null)
				cb_getAccountType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountType);
			return cb_getAccountType;
		}

		static IntPtr n_GetAccountType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountType);
		}
#pragma warning restore 0169

		static Delegate cb_setAccountType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountType_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountType_Ljava_lang_String_ == null)
				cb_setAccountType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccountType_Ljava_lang_String_);
			return cb_setAccountType_Ljava_lang_String_;
		}

		static void n_SetAccountType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccountType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AccountType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getAccountType' and count(parameter)=0]"
			[Register ("getAccountType", "()Ljava/lang/String;", "GetGetAccountTypeHandler")]
			get {
				const string __id = "getAccountType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setAccountType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountType", "(Ljava/lang/String;)V", "GetSetAccountType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccountType.(Ljava/lang/String;)V";
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

		static Delegate cb_getIoTCredential;
#pragma warning disable 0169
		static Delegate GetGetIoTCredentialHandler ()
		{
			if (cb_getIoTCredential == null)
				cb_getIoTCredential = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIoTCredential);
			return cb_getIoTCredential;
		}

		static IntPtr n_GetIoTCredential (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IoTCredential);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData IoTCredential {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getIoTCredential' and count(parameter)=0]"
			[Register ("getIoTCredential", "()Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;", "GetGetIoTCredentialHandler")]
			get {
				const string __id = "getIoTCredential.()Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIoTIdentity;
#pragma warning disable 0169
		static Delegate GetGetIoTIdentityHandler ()
		{
			if (cb_getIoTIdentity == null)
				cb_getIoTIdentity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIoTIdentity);
			return cb_getIoTIdentity;
		}

		static IntPtr n_GetIoTIdentity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTIdentity);
		}
#pragma warning restore 0169

		public virtual unsafe string IoTIdentity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getIoTIdentity' and count(parameter)=0]"
			[Register ("getIoTIdentity", "()Ljava/lang/String;", "GetGetIoTIdentityHandler")]
			get {
				const string __id = "getIoTIdentity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIoTRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetIoTRefreshTokenHandler ()
		{
			if (cb_getIoTRefreshToken == null)
				cb_getIoTRefreshToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIoTRefreshToken);
			return cb_getIoTRefreshToken;
		}

		static IntPtr n_GetIoTRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTRefreshToken);
		}
#pragma warning restore 0169

		public virtual unsafe string IoTRefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getIoTRefreshToken' and count(parameter)=0]"
			[Register ("getIoTRefreshToken", "()Ljava/lang/String;", "GetGetIoTRefreshTokenHandler")]
			get {
				const string __id = "getIoTRefreshToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIoTToken;
#pragma warning disable 0169
		static Delegate GetGetIoTTokenHandler ()
		{
			if (cb_getIoTToken == null)
				cb_getIoTToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIoTToken);
			return cb_getIoTToken;
		}

		static IntPtr n_GetIoTToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTToken);
		}
#pragma warning restore 0169

		public virtual unsafe string IoTToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getIoTToken' and count(parameter)=0]"
			[Register ("getIoTToken", "()Ljava/lang/String;", "GetGetIoTTokenHandler")]
			get {
				const string __id = "getIoTToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIoTRefreshTokenExpired;
#pragma warning disable 0169
		static Delegate GetIsIoTRefreshTokenExpiredHandler ()
		{
			if (cb_isIoTRefreshTokenExpired == null)
				cb_isIoTRefreshTokenExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIoTRefreshTokenExpired);
			return cb_isIoTRefreshTokenExpired;
		}

		static bool n_IsIoTRefreshTokenExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIoTRefreshTokenExpired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIoTRefreshTokenExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='isIoTRefreshTokenExpired' and count(parameter)=0]"
			[Register ("isIoTRefreshTokenExpired", "()Z", "GetIsIoTRefreshTokenExpiredHandler")]
			get {
				const string __id = "isIoTRefreshTokenExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isIoTTokenExpired;
#pragma warning disable 0169
		static Delegate GetIsIoTTokenExpiredHandler ()
		{
			if (cb_isIoTTokenExpired == null)
				cb_isIoTTokenExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIoTTokenExpired);
			return cb_isIoTTokenExpired;
		}

		static bool n_IsIoTTokenExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIoTTokenExpired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIoTTokenExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='isIoTTokenExpired' and count(parameter)=0]"
			[Register ("isIoTTokenExpired", "()Z", "GetIsIoTTokenExpiredHandler")]
			get {
				const string __id = "isIoTTokenExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_;
#pragma warning disable 0169
		static Delegate GetAsyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_Handler ()
		{
			if (cb_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_ == null)
				cb_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_);
			return cb_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_;
		}

		static void n_AsyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AsyncRefreshIoTCredential (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='asyncRefreshIoTCredential' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialListener']]"
		[Register ("asyncRefreshIoTCredential", "(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener;)V", "GetAsyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_Handler")]
		public virtual unsafe void AsyncRefreshIoTCredential (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener p0)
		{
			const string __id = "asyncRefreshIoTCredential.(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearIoTTokenInfo;
#pragma warning disable 0169
		static Delegate GetClearIoTTokenInfoHandler ()
		{
			if (cb_clearIoTTokenInfo == null)
				cb_clearIoTTokenInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearIoTTokenInfo);
			return cb_clearIoTTokenInfo;
		}

		static void n_ClearIoTTokenInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearIoTTokenInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='clearIoTTokenInfo' and count(parameter)=0]"
		[Register ("clearIoTTokenInfo", "()V", "GetClearIoTTokenInfoHandler")]
		public virtual unsafe void ClearIoTTokenInfo ()
		{
			const string __id = "clearIoTTokenInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("getInstance", "(Landroid/app/Application;)Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageImpl;", "")]
		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl GetInstance (global::Android.App.Application p0)
		{
			const string __id = "getInstance.(Landroid/app/Application;)Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageImpl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='init' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("init", "(Ljava/lang/String;)V", "")]
		public static unsafe void Init (string p0)
		{
			const string __id = "init.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_;
#pragma warning disable 0169
		static Delegate GetRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_Handler ()
		{
			if (cb_registerIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ == null)
				cb_registerIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_);
			return cb_registerIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_;
		}

		static void n_RegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterIotTokenCreatedListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='registerIotTokenCreatedListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.listener.IoTTokenCreatedListener']]"
		[Register ("registerIotTokenCreatedListener", "(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener;)V", "GetRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_Handler")]
		public virtual unsafe void RegisterIotTokenCreatedListener (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener p0)
		{
			const string __id = "registerIotTokenCreatedListener.(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_;
#pragma warning disable 0169
		static Delegate GetRequestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_Handler ()
		{
			if (cb_requestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ == null)
				cb_requestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_);
			return cb_requestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_;
		}

		static void n_RequestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback p1 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestCompanyList (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='requestCompanyList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.iot.aep.sdk.credential.listener.OnReqCompanyCallback']]"
		[Register ("requestCompanyList", "(Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback;)V", "GetRequestCompanyList_Ljava_lang_String_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_Handler")]
		public virtual unsafe void RequestCompanyList (string p0, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback p1)
		{
			const string __id = "requestCompanyList.(Ljava/lang/String;Lcom/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAccountTypeCompany;
#pragma warning disable 0169
		static Delegate GetSetAccountTypeCompanyHandler ()
		{
			if (cb_setAccountTypeCompany == null)
				cb_setAccountTypeCompany = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetAccountTypeCompany);
			return cb_setAccountTypeCompany;
		}

		static void n_SetAccountTypeCompany (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAccountTypeCompany ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setAccountTypeCompany' and count(parameter)=0]"
		[Register ("setAccountTypeCompany", "()V", "GetSetAccountTypeCompanyHandler")]
		public virtual unsafe void SetAccountTypeCompany ()
		{
			const string __id = "setAccountTypeCompany.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAuthCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthCode_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthCode_Ljava_lang_String_ == null)
				cb_setAuthCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthCode_Ljava_lang_String_);
			return cb_setAuthCode_Ljava_lang_String_;
		}

		static void n_SetAuthCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthCode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuthCode", "(Ljava/lang/String;)V", "GetSetAuthCode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAuthCode (string p0)
		{
			const string __id = "setAuthCode.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCompanyId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCompanyId_Ljava_lang_String_Handler ()
		{
			if (cb_setCompanyId_Ljava_lang_String_ == null)
				cb_setCompanyId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompanyId_Ljava_lang_String_);
			return cb_setCompanyId_Ljava_lang_String_;
		}

		static void n_SetCompanyId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCompanyId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setCompanyId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCompanyId", "(Ljava/lang/String;)V", "GetSetCompanyId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCompanyId (string p0)
		{
			const string __id = "setCompanyId.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_;
#pragma warning disable 0169
		static Delegate GetSetIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_Handler ()
		{
			if (cb_setIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ == null)
				cb_setIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_);
			return cb_setIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_;
		}

		static void n_SetIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIotCredentialListenerList (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setIotCredentialListenerList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.listener.IoTTokenInvalidListener']]"
		[Register ("setIotCredentialListenerList", "(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener;)V", "GetSetIotCredentialListenerList_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_Handler")]
		public virtual unsafe void SetIotCredentialListenerList (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener p0)
		{
			const string __id = "setIotCredentialListenerList.(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_;
#pragma warning disable 0169
		static Delegate GetSetIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_Handler ()
		{
			if (cb_setIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ == null)
				cb_setIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_);
			return cb_setIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_;
		}

		static void n_SetIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIotTokenInvalidListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setIotTokenInvalidListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.listener.IoTTokenInvalidListener']]"
		[Register ("setIotTokenInvalidListener", "(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener;)V", "GetSetIotTokenInvalidListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenInvalidListener_Handler")]
		public virtual unsafe void SetIotTokenInvalidListener (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener p0)
		{
			const string __id = "setIotTokenInvalidListener.(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_Handler ()
		{
			if (cb_setOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ == null)
				cb_setOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_);
			return cb_setOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_;
		}

		static void n_SetOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnReqCompanyCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='setOnReqCompanyCallback' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.listener.OnReqCompanyCallback']]"
		[Register ("setOnReqCompanyCallback", "(Lcom/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback;)V", "GetSetOnReqCompanyCallback_Lcom_aliyun_iot_aep_sdk_credential_listener_OnReqCompanyCallback_Handler")]
		public virtual unsafe void SetOnReqCompanyCallback (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IOnReqCompanyCallback p0)
		{
			const string __id = "setOnReqCompanyCallback.(Lcom/aliyun/iot/aep/sdk/credential/listener/OnReqCompanyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_;
#pragma warning disable 0169
		static Delegate GetUnRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_Handler ()
		{
			if (cb_unRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ == null)
				cb_unRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_);
			return cb_unRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_;
		}

		static void n_UnRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterIotTokenCreatedListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/class[@name='IoTCredentialManageImpl']/method[@name='unRegisterIotTokenCreatedListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.listener.IoTTokenCreatedListener']]"
		[Register ("unRegisterIotTokenCreatedListener", "(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener;)V", "GetUnRegisterIotTokenCreatedListener_Lcom_aliyun_iot_aep_sdk_credential_listener_IoTTokenCreatedListener_Handler")]
		public virtual unsafe void UnRegisterIotTokenCreatedListener (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener p0)
		{
			const string __id = "unRegisterIotTokenCreatedListener.(Lcom/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener"
		public event EventHandler IotCredentialListenerList {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor>(
						ref weak_implementor_SetIotCredentialListenerList,
						__CreateIIoTTokenInvalidListenerImplementor,
						SetIotCredentialListenerList,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor>(
						ref weak_implementor_SetIotCredentialListenerList,
						global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor.__IsEmpty,
						__v => SetIotCredentialListenerList (null),
						__h => __h.Handler -= value);
			}
		}

		public event EventHandler IotTokenInvalid {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor>(
						ref weak_implementor_SetIotTokenInvalidListener,
						__CreateIIoTTokenInvalidListenerImplementor,
						SetIotTokenInvalidListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener, global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor>(
						ref weak_implementor_SetIotTokenInvalidListener,
						global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor.__IsEmpty,
						__v => SetIotTokenInvalidListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetIotCredentialListenerList;
		WeakReference weak_implementor_SetIotTokenInvalidListener;

		global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor __CreateIIoTTokenInvalidListenerImplementor ()
		{
			return new global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerImplementor (this);
		}
#endregion
	}
}
