using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceRemoveListener']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListenerInvoker")]
	public partial interface ISubDeviceRemoveListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceRemoveListener']/method[@name='onSuceess' and count(parameter)=0]"
		[Register ("onSuceess", "()V", "GetOnSuceessHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListenerInvoker, PublicChannelGatewayBinding")]
		void OnSuceess ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener", DoNotGenerateAcw=true)]
	internal partial class ISubDeviceRemoveListenerInvoker : global::Java.Lang.Object, ISubDeviceRemoveListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListener", typeof (ISubDeviceRemoveListenerInvoker));

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

		public static ISubDeviceRemoveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubDeviceRemoveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceRemoveListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubDeviceRemoveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuceess;
#pragma warning disable 0169
		static Delegate GetOnSuceessHandler ()
		{
			if (cb_onSuceess == null)
				cb_onSuceess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuceess);
			return cb_onSuceess;
		}

		static void n_OnSuceess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceRemoveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuceess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuceess;
		public unsafe void OnSuceess ()
		{
			if (id_onSuceess == IntPtr.Zero)
				id_onSuceess = JNIEnv.GetMethodID (class_ref, "onSuceess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuceess);
		}

	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListenerImplementor")]
	internal sealed partial class ISubDeviceRemoveListenerImplementor : global::Java.Lang.Object, ISubDeviceRemoveListener {

		object sender;

		public ISubDeviceRemoveListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceRemoveListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnSuceess ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ISubDeviceRemoveListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
