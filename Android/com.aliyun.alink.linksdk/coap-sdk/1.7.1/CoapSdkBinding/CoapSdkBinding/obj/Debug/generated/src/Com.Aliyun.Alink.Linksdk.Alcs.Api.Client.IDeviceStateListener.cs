using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	[Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener", DoNotGenerateAcw=true)]
	public abstract class DeviceStateListener : Java.Lang.Object {

		internal DeviceStateListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceStateListener']/field[@name='STATE_CONNECTED']"
		[Register ("STATE_CONNECTED")]
		public const int StateConnected = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceStateListener']/field[@name='STATE_DISCONNECTED']"
		[Register ("STATE_DISCONNECTED")]
		public const int StateDisconnected = (int) 0;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'DeviceStateListener' type. This type will be removed in a future release.", error: true)]
	public abstract class DeviceStateListenerConsts : DeviceStateListener {

		private DeviceStateListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceStateListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerInvoker")]
	public partial interface IDeviceStateListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/interface[@name='IDeviceStateListener']/method[@name='onDeviceStateChange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDeviceStateChange", "(I)V", "GetOnDeviceStateChange_IHandler:Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListenerInvoker, CoapSdkBinding")]
		void OnDeviceStateChange (int p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener", DoNotGenerateAcw=true)]
	internal partial class IDeviceStateListenerInvoker : global::Java.Lang.Object, IDeviceStateListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListener", typeof (IDeviceStateListenerInvoker));

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

		public static IDeviceStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.api.client.IDeviceStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDeviceStateChange_I;
#pragma warning disable 0169
		static Delegate GetOnDeviceStateChange_IHandler ()
		{
			if (cb_onDeviceStateChange_I == null)
				cb_onDeviceStateChange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDeviceStateChange_I);
			return cb_onDeviceStateChange_I;
		}

		static void n_OnDeviceStateChange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.IDeviceStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceStateChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDeviceStateChange_I;
		public unsafe void OnDeviceStateChange (int p0)
		{
			if (id_onDeviceStateChange_I == IntPtr.Zero)
				id_onDeviceStateChange_I = JNIEnv.GetMethodID (class_ref, "onDeviceStateChange", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceStateChange_I, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.api.client.IDeviceStateListener.onDeviceStateChange
	public partial class DeviceStateEventArgs : global::System.EventArgs {

		public DeviceStateEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListenerImplementor")]
	internal sealed partial class IDeviceStateListenerImplementor : global::Java.Lang.Object, IDeviceStateListener {

		object sender;

		public IDeviceStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/api/client/IDeviceStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DeviceStateEventArgs> Handler;
#pragma warning restore 0649

		public void OnDeviceStateChange (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DeviceStateEventArgs (p0));
		}

		internal static bool __IsEmpty (IDeviceStateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
