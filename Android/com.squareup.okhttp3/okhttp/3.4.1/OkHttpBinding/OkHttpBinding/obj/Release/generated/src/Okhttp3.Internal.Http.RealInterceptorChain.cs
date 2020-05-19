using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/RealInterceptorChain", DoNotGenerateAcw=true)]
	public sealed partial class RealInterceptorChain : global::Java.Lang.Object, global::Okhttp3.IInterceptorChain {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/RealInterceptorChain", typeof (RealInterceptorChain));
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

		internal RealInterceptorChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/constructor[@name='RealInterceptorChain' and count(parameter)=6 and parameter[1][@type='java.util.List&lt;okhttp3.Interceptor&gt;'] and parameter[2][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[3][@type='okhttp3.internal.http.HttpStream'] and parameter[4][@type='okhttp3.Connection'] and parameter[5][@type='int'] and parameter[6][@type='okhttp3.Request']]"
		[Register (".ctor", "(Ljava/util/List;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpStream;Lokhttp3/Connection;ILokhttp3/Request;)V", "")]
		public unsafe RealInterceptorChain (global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> interceptors, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Http.IHttpStream httpStream, global::Okhttp3.IConnection connection, int index, global::Okhttp3.Request request)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpStream;Lokhttp3/Connection;ILokhttp3/Request;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_interceptors = global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.ToLocalJniHandle (interceptors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_interceptors);
				__args [1] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [2] = new JniArgumentValue ((httpStream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) httpStream).Handle);
				__args [3] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				__args [4] = new JniArgumentValue (index);
				__args [5] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_interceptors);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/Connection;", "")]
		public unsafe global::Okhttp3.IConnection Connection ()
		{
			const string __id = "connection.()Lokhttp3/Connection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='httpStream' and count(parameter)=0]"
		[Register ("httpStream", "()Lokhttp3/internal/http/HttpStream;", "")]
		public unsafe global::Okhttp3.Internal.Http.IHttpStream HttpStream ()
		{
			const string __id = "httpStream.()Lokhttp3/internal/http/HttpStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("proceed", "(Lokhttp3/Request;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request)
		{
			const string __id = "proceed.(Lokhttp3/Request;)Lokhttp3/Response;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='proceed' and count(parameter)=4 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[3][@type='okhttp3.internal.http.HttpStream'] and parameter[4][@type='okhttp3.Connection']]"
		[Register ("proceed", "(Lokhttp3/Request;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpStream;Lokhttp3/Connection;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Http.IHttpStream httpStream, global::Okhttp3.IConnection connection)
		{
			const string __id = "proceed.(Lokhttp3/Request;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpStream;Lokhttp3/Connection;)Lokhttp3/Response;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [2] = new JniArgumentValue ((httpStream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) httpStream).Handle);
				__args [3] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request Request ()
		{
			const string __id = "request.()Lokhttp3/Request;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='streamAllocation' and count(parameter)=0]"
		[Register ("streamAllocation", "()Lokhttp3/internal/connection/StreamAllocation;", "")]
		public unsafe global::Okhttp3.Internal.Connection.StreamAllocation StreamAllocation ()
		{
			const string __id = "streamAllocation.()Lokhttp3/internal/connection/StreamAllocation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.StreamAllocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
