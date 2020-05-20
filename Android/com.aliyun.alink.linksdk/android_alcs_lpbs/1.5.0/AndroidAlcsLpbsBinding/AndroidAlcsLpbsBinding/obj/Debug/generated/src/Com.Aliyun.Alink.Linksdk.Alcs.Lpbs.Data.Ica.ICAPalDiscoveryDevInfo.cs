using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Ica {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICAPalDiscoveryDevInfo']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICAPalDiscoveryDevInfo", DoNotGenerateAcw=true)]
	public partial class ICAPalDiscoveryDevInfo : global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/ica/ICAPalDiscoveryDevInfo", typeof (ICAPalDiscoveryDevInfo));
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

		protected ICAPalDiscoveryDevInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data.ica']/class[@name='ICAPalDiscoveryDevInfo']/constructor[@name='ICAPalDiscoveryDevInfo' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Z)V", "")]
		public unsafe ICAPalDiscoveryDevInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
