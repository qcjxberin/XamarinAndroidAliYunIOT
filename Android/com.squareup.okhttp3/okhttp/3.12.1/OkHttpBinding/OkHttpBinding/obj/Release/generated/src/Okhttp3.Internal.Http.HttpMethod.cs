using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpMethod : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HttpMethod", typeof (HttpMethod));
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

		internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='invalidatesCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invalidatesCache", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool InvalidatesCache (string method)
		{
			const string __id = "invalidatesCache.(Ljava/lang/String;)Z";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='permitsRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("permitsRequestBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool PermitsRequestBody (string method)
		{
			const string __id = "permitsRequestBody.(Ljava/lang/String;)Z";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='redirectsToGet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirectsToGet", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RedirectsToGet (string method)
		{
			const string __id = "redirectsToGet.(Ljava/lang/String;)Z";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='redirectsWithBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirectsWithBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RedirectsWithBody (string method)
		{
			const string __id = "redirectsWithBody.(Ljava/lang/String;)Z";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpMethod']/method[@name='requiresRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requiresRequestBody", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool RequiresRequestBody (string method)
		{
			const string __id = "requiresRequestBody.(Ljava/lang/String;)Z";
			IntPtr native_method = JNIEnv.NewString (method);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_method);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_method);
			}
		}

	}
}
