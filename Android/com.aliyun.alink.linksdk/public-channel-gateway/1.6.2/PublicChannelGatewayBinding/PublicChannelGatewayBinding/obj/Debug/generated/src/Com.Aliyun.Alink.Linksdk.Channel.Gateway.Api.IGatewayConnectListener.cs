using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayConnectListener']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListenerInvoker")]
	public partial interface IGatewayConnectListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayConnectListener']/method[@name='onConnectStateChange' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.gateway.api.GatewayConnectState']]"
		[Register ("onConnectStateChange", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;)V", "GetOnConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListenerInvoker, PublicChannelGatewayBinding")]
		void OnConnectStateChange (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener", DoNotGenerateAcw=true)]
	internal partial class IGatewayConnectListenerInvoker : global::Java.Lang.Object, IGatewayConnectListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListener", typeof (IGatewayConnectListenerInvoker));

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

		public static IGatewayConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGatewayConnectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGatewayConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_;
#pragma warning disable 0169
		static Delegate GetOnConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_Handler ()
		{
			if (cb_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_ == null)
				cb_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_);
			return cb_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_;
		}

		static void n_OnConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectStateChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_;
		public unsafe void OnConnectStateChange (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0)
		{
			if (id_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_ == IntPtr.Zero)
				id_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_ = JNIEnv.GetMethodID (class_ref, "onConnectStateChange", "(Lcom/aliyun/alink/linksdk/channel/gateway/api/GatewayConnectState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectStateChange_Lcom_aliyun_alink_linksdk_channel_gateway_api_GatewayConnectState_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.gateway.api.IGatewayConnectListener.onConnectStateChange
	public partial class GatewayConnectEventArgs : global::System.EventArgs {

		public GatewayConnectEventArgs (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0;
		public global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListenerImplementor")]
	internal sealed partial class IGatewayConnectListenerImplementor : global::Java.Lang.Object, IGatewayConnectListener {

		object sender;

		public IGatewayConnectListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/gateway/api/IGatewayConnectListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GatewayConnectEventArgs> Handler;
#pragma warning restore 0649

		public void OnConnectStateChange (global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.GatewayConnectState p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GatewayConnectEventArgs (p0));
		}

		internal static bool __IsEmpty (IGatewayConnectListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
