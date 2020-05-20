using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HeaderParser']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HeaderParser", DoNotGenerateAcw=true)]
	public sealed partial class HeaderParser : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HeaderParser", typeof (HeaderParser));
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

		internal HeaderParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HeaderParser']/method[@name='parseSeconds' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parseSeconds", "(Ljava/lang/String;I)I", "")]
		public static unsafe int ParseSeconds (string value, int defaultValue)
		{
			const string __id = "parseSeconds.(Ljava/lang/String;I)I";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (defaultValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HeaderParser']/method[@name='skipUntil' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("skipUntil", "(Ljava/lang/String;ILjava/lang/String;)I", "")]
		public static unsafe int SkipUntil (string input, int pos, string characters)
		{
			const string __id = "skipUntil.(Ljava/lang/String;ILjava/lang/String;)I";
			IntPtr native_input = JNIEnv.NewString (input);
			IntPtr native_characters = JNIEnv.NewString (characters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue (native_characters);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
				JNIEnv.DeleteLocalRef (native_characters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HeaderParser']/method[@name='skipWhitespace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("skipWhitespace", "(Ljava/lang/String;I)I", "")]
		public static unsafe int SkipWhitespace (string input, int pos)
		{
			const string __id = "skipWhitespace.(Ljava/lang/String;I)I";
			IntPtr native_input = JNIEnv.NewString (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue (pos);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}
}
