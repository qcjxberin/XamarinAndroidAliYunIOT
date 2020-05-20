using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='StreamResetException']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/StreamResetException", DoNotGenerateAcw=true)]
	public sealed partial class StreamResetException : global::Java.IO.IOException {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='StreamResetException']/field[@name='errorCode']"
		[Register ("errorCode")]
		public global::Okhttp3.Internal.Framed.ErrorCode ErrorCode {
			get {
				const string __id = "errorCode.Lokhttp3/internal/framed/ErrorCode;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.ErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "errorCode.Lokhttp3/internal/framed/ErrorCode;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/StreamResetException", typeof (StreamResetException));
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

		internal StreamResetException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='StreamResetException']/constructor[@name='StreamResetException' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register (".ctor", "(Lokhttp3/internal/framed/ErrorCode;)V", "")]
		public unsafe StreamResetException (global::Okhttp3.Internal.Framed.ErrorCode errorCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/internal/framed/ErrorCode;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
