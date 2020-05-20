using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']"
	[global::Android.Runtime.Register ("okhttp3/internal/http1/Http1Codec", DoNotGenerateAcw=true)]
	public sealed partial class Http1Codec : global::Java.Lang.Object, global::Okhttp3.Internal.Http.IHttpCodec {


		public static class InterfaceConsts {

			// The following are fields from: okhttp3.internal.http.HttpCodec

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
			[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
			public const int DiscardStreamTimeoutMillis = (int) 100;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http1/Http1Codec", typeof (Http1Codec));
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

		internal Http1Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "")]
		public unsafe void FinishRequest ()
		{
			const string __id = "finishRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='flushRequest' and count(parameter)=0]"
		[Register ("flushRequest", "()V", "")]
		public unsafe void FlushRequest ()
		{
			const string __id = "flushRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='openResponseBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("openResponseBody", "(Lokhttp3/Response;)Lokhttp3/ResponseBody;", "")]
		public unsafe global::Okhttp3.ResponseBody OpenResponseBody (global::Okhttp3.Response response)
		{
			const string __id = "openResponseBody.(Lokhttp3/Response;)Lokhttp3/ResponseBody;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ResponseBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='readHeaders' and count(parameter)=0]"
		[Register ("readHeaders", "()Lokhttp3/Headers;", "")]
		public unsafe global::Okhttp3.Headers ReadHeaders ()
		{
			const string __id = "readHeaders.()Lokhttp3/Headers;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("readResponseHeaders", "(Z)Lokhttp3/Response$Builder;", "")]
		public unsafe global::Okhttp3.Response.Builder ReadResponseHeaders (bool expectContinue)
		{
			const string __id = "readResponseHeaders.(Z)Lokhttp3/Response$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expectContinue);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='writeRequest' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeRequest", "(Lokhttp3/Headers;Ljava/lang/String;)V", "")]
		public unsafe void WriteRequest (global::Okhttp3.Headers headers, string requestLine)
		{
			const string __id = "writeRequest.(Lokhttp3/Headers;Ljava/lang/String;)V";
			IntPtr native_requestLine = JNIEnv.NewString (requestLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				__args [1] = new JniArgumentValue (native_requestLine);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestLine);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http1']/class[@name='Http1Codec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("writeRequestHeaders", "(Lokhttp3/Request;)V", "")]
		public unsafe void WriteRequestHeaders (global::Okhttp3.Request request)
		{
			const string __id = "writeRequestHeaders.(Lokhttp3/Request;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
