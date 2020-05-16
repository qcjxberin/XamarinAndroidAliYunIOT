using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker")]
	public partial interface ISubDeviceChannel : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo SubDeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='getSubDeviceInfo' and count(parameter)=0]"
			[Register ("getSubDeviceInfo", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;", "GetGetSubDeviceInfoHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='offline' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener']]"
		[Register ("offline", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V", "GetOffline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")]
		void Offline (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='online' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener']]"
		[Register ("online", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V", "GetOnline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")]
		void Online (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V", "GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")]
		void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='unSubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener']]"
		[Register ("unSubscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V", "GetUnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")]
		void UnSubscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceChannel']/method[@name='uploadData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener']]"
		[Register ("uploadData", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V", "GetUploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannelInvoker, PublicChannelGatewayBinding")]
		void UploadData (string p0, string p1, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel", DoNotGenerateAcw=true)]
	internal partial class ISubDeviceChannelInvoker : global::Java.Lang.Object, ISubDeviceChannel {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceChannel", typeof (ISubDeviceChannelInvoker));

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

		public static ISubDeviceChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubDeviceChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubDeviceChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSubDeviceInfo;
#pragma warning disable 0169
		static Delegate GetGetSubDeviceInfoHandler ()
		{
			if (cb_getSubDeviceInfo == null)
				cb_getSubDeviceInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubDeviceInfo);
			return cb_getSubDeviceInfo;
		}

		static IntPtr n_GetSubDeviceInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubDeviceInfo);
		}
#pragma warning restore 0169

		IntPtr id_getSubDeviceInfo;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo SubDeviceInfo {
			get {
				if (id_getSubDeviceInfo == IntPtr.Zero)
					id_getSubDeviceInfo = JNIEnv.GetMethodID (class_ref, "getSubDeviceInfo", "()Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/SubDeviceInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.SubDeviceInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubDeviceInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
#pragma warning disable 0169
		static Delegate GetOffline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler ()
		{
			if (cb_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == null)
				cb_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_);
			return cb_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		}

		static void n_Offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Offline (p0);
		}
#pragma warning restore 0169

		IntPtr id_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		public unsafe void Offline (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0)
		{
			if (id_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == IntPtr.Zero)
				id_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNIEnv.GetMethodID (class_ref, "offline", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_offline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_, __args);
		}

		static Delegate cb_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
#pragma warning disable 0169
		static Delegate GetOnline_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler ()
		{
			if (cb_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == null)
				cb_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_);
			return cb_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		}

		static void n_Online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Online (p0);
		}
#pragma warning restore 0169

		IntPtr id_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		public unsafe void Online (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p0)
		{
			if (id_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == IntPtr.Zero)
				id_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNIEnv.GetMethodID (class_ref, "online", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_online_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_, __args);
		}

		static Delegate cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == null)
				cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_);
			return cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		}

		static void n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		public unsafe void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1)
		{
			if (id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
#pragma warning disable 0169
		static Delegate GetUnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler ()
		{
			if (cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == null)
				cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_);
			return cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		}

		static void n_UnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribe (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		public unsafe void UnSubscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p1)
		{
			if (id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == IntPtr.Zero)
				id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNIEnv.GetMethodID (class_ref, "unSubscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
#pragma warning disable 0169
		static Delegate GetUploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_Handler ()
		{
			if (cb_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == null)
				cb_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_);
			return cb_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		}

		static void n_UploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UploadData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_;
		public unsafe void UploadData (string p0, string p1, global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener p2)
		{
			if (id_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ == IntPtr.Zero)
				id_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_ = JNIEnv.GetMethodID (class_ref, "uploadData", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uploadData_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_gateway_api_subdevice_ISubDeviceActionListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
