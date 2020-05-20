using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']"
	[Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManage", "", "Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker")]
	public partial interface IIoTCredentialManage : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData IoTCredential {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='getIoTCredential' and count(parameter)=0]"
			[Register ("getIoTCredential", "()Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;", "GetGetIoTCredentialHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		string IoTIdentity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='getIoTIdentity' and count(parameter)=0]"
			[Register ("getIoTIdentity", "()Ljava/lang/String;", "GetGetIoTIdentityHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		string IoTRefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='getIoTRefreshToken' and count(parameter)=0]"
			[Register ("getIoTRefreshToken", "()Ljava/lang/String;", "GetGetIoTRefreshTokenHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		string IoTToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='getIoTToken' and count(parameter)=0]"
			[Register ("getIoTToken", "()Ljava/lang/String;", "GetGetIoTTokenHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		bool IsIoTRefreshTokenExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='isIoTRefreshTokenExpired' and count(parameter)=0]"
			[Register ("isIoTRefreshTokenExpired", "()Z", "GetIsIoTRefreshTokenExpiredHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		bool IsIoTTokenExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='isIoTTokenExpired' and count(parameter)=0]"
			[Register ("isIoTTokenExpired", "()Z", "GetIsIoTTokenExpiredHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialManage']/method[@name='asyncRefreshIoTCredential' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialListener']]"
		[Register ("asyncRefreshIoTCredential", "(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener;)V", "GetAsyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_Handler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManageInvoker, IotCredentialBinding")]
		void AsyncRefreshIoTCredential (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManage", DoNotGenerateAcw=true)]
	internal partial class IIoTCredentialManageInvoker : global::Java.Lang.Object, IIoTCredentialManage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManage", typeof (IIoTCredentialManageInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IIoTCredentialManage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIoTCredentialManage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialManage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIoTCredentialManageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IoTCredential);
		}
#pragma warning restore 0169

		IntPtr id_getIoTCredential;
		public unsafe global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData IoTCredential {
			get {
				if (id_getIoTCredential == IntPtr.Zero)
					id_getIoTCredential = JNIEnv.GetMethodID (class_ref, "getIoTCredential", "()Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIoTCredential), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTIdentity);
		}
#pragma warning restore 0169

		IntPtr id_getIoTIdentity;
		public unsafe string IoTIdentity {
			get {
				if (id_getIoTIdentity == IntPtr.Zero)
					id_getIoTIdentity = JNIEnv.GetMethodID (class_ref, "getIoTIdentity", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIoTIdentity), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTRefreshToken);
		}
#pragma warning restore 0169

		IntPtr id_getIoTRefreshToken;
		public unsafe string IoTRefreshToken {
			get {
				if (id_getIoTRefreshToken == IntPtr.Zero)
					id_getIoTRefreshToken = JNIEnv.GetMethodID (class_ref, "getIoTRefreshToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIoTRefreshToken), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IoTToken);
		}
#pragma warning restore 0169

		IntPtr id_getIoTToken;
		public unsafe string IoTToken {
			get {
				if (id_getIoTToken == IntPtr.Zero)
					id_getIoTToken = JNIEnv.GetMethodID (class_ref, "getIoTToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIoTToken), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIoTRefreshTokenExpired;
		}
#pragma warning restore 0169

		IntPtr id_isIoTRefreshTokenExpired;
		public unsafe bool IsIoTRefreshTokenExpired {
			get {
				if (id_isIoTRefreshTokenExpired == IntPtr.Zero)
					id_isIoTRefreshTokenExpired = JNIEnv.GetMethodID (class_ref, "isIoTRefreshTokenExpired", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIoTRefreshTokenExpired);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIoTTokenExpired;
		}
#pragma warning restore 0169

		IntPtr id_isIoTTokenExpired;
		public unsafe bool IsIoTTokenExpired {
			get {
				if (id_isIoTTokenExpired == IntPtr.Zero)
					id_isIoTTokenExpired = JNIEnv.GetMethodID (class_ref, "isIoTTokenExpired", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIoTTokenExpired);
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
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialManage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener p0 = (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AsyncRefreshIoTCredential (p0);
		}
#pragma warning restore 0169

		IntPtr id_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_;
		public unsafe void AsyncRefreshIoTCredential (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener p0)
		{
			if (id_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_ == IntPtr.Zero)
				id_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_ = JNIEnv.GetMethodID (class_ref, "asyncRefreshIoTCredential", "(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_asyncRefreshIoTCredential_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialListener_, __args);
		}

	}

}
