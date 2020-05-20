using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.WS {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']"
	[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket", DoNotGenerateAcw=true)]
	public sealed partial class RealWebSocket : global::Java.Lang.Object, global::Okhttp3.IWebSocket, global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.CancelRunnable']"
		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$CancelRunnable", DoNotGenerateAcw=true)]
		public sealed partial class CancelRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket$CancelRunnable", typeof (CancelRunnable));
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

			internal CancelRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.CancelRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Close']"
		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Close", DoNotGenerateAcw=true)]
		public sealed partial class Close : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket$Close", typeof (Close));
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

			internal Close (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Message']"
		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Message", DoNotGenerateAcw=true)]
		public sealed partial class Message : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket$Message", typeof (Message));
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

			internal Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']"
		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Streams", DoNotGenerateAcw=true)]
		public abstract partial class Streams : global::Java.Lang.Object, global::Java.IO.ICloseable {



			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']/field[@name='client']"
			[Register ("client")]
			public bool Client {
				get {
					const string __id = "client.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "client.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']/field[@name='sink']"
			[Register ("sink")]
			public global::Okio.IBufferedSink Sink {
				get {
					const string __id = "sink.Lokio/BufferedSink;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sink.Lokio/BufferedSink;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']/field[@name='source']"
			[Register ("source")]
			public global::Okio.IBufferedSource Source {
				get {
					const string __id = "source.Lokio/BufferedSource;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "source.Lokio/BufferedSource;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket$Streams", typeof (Streams));
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

			protected Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket.Streams']/constructor[@name='RealWebSocket.Streams' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='okio.BufferedSource'] and parameter[3][@type='okio.BufferedSink']]"
			[Register (".ctor", "(ZLokio/BufferedSource;Lokio/BufferedSink;)V", "")]
			public unsafe Streams (bool client, global::Okio.IBufferedSource source, global::Okio.IBufferedSink sink)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZLokio/BufferedSource;Lokio/BufferedSink;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (client);
					__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					__args [2] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.WS.RealWebSocket.Streams __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.RealWebSocket.Streams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			[Register ("close", "()V", "GetCloseHandler")]
			public abstract void Close ();

		}

		[global::Android.Runtime.Register ("okhttp3/internal/ws/RealWebSocket$Streams", DoNotGenerateAcw=true)]
		internal partial class StreamsInvoker : Streams {

			public StreamsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket$Streams", typeof (StreamsInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			[Register ("close", "()V", "GetCloseHandler")]
			public override unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/RealWebSocket", typeof (RealWebSocket));
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

		internal RealWebSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/constructor[@name='RealWebSocket' and count(parameter)=4 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.WebSocketListener'] and parameter[3][@type='java.util.Random'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V", "")]
		public unsafe RealWebSocket (global::Okhttp3.Request request, global::Okhttp3.WebSocketListener listener, global::Java.Util.Random random, long pingIntervalMillis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Request;Lokhttp3/WebSocketListener;Ljava/util/Random;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((random == null) ? IntPtr.Zero : ((global::Java.Lang.Object) random).Handle);
				__args [3] = new JniArgumentValue (pingIntervalMillis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)Z", "")]
		public unsafe bool InvokeClose (int code, string reason)
		{
			const string __id = "close.(ILjava/lang/String;)Z";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_reason);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
		[Register ("connect", "(Lokhttp3/OkHttpClient;)V", "")]
		public unsafe void Connect (global::Okhttp3.OkHttpClient client)
		{
			const string __id = "connect.(Lokhttp3/OkHttpClient;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='failWebSocket' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='okhttp3.Response']]"
		[Register ("failWebSocket", "(Ljava/lang/Exception;Lokhttp3/Response;)V", "")]
		public unsafe void FailWebSocket (global::Java.Lang.Exception e, global::Okhttp3.Response response)
		{
			const string __id = "failWebSocket.(Ljava/lang/Exception;Lokhttp3/Response;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='initReaderAndWriter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='okhttp3.internal.ws.RealWebSocket.Streams']]"
		[Register ("initReaderAndWriter", "(Ljava/lang/String;Lokhttp3/internal/ws/RealWebSocket$Streams;)V", "")]
		public unsafe void InitReaderAndWriter (string name, global::Okhttp3.Internal.WS.RealWebSocket.Streams streams)
		{
			const string __id = "initReaderAndWriter.(Ljava/lang/String;Lokhttp3/internal/ws/RealWebSocket$Streams;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((streams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) streams).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='loopReader' and count(parameter)=0]"
		[Register ("loopReader", "()V", "")]
		public unsafe void LoopReader ()
		{
			const string __id = "loopReader.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadClose' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onReadClose", "(ILjava/lang/String;)V", "")]
		public unsafe void OnReadClose (int code, string reason)
		{
			const string __id = "onReadClose.(ILjava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReadMessage", "(Ljava/lang/String;)V", "")]
		public unsafe void OnReadMessage (string text)
		{
			const string __id = "onReadMessage.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadMessage' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("onReadMessage", "(Lokio/ByteString;)V", "")]
		public unsafe void OnReadMessage (global::Okio.ByteString bytes)
		{
			const string __id = "onReadMessage.(Lokio/ByteString;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadPing' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("onReadPing", "(Lokio/ByteString;)V", "")]
		public unsafe void OnReadPing (global::Okio.ByteString payload)
		{
			const string __id = "onReadPing.(Lokio/ByteString;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='onReadPong' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("onReadPong", "(Lokio/ByteString;)V", "")]
		public unsafe void OnReadPong (global::Okio.ByteString buffer)
		{
			const string __id = "onReadPong.(Lokio/ByteString;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='queueSize' and count(parameter)=0]"
		[Register ("queueSize", "()J", "")]
		public unsafe long QueueSize ()
		{
			const string __id = "queueSize.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='request' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Send (string text)
		{
			const string __id = "send.(Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='RealWebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("send", "(Lokio/ByteString;)Z", "")]
		public unsafe bool Send (global::Okio.ByteString bytes)
		{
			const string __id = "send.(Lokio/ByteString;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
