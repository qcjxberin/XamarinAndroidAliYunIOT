using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='IoTTokenInvalidListener']"
	[Register ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener", "", "Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerInvoker")]
	public partial interface IIoTTokenInvalidListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='IoTTokenInvalidListener']/method[@name='onIoTTokenInvalid' and count(parameter)=0]"
		[Register ("onIoTTokenInvalid", "()V", "GetOnIoTTokenInvalidHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListenerInvoker, IotCredentialBinding")]
		void OnIoTTokenInvalid ();

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener", DoNotGenerateAcw=true)]
	internal partial class IIoTTokenInvalidListenerInvoker : global::Java.Lang.Object, IIoTTokenInvalidListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListener", typeof (IIoTTokenInvalidListenerInvoker));

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

		public static IIoTTokenInvalidListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIoTTokenInvalidListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.credential.listener.IoTTokenInvalidListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIoTTokenInvalidListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onIoTTokenInvalid;
#pragma warning disable 0169
		static Delegate GetOnIoTTokenInvalidHandler ()
		{
			if (cb_onIoTTokenInvalid == null)
				cb_onIoTTokenInvalid = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnIoTTokenInvalid);
			return cb_onIoTTokenInvalid;
		}

		static void n_OnIoTTokenInvalid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenInvalidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnIoTTokenInvalid ();
		}
#pragma warning restore 0169

		IntPtr id_onIoTTokenInvalid;
		public unsafe void OnIoTTokenInvalid ()
		{
			if (id_onIoTTokenInvalid == IntPtr.Zero)
				id_onIoTTokenInvalid = JNIEnv.GetMethodID (class_ref, "onIoTTokenInvalid", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIoTTokenInvalid);
		}

	}

	[global::Android.Runtime.Register ("mono/com/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListenerImplementor")]
	internal sealed partial class IIoTTokenInvalidListenerImplementor : global::Java.Lang.Object, IIoTTokenInvalidListener {

		object sender;

		public IIoTTokenInvalidListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/iot/aep/sdk/credential/listener/IoTTokenInvalidListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnIoTTokenInvalid ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IIoTTokenInvalidListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
