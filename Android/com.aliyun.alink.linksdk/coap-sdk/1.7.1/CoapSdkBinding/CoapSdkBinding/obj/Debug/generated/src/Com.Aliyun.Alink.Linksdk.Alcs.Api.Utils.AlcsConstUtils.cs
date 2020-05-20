using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/utils/AlcsConstUtils", DoNotGenerateAcw=true)]
	public partial class AlcsConstUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='ALCS_AUTH_CLIENT']"
		[Register ("ALCS_AUTH_CLIENT")]
		public const int AlcsAuthClient = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='ALCS_AUTH_C_S']"
		[Register ("ALCS_AUTH_C_S")]
		public const int AlcsAuthCS = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='ALCS_AUTH_SERVER']"
		[Register ("ALCS_AUTH_SERVER")]
		public const int AlcsAuthServer = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='HEARTBEAT_DEFAULT_TIME']"
		[Register ("HEARTBEAT_DEFAULT_TIME")]
		public const int HeartbeatDefaultTime = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='MULTI_CAST']"
		[Register ("MULTI_CAST")]
		public const int MultiCast = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='SESSION_VALID_TIME']"
		[Register ("SESSION_VALID_TIME")]
		public const int SessionValidTime = (int) 86400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "[alcs_coap_sdk]";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/utils/AlcsConstUtils", typeof (AlcsConstUtils));
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

		protected AlcsConstUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.utils']/class[@name='AlcsConstUtils']/constructor[@name='AlcsConstUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsConstUtils ()
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

	}
}
