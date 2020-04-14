using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Sdk.Tools.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='Trackers']"
	[global::Android.Runtime.Register ("com/aliyun/iot/sdk/tools/tracker/Trackers", DoNotGenerateAcw=true)]
	public partial class Trackers : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/sdk/tools/tracker/Trackers", typeof (Trackers));
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

		protected Trackers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='Trackers']/constructor[@name='Trackers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Trackers ()
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

		public static unsafe global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker BoneLinkTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.sdk.tools.tracker']/class[@name='Trackers']/method[@name='getBoneLinkTracker' and count(parameter)=0]"
			[Register ("getBoneLinkTracker", "()Lcom/aliyun/iot/sdk/tools/tracker/BoneLinkTracker;", "")]
			get {
				const string __id = "getBoneLinkTracker.()Lcom/aliyun/iot/sdk/tools/tracker/BoneLinkTracker;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Sdk.Tools.Tracker.BoneLinkTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
