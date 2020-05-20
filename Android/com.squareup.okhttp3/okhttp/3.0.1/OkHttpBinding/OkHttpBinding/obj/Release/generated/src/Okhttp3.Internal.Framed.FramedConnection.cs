using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedConnection", DoNotGenerateAcw=true)]
	public sealed partial class FramedConnection : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']"
		[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedConnection$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedConnection$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/constructor[@name='FramedConnection.Builder' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register (".ctor", "(Z)V", "")]
			public unsafe Builder (bool client)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (client);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/internal/framed/FramedConnection;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Internal.Framed.FramedConnection Build ()
			{
				const string __id = "build.()Lokhttp3/internal/framed/FramedConnection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_listener_Lokhttp3_internal_framed_FramedConnection_Listener_;
#pragma warning disable 0169
			static Delegate GetListener_Lokhttp3_internal_framed_FramedConnection_Listener_Handler ()
			{
				if (cb_listener_Lokhttp3_internal_framed_FramedConnection_Listener_ == null)
					cb_listener_Lokhttp3_internal_framed_FramedConnection_Listener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listener_Lokhttp3_internal_framed_FramedConnection_Listener_);
				return cb_listener_Lokhttp3_internal_framed_FramedConnection_Listener_;
			}

			static IntPtr n_Listener_Lokhttp3_internal_framed_FramedConnection_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.FramedConnection.Listener listener = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Listener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FramedConnection.Listener']]"
			[Register ("listener", "(Lokhttp3/internal/framed/FramedConnection$Listener;)Lokhttp3/internal/framed/FramedConnection$Builder;", "GetListener_Lokhttp3_internal_framed_FramedConnection_Listener_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Framed.FramedConnection.Builder Listener (global::Okhttp3.Internal.Framed.FramedConnection.Listener listener)
			{
				const string __id = "listener.(Lokhttp3/internal/framed/FramedConnection$Listener;)Lokhttp3/internal/framed/FramedConnection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_protocol_Lokhttp3_Protocol_;
#pragma warning disable 0169
			static Delegate GetProtocol_Lokhttp3_Protocol_Handler ()
			{
				if (cb_protocol_Lokhttp3_Protocol_ == null)
					cb_protocol_Lokhttp3_Protocol_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Protocol_Lokhttp3_Protocol_);
				return cb_protocol_Lokhttp3_Protocol_;
			}

			static IntPtr n_Protocol_Lokhttp3_Protocol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_protocol)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Protocol protocol = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (native_protocol, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protocol (protocol));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/method[@name='protocol' and count(parameter)=1 and parameter[1][@type='okhttp3.Protocol']]"
			[Register ("protocol", "(Lokhttp3/Protocol;)Lokhttp3/internal/framed/FramedConnection$Builder;", "GetProtocol_Lokhttp3_Protocol_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Framed.FramedConnection.Builder Protocol (global::Okhttp3.Protocol protocol)
			{
				const string __id = "protocol.(Lokhttp3/Protocol;)Lokhttp3/internal/framed/FramedConnection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((protocol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocol).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_pushObserver_Lokhttp3_internal_framed_PushObserver_;
#pragma warning disable 0169
			static Delegate GetPushObserver_Lokhttp3_internal_framed_PushObserver_Handler ()
			{
				if (cb_pushObserver_Lokhttp3_internal_framed_PushObserver_ == null)
					cb_pushObserver_Lokhttp3_internal_framed_PushObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PushObserver_Lokhttp3_internal_framed_PushObserver_);
				return cb_pushObserver_Lokhttp3_internal_framed_PushObserver_;
			}

			static IntPtr n_PushObserver_Lokhttp3_internal_framed_PushObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pushObserver)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.IPushObserver pushObserver = (global::Okhttp3.Internal.Framed.IPushObserver)global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IPushObserver> (native_pushObserver, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PushObserver (pushObserver));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/method[@name='pushObserver' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.PushObserver']]"
			[Register ("pushObserver", "(Lokhttp3/internal/framed/PushObserver;)Lokhttp3/internal/framed/FramedConnection$Builder;", "GetPushObserver_Lokhttp3_internal_framed_PushObserver_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Framed.FramedConnection.Builder PushObserver (global::Okhttp3.Internal.Framed.IPushObserver pushObserver)
			{
				const string __id = "pushObserver.(Lokhttp3/internal/framed/PushObserver;)Lokhttp3/internal/framed/FramedConnection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((pushObserver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pushObserver).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_socket_Ljava_net_Socket_;
#pragma warning disable 0169
			static Delegate GetSocket_Ljava_net_Socket_Handler ()
			{
				if (cb_socket_Ljava_net_Socket_ == null)
					cb_socket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Socket_Ljava_net_Socket_);
				return cb_socket_Ljava_net_Socket_;
			}

			static IntPtr n_Socket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Socket (socket));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Builder']/method[@name='socket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
			[Register ("socket", "(Ljava/net/Socket;)Lokhttp3/internal/framed/FramedConnection$Builder;", "GetSocket_Ljava_net_Socket_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Framed.FramedConnection.Builder Socket (global::Java.Net.Socket socket)
			{
				const string __id = "socket.(Ljava/net/Socket;)Lokhttp3/internal/framed/FramedConnection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']"
		[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedConnection$Listener", DoNotGenerateAcw=true)]
		public abstract partial class Listener : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']/field[@name='REFUSE_INCOMING_STREAMS']"
			[Register ("REFUSE_INCOMING_STREAMS")]
			public static global::Okhttp3.Internal.Framed.FramedConnection.Listener RefuseIncomingStreams {
				get {
					const string __id = "REFUSE_INCOMING_STREAMS.Lokhttp3/internal/framed/FramedConnection$Listener;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Listener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedConnection$Listener", typeof (Listener));
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

			protected Listener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']/constructor[@name='FramedConnection.Listener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Listener ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onSettings_Lokhttp3_internal_framed_FramedConnection_;
#pragma warning disable 0169
			static Delegate GetOnSettings_Lokhttp3_internal_framed_FramedConnection_Handler ()
			{
				if (cb_onSettings_Lokhttp3_internal_framed_FramedConnection_ == null)
					cb_onSettings_Lokhttp3_internal_framed_FramedConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSettings_Lokhttp3_internal_framed_FramedConnection_);
				return cb_onSettings_Lokhttp3_internal_framed_FramedConnection_;
			}

			static void n_OnSettings_Lokhttp3_internal_framed_FramedConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connection)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Listener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.FramedConnection connection = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection> (native_connection, JniHandleOwnership.DoNotTransfer);
				__this.OnSettings (connection);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']/method[@name='onSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FramedConnection']]"
			[Register ("onSettings", "(Lokhttp3/internal/framed/FramedConnection;)V", "GetOnSettings_Lokhttp3_internal_framed_FramedConnection_Handler")]
			public virtual unsafe void OnSettings (global::Okhttp3.Internal.Framed.FramedConnection connection)
			{
				const string __id = "onSettings.(Lokhttp3/internal/framed/FramedConnection;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStream_Lokhttp3_internal_framed_FramedStream_;
#pragma warning disable 0169
			static Delegate GetOnStream_Lokhttp3_internal_framed_FramedStream_Handler ()
			{
				if (cb_onStream_Lokhttp3_internal_framed_FramedStream_ == null)
					cb_onStream_Lokhttp3_internal_framed_FramedStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStream_Lokhttp3_internal_framed_FramedStream_);
				return cb_onStream_Lokhttp3_internal_framed_FramedStream_;
			}

			static void n_OnStream_Lokhttp3_internal_framed_FramedStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Listener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.FramedStream p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStream (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FramedStream']]"
			[Register ("onStream", "(Lokhttp3/internal/framed/FramedStream;)V", "GetOnStream_Lokhttp3_internal_framed_FramedStream_Handler")]
			public abstract void OnStream (global::Okhttp3.Internal.Framed.FramedStream p0);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedConnection$Listener", DoNotGenerateAcw=true)]
		internal partial class ListenerInvoker : Listener {

			public ListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedConnection$Listener", typeof (ListenerInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FramedStream']]"
			[Register ("onStream", "(Lokhttp3/internal/framed/FramedStream;)V", "GetOnStream_Lokhttp3_internal_framed_FramedStream_Handler")]
			public override unsafe void OnStream (global::Okhttp3.Internal.Framed.FramedStream p0)
			{
				const string __id = "onStream.(Lokhttp3/internal/framed/FramedStream;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']"
		[global::Android.Runtime.Register ("okhttp3/internal/framed/FramedConnection$Reader", DoNotGenerateAcw=true)]
		public partial class Reader : global::Okhttp3.Internal.NamedRunnable, global::Okhttp3.Internal.Framed.IFrameReaderHandler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedConnection$Reader", typeof (Reader));
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

			protected Reader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_ackSettings;
#pragma warning disable 0169
			static Delegate GetAckSettingsHandler ()
			{
				if (cb_ackSettings == null)
					cb_ackSettings = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AckSettings);
				return cb_ackSettings;
			}

			static void n_AckSettings (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AckSettings ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='ackSettings' and count(parameter)=0]"
			[Register ("ackSettings", "()V", "GetAckSettingsHandler")]
			public virtual unsafe void AckSettings ()
			{
				const string __id = "ackSettings.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_execute;
#pragma warning disable 0169
			static Delegate GetExecuteHandler ()
			{
				if (cb_execute == null)
					cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
				return cb_execute;
			}

			static void n_Execute (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Execute ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='execute' and count(parameter)=0]"
			[Register ("execute", "()V", "GetExecuteHandler")]
			protected override unsafe void Execute ()
			{
				const string __id = "execute.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_;
#pragma warning disable 0169
			static Delegate GetHeaders_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_Handler ()
			{
				if (cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ == null)
					cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, int, int, IntPtr, IntPtr>) n_Headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_);
				return cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_;
			}

			static void n_Headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ (IntPtr jnienv, IntPtr native__this, bool outFinished, bool inFinished, int streamId, int associatedStreamId, IntPtr native_headerBlock, IntPtr native_headersMode)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_headerBlock, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.HeadersMode headersMode = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (native_headersMode, JniHandleOwnership.DoNotTransfer);
				__this.Headers (outFinished, inFinished, streamId, associatedStreamId, headerBlock, headersMode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='headers' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;'] and parameter[6][@type='okhttp3.internal.framed.HeadersMode']]"
			[Register ("headers", "(ZZIILjava/util/List;Lokhttp3/internal/framed/HeadersMode;)V", "GetHeaders_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_Handler")]
			public virtual unsafe void Headers (bool outFinished, bool inFinished, int streamId, int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> headerBlock, global::Okhttp3.Internal.Framed.HeadersMode headersMode)
			{
				const string __id = "headers.(ZZIILjava/util/List;Lokhttp3/internal/framed/HeadersMode;)V";
				IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (headerBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (outFinished);
					__args [1] = new JniArgumentValue (inFinished);
					__args [2] = new JniArgumentValue (streamId);
					__args [3] = new JniArgumentValue (associatedStreamId);
					__args [4] = new JniArgumentValue (native_headerBlock);
					__args [5] = new JniArgumentValue ((headersMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headersMode).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_headerBlock);
				}
			}

			static Delegate cb_ping_ZII;
#pragma warning disable 0169
			static Delegate GetPing_ZIIHandler ()
			{
				if (cb_ping_ZII == null)
					cb_ping_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int>) n_Ping_ZII);
				return cb_ping_ZII;
			}

			static void n_Ping_ZII (IntPtr jnienv, IntPtr native__this, bool reply, int payload1, int payload2)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ping (reply, payload1, payload2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("ping", "(ZII)V", "GetPing_ZIIHandler")]
			public virtual unsafe void Ping (bool reply, int payload1, int payload2)
			{
				const string __id = "ping.(ZII)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (reply);
					__args [1] = new JniArgumentValue (payload1);
					__args [2] = new JniArgumentValue (payload2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_priority_IIIZ;
#pragma warning disable 0169
			static Delegate GetPriority_IIIZHandler ()
			{
				if (cb_priority_IIIZ == null)
					cb_priority_IIIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, bool>) n_Priority_IIIZ);
				return cb_priority_IIIZ;
			}

			static void n_Priority_IIIZ (IntPtr jnienv, IntPtr native__this, int streamId, int streamDependency, int weight, bool exclusive)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Priority (streamId, streamDependency, weight, exclusive);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='priority' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("priority", "(IIIZ)V", "GetPriority_IIIZHandler")]
			public virtual unsafe void Priority (int streamId, int streamDependency, int weight, bool exclusive)
			{
				const string __id = "priority.(IIIZ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (streamDependency);
					__args [2] = new JniArgumentValue (weight);
					__args [3] = new JniArgumentValue (exclusive);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_pushPromise_IILjava_util_List_;
#pragma warning disable 0169
			static Delegate GetPushPromise_IILjava_util_List_Handler ()
			{
				if (cb_pushPromise_IILjava_util_List_ == null)
					cb_pushPromise_IILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_PushPromise_IILjava_util_List_);
				return cb_pushPromise_IILjava_util_List_;
			}

			static void n_PushPromise_IILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int streamId, int promisedStreamId, IntPtr native_requestHeaders)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_requestHeaders, JniHandleOwnership.DoNotTransfer);
				__this.PushPromise (streamId, promisedStreamId, requestHeaders);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
			[Register ("pushPromise", "(IILjava/util/List;)V", "GetPushPromise_IILjava_util_List_Handler")]
			public virtual unsafe void PushPromise (int streamId, int promisedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> requestHeaders)
			{
				const string __id = "pushPromise.(IILjava/util/List;)V";
				IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (requestHeaders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (promisedStreamId);
					__args [2] = new JniArgumentValue (native_requestHeaders);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_requestHeaders);
				}
			}

			static Delegate cb_rstStream_ILokhttp3_internal_framed_ErrorCode_;
#pragma warning disable 0169
			static Delegate GetRstStream_ILokhttp3_internal_framed_ErrorCode_Handler ()
			{
				if (cb_rstStream_ILokhttp3_internal_framed_ErrorCode_ == null)
					cb_rstStream_ILokhttp3_internal_framed_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RstStream_ILokhttp3_internal_framed_ErrorCode_);
				return cb_rstStream_ILokhttp3_internal_framed_ErrorCode_;
			}

			static void n_RstStream_ILokhttp3_internal_framed_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int streamId, IntPtr native_errorCode)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.ErrorCode errorCode = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.ErrorCode> (native_errorCode, JniHandleOwnership.DoNotTransfer);
				__this.RstStream (streamId, errorCode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode']]"
			[Register ("rstStream", "(ILokhttp3/internal/framed/ErrorCode;)V", "GetRstStream_ILokhttp3_internal_framed_ErrorCode_Handler")]
			public virtual unsafe void RstStream (int streamId, global::Okhttp3.Internal.Framed.ErrorCode errorCode)
			{
				const string __id = "rstStream.(ILokhttp3/internal/framed/ErrorCode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_settings_ZLokhttp3_internal_framed_Settings_;
#pragma warning disable 0169
			static Delegate GetSettings_ZLokhttp3_internal_framed_Settings_Handler ()
			{
				if (cb_settings_ZLokhttp3_internal_framed_Settings_ == null)
					cb_settings_ZLokhttp3_internal_framed_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_Settings_ZLokhttp3_internal_framed_Settings_);
				return cb_settings_ZLokhttp3_internal_framed_Settings_;
			}

			static void n_Settings_ZLokhttp3_internal_framed_Settings_ (IntPtr jnienv, IntPtr native__this, bool clearPrevious, IntPtr native_newSettings)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Framed.Settings newSettings = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.Settings> (native_newSettings, JniHandleOwnership.DoNotTransfer);
				__this.Settings (clearPrevious, newSettings);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='settings' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='okhttp3.internal.framed.Settings']]"
			[Register ("settings", "(ZLokhttp3/internal/framed/Settings;)V", "GetSettings_ZLokhttp3_internal_framed_Settings_Handler")]
			public virtual unsafe void Settings (bool clearPrevious, global::Okhttp3.Internal.Framed.Settings newSettings)
			{
				const string __id = "settings.(ZLokhttp3/internal/framed/Settings;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (clearPrevious);
					__args [1] = new JniArgumentValue ((newSettings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newSettings).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_windowUpdate_IJ;
#pragma warning disable 0169
			static Delegate GetWindowUpdate_IJHandler ()
			{
				if (cb_windowUpdate_IJ == null)
					cb_windowUpdate_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_WindowUpdate_IJ);
				return cb_windowUpdate_IJ;
			}

			static void n_WindowUpdate_IJ (IntPtr jnienv, IntPtr native__this, int streamId, long windowSizeIncrement)
			{
				global::Okhttp3.Internal.Framed.FramedConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WindowUpdate (streamId, windowSizeIncrement);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection.Reader']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("windowUpdate", "(IJ)V", "GetWindowUpdate_IJHandler")]
			public virtual unsafe void WindowUpdate (int streamId, long windowSizeIncrement)
			{
				const string __id = "windowUpdate.(IJ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue (windowSizeIncrement);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FramedConnection", typeof (FramedConnection));
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

		internal FramedConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe long IdleStartTimeNs {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='getIdleStartTimeNs' and count(parameter)=0]"
			[Register ("getIdleStartTimeNs", "()J", "")]
			get {
				const string __id = "getIdleStartTimeNs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsIdle {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='isIdle' and count(parameter)=0]"
			[Register ("isIdle", "()Z", "")]
			get {
				const string __id = "isIdle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Protocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='getProtocol' and count(parameter)=0]"
			[Register ("getProtocol", "()Lokhttp3/Protocol;", "")]
			get {
				const string __id = "getProtocol.()Lokhttp3/Protocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='maxConcurrentStreams' and count(parameter)=0]"
		[Register ("maxConcurrentStreams", "()I", "")]
		public unsafe int MaxConcurrentStreams ()
		{
			const string __id = "maxConcurrentStreams.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='newStream' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("newStream", "(Ljava/util/List;ZZ)Lokhttp3/internal/framed/FramedStream;", "")]
		public unsafe global::Okhttp3.Internal.Framed.FramedStream NewStream (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> requestHeaders, bool @out, bool @in)
		{
			const string __id = "newStream.(Ljava/util/List;ZZ)Lokhttp3/internal/framed/FramedStream;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_requestHeaders);
				__args [1] = new JniArgumentValue (@out);
				__args [2] = new JniArgumentValue (@in);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='openStreamCount' and count(parameter)=0]"
		[Register ("openStreamCount", "()I", "")]
		public unsafe int OpenStreamCount ()
		{
			const string __id = "openStreamCount.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()Lokhttp3/internal/framed/Ping;", "")]
		public unsafe global::Okhttp3.Internal.Framed.Ping Ping ()
		{
			const string __id = "ping.()Lokhttp3/internal/framed/Ping;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.Ping> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='pushStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;'] and parameter[3][@type='boolean']]"
		[Register ("pushStream", "(ILjava/util/List;Z)Lokhttp3/internal/framed/FramedStream;", "")]
		public unsafe global::Okhttp3.Internal.Framed.FramedStream PushStream (int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> requestHeaders, bool @out)
		{
			const string __id = "pushStream.(ILjava/util/List;Z)Lokhttp3/internal/framed/FramedStream;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (associatedStreamId);
				__args [1] = new JniArgumentValue (native_requestHeaders);
				__args [2] = new JniArgumentValue (@out);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.FramedStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='sendConnectionPreface' and count(parameter)=0]"
		[Register ("sendConnectionPreface", "()V", "")]
		public unsafe void SendConnectionPreface ()
		{
			const string __id = "sendConnectionPreface.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='setSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.Settings']]"
		[Register ("setSettings", "(Lokhttp3/internal/framed/Settings;)V", "")]
		public unsafe void SetSettings (global::Okhttp3.Internal.Framed.Settings settings)
		{
			const string __id = "setSettings.(Lokhttp3/internal/framed/Settings;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/class[@name='FramedConnection']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register ("shutdown", "(Lokhttp3/internal/framed/ErrorCode;)V", "")]
		public unsafe void Shutdown (global::Okhttp3.Internal.Framed.ErrorCode statusCode)
		{
			const string __id = "shutdown.(Lokhttp3/internal/framed/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((statusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
