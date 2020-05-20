using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalMsgListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListenerInvoker")]
	public partial interface IPalMsgListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.listener']/interface[@name='PalMsgListener']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalRspMessage']]"
		[Register ("onLoad", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalRspMessage;)V", "GetOnLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener", DoNotGenerateAcw=true)]
	internal partial class IPalMsgListenerInvoker : global::Java.Lang.Object, IPalMsgListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener", typeof (IPalMsgListenerInvoker));

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

		public static IPalMsgListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalMsgListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalMsgListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_;
#pragma warning disable 0169
		static Delegate GetOnLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_Handler ()
		{
			if (cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_ == null)
				cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_);
			return cb_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_;
		}

		static void n_OnLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_;
		public unsafe void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0)
		{
			if (id_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_ == IntPtr.Zero)
				id_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalRspMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalRspMessage_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener.onLoad
	public partial class PalMsgEventArgs : global::System.EventArgs {

		public PalMsgEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListenerImplementor")]
	internal sealed partial class IPalMsgListenerImplementor : global::Java.Lang.Object, IPalMsgListener {

		object sender;

		public IPalMsgListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PalMsgEventArgs> Handler;
#pragma warning restore 0649

		public void OnLoad (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalRspMessage p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PalMsgEventArgs (p0));
		}

		internal static bool __IsEmpty (IPalMsgListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
