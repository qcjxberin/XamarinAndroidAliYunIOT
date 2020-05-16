using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayChannel", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker")]
	public partial interface IGatewayChannel : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState GatewayConnectState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='getGatewayConnectState' and count(parameter)=0]"
			[Register ("getGatewayConnectState", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;", "GetGetGatewayConnectStateHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='addSubDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.SubDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceConnectListener']]"
		[Register ("addSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener;)V", "GetAddSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void AddSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='asyncSendRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener']]"
		[Register ("asyncSendRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V", "GetAsyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void AsyncSendRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='ayncSendPublishRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener']]"
		[Register ("ayncSendPublishRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V", "GetAyncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void AyncSendPublishRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='destroyConnect' and count(parameter)=0]"
		[Register ("destroyConnect", "()V", "GetDestroyConnectHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void DestroyConnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='getSubDeviceChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSubDeviceChannel", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel;", "GetGetSubDeviceChannel_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel GetSubDeviceChannel (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='removeSubDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.SubDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceRemoveListener']]"
		[Register ("removeSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener;)V", "GetRemoveSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void RemoveSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='startConnect' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.GatewayConnectConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener']]"
		[Register ("startConnect", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectConfig;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V", "GetStartConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void StartConnect (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig p1, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayChannel']/method[@name='startConnectReuseMobileChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener']]"
		[Register ("startConnectReuseMobileChannel", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V", "GetStartConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannelInvoker, PublicChannelGatewayBinding")]
		void StartConnectReuseMobileChannel (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayChannel", DoNotGenerateAcw=true)]
	internal partial class IGatewayChannelInvoker : global::Java.Lang.Object, IGatewayChannel {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayChannel", typeof (IGatewayChannelInvoker));

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

		public static IGatewayChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGatewayChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.IGatewayChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGatewayChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GatewayConnectState);
		}
#pragma warning restore 0169

		IntPtr id_getGatewayConnectState;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState GatewayConnectState {
			get {
				if (id_getGatewayConnectState == IntPtr.Zero)
					id_getGatewayConnectState = JNIEnv.GetMethodID (class_ref, "getGatewayConnectState", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayConnectState), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSubDevice (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_;
		public unsafe void AddSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceConnectListener p1)
		{
			if (id_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_ == IntPtr.Zero)
				id_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_ = JNIEnv.GetMethodID (class_ref, "addSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceConnectListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceConnectListener_, __args);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AsyncSendRequest (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
		public unsafe void AsyncSendRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4)
		{
			if (id_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ == IntPtr.Zero)
				id_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ = JNIEnv.GetMethodID (class_ref, "asyncSendRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_asyncSendRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AyncSendPublishRequest (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_;
		public unsafe void AyncSendPublishRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::Java.Lang.Object p3, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener p4)
		{
			if (id_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ == IntPtr.Zero)
				id_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_ = JNIEnv.GetMethodID (class_ref, "ayncSendPublishRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ayncSendPublishRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayRequestListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyConnect ();
		}
#pragma warning restore 0169

		IntPtr id_destroyConnect;
		public unsafe void DestroyConnect ()
		{
			if (id_destroyConnect == IntPtr.Zero)
				id_destroyConnect = JNIEnv.GetMethodID (class_ref, "destroyConnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyConnect);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSubDeviceChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSubDeviceChannel_Ljava_lang_String_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel GetSubDeviceChannel (string p0)
		{
			if (id_getSubDeviceChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_getSubDeviceChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSubDeviceChannel", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubDeviceChannel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSubDevice (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_;
		public unsafe void RemoveSubDevice (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener p1)
		{
			if (id_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_ == IntPtr.Zero)
				id_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_ = JNIEnv.GetMethodID (class_ref, "removeSubDevice", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSubDevice_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_SubDeviceInfo_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceRemoveListener_, __args);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
		public unsafe void StartConnect (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectConfig p1, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p2)
		{
			if (id_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ == IntPtr.Zero)
				id_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ = JNIEnv.GetMethodID (class_ref, "startConnect", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectConfig;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startConnect_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectConfig_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_, __args);
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartConnectReuseMobileChannel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_;
		public unsafe void StartConnectReuseMobileChannel (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener p1)
		{
			if (id_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ == IntPtr.Zero)
				id_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_ = JNIEnv.GetMethodID (class_ref, "startConnectReuseMobileChannel", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startConnectReuseMobileChannel_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_gateway_api_IGatewayConnectListener_, __args);
		}

	}

}
