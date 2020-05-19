using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']"
	[global::Android.Runtime.Register ("okhttp3/Credentials", DoNotGenerateAcw=true)]
	public sealed partial class Credentials : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Credentials", typeof (Credentials));
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

		internal Credentials (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']/method[@name='basic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("basic", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Basic (string username, string password)
		{
			const string __id = "basic.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_username);
				__args [1] = new JniArgumentValue (native_password);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Credentials']/method[@name='basic' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register ("basic", "(Ljava/lang/String;Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static unsafe string Basic (string username, string password, global::Java.Nio.Charset.Charset charset)
		{
			const string __id = "basic.(Ljava/lang/String;Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;";
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_username);
				__args [1] = new JniArgumentValue (native_password);
				__args [2] = new JniArgumentValue ((charset == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charset).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

	}
}
