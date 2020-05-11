using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSCompletedCallback']"
	[Register ("com/alibaba/sdk/android/oss/callback/OSSCompletedCallback", "", "Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T1 extends com.alibaba.sdk.android.oss.model.OSSRequest", "T2 extends com.alibaba.sdk.android.oss.model.OSSResult"})]
	public partial interface IOSSCompletedCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSCompletedCallback']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='T1'] and parameter[2][@type='com.alibaba.sdk.android.oss.ClientException'] and parameter[3][@type='com.alibaba.sdk.android.oss.ServiceException']]"
		[Register ("onFailure", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/ClientException;Lcom/alibaba/sdk/android/oss/ServiceException;)V", "GetOnFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_Handler:Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallbackInvoker, OssAndroidSdkBinding")]
		void OnFailure (global::Java.Lang.Object p0, global::Com.Alibaba.Sdk.Android.Oss.ClientException p1, global::Com.Alibaba.Sdk.Android.Oss.ServiceException p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.callback']/interface[@name='OSSCompletedCallback']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='T1'] and parameter[2][@type='T2']]"
		[Register ("onSuccess", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/model/OSSResult;)V", "GetOnSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_Handler:Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallbackInvoker, OssAndroidSdkBinding")]
		void OnSuccess (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/callback/OSSCompletedCallback", DoNotGenerateAcw=true)]
	internal partial class IOSSCompletedCallbackInvoker : global::Java.Lang.Object, IOSSCompletedCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/callback/OSSCompletedCallback", typeof (IOSSCompletedCallbackInvoker));

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

		public static IOSSCompletedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSCompletedCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alibaba.sdk.android.oss.callback.OSSCompletedCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSCompletedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_Handler ()
		{
			if (cb_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_ == null)
				cb_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_);
			return cb_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_;
		}

		static void n_OnFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.ClientException p1 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ClientException> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alibaba.Sdk.Android.Oss.ServiceException p2 = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.ServiceException> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_;
		public unsafe void OnFailure (global::Java.Lang.Object p0, global::Com.Alibaba.Sdk.Android.Oss.ClientException p1, global::Com.Alibaba.Sdk.Android.Oss.ServiceException p2)
		{
			if (id_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_ == IntPtr.Zero)
				id_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/ClientException;Lcom/alibaba/sdk/android/oss/ServiceException;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_ClientException_Lcom_alibaba_sdk_android_oss_ServiceException_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_Handler ()
		{
			if (cb_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_ == null)
				cb_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_);
			return cb_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_;
		}

		static void n_OnSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Callback.IOSSCompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_ == IntPtr.Zero)
				id_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/model/OSSResult;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_alibaba_sdk_android_oss_model_OSSRequest_Lcom_alibaba_sdk_android_oss_model_OSSResult_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
