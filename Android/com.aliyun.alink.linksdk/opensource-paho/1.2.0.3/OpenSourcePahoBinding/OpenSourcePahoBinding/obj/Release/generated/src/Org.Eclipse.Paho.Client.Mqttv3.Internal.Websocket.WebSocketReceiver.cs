using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketReceiver", DoNotGenerateAcw=true)]
	public partial class WebSocketReceiver : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketReceiver", typeof (WebSocketReceiver));
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

		protected WebSocketReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/constructor[@name='WebSocketReceiver' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.PipedInputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/io/PipedInputStream;)V", "")]
		public unsafe WebSocketReceiver (global::System.IO.Stream input, global::Java.IO.PipedInputStream pipedInputStream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;Ljava/io/PipedInputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_input);
				__args [1] = new JniArgumentValue ((pipedInputStream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pipedInputStream).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_isReceiving;
#pragma warning disable 0169
		static Delegate GetIsReceivingHandler ()
		{
			if (cb_isReceiving == null)
				cb_isReceiving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReceiving);
			return cb_isReceiving;
		}

		static bool n_IsReceiving (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReceiving;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsReceiving {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/method[@name='isReceiving' and count(parameter)=0]"
			[Register ("isReceiving", "()Z", "GetIsReceivingHandler")]
			get {
				const string __id = "isReceiving.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Handler ()
		{
			if (cb_start_Ljava_lang_String_ == null)
				cb_start_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Ljava_lang_String_);
			return cb_start_Ljava_lang_String_;
		}

		static void n_Start_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadName)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			__this.Start (threadName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("start", "(Ljava/lang/String;)V", "GetStart_Ljava_lang_String_Handler")]
		public virtual unsafe void Start (string threadName)
		{
			const string __id = "start.(Ljava/lang/String;)V";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_threadName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketReceiver']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
