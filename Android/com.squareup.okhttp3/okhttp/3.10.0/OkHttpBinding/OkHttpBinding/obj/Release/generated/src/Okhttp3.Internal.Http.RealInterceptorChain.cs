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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/constructor[@name='RealInterceptorChain' and count(parameter)=11 and parameter[1][@type='java.util.List&lt;okhttp3.Interceptor&gt;'] and parameter[2][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[3][@type='okhttp3.internal.http.HttpCodec'] and parameter[4][@type='okhttp3.internal.connection.RealConnection'] and parameter[5][@type='int'] and parameter[6][@type='okhttp3.Request'] and parameter[7][@type='okhttp3.Call'] and parameter[8][@type='okhttp3.EventListener'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpCodec;Lokhttp3/internal/connection/RealConnection;ILokhttp3/Request;Lokhttp3/Call;Lokhttp3/EventListener;III)V", "")]
		public unsafe RealInterceptorChain (global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> interceptors, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Http.IHttpCodec httpCodec, global::Okhttp3.Internal.Connection.RealConnection connection, int index, global::Okhttp3.Request request, global::Okhttp3.ICall call, global::Okhttp3.EventListener eventListener, int connectTimeout, int readTimeout, int writeTimeout)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpCodec;Lokhttp3/internal/connection/RealConnection;ILokhttp3/Request;Lokhttp3/Call;Lokhttp3/EventListener;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_interceptors = global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.ToLocalJniHandle (interceptors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (native_interceptors);
				__args [1] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [2] = new JniArgumentValue ((httpCodec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) httpCodec).Handle);
				__args [3] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				__args [4] = new JniArgumentValue (index);
				__args [5] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [6] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [7] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [8] = new JniArgumentValue (connectTimeout);
				__args [9] = new JniArgumentValue (readTimeout);
				__args [10] = new JniArgumentValue (writeTimeout);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_interceptors);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Lokhttp3/Call;", "")]
		public unsafe global::Okhttp3.ICall Call ()
		{
			const string __id = "call.()Lokhttp3/Call;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='connectTimeoutMillis' and count(parameter)=0]"
		[Register ("connectTimeoutMillis", "()I", "")]
		public unsafe int ConnectTimeoutMillis ()
		{
			const string __id = "connectTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='eventListener' and count(parameter)=0]"
		[Register ("eventListener", "()Lokhttp3/EventListener;", "")]
		public unsafe global::Okhttp3.EventListener EventListener ()
		{
			const string __id = "eventListener.()Lokhttp3/EventListener;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='httpStream' and count(parameter)=0]"
		[Register ("httpStream", "()Lokhttp3/internal/http/HttpCodec;", "")]
		public unsafe global::Okhttp3.Internal.Http.IHttpCodec HttpStream ()
		{
			const string __id = "httpStream.()Lokhttp3/internal/http/HttpCodec;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='proceed' and count(parameter)=4 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.internal.connection.StreamAllocation'] and parameter[3][@type='okhttp3.internal.http.HttpCodec'] and parameter[4][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("proceed", "(Lokhttp3/Request;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpCodec;Lokhttp3/internal/connection/RealConnection;)Lokhttp3/Response;", "")]
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation, global::Okhttp3.Internal.Http.IHttpCodec httpCodec, global::Okhttp3.Internal.Connection.RealConnection connection)
		{
			const string __id = "proceed.(Lokhttp3/Request;Lokhttp3/internal/connection/StreamAllocation;Lokhttp3/internal/http/HttpCodec;Lokhttp3/internal/connection/RealConnection;)Lokhttp3/Response;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				__args [2] = new JniArgumentValue ((httpCodec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) httpCodec).Handle);
				__args [3] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='readTimeoutMillis' and count(parameter)=0]"
		[Register ("readTimeoutMillis", "()I", "")]
		public unsafe int ReadTimeoutMillis ()
		{
			const string __id = "readTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withConnectTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withConnectTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithConnectTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "withConnectTimeout.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withReadTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withReadTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithReadTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "withReadTimeout.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='withWriteTimeout' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("withWriteTimeout", "(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;", "")]
		public unsafe global::Okhttp3.IInterceptorChain WithWriteTimeout (int timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			const string __id = "withWriteTimeout.(ILjava/util/concurrent/TimeUnit;)Lokhttp3/Interceptor$Chain;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unit).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='RealInterceptorChain']/method[@name='writeTimeoutMillis' and count(parameter)=0]"
		[Register ("writeTimeoutMillis", "()I", "")]
		public unsafe int WriteTimeoutMillis ()
		{
			const string __id = "writeTimeoutMillis.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
