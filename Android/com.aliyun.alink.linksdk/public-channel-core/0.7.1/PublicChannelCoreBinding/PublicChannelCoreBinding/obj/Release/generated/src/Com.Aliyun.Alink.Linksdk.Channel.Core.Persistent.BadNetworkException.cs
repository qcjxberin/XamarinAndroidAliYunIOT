using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='BadNetworkException']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/BadNetworkException", DoNotGenerateAcw=true)]
	public partial class BadNetworkException : global::Java.Lang.Exception {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/BadNetworkException", typeof (BadNetworkException));
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

		protected BadNetworkException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='BadNetworkException']/constructor[@name='BadNetworkException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BadNetworkException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
