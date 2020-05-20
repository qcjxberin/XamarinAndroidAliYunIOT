using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Version']"
	[global::Android.Runtime.Register ("okhttp3/internal/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/Version", typeof (Version));
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

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Version']/method[@name='userAgent' and count(parameter)=0]"
		[Register ("userAgent", "()Ljava/lang/String;", "")]
		public static unsafe string UserAgent ()
		{
			const string __id = "userAgent.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
