using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalGroupConnect']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalGroupConnect", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnectInvoker")]
	public partial interface IPalGroupConnect : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalGroupConnect']/method[@name='asyncSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.group.PalGroupReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnectInvoker, AndroidAlcsLpbsBinding")]
		bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalGroupConnect", DoNotGenerateAcw=true)]
	internal partial class IPalGroupConnectInvoker : global::Java.Lang.Object, IPalGroupConnect {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalGroupConnect", typeof (IPalGroupConnectInvoker));

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

		public static IPalGroupConnect GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalGroupConnect> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalGroupConnect"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalGroupConnectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupReqMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupReqMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AsyncSendRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		public unsafe bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			if (id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == IntPtr.Zero)
				id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNIEnv.GetMethodID (class_ref, "asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_, __args);
			return __ret;
		}

	}

}
