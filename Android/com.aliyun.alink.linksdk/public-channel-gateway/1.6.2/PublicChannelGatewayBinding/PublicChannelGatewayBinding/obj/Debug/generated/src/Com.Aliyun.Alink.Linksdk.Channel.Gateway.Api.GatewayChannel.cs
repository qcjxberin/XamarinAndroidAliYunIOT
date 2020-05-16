using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/GatewayChannel", DoNotGenerateAcw=true)]
	public partial class GatewayChannel : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/field[@name='DID_SEPARATOR']"
		[Register ("DID_SEPARATOR")]
		public const string DidSeparator = (string) "-&&-";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/GatewayChannel", typeof (GatewayChannel));
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

		protected GatewayChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getGatewayConnectState;
#pragma warning disable 0169
		static Delegate GetGetGatewayConnectStateHandler ()
		{
			if (cb_getGatewayConnectState == null)
				cb_getGatewayConnectState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayConnectState);
			return cb_getGatewayConnectState;
		}

		static IntPtr n_GetGatewayConnectState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GatewayConnectState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState GatewayConnectState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='getGatewayConnectState' and count(parameter)=0]"
			[Register ("getGatewayConnectState", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;", "GetGetGatewayConnectStateHandler")]
			get {
				const string __id = "getGatewayConnectState.()Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayChannel;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayChannel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_;
#pragma warning disable 0169
		static Delegate GetAddSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_Handler ()
		{
			if (cb_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_ == null)
				cb_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_);
			return cb_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_;
		}

		static void n_AddSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSubDevice (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='addSubDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.SubDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceConnectListener']]"
		[Register ("addSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener;)V", "GetAddSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_Handler")]
		public virtual unsafe void AddSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener p1)
		{
			const string __id = "addSubDevice.(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler ()
		{
			if (cb_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ == null)
				cb_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_);
			return cb_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
		}

		static void n_AsyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AsyncSendRequest (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='asyncSendRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener']]"
		[Register ("asyncSendRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V", "GetAsyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler")]
		public virtual unsafe void AsyncSendRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4)
		{
			const string __id = "asyncSendRequest.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
#pragma warning disable 0169
		static Delegate GetAyncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler ()
		{
			if (cb_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ == null)
				cb_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AyncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_);
			return cb_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
		}

		static void n_AyncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AyncSendPublishRequest (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='ayncSendPublishRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener']]"
		[Register ("ayncSendPublishRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V", "GetAyncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler")]
		public virtual unsafe void AyncSendPublishRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4)
		{
			const string __id = "ayncSendPublishRequest.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_destroyConnect;
#pragma warning disable 0169
		static Delegate GetDestroyConnectHandler ()
		{
			if (cb_destroyConnect == null)
				cb_destroyConnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DestroyConnect);
			return cb_destroyConnect;
		}

		static void n_DestroyConnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyConnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='destroyConnect' and count(parameter)=0]"
		[Register ("destroyConnect", "()V", "GetDestroyConnectHandler")]
		public virtual unsafe void DestroyConnect ()
		{
			const string __id = "destroyConnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getSubDeviceChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSubDeviceChannel_Ljava_lang_String_Handler ()
		{
			if (cb_getSubDeviceChannel_Ljava_lang_String_ == null)
				cb_getSubDeviceChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSubDeviceChannel_Ljava_lang_String_);
			return cb_getSubDeviceChannel_Ljava_lang_String_;
		}

		static IntPtr n_GetSubDeviceChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSubDeviceChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='getSubDeviceChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSubDeviceChannel", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel;", "GetGetSubDeviceChannel_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel GetSubDeviceChannel (string p0)
		{
			const string __id = "getSubDeviceChannel.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_;
#pragma warning disable 0169
		static Delegate GetRemoveSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_Handler ()
		{
			if (cb_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_ == null)
				cb_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_);
			return cb_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_;
		}

		static void n_RemoveSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSubDevice (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='removeSubDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.SubDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceRemoveListener']]"
		[Register ("removeSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener;)V", "GetRemoveSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_Handler")]
		public virtual unsafe void RemoveSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener p1)
		{
			const string __id = "removeSubDevice.(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
#pragma warning disable 0169
		static Delegate GetStartConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler ()
		{
			if (cb_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ == null)
				cb_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_);
			return cb_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
		}

		static void n_StartConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='startConnect' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.GatewayConnectConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener']]"
		[Register ("startConnect", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectConfig;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V", "GetStartConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler")]
		public virtual unsafe void StartConnect (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig p1, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p2)
		{
			const string __id = "startConnect.(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectConfig;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
#pragma warning disable 0169
		static Delegate GetStartConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler ()
		{
			if (cb_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ == null)
				cb_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_);
			return cb_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
		}

		static void n_StartConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartConnectReuseMobileChannel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/class[@name='GatewayChannel']/method[@name='startConnectReuseMobileChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener']]"
		[Register ("startConnectReuseMobileChannel", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V", "GetStartConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler")]
		public virtual unsafe void StartConnectReuseMobileChannel (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p1)
		{
			const string __id = "startConnectReuseMobileChannel.(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
