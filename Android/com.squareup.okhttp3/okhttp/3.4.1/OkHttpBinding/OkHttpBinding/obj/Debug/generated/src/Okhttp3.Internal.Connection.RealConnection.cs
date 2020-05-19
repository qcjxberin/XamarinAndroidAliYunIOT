using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/connection/RealConnection", DoNotGenerateAcw=true)]
	public sealed partial class RealConnection : global::Okhttp3.Internal.Framed.FramedConnection.Listener, global::Okhttp3.IConnection {



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


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/field[@name='framedConnection']"
		[Register ("framedConnection")]
		public global::Okhttp3.Internal.Framed.FramedConnection FramedConnection {
			get {
				const string __id = "framedConnection.Lokhttp3/internal/framed/FramedConnection;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "framedConnection.Lokhttp3/internal/framed/FramedConnection;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/constructor[@name='RealConnection' and count(parameter)=1 and parameter[1][@type='okhttp3.Route']]"
		[Register (".ctor", "(Lokhttp3/Route;)V", "")]
		public unsafe RealConnection (global::Okhttp3.Route route)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Route;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((route == null) ? IntPtr.Zero : ((global::Java.Lang.Object) route).Handle);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='connect' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;'] and parameter[5][@type='boolean']]"
		[Register ("connect", "(IIILjava/util/List;Z)V", "")]
		public unsafe void Connect (int connectTimeout, int readTimeout, int writeTimeout, global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs, bool connectionRetryEnabled)
		{
			const string __id = "connect.(IIILjava/util/List;Z)V";
			IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (connectTimeout);
				__args [1] = new JniArgumentValue (readTimeout);
				__args [2] = new JniArgumentValue (writeTimeout);
				__args [3] = new JniArgumentValue (native_connectionSpecs);
				__args [4] = new JniArgumentValue (connectionRetryEnabled);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_connectionSpecs);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.connection']/class[@name='RealConnection']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FramedStream']]"
		[Register ("onStream", "(Lokhttp3/internal/framed/FramedStream;)V", "")]
		public override unsafe void OnStream (global::Okhttp3.Internal.Framed.FramedStream stream)
		{
			const string __id = "onStream.(Lokhttp3/internal/framed/FramedStream;)V";
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

	}
}
