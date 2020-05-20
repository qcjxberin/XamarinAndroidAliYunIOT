using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='IoTTokenCreatedListener']"
	[Register ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener", "", "Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListenerInvoker")]
	public partial interface IIoTTokenCreatedListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.listener']/interface[@name='IoTTokenCreatedListener']/method[@name='onIoTTokenCreated' and count(parameter)=0]"
		[Register ("onIoTTokenCreated", "()V", "GetOnIoTTokenCreatedHandler:Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListenerInvoker, IotCredentialBinding")]
		void OnIoTTokenCreated ();

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener", DoNotGenerateAcw=true)]
	internal partial class IIoTTokenCreatedListenerInvoker : global::Java.Lang.Object, IIoTTokenCreatedListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListener", typeof (IIoTTokenCreatedListenerInvoker));

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

		public static IIoTTokenCreatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIoTTokenCreatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.credential.listener.IoTTokenCreatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIoTTokenCreatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onIoTTokenCreated;
#pragma warning disable 0169
		static Delegate GetOnIoTTokenCreatedHandler ()
		{
			if (cb_onIoTTokenCreated == null)
				cb_onIoTTokenCreated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnIoTTokenCreated);
			return cb_onIoTTokenCreated;
		}

		static void n_OnIoTTokenCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Listener.IIoTTokenCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnIoTTokenCreated ();
		}
#pragma warning restore 0169

		IntPtr id_onIoTTokenCreated;
		public unsafe void OnIoTTokenCreated ()
		{
			if (id_onIoTTokenCreated == IntPtr.Zero)
				id_onIoTTokenCreated = JNIEnv.GetMethodID (class_ref, "onIoTTokenCreated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIoTTokenCreated);
		}

	}

	[global::Android.Runtime.Register ("mono/com/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListenerImplementor")]
	internal sealed partial class IIoTTokenCreatedListenerImplementor : global::Java.Lang.Object, IIoTTokenCreatedListener {

		object sender;

		public IIoTTokenCreatedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/iot/aep/sdk/credential/listener/IoTTokenCreatedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnIoTTokenCreated ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IIoTTokenCreatedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
