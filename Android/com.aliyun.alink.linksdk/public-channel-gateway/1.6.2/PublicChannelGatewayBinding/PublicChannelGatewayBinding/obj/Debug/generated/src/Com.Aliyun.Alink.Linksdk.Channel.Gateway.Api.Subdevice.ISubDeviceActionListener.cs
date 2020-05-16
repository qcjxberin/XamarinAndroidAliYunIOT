using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceActionListener']"
	[Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener", "", "Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListenerInvoker")]
	public partial interface ISubDeviceActionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.gateway.api.subdevice']/interface[@name='ISubDeviceActionListener']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListenerInvoker, PublicChannelGatewayBinding")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener", DoNotGenerateAcw=true)]
	internal partial class ISubDeviceActionListenerInvoker : global::Java.Lang.Object, ISubDeviceActionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListener", typeof (ISubDeviceActionListenerInvoker));

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

		public static ISubDeviceActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubDeviceActionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.gateway.api.subdevice.ISubDeviceActionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubDeviceActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Gateway.Api.Subdevice.ISubDeviceActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListenerImplementor")]
	internal sealed partial class ISubDeviceActionListenerImplementor : global::Java.Lang.Object, ISubDeviceActionListener {

		object sender;

		public ISubDeviceActionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/channel/gateway/api/subdevice/ISubDeviceActionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnSuccess ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ISubDeviceActionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
