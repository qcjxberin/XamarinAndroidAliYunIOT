using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannel']"
	[Register ("com/aliyun/iot/aep/sdk/abus/IChannel", "", "Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelInvoker")]
	public partial interface IChannel : IJavaObject, IJavaPeerable {

		int ChannelID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannel']/method[@name='getChannelID' and count(parameter)=0]"
			[Register ("getChannelID", "()I", "GetGetChannelIDHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelInvoker, ABus")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannel']/method[@name='blockChannel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("blockChannel", "(Z)V", "GetBlockChannel_ZHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelInvoker, ABus")]
		void BlockChannel (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/interface[@name='IChannel']/method[@name='cancelChannel' and count(parameter)=0]"
		[Register ("cancelChannel", "()V", "GetCancelChannelHandler:Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelInvoker, ABus")]
		void CancelChannel ();

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/IChannel", DoNotGenerateAcw=true)]
	internal partial class IChannelInvoker : global::Java.Lang.Object, IChannel {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/IChannel", typeof (IChannelInvoker));

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

		public static IChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.abus.IChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getChannelID;
#pragma warning disable 0169
		static Delegate GetGetChannelIDHandler ()
		{
			if (cb_getChannelID == null)
				cb_getChannelID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelID);
			return cb_getChannelID;
		}

		static int n_GetChannelID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelID;
		}
#pragma warning restore 0169

		IntPtr id_getChannelID;
		public unsafe int ChannelID {
			get {
				if (id_getChannelID == IntPtr.Zero)
					id_getChannelID = JNIEnv.GetMethodID (class_ref, "getChannelID", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelID);
			}
		}

		static Delegate cb_blockChannel_Z;
#pragma warning disable 0169
		static Delegate GetBlockChannel_ZHandler ()
		{
			if (cb_blockChannel_Z == null)
				cb_blockChannel_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_BlockChannel_Z);
			return cb_blockChannel_Z;
		}

		static void n_BlockChannel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_blockChannel_Z;
		public unsafe void BlockChannel (bool p0)
		{
			if (id_blockChannel_Z == IntPtr.Zero)
				id_blockChannel_Z = JNIEnv.GetMethodID (class_ref, "blockChannel", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockChannel_Z, __args);
		}

		static Delegate cb_cancelChannel;
#pragma warning disable 0169
		static Delegate GetCancelChannelHandler ()
		{
			if (cb_cancelChannel == null)
				cb_cancelChannel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelChannel);
			return cb_cancelChannel;
		}

		static void n_CancelChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelChannel ();
		}
#pragma warning restore 0169

		IntPtr id_cancelChannel;
		public unsafe void CancelChannel ()
		{
			if (id_cancelChannel == IntPtr.Zero)
				id_cancelChannel = JNIEnv.GetMethodID (class_ref, "cancelChannel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelChannel);
		}

	}

}
