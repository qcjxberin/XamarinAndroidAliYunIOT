using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/Http2xStream", DoNotGenerateAcw=true)]
	public sealed partial class Http2xStream : global::Java.Lang.Object, global::Okhttp3.Internal.Http.IHttpStream {


		public static class InterfaceConsts {

			// The following are fields from: okhttp3.internal.http.HttpStream

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='HttpStream']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
			[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
			public const int DiscardStreamTimeoutMillis = (int) 100;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/Http2xStream", typeof (Http2xStream));
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

		internal Http2xStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/constructor[@name='Http2xStream' and count(parameter)=3 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[3][@type='okhttp3.internal.framed.FramedConnection']]"
		[Register (".ctor", "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/framed/FramedConnection;)V", "")]
		public unsafe Http2xStream (global::Okhttp3.OkHttpClient client, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Framed.FramedConnection framedConnection)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/OkHttpClient;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/framed/FramedConnection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [2] = new JniArgumentValue ((framedConnection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framedConnection).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "")]
		public unsafe void FinishRequest ()
		{
			const string __id = "finishRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='http2HeadersList' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("http2HeadersList", "(Lokhttp3/Request;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> Http2HeadersList (global::Okhttp3.Request request)
		{
			const string __id = "http2HeadersList.(Lokhttp3/Request;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='openResponseBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='readHttp2HeadersList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("readHttp2HeadersList", "(Ljava/util/List;)Lokhttp3/Response$Builder;", "")]
		public static unsafe global::Okhttp3.Response.Builder ReadHttp2HeadersList (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock)
		{
			const string __id = "readHttp2HeadersList.(Ljava/util/List;)Lokhttp3/Response$Builder;";
			IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerBlock);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerBlock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='readResponseHeaders' and count(parameter)=0]"
		[Register ("readResponseHeaders", "()Lokhttp3/Response$Builder;", "")]
		public unsafe global::Okhttp3.Response.Builder ReadResponseHeaders ()
		{
			const string __id = "readResponseHeaders.()Lokhttp3/Response$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='readSpdy3HeadersList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("readSpdy3HeadersList", "(Ljava/util/List;)Lokhttp3/Response$Builder;", "")]
		public static unsafe global::Okhttp3.Response.Builder ReadSpdy3HeadersList (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock)
		{
			const string __id = "readSpdy3HeadersList.(Ljava/util/List;)Lokhttp3/Response$Builder;";
			IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_headerBlock);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_headerBlock);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='spdy3HeadersList' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("spdy3HeadersList", "(Lokhttp3/Request;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> Spdy3HeadersList (global::Okhttp3.Request request)
		{
			const string __id = "spdy3HeadersList.(Lokhttp3/Request;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='Http2xStream']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
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
