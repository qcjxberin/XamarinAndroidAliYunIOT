using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAlcsCoAPResHandler']"
	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler", "", "Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandlerInvoker")]
	public partial interface IAlcsCoAPResHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAlcsCoAPResHandler']/method[@name='onRecRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPContext'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPRequest']]"
		[Register ("onRecRequest", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)V", "GetOnRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandlerInvoker, CoapSdkBinding")]
		void OnRecRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler", DoNotGenerateAcw=true)]
	internal partial class IAlcsCoAPResHandlerInvoker : global::Java.Lang.Object, IAlcsCoAPResHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPResHandler", typeof (IAlcsCoAPResHandlerInvoker));

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

		public static IAlcsCoAPResHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlcsCoAPResHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPResHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlcsCoAPResHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_;
#pragma warning disable 0169
		static Delegate GetOnRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_Handler ()
		{
			if (cb_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ == null)
				cb_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_);
			return cb_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_;
		}

		static void n_OnRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPResHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRecRequest (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_;
		public unsafe void OnRecRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPRequest p1)
		{
			if (id_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ == IntPtr.Zero)
				id_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_ = JNIEnv.GetMethodID (class_ref, "onRecRequest", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPRequest;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecRequest_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPRequest_, __args);
		}

	}

}
