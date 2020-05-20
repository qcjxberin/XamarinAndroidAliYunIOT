using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/IAlcsPal", DoNotGenerateAcw=true)]
	public abstract partial class IAlcsPal : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalProbe {


		public static class InterfaceConsts {

			// The following are fields from: com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalDiscovery

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/field[@name='DISCOVERY_TYPE_FINISH']"
			[Register ("DISCOVERY_TYPE_FINISH")]
			public const int DiscoveryTypeFinish = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/field[@name='DISCOVERY_TYPE_FOUND']"
			[Register ("DISCOVERY_TYPE_FOUND")]
			public const int DiscoveryTypeFound = (int) 1;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/IAlcsPal", typeof (IAlcsPal));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected IAlcsPal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/constructor[@name='IAlcsPal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IAlcsPal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deInitAlcs;
#pragma warning disable 0169
		static Delegate GetDeInitAlcsHandler ()
		{
			if (cb_deInitAlcs == null)
				cb_deInitAlcs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeInitAlcs);
			return cb_deInitAlcs;
		}

		static void n_DeInitAlcs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeInitAlcs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='deInitAlcs' and count(parameter)=0]"
		[Register ("deInitAlcs", "()V", "GetDeInitAlcsHandler")]
		public abstract void DeInitAlcs ();

		static Delegate cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
#pragma warning disable 0169
		static Delegate GetInitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler ()
		{
			if (cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ == null)
				cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_);
			return cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
		}

		static void n_InitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitAlcs (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='initAlcs' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalInitData']]"
		[Register ("initAlcs", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V", "GetInitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler")]
		public abstract void InitAlcs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0);

		static Delegate cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
#pragma warning disable 0169
		static Delegate GetRegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler ()
		{
			if (cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ == null)
				cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_);
			return cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
		}

		static bool n_RegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegAuthProvider (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='regAuthProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProvider']]"
		[Register ("regAuthProvider", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z", "GetRegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler")]
		public abstract bool RegAuthProvider (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p1);

		static Delegate cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_;
#pragma warning disable 0169
		static Delegate GetRegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_Handler ()
		{
			if (cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ == null)
				cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_);
			return cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_;
		}

		static void n_RegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegCloudChannelFactory (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='regCloudChannelFactory' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory']]"
		[Register ("regCloudChannelFactory", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;)V", "GetRegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_Handler")]
		public abstract void RegCloudChannelFactory (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory p0);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AsyncSendRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='asyncSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public abstract bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceConnected (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='isDeviceConnected' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDeviceConnected", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public abstract bool IsDeviceConnected (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCloudChannelCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='onCloudChannelCreate' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel']]"
		[Register ("onCloudChannelCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V", "GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler")]
		public abstract void OnCloudChannelCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='regDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("regDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public abstract bool RegDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='startConnect' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalConnectParams'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener']]"
		[Register ("startConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V", "GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler")]
		public abstract void StartConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopConnect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='stopConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("stopConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public abstract void StopConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Subscribe (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("subscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public abstract bool Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unregDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("unregDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public abstract bool UnregDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1);

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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unsubscribe (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("unsubscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public abstract bool Unsubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1);

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public abstract bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2);

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public abstract bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1);

		static Delegate cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartNotifyMonitor (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startNotifyMonitor' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startNotifyMonitor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public abstract bool StartNotifyMonitor (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0);

		static Delegate cb_stopDiscovery;
#pragma warning disable 0169
		static Delegate GetStopDiscoveryHandler ()
		{
			if (cb_stopDiscovery == null)
				cb_stopDiscovery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopDiscovery);
			return cb_stopDiscovery;
		}

		static bool n_StopDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDiscovery ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopDiscovery' and count(parameter)=0]"
		[Register ("stopDiscovery", "()Z", "GetStopDiscoveryHandler")]
		public abstract bool StopDiscovery ();

		static Delegate cb_stopNotifyMonitor;
#pragma warning disable 0169
		static Delegate GetStopNotifyMonitorHandler ()
		{
			if (cb_stopNotifyMonitor == null)
				cb_stopNotifyMonitor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopNotifyMonitor);
			return cb_stopNotifyMonitor;
		}

		static bool n_StopNotifyMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopNotifyMonitor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopNotifyMonitor' and count(parameter)=0]"
		[Register ("stopNotifyMonitor", "()Z", "GetStopNotifyMonitorHandler")]
		public abstract bool StopNotifyMonitor ();

		static Delegate cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_;
#pragma warning disable 0169
		static Delegate GetProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_Handler ()
		{
			if (cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ == null)
				cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_);
			return cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_;
		}

		static void n_ProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProbeDevice (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalProbe']/method[@name='probeDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalProbeListener']]"
		[Register ("probeDevice", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener;)V", "GetProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_Handler")]
		public abstract void ProbeDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/IAlcsPal", DoNotGenerateAcw=true)]
	internal partial class IAlcsPalInvoker : IAlcsPal {

		public IAlcsPalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/IAlcsPal", typeof (IAlcsPalInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='deInitAlcs' and count(parameter)=0]"
		[Register ("deInitAlcs", "()V", "GetDeInitAlcsHandler")]
		public override unsafe void DeInitAlcs ()
		{
			const string __id = "deInitAlcs.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='initAlcs' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalInitData']]"
		[Register ("initAlcs", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V", "GetInitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler")]
		public override unsafe void InitAlcs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0)
		{
			const string __id = "initAlcs.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='regAuthProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProvider']]"
		[Register ("regAuthProvider", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z", "GetRegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler")]
		public override unsafe bool RegAuthProvider (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p1)
		{
			const string __id = "regAuthProvider.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='IAlcsPal']/method[@name='regCloudChannelFactory' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory']]"
		[Register ("regCloudChannelFactory", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;)V", "GetRegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_Handler")]
		public override unsafe void RegCloudChannelFactory (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory p0)
		{
			const string __id = "regCloudChannelFactory.(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='asyncSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			const string __id = "asyncSendRequest.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='isDeviceConnected' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDeviceConnected", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public override unsafe bool IsDeviceConnected (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "isDeviceConnected.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='onCloudChannelCreate' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel']]"
		[Register ("onCloudChannelCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V", "GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler")]
		public override unsafe void OnCloudChannelCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0)
		{
			const string __id = "onCloudChannelCreate.(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='regDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("regDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public override unsafe bool RegDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			const string __id = "regDeviceStateListener.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='startConnect' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalConnectParams'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener']]"
		[Register ("startConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V", "GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler")]
		public override unsafe void StartConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1)
		{
			const string __id = "startConnect.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='stopConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("stopConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public override unsafe void StopConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "stopConnect.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("subscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2)
		{
			const string __id = "subscribe.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unregDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("unregDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public override unsafe bool UnregDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			const string __id = "unregDeviceStateListener.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalConnect']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("unsubscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool Unsubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			const string __id = "unsubscribe.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2)
		{
			const string __id = "startDiscovery.(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1)
		{
			const string __id = "startDiscovery.(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startNotifyMonitor' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startNotifyMonitor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartNotifyMonitor (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0)
		{
			const string __id = "startNotifyMonitor.(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopDiscovery' and count(parameter)=0]"
		[Register ("stopDiscovery", "()Z", "GetStopDiscoveryHandler")]
		public override unsafe bool StopDiscovery ()
		{
			const string __id = "stopDiscovery.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopNotifyMonitor' and count(parameter)=0]"
		[Register ("stopNotifyMonitor", "()Z", "GetStopNotifyMonitorHandler")]
		public override unsafe bool StopNotifyMonitor ()
		{
			const string __id = "stopNotifyMonitor.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalProbe']/method[@name='probeDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalProbeListener']]"
		[Register ("probeDevice", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener;)V", "GetProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_Handler")]
		public override unsafe void ProbeDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener p1)
		{
			const string __id = "probeDevice.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
