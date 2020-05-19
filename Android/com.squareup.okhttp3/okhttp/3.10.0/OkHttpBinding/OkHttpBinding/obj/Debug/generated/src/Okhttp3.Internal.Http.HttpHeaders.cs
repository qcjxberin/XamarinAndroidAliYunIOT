using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpHeaders", DoNotGenerateAcw=true)]
	public sealed partial class HttpHeaders : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HttpHeaders", typeof (HttpHeaders));
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

		internal HttpHeaders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='contentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("contentLength", "(Lokhttp3/Headers;)J", "")]
		public static unsafe long ContentLength (global::Okhttp3.Headers headers)
		{
			const string __id = "contentLength.(Lokhttp3/Headers;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='contentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("contentLength", "(Lokhttp3/Response;)J", "")]
		public static unsafe long ContentLength (global::Okhttp3.Response response)
		{
			const string __id = "contentLength.(Lokhttp3/Response;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("hasBody", "(Lokhttp3/Response;)Z", "")]
		public static unsafe bool HasBody (global::Okhttp3.Response response)
		{
			const string __id = "hasBody.(Lokhttp3/Response;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasVaryAll' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("hasVaryAll", "(Lokhttp3/Headers;)Z", "")]
		public static unsafe bool HasVaryAll (global::Okhttp3.Headers responseHeaders)
		{
			const string __id = "hasVaryAll.(Lokhttp3/Headers;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseHeaders == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHeaders).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='hasVaryAll' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("hasVaryAll", "(Lokhttp3/Response;)Z", "")]
		public static unsafe bool HasVaryAll (global::Okhttp3.Response response)
		{
			const string __id = "hasVaryAll.(Lokhttp3/Response;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='parseChallenges' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='java.lang.String']]"
		[Register ("parseChallenges", "(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Challenge> ParseChallenges (global::Okhttp3.Headers responseHeaders, string challengeHeader)
		{
			const string __id = "parseChallenges.(Lokhttp3/Headers;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_challengeHeader = JNIEnv.NewString (challengeHeader);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((responseHeaders == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHeaders).Handle);
				__args [1] = new JniArgumentValue (native_challengeHeader);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Challenge>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_challengeHeader);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='parseSeconds' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='receiveHeaders' and count(parameter)=3 and parameter[1][@type='okhttp3.CookieJar'] and parameter[2][@type='okhttp3.HttpUrl'] and parameter[3][@type='okhttp3.Headers']]"
		[Register ("receiveHeaders", "(Lokhttp3/CookieJar;Lokhttp3/HttpUrl;Lokhttp3/Headers;)V", "")]
		public static unsafe void ReceiveHeaders (global::Okhttp3.ICookieJar cookieJar, global::Okhttp3.HttpUrl url, global::Okhttp3.Headers headers)
		{
			const string __id = "receiveHeaders.(Lokhttp3/CookieJar;Lokhttp3/HttpUrl;Lokhttp3/Headers;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cookieJar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cookieJar).Handle);
				__args [1] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [2] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='skipUntil' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='skipWhitespace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyFields' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("varyFields", "(Lokhttp3/Headers;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> VaryFields (global::Okhttp3.Headers responseHeaders)
		{
			const string __id = "varyFields.(Lokhttp3/Headers;)Ljava/util/Set;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseHeaders == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHeaders).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyHeaders' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.Headers']]"
		[Register ("varyHeaders", "(Lokhttp3/Headers;Lokhttp3/Headers;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers VaryHeaders (global::Okhttp3.Headers requestHeaders, global::Okhttp3.Headers responseHeaders)
		{
			const string __id = "varyHeaders.(Lokhttp3/Headers;Lokhttp3/Headers;)Lokhttp3/Headers;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((requestHeaders == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestHeaders).Handle);
				__args [1] = new JniArgumentValue ((responseHeaders == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHeaders).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("varyHeaders", "(Lokhttp3/Response;)Lokhttp3/Headers;", "")]
		public static unsafe global::Okhttp3.Headers VaryHeaders (global::Okhttp3.Response response)
		{
			const string __id = "varyHeaders.(Lokhttp3/Response;)Lokhttp3/Headers;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpHeaders']/method[@name='varyMatches' and count(parameter)=3 and parameter[1][@type='okhttp3.Response'] and parameter[2][@type='okhttp3.Headers'] and parameter[3][@type='okhttp3.Request']]"
		[Register ("varyMatches", "(Lokhttp3/Response;Lokhttp3/Headers;Lokhttp3/Request;)Z", "")]
		public static unsafe bool VaryMatches (global::Okhttp3.Response cachedResponse, global::Okhttp3.Headers cachedRequest, global::Okhttp3.Request newRequest)
		{
			const string __id = "varyMatches.(Lokhttp3/Response;Lokhttp3/Headers;Lokhttp3/Request;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cachedResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cachedResponse).Handle);
				__args [1] = new JniArgumentValue ((cachedRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cachedRequest).Handle);
				__args [2] = new JniArgumentValue ((newRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newRequest).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
