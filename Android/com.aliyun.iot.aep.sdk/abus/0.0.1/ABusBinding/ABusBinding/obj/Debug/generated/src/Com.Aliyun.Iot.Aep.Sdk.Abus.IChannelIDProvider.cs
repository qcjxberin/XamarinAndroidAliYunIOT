using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannelIDProvider']"
	[Register ("com/aliyun/iot/aep/sdk/abus/IChannelIDProvider", "", "Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelIDProviderInvoker")]
	public partial interface IChannelIDProvider : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannelIDProvider']/method[@name='generateChannelID' and count(parameter)=0]"
		[Register ("generateChannelID", "()I", "GetGenerateChannelIDHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelIDProviderInvoker, ABus")]
		int GenerateChannelID ();

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/IChannelIDProvider", DoNotGenerateAcw=true)]
	internal partial class IChannelIDProviderInvoker : global::Java.Lang.Object, IChannelIDProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/IChannelIDProvider", typeof (IChannelIDProviderInvoker));

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

		public static IChannelIDProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChannelIDProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.abus.IChannelIDProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChannelIDProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_generateChannelID;
#pragma warning disable 0169
		static Delegate GetGenerateChannelIDHandler ()
		{
			if (cb_generateChannelID == null)
				cb_generateChannelID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GenerateChannelID);
			return cb_generateChannelID;
		}

		static int n_GenerateChannelID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelIDProvider __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelIDProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GenerateChannelID ();
		}
#pragma warning restore 0169

		IntPtr id_generateChannelID;
		public unsafe int GenerateChannelID ()
		{
			if (id_generateChannelID == IntPtr.Zero)
				id_generateChannelID = JNIEnv.GetMethodID (class_ref, "generateChannelID", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_generateChannelID);
		}

	}

}
