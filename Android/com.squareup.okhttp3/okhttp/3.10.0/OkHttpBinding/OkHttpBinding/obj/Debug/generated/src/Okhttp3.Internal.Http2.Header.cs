using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Header", DoNotGenerateAcw=true)]
	public sealed partial class Header : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Header", typeof (Header));
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

		internal Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/constructor[@name='Header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Header (string name, string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
