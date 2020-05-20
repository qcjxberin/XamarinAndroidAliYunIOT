using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalConnect", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker")]
	public partial interface IPalConnect : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='asyncSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='isDeviceConnected' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDeviceConnected", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool IsDeviceConnected (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='onCloudChannelCreate' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel']]"
		[Register ("onCloudChannelCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V", "GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		void OnCloudChannelCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='regDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("regDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool RegDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='startConnect' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalConnectParams'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener']]"
		[Register ("startConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V", "GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		void StartConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='stopConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("stopConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		void StopConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("subscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unregDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("unregDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool UnregDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("unsubscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnectInvoker, AndroidAlcsLpbsBinding")]
		bool Unsubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalConnect", DoNotGenerateAcw=true)]
	internal partial class IPalConnectInvoker : global::Java.Lang.Object, IPalConnect {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalConnect", typeof (IPalConnectInvoker));

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

		public static IPalConnect GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalConnect> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalConnect"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalConnectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AsyncSendRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		public unsafe bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			if (id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == IntPtr.Zero)
				id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNIEnv.GetMethodID (class_ref, "asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_, __args);
			return __ret;
		}

		static Delegate cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static bool n_IsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceConnected (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe bool IsDeviceConnected (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "isDeviceConnected", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args);
			return __ret;
		}

		static Delegate cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
#pragma warning disable 0169
		static Delegate GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler ()
		{
			if (cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ == null)
				cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_);
			return cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
		}

		static void n_OnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCloudChannelCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
		public unsafe void OnCloudChannelCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0)
		{
			if (id_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ == IntPtr.Zero)
				id_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ = JNIEnv.GetMethodID (class_ref, "onCloudChannelCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_, __args);
		}

		static Delegate cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
#pragma warning disable 0169
		static Delegate GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler ()
		{
			if (cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == null)
				cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_);
			return cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		}

		static bool n_RegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		public unsafe bool RegDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			if (id_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == IntPtr.Zero)
				id_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNIEnv.GetMethodID (class_ref, "regDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_, __args);
			return __ret;
		}

		static Delegate cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_;
#pragma warning disable 0169
		static Delegate GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler ()
		{
			if (cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ == null)
				cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_);
			return cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_;
		}

		static void n_StartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_;
		public unsafe void StartConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1)
		{
			if (id_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ == IntPtr.Zero)
				id_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ = JNIEnv.GetMethodID (class_ref, "startConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_, __args);
		}

		static Delegate cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static void n_StopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopConnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe void StopConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "stopConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args);
		}

		static Delegate cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Subscribe (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		public unsafe bool Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2)
		{
			if (id_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == IntPtr.Zero)
				id_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_, __args);
			return __ret;
		}

		static Delegate cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler ()
		{
			if (cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == null)
				cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_);
			return cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		}

		static bool n_UnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		public unsafe bool UnregDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			if (id_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == IntPtr.Zero)
				id_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNIEnv.GetMethodID (class_ref, "unregDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_, __args);
			return __ret;
		}

		static Delegate cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_Unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unsubscribe (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		public unsafe bool Unsubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			if (id_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == IntPtr.Zero)
				id_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_, __args);
			return __ret;
		}

	}

}
