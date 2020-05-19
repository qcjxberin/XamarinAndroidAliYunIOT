using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Codec", DoNotGenerateAcw=true)]
	public sealed partial class Http2Codec : global::Java.Lang.Object, global::Okhttp3.Internal.Http.IHttpCodec {


		public static class InterfaceConsts {

			// The following are fields from: okhttp3.internal.http.HttpCodec

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
			[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
			public const int DiscardStreamTimeoutMillis = (int) 100;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Codec", typeof (Http2Codec));
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

		internal Http2Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/constructor[@name='Http2Codec' and count(parameter)=4 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Interceptor.Chain'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[4][@type='okhttp3.internal.http2.Http2Connection']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http2/Http2Connection;)V", "")]
		public unsafe Http2Codec (global::Okhttp3.OkHttpClient client, global::Okhttp3.IInterceptorChain chain, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Http2.Http2Connection connection)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http2/Http2Connection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((chain == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chain).Handle);
				__args [2] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [3] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "")]
		public unsafe void FinishRequest ()
		{
			const string __id = "finishRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='flushRequest' and count(parameter)=0]"
		[Register ("flushRequest", "()V", "")]
		public unsafe void FlushRequest ()
		{
			const string __id = "flushRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='http2HeadersList' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("http2HeadersList", "(Lokhttp3/Request;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> Http2HeadersList (global::Okhttp3.Request request)
		{
			const string __id = "http2HeadersList.(Lokhttp3/Request;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='openResponseBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='readHttp2HeadersList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
		[Register ("readHttp2HeadersList", "(Ljava/util/List;)Lokhttp3/Response$Builder;", "")]
		public static unsafe global::Okhttp3.Response.Builder ReadHttp2HeadersList (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> headerBlock)
		{
			const string __id = "readHttp2HeadersList.(Ljava/util/List;)Lokhttp3/Response$Builder;";
			IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (headerBlock);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerBlock);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerBlock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Codec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
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
