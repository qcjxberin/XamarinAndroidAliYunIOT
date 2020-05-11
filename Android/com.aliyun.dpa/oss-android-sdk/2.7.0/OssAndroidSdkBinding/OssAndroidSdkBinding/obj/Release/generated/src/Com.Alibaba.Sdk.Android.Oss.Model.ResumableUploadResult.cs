using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadResult']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/ResumableUploadResult", DoNotGenerateAcw=true)]
	public partial class ResumableUploadResult : global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/ResumableUploadResult", typeof (ResumableUploadResult));
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

		protected ResumableUploadResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='ResumableUploadResult']/constructor[@name='ResumableUploadResult' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CompleteMultipartUploadResult']]"
		[Register (".ctor", "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;)V", "")]
		public unsafe ResumableUploadResult (global::Com.Alibaba.Sdk.Android.Oss.Model.CompleteMultipartUploadResult completeResult)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/alibaba/sdk/android/oss/model/CompleteMultipartUploadResult;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((completeResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeResult).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
