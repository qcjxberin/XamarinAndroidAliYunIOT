using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection", DoNotGenerateAcw=true)]
	public sealed partial class Http2Connection : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/constructor[@name='Http2Connection.Builder' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
				global::Okhttp3.Internal.Http2.Http2Connection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/internal/http2/Http2Connection;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection Build ()
			{
				const string __id = "build.()Lokhttp3/internal/http2/Http2Connection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_;
#pragma warning disable 0169
			static Delegate GetListener_Lokhttp3_internal_http2_Http2Connection_Listener_Handler ()
			{
				if (cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ == null)
					cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listener_Lokhttp3_internal_http2_Http2Connection_Listener_);
				return cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_;
			}

			static IntPtr n_Listener_Lokhttp3_internal_http2_Http2Connection_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.Http2Connection.Listener listener = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Connection.Listener']]"
			[Register ("listener", "(Lokhttp3/internal/http2/Http2Connection$Listener;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetListener_Lokhttp3_internal_http2_Http2Connection_Listener_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder Listener (global::Okhttp3.Internal.Http2.Http2Connection.Listener listener)
			{
				const string __id = "listener.(Lokhttp3/internal/http2/Http2Connection$Listener;)Lokhttp3/internal/http2/Http2Connection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_pingIntervalMillis_I;
#pragma warning disable 0169
			static Delegate GetPingIntervalMillis_IHandler ()
			{
				if (cb_pingIntervalMillis_I == null)
					cb_pingIntervalMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PingIntervalMillis_I);
				return cb_pingIntervalMillis_I;
			}

			static IntPtr n_PingIntervalMillis_I (IntPtr jnienv, IntPtr native__this, int pingIntervalMillis)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PingIntervalMillis (pingIntervalMillis));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='pingIntervalMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("pingIntervalMillis", "(I)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetPingIntervalMillis_IHandler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder PingIntervalMillis (int pingIntervalMillis)
			{
				const string __id = "pingIntervalMillis.(I)Lokhttp3/internal/http2/Http2Connection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (pingIntervalMillis);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_pushObserver_Lokhttp3_internal_http2_PushObserver_;
#pragma warning disable 0169
			static Delegate GetPushObserver_Lokhttp3_internal_http2_PushObserver_Handler ()
			{
				if (cb_pushObserver_Lokhttp3_internal_http2_PushObserver_ == null)
					cb_pushObserver_Lokhttp3_internal_http2_PushObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PushObserver_Lokhttp3_internal_http2_PushObserver_);
				return cb_pushObserver_Lokhttp3_internal_http2_PushObserver_;
			}

			static IntPtr n_PushObserver_Lokhttp3_internal_http2_PushObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pushObserver)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.IPushObserver pushObserver = (global::Okhttp3.Internal.Http2.IPushObserver)global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (native_pushObserver, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PushObserver (pushObserver));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='pushObserver' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.PushObserver']]"
			[Register ("pushObserver", "(Lokhttp3/internal/http2/PushObserver;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetPushObserver_Lokhttp3_internal_http2_PushObserver_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder PushObserver (global::Okhttp3.Internal.Http2.IPushObserver pushObserver)
			{
				const string __id = "pushObserver.(Lokhttp3/internal/http2/PushObserver;)Lokhttp3/internal/http2/Http2Connection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((pushObserver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pushObserver).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Okhttp3.Internal.Http2.Http2Connection.Builder __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Socket (socket));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='socket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
			[Register ("socket", "(Ljava/net/Socket;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetSocket_Ljava_net_Socket_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder Socket (global::Java.Net.Socket socket)
			{
				const string __id = "socket.(Ljava/net/Socket;)Lokhttp3/internal/http2/Http2Connection$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Listener", DoNotGenerateAcw=true)]
		public abstract partial class Listener : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/field[@name='REFUSE_INCOMING_STREAMS']"
			[Register ("REFUSE_INCOMING_STREAMS")]
			public static global::Okhttp3.Internal.Http2.Http2Connection.Listener RefuseIncomingStreams {
				get {
					const string __id = "REFUSE_INCOMING_STREAMS.Lokhttp3/internal/http2/Http2Connection$Listener;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection$Listener", typeof (Listener));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/constructor[@name='Http2Connection.Listener' and count(parameter)=0]"
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

			static Delegate cb_onSettings_Lokhttp3_internal_http2_Http2Connection_;
#pragma warning disable 0169
			static Delegate GetOnSettings_Lokhttp3_internal_http2_Http2Connection_Handler ()
			{
				if (cb_onSettings_Lokhttp3_internal_http2_Http2Connection_ == null)
					cb_onSettings_Lokhttp3_internal_http2_Http2Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSettings_Lokhttp3_internal_http2_Http2Connection_);
				return cb_onSettings_Lokhttp3_internal_http2_Http2Connection_;
			}

			static void n_OnSettings_Lokhttp3_internal_http2_Http2Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connection)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.Listener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.Http2Connection connection = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (native_connection, JniHandleOwnership.DoNotTransfer);
				__this.OnSettings (connection);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Connection']]"
			[Register ("onSettings", "(Lokhttp3/internal/http2/Http2Connection;)V", "GetOnSettings_Lokhttp3_internal_http2_Http2Connection_Handler")]
			public virtual unsafe void OnSettings (global::Okhttp3.Internal.Http2.Http2Connection connection)
			{
				const string __id = "onSettings.(Lokhttp3/internal/http2/Http2Connection;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((connection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connection).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStream_Lokhttp3_internal_http2_Http2Stream_;
#pragma warning disable 0169
			static Delegate GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler ()
			{
				if (cb_onStream_Lokhttp3_internal_http2_Http2Stream_ == null)
					cb_onStream_Lokhttp3_internal_http2_Http2Stream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStream_Lokhttp3_internal_http2_Http2Stream_);
				return cb_onStream_Lokhttp3_internal_http2_Http2Stream_;
			}

			static void n_OnStream_Lokhttp3_internal_http2_Http2Stream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.Listener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.Http2Stream p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStream (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
			[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler")]
			public abstract void OnStream (global::Okhttp3.Internal.Http2.Http2Stream p0);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Listener", DoNotGenerateAcw=true)]
		internal partial class ListenerInvoker : Listener {

			public ListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection$Listener", typeof (ListenerInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
			[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler")]
			public override unsafe void OnStream (global::Okhttp3.Internal.Http2.Http2Stream p0)
			{
				const string __id = "onStream.(Lokhttp3/internal/http2/Http2Stream;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.PingRunnable']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$PingRunnable", DoNotGenerateAcw=true)]
		public sealed partial class PingRunnable : global::Okhttp3.Internal.NamedRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection$PingRunnable", typeof (PingRunnable));
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

			internal PingRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$ReaderRunnable", DoNotGenerateAcw=true)]
		public partial class ReaderRunnable : global::Okhttp3.Internal.NamedRunnable, global::Okhttp3.Internal.Http2.Http2Reader.IHandler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection$ReaderRunnable", typeof (ReaderRunnable));
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

			protected ReaderRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AckSettings ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='ackSettings' and count(parameter)=0]"
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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Execute ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='execute' and count(parameter)=0]"
			[Register ("execute", "()V", "GetExecuteHandler")]
			protected override unsafe void Execute ()
			{
				const string __id = "execute.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_headers_ZIILjava_util_List_;
#pragma warning disable 0169
			static Delegate GetHeaders_ZIILjava_util_List_Handler ()
			{
				if (cb_headers_ZIILjava_util_List_ == null)
					cb_headers_ZIILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, IntPtr>) n_Headers_ZIILjava_util_List_);
				return cb_headers_ZIILjava_util_List_;
			}

			static void n_Headers_ZIILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool inFinished, int streamId, int associatedStreamId, IntPtr native_headerBlock)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_headerBlock, JniHandleOwnership.DoNotTransfer);
				__this.Headers (inFinished, streamId, associatedStreamId, headerBlock);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='headers' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
			[Register ("headers", "(ZIILjava/util/List;)V", "GetHeaders_ZIILjava_util_List_Handler")]
			public virtual unsafe void Headers (bool inFinished, int streamId, int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> headerBlock)
			{
				const string __id = "headers.(ZIILjava/util/List;)V";
				IntPtr native_headerBlock = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (headerBlock);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (inFinished);
					__args [1] = new JniArgumentValue (streamId);
					__args [2] = new JniArgumentValue (associatedStreamId);
					__args [3] = new JniArgumentValue (native_headerBlock);
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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ping (reply, payload1, payload2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Priority (streamId, streamDependency, weight, exclusive);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='priority' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_requestHeaders, JniHandleOwnership.DoNotTransfer);
				__this.PushPromise (streamId, promisedStreamId, requestHeaders);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
			[Register ("pushPromise", "(IILjava/util/List;)V", "GetPushPromise_IILjava_util_List_Handler")]
			public virtual unsafe void PushPromise (int streamId, int promisedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> requestHeaders)
			{
				const string __id = "pushPromise.(IILjava/util/List;)V";
				IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (requestHeaders);
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

			static Delegate cb_rstStream_ILokhttp3_internal_http2_ErrorCode_;
#pragma warning disable 0169
			static Delegate GetRstStream_ILokhttp3_internal_http2_ErrorCode_Handler ()
			{
				if (cb_rstStream_ILokhttp3_internal_http2_ErrorCode_ == null)
					cb_rstStream_ILokhttp3_internal_http2_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RstStream_ILokhttp3_internal_http2_ErrorCode_);
				return cb_rstStream_ILokhttp3_internal_http2_ErrorCode_;
			}

			static void n_RstStream_ILokhttp3_internal_http2_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int streamId, IntPtr native_errorCode)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.ErrorCode errorCode = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (native_errorCode, JniHandleOwnership.DoNotTransfer);
				__this.RstStream (streamId, errorCode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.http2.ErrorCode']]"
			[Register ("rstStream", "(ILokhttp3/internal/http2/ErrorCode;)V", "GetRstStream_ILokhttp3_internal_http2_ErrorCode_Handler")]
			public virtual unsafe void RstStream (int streamId, global::Okhttp3.Internal.Http2.ErrorCode errorCode)
			{
				const string __id = "rstStream.(ILokhttp3/internal/http2/ErrorCode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (streamId);
					__args [1] = new JniArgumentValue ((errorCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCode).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_settings_ZLokhttp3_internal_http2_Settings_;
#pragma warning disable 0169
			static Delegate GetSettings_ZLokhttp3_internal_http2_Settings_Handler ()
			{
				if (cb_settings_ZLokhttp3_internal_http2_Settings_ == null)
					cb_settings_ZLokhttp3_internal_http2_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_Settings_ZLokhttp3_internal_http2_Settings_);
				return cb_settings_ZLokhttp3_internal_http2_Settings_;
			}

			static void n_Settings_ZLokhttp3_internal_http2_Settings_ (IntPtr jnienv, IntPtr native__this, bool clearPrevious, IntPtr native_newSettings)
			{
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.Settings newSettings = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Settings> (native_newSettings, JniHandleOwnership.DoNotTransfer);
				__this.Settings (clearPrevious, newSettings);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='settings' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='okhttp3.internal.http2.Settings']]"
			[Register ("settings", "(ZLokhttp3/internal/http2/Settings;)V", "GetSettings_ZLokhttp3_internal_http2_Settings_Handler")]
			public virtual unsafe void Settings (bool clearPrevious, global::Okhttp3.Internal.Http2.Settings newSettings)
			{
				const string __id = "settings.(ZLokhttp3/internal/http2/Settings;)V";
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
				global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.ReaderRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WindowUpdate (streamId, windowSizeIncrement);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.ReaderRunnable']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Connection", typeof (Http2Connection));
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

		internal Http2Connection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsShutdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='isShutdown' and count(parameter)=0]"
			[Register ("isShutdown", "()Z", "")]
			get {
				const string __id = "isShutdown.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Protocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='getProtocol' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='maxConcurrentStreams' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='newStream' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[2][@type='boolean']]"
		[Register ("newStream", "(Ljava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;", "")]
		public unsafe global::Okhttp3.Internal.Http2.Http2Stream NewStream (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> requestHeaders, bool @out)
		{
			const string __id = "newStream.(Ljava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_requestHeaders);
				__args [1] = new JniArgumentValue (@out);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='openStreamCount' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='pushStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[3][@type='boolean']]"
		[Register ("pushStream", "(ILjava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;", "")]
		public unsafe global::Okhttp3.Internal.Http2.Http2Stream PushStream (int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> requestHeaders, bool @out)
		{
			const string __id = "pushStream.(ILjava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;";
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (associatedStreamId);
				__args [1] = new JniArgumentValue (native_requestHeaders);
				__args [2] = new JniArgumentValue (@out);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='setSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Settings']]"
		[Register ("setSettings", "(Lokhttp3/internal/http2/Settings;)V", "")]
		public unsafe void SetSettings (global::Okhttp3.Internal.Http2.Settings settings)
		{
			const string __id = "setSettings.(Lokhttp3/internal/http2/Settings;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("shutdown", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe void Shutdown (global::Okhttp3.Internal.Http2.ErrorCode statusCode)
		{
			const string __id = "shutdown.(Lokhttp3/internal/http2/ErrorCode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((statusCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusCode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
