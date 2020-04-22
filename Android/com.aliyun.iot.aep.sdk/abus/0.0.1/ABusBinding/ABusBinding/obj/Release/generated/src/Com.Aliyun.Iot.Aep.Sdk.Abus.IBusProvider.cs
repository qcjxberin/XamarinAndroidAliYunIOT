using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBusProvider']"
	[Register ("com/aliyun/iot/aep/sdk/abus/IBusProvider", "", "Com.Aliyun.Iot.Aep.Sdk.Abus.IBusProviderInvoker")]
	public partial interface IBusProvider : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus Bus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IBusProvider']/method[@name='getBus' and count(parameter)=0]"
			[Register ("getBus", "()Lcom/aliyun/iot/aep/sdk/abus/IBus;", "GetGetBusHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IBusProviderInvoker, ABus")] get;
		}

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/IBusProvider", DoNotGenerateAcw=true)]
	internal partial class IBusProviderInvoker : global::Java.Lang.Object, IBusProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/IBusProvider", typeof (IBusProviderInvoker));

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

		public static IBusProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBusProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.abus.IBusProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBusProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBus;
#pragma warning disable 0169
		static Delegate GetGetBusHandler ()
		{
			if (cb_getBus == null)
				cb_getBus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBus);
			return cb_getBus;
		}

		static IntPtr n_GetBus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBusProvider __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBusProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bus);
		}
#pragma warning restore 0169

		IntPtr id_getBus;
		public unsafe global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus Bus {
			get {
				if (id_getBus == IntPtr.Zero)
					id_getBus = JNIEnv.GetMethodID (class_ref, "getBus", "()Lcom/aliyun/iot/aep/sdk/abus/IBus;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IBus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBus), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
