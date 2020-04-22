using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Abus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='AChannelIDProvider']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/abus/AChannelIDProvider", DoNotGenerateAcw=true)]
	public partial class AChannelIDProvider : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Sdk.Abus.IChannelIDProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/abus/AChannelIDProvider", typeof (AChannelIDProvider));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AChannelIDProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='AChannelIDProvider']/constructor[@name='AChannelIDProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AChannelIDProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
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
			global::Com.Aliyun.Iot.Aep.Sdk.Abus.AChannelIDProvider __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Abus.AChannelIDProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GenerateChannelID ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.abus']/class[@name='AChannelIDProvider']/method[@name='generateChannelID' and count(parameter)=0]"
		[Register ("generateChannelID", "()I", "GetGenerateChannelIDHandler")]
		public virtual unsafe int GenerateChannelID ()
		{
			const string __id = "generateChannelID.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
