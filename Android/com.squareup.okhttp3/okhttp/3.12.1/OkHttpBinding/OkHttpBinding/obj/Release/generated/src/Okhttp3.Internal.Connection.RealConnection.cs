using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RealConnection", DoNotGenerateAcw=true)]
	public sealed partial class RealConnection : global::Okhttp3.Internal.Http2.Http2Connection.Listener, global::Okhttp3.IConnection {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='allocationLimit']"
		[Register ("allocationLimit")]
		public int AllocationLimit {
			get {
				const string __id = "allocationLimit.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "allocationLimit.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='allocations']"
		[Register ("allocations")]
		public global::System.Collections.IList Allocations {
			get {
				const string __id = "allocations.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "allocations.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='idleAtNanos']"
		[Register ("idleAtNanos")]
		public long IdleAtNanos {
			get {
				const string __id = "idleAtNanos.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "idleAtNanos.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='noNewStreams']"
		[Register ("noNewStreams")]
		public bool NoNewStreams {
			get {
				const string __id = "noNewStreams.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "noNewStreams.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='successCount']"
		[Register ("successCount")]
		public int SuccessCount {
			get {
				const string __id = "successCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "successCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/RealConnection", typeof (RealConnection));
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

		internal RealConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/constructor[@name='RealConnection' and count(parameter)=2 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Route']]"
		[Register (".ctor", "(Lokhttp3/ConnectionPool;Lokhttp3/Route;)V", "")]
		public unsafe RealConnection (global::Okhttp3.ConnectionPool connectionPool, global::Okhttp3.Route route)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/ConnectionPool;Lokhttp3/Route;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((connectionPool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionPool).Handle);
				__args [1] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsMultiplexed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='isMultiplexed' and count(parameter)=0]"
			[Register ("isMultiplexed", "()Z", "")]
			get {
				const string __id = "isMultiplexed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='connect' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='okhttp3.Call'] and parameter[7][@type='okhttp3.EventListener']]"
		[Register ("connect", "(IIIIZLokhttp3/Call;Lokhttp3/EventListener;)V", "")]
		public unsafe void Connect (int connectTimeout, int readTimeout, int writeTimeout, int pingIntervalMillis, bool connectionRetryEnabled, global::Okhttp3.ICall call, global::Okhttp3.EventListener eventListener)
		{
			const string __id = "connect.(IIIIZLokhttp3/Call;Lokhttp3/EventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (connectTimeout);
				__args [1] = new JniArgumentValue (readTimeout);
				__args [2] = new JniArgumentValue (writeTimeout);
				__args [3] = new JniArgumentValue (pingIntervalMillis);
				__args [4] = new JniArgumentValue (connectionRetryEnabled);
				__args [5] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [6] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "")]
		public unsafe global::Okhttp3.Handshake Handshake ()
		{
			const string __id = "handshake.()Lokhttp3/Handshake;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='isEligible' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.Route']]"
		[Register ("isEligible", "(Lokhttp3/Address;Lokhttp3/Route;)Z", "")]
		public unsafe bool IsEligible (global::Okhttp3.Address address, global::Okhttp3.Route route)
		{
			const string __id = "isEligible.(Lokhttp3/Address;Lokhttp3/Route;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='isHealthy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isHealthy", "(Z)Z", "")]
		public unsafe bool IsHealthy (bool doExtensiveChecks)
		{
			const string __id = "isHealthy.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (doExtensiveChecks);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='newCodec' and count(parameter)=3 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Interceptor.Chain'] and parameter[3][@type='okhttp3.internal.connection.StreamAllocation']]"
		[Register ("newCodec", "(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/connection/StreamAllocation;)Lokhttp3/internal/http/HttpCodec;", "")]
		public unsafe global::Okhttp3.Internal.Http.IHttpCodec NewCodec (global::Okhttp3.OkHttpClient client, global::Okhttp3.IInterceptorChain chain, global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation)
		{
			const string __id = "newCodec.(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Lokhttp3/internal/connection/StreamAllocation;)Lokhttp3/internal/http/HttpCodec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((chain == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chain).Handle);
				__args [2] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='newWebSocketStreams' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.connection.StreamAllocation']]"
		[Register ("newWebSocketStreams", "(Lokhttp3/internal/connection/StreamAllocation;)Lokhttp3/internal/ws/RealWebSocket$Streams;", "")]
		public unsafe global::Okhttp3.Internal.WS.RealWebSocket.Streams NewWebSocketStreams (global::Okhttp3.Internal.Connection.StreamAllocation streamAllocation)
		{
			const string __id = "newWebSocketStreams.(Lokhttp3/internal/connection/StreamAllocation;)Lokhttp3/internal/ws/RealWebSocket$Streams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((streamAllocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streamAllocation).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.RealWebSocket.Streams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
		[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "")]
		public override unsafe void OnStream (global::Okhttp3.Internal.Http2.Http2Stream stream)
		{
			const string __id = "onStream.(Lokhttp3/internal/http2/Http2Stream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Lokhttp3/Protocol;", "")]
		public unsafe global::Okhttp3.Protocol Protocol ()
		{
			const string __id = "protocol.()Lokhttp3/Protocol;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='route' and count(parameter)=0]"
		[Register ("route", "()Lokhttp3/Route;", "")]
		public unsafe global::Okhttp3.Route Route ()
		{
			const string __id = "route.()Lokhttp3/Route;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Route> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='socket' and count(parameter)=0]"
		[Register ("socket", "()Ljava/net/Socket;", "")]
		public unsafe global::Java.Net.Socket Socket ()
		{
			const string __id = "socket.()Ljava/net/Socket;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='supportsUrl' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("supportsUrl", "(Lokhttp3/HttpUrl;)Z", "")]
		public unsafe bool SupportsUrl (global::Okhttp3.HttpUrl url)
		{
			const string __id = "supportsUrl.(Lokhttp3/HttpUrl;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='testConnection' and count(parameter)=4 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Route'] and parameter[3][@type='java.net.Socket'] and parameter[4][@type='long']]"
		[Register ("testConnection", "(Lokhttp3/ConnectionPool;Lokhttp3/Route;Ljava/net/Socket;J)Lokhttp3/internal/connection/RealConnection;", "")]
		public static unsafe global::Okhttp3.Internal.Connection.RealConnection TestConnection (global::Okhttp3.ConnectionPool connectionPool, global::Okhttp3.Route route, global::Java.Net.Socket socket, long idleAtNanos)
		{
			const string __id = "testConnection.(Lokhttp3/ConnectionPool;Lokhttp3/Route;Ljava/net/Socket;J)Lokhttp3/internal/connection/RealConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((connectionPool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionPool).Handle);
				__args [1] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
				__args [2] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
				__args [3] = new JniArgumentValue (idleAtNanos);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
