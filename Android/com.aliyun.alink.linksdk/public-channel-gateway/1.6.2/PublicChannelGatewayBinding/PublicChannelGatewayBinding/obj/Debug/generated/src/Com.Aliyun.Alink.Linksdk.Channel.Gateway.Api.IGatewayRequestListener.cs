using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayRequestListener']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListenerInvoker")]
	public partial interface IGatewayRequestListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api']/interface[@name='IGatewayRequestListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListenerInvoker, PublicChannelGatewayBinding")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener", DoNotGenerateAcw=true)]
	internal partial class IGatewayRequestListenerInvoker : global::Java.Lang.Object, IGatewayRequestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListener", typeof (IGatewayRequestListenerInvoker));

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

		public static IGatewayRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGatewayRequestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGatewayRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.IGatewayRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.aliyun.alink.linksdk.channel.gateway.api.IGatewayRequestListener.onSuccess
	public partial class GatewayRequestEventArgs : global::System.EventArgs {

		public GatewayRequestEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListenerImplementor")]
	internal sealed partial class IGatewayRequestListenerImplementor : global::Java.Lang.Object, IGatewayRequestListener {

		object sender;

		public IGatewayRequestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/gateway/api/IGatewayRequestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GatewayRequestEventArgs> Handler;
#pragma warning restore 0649

		public void OnSuccess (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GatewayRequestEventArgs (p0));
		}

		internal static bool __IsEmpty (IGatewayRequestListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
