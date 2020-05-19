using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/StreamAllocation", DoNotGenerateAcw=true)]
	public sealed partial class StreamAllocation : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/field[@name='address']"
		[Register ("address")]
		public global::Okhttp3.Address Address {
			get {
				const string __id = "address.Lokhttp3/Address;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "address.Lokhttp3/Address;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/field[@name='call']"
		[Register ("call")]
		public global::Okhttp3.ICall Call {
			get {
				const string __id = "call.Lokhttp3/Call;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "call.Lokhttp3/Call;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/field[@name='eventListener']"
		[Register ("eventListener")]
		public global::Okhttp3.EventListener EventListener {
			get {
				const string __id = "eventListener.Lokhttp3/EventListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "eventListener.Lokhttp3/EventListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation.StreamAllocationReference']"
		[global::Android.Runtime.Register ("okhttp3/internal/connection/StreamAllocation$StreamAllocationReference", DoNotGenerateAcw=true)]
		public sealed partial class StreamAllocationReference : global::Java.Lang.Ref.WeakReference {



			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation.StreamAllocationReference']/field[@name='callStackTrace']"
			[Register ("callStackTrace")]
			public global::Java.Lang.Object CallStackTrace {
				get {
					const string __id = "callStackTrace.Ljava/lang/Object;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "callStackTrace.Ljava/lang/Object;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/StreamAllocation$StreamAllocationReference", typeof (StreamAllocationReference));
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

			internal StreamAllocationReference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/connection/StreamAllocation", typeof (StreamAllocation));
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

		internal StreamAllocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/constructor[@name='StreamAllocation' and count(parameter)=5 and parameter[1][@type='okhttp3.ConnectionPool'] and parameter[2][@type='okhttp3.Address'] and parameter[3][@type='okhttp3.Call'] and parameter[4][@type='okhttp3.EventListener'] and parameter[5][@type='java.lang.Object']]"
		[Register (".ctor", "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/Call;Lokhttp3/EventListener;Ljava/lang/Object;)V", "")]
		public unsafe StreamAllocation (global::Okhttp3.ConnectionPool connectionPool, global::Okhttp3.Address address, global::Okhttp3.ICall call, global::Okhttp3.EventListener eventListener, global::Java.Lang.Object callStackTrace)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/ConnectionPool;Lokhttp3/Address;Lokhttp3/Call;Lokhttp3/EventListener;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((connectionPool == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionPool).Handle);
				__args [1] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [2] = new JniArgumentValue ((call == null) ? IntPtr.Zero : ((global::Java.Lang.Object) call).Handle);
				__args [3] = new JniArgumentValue ((eventListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventListener).Handle);
				__args [4] = new JniArgumentValue ((callStackTrace == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callStackTrace).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool HasMoreRoutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='hasMoreRoutes' and count(parameter)=0]"
			[Register ("hasMoreRoutes", "()Z", "")]
			get {
				const string __id = "hasMoreRoutes.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='acquire' and count(parameter)=2 and parameter[1][@type='okhttp3.internal.connection.RealConnection'] and parameter[2][@type='boolean']]"
		[Register ("acquire", "(Lokhttp3/internal/connection/RealConnection;Z)V", "")]
		public unsafe void Acquire (global::Okhttp3.Internal.Connection.RealConnection connection, bool reportedAcquired)
		{
			const string __id = "acquire.(Lokhttp3/internal/connection/RealConnection;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
				__args [1] = new JniArgumentValue (reportedAcquired);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='codec' and count(parameter)=0]"
		[Register ("codec", "()Lokhttp3/internal/http/HttpCodec;", "")]
		public unsafe global::Okhttp3.Internal.Http.IHttpCodec Codec ()
		{
			const string __id = "codec.()Lokhttp3/internal/http/HttpCodec;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/internal/connection/RealConnection;", "")]
		public unsafe global::Okhttp3.Internal.Connection.RealConnection Connection ()
		{
			const string __id = "connection.()Lokhttp3/internal/connection/RealConnection;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='newStream' and count(parameter)=3 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Interceptor.Chain'] and parameter[3][@type='boolean']]"
		[Register ("newStream", "(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Z)Lokhttp3/internal/http/HttpCodec;", "")]
		public unsafe global::Okhttp3.Internal.Http.IHttpCodec NewStream (global::Okhttp3.OkHttpClient client, global::Okhttp3.IInterceptorChain chain, bool doExtensiveHealthChecks)
		{
			const string __id = "newStream.(Lokhttp3/OkHttpClient;Lokhttp3/Interceptor$Chain;Z)Lokhttp3/internal/http/HttpCodec;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((chain == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chain).Handle);
				__args [2] = new JniArgumentValue (doExtensiveHealthChecks);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IHttpCodec> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='noNewStreams' and count(parameter)=0]"
		[Register ("noNewStreams", "()V", "")]
		public unsafe void NoNewStreams ()
		{
			const string __id = "noNewStreams.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='releaseAndAcquire' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.connection.RealConnection']]"
		[Register ("releaseAndAcquire", "(Lokhttp3/internal/connection/RealConnection;)Ljava/net/Socket;", "")]
		public unsafe global::Java.Net.Socket ReleaseAndAcquire (global::Okhttp3.Internal.Connection.RealConnection newConnection)
		{
			const string __id = "releaseAndAcquire.(Lokhttp3/internal/connection/RealConnection;)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newConnection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newConnection).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='route' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='streamFailed' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("streamFailed", "(Ljava/io/IOException;)V", "")]
		public unsafe void StreamFailed (global::Java.IO.IOException e)
		{
			const string __id = "streamFailed.(Ljava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='StreamAllocation']/method[@name='streamFinished' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='okhttp3.internal.http.HttpCodec'] and parameter[3][@type='long'] and parameter[4][@type='java.io.IOException']]"
		[Register ("streamFinished", "(ZLokhttp3/internal/http/HttpCodec;JLjava/io/IOException;)V", "")]
		public unsafe void StreamFinished (bool noNewStreams, global::Okhttp3.Internal.Http.IHttpCodec codec, long bytesRead, global::Java.IO.IOException e)
		{
			const string __id = "streamFinished.(ZLokhttp3/internal/http/HttpCodec;JLjava/io/IOException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (noNewStreams);
				__args [1] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				__args [2] = new JniArgumentValue (bytesRead);
				__args [3] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
