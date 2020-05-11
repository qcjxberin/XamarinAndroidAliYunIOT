using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='VersionInfoUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/VersionInfoUtils", DoNotGenerateAcw=true)]
	public partial class VersionInfoUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/VersionInfoUtils", typeof (VersionInfoUtils));
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

		protected VersionInfoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='VersionInfoUtils']/constructor[@name='VersionInfoUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VersionInfoUtils ()
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

		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='VersionInfoUtils']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='VersionInfoUtils']/method[@name='getUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserAgent", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAgent (string customInfo)
		{
			const string __id = "getUserAgent.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_customInfo = JNIEnv.NewString (customInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_customInfo);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_customInfo);
			}
		}

	}
}
