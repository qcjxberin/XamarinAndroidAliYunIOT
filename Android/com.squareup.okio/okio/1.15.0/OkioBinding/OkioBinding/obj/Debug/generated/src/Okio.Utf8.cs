using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Utf8']"
	[global::Android.Runtime.Register ("okio/Utf8", DoNotGenerateAcw=true)]
	public sealed partial class Utf8 : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Utf8", typeof (Utf8));
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

		internal Utf8 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Utf8']/method[@name='size' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("size", "(Ljava/lang/String;)J", "")]
		public static unsafe long Size (string @string)
		{
			const string __id = "size.(Ljava/lang/String;)J";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Utf8']/method[@name='size' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("size", "(Ljava/lang/String;II)J", "")]
		public static unsafe long Size (string @string, int beginIndex, int endIndex)
		{
			const string __id = "size.(Ljava/lang/String;II)J";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (beginIndex);
				__args [2] = new JniArgumentValue (endIndex);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

	}
}
