using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialListener']"
	[Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener", "", "Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListenerInvoker")]
	public partial interface IIoTCredentialListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialListener']/method[@name='onRefreshIoTCredentialFailed' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialManageError']]"
		[Register ("onRefreshIoTCredentialFailed", "(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageError;)V", "GetOnRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_Handler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListenerInvoker, IotCredentialBinding")]
		void OnRefreshIoTCredentialFailed (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.IotCredentialManager']/interface[@name='IoTCredentialListener']/method[@name='onRefreshIoTCredentialSuccess' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.credential.data.IoTCredentialData']]"
		[Register ("onRefreshIoTCredentialSuccess", "(Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;)V", "GetOnRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_Handler:Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListenerInvoker, IotCredentialBinding")]
		void OnRefreshIoTCredentialSuccess (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener", DoNotGenerateAcw=true)]
	internal partial class IIoTCredentialListenerInvoker : global::Java.Lang.Object, IIoTCredentialListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListener", typeof (IIoTCredentialListenerInvoker));

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

		public static IIoTCredentialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIoTCredentialListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIoTCredentialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_;
#pragma warning disable 0169
		static Delegate GetOnRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_Handler ()
		{
			if (cb_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_ == null)
				cb_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_);
			return cb_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_;
		}

		static void n_OnRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRefreshIoTCredentialFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_;
		public unsafe void OnRefreshIoTCredentialFailed (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0)
		{
			if (id_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_ == IntPtr.Zero)
				id_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_ = JNIEnv.GetMethodID (class_ref, "onRefreshIoTCredentialFailed", "(Lcom/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialManageError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefreshIoTCredentialFailed_Lcom_aliyun_iot_aep_sdk_credential_IotCredentialManager_IoTCredentialManageError_, __args);
		}

		static Delegate cb_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_;
#pragma warning disable 0169
		static Delegate GetOnRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_Handler ()
		{
			if (cb_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_ == null)
				cb_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_);
			return cb_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_;
		}

		static void n_OnRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IIoTCredentialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRefreshIoTCredentialSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_;
		public unsafe void OnRefreshIoTCredentialSuccess (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0)
		{
			if (id_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_ == IntPtr.Zero)
				id_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_ = JNIEnv.GetMethodID (class_ref, "onRefreshIoTCredentialSuccess", "(Lcom/aliyun/iot/aep/sdk/credential/data/IoTCredentialData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefreshIoTCredentialSuccess_Lcom_aliyun_iot_aep_sdk_credential_data_IoTCredentialData_, __args);
		}

	}

	// event args for com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialListener.onRefreshIoTCredentialFailed
	public partial class RefreshIoTCredentialFailedEventArgs : global::System.EventArgs {

		public RefreshIoTCredentialFailedEventArgs (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0;
		public global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError P0 {
			get { return p0; }
		}
	}

	// event args for com.aliyun.iot.aep.sdk.credential.IotCredentialManager.IoTCredentialListener.onRefreshIoTCredentialSuccess
	public partial class RefreshIoTCredentialSuccessEventArgs : global::System.EventArgs {

		public RefreshIoTCredentialSuccessEventArgs (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0;
		public global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListenerImplementor")]
	internal sealed partial class IIoTCredentialListenerImplementor : global::Java.Lang.Object, IIoTCredentialListener {

		object sender;

		public IIoTCredentialListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/iot/aep/sdk/credential/IotCredentialManager/IoTCredentialListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RefreshIoTCredentialFailedEventArgs> OnRefreshIoTCredentialFailedHandler;
#pragma warning restore 0649

		public void OnRefreshIoTCredentialFailed (global::Com.Aliyun.Iot.Aep.Sdk.Credential.IotCredentialManager.IoTCredentialManageError p0)
		{
			var __h = OnRefreshIoTCredentialFailedHandler;
			if (__h != null)
				__h (sender, new RefreshIoTCredentialFailedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<RefreshIoTCredentialSuccessEventArgs> OnRefreshIoTCredentialSuccessHandler;
#pragma warning restore 0649

		public void OnRefreshIoTCredentialSuccess (global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData p0)
		{
			var __h = OnRefreshIoTCredentialSuccessHandler;
			if (__h != null)
				__h (sender, new RefreshIoTCredentialSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IIoTCredentialListenerImplementor value)
		{
			return value.OnRefreshIoTCredentialFailedHandler == null && value.OnRefreshIoTCredentialSuccessHandler == null;
		}
	}

}
