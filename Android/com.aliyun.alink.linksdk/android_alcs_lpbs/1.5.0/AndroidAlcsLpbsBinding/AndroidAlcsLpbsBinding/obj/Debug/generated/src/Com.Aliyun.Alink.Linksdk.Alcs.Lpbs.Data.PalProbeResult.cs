using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/data/PalProbeResult", DoNotGenerateAcw=true)]
	public partial class PalProbeResult : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']/field[@name='PAL_PROBE_ERROR_RSPERROR']"
		[Register ("PAL_PROBE_ERROR_RSPERROR")]
		public const int PalProbeErrorRsperror = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']/field[@name='PAL_PROBE_ERROR_TIMEOUT']"
		[Register ("PAL_PROBE_ERROR_TIMEOUT")]
		public const int PalProbeErrorTimeout = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']/field[@name='PAL_PROBE_OK']"
		[Register ("PAL_PROBE_OK")]
		public const int PalProbeOk = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']/field[@name='probeResult']"
		[Register ("probeResult")]
		public int ProbeResult {
			get {
				const string __id = "probeResult.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "probeResult.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/data/PalProbeResult", typeof (PalProbeResult));
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

		protected PalProbeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.data']/class[@name='PalProbeResult']/constructor[@name='PalProbeResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe PalProbeResult (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
