using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceHandler']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandlerInvoker")]
	public partial interface IDeviceHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceHandler']/method[@name='onFail' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.api.utils.ErrorInfo']]"
		[Register ("onFail", "(Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/api/utils/ErrorInfo;)V", "GetOnFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandlerInvoker, CoapSdkBinding")]
		void OnFail (global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandlerInvoker, CoapSdkBinding")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler", DoNotGenerateAcw=true)]
	internal partial class IDeviceHandlerInvoker : global::Java.Lang.Object, IDeviceHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceHandler", typeof (IDeviceHandlerInvoker));

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

		public static IDeviceHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.client.IDeviceHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_;
#pragma warning disable 0169
		static Delegate GetOnFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_Handler ()
		{
			if (cb_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_ == null)
				cb_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_);
			return cb_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_;
		}

		static void n_OnFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_;
		public unsafe void OnFail (global::Java.Lang.Object p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils.ErrorInfo p1)
		{
			if (id_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_ == IntPtr.Zero)
				id_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/api/utils/ErrorInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_api_utils_ErrorInfo_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
		}

	}

}
