using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler", DoNotGenerateAcw=true)]
	public abstract class AlcsCoAPReqHandler : Java.Lang.Object {

		internal AlcsCoAPReqHandler ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAlcsCoAPReqHandler']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AlcsCoAPReqHandler' type. This type will be removed in a future release.", error: true)]
	public abstract class AlcsCoAPReqHandlerConsts : AlcsCoAPReqHandler {

		private AlcsCoAPReqHandlerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAlcsCoAPReqHandler']"
	[Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler", "", "Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandlerInvoker")]
	public partial interface IAlcsCoAPReqHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/interface[@name='IAlcsCoAPReqHandler']/method[@name='onReqComplete' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPContext'] and parameter[2][@type='int'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPResponse']]"
		[Register ("onReqComplete", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;ILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)V", "GetOnReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandlerInvoker, CoapSdkBinding")]
		void OnReqComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0, int p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler", DoNotGenerateAcw=true)]
	internal partial class IAlcsCoAPReqHandlerInvoker : global::Java.Lang.Object, IAlcsCoAPReqHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/IAlcsCoAPReqHandler", typeof (IAlcsCoAPReqHandlerInvoker));

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

		public static IAlcsCoAPReqHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlcsCoAPReqHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.coap.IAlcsCoAPReqHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlcsCoAPReqHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
#pragma warning disable 0169
		static Delegate GetOnReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_Handler ()
		{
			if (cb_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == null)
				cb_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_);
			return cb_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		}

		static void n_OnReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.IAlcsCoAPReqHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse p2 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnReqComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_;
		public unsafe void OnReqComplete (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPContext p0, int p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPResponse p2)
		{
			if (id_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ == IntPtr.Zero)
				id_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_ = JNIEnv.GetMethodID (class_ref, "onReqComplete", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPContext;ILcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPResponse;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReqComplete_Lcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPContext_ILcom_aliyun_alink_linksdk_alcs_coap_AlcsCoAPResponse_, __args);
		}

	}

}
