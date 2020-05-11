using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.exception']/class[@name='InconsistentException']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/exception/InconsistentException", DoNotGenerateAcw=true)]
	public partial class InconsistentException : global::Java.IO.IOException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/exception/InconsistentException", typeof (InconsistentException));
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

		protected InconsistentException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.exception']/class[@name='InconsistentException']/constructor[@name='InconsistentException' and count(parameter)=3 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public unsafe InconsistentException (global::Java.Lang.Long clientChecksum, global::Java.Lang.Long serverChecksum, string requestId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_requestId = JNIEnv.NewString (requestId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clientChecksum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientChecksum).Handle);
				__args [1] = new JniArgumentValue ((serverChecksum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverChecksum).Handle);
				__args [2] = new JniArgumentValue (native_requestId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestId);
			}
		}

	}
}
