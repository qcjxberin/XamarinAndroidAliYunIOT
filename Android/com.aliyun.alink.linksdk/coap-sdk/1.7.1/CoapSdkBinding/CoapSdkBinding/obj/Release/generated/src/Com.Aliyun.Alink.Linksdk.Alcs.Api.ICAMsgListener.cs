using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAMsgListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/ICAMsgListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListenerInvoker")]
	public partial interface ICAMsgListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api']/interface[@name='ICAMsgListener']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.data.ica.ICARspMessage']]"
		[Register ("onLoad", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;)V", "GetOnLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListenerInvoker, CoapSdkBinding")]
		void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/ICAMsgListener", DoNotGenerateAcw=true)]
	internal partial class ICAMsgListenerInvoker : global::Java.Lang.Object, ICAMsgListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/ICAMsgListener", typeof (ICAMsgListenerInvoker));

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

		public static ICAMsgListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICAMsgListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.ICAMsgListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICAMsgListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_;
#pragma warning disable 0169
		static Delegate GetOnLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_Handler ()
		{
			if (cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_ == null)
				cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_);
			return cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_;
		}

		static void n_OnLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.ICAMsgListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_;
		public unsafe void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0)
		{
			if (id_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_ == IntPtr.Zero)
				id_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Lcom/aliyun/alink/linksdk/alcs/data/ica/ICARspMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Lcom_aliyun_alink_linksdk_alcs_data_ica_ICARspMessage_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.api.ICAMsgListener.onLoad
	public partial class CAMsgEventArgs : global::System.EventArgs {

		public CAMsgEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/api/ICAMsgListenerImplementor")]
	internal sealed partial class ICAMsgListenerImplementor : global::Java.Lang.Object, ICAMsgListener {

		object sender;

		public ICAMsgListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/api/ICAMsgListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CAMsgEventArgs> Handler;
#pragma warning restore 0649

		public void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Data.Ica.ICARspMessage p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CAMsgEventArgs (p0));
		}

		internal static bool __IsEmpty (ICAMsgListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
