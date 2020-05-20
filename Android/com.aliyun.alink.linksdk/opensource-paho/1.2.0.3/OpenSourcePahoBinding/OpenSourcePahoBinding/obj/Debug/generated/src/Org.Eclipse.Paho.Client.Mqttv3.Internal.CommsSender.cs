using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsSender", DoNotGenerateAcw=true)]
	public partial class CommsSender : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/CommsSender", typeof (CommsSender));
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

		protected CommsSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/constructor[@name='CommsSender' and count(parameter)=4 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.CommsTokenStore'] and parameter[4][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V", "")]
		public unsafe CommsSender (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms clientComms, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore tokenStore, global::System.IO.Stream @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((clientComms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientComms).Handle);
				__args [1] = new JniArgumentValue ((clientState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientState).Handle);
				__args [2] = new JniArgumentValue ((tokenStore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenStore).Handle);
				__args [3] = new JniArgumentValue (native__out);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_Handler ()
		{
			if (cb_start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_ == null)
				cb_start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_);
			return cb_start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_;
		}

		static void n_Start_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadName, IntPtr native_executorService)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService executorService = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_executorService, JniHandleOwnership.DoNotTransfer);
			__this.Start (threadName, executorService);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='start' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
		[Register ("start", "(Ljava/lang/String;Ljava/util/concurrent/ExecutorService;)V", "GetStart_Ljava_lang_String_Ljava_util_concurrent_ExecutorService_Handler")]
		public virtual unsafe void Start (string threadName, global::Java.Util.Concurrent.IExecutorService executorService)
		{
			const string __id = "start.(Ljava/lang/String;Ljava/util/concurrent/ExecutorService;)V";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_threadName);
				__args [1] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsSender']/method[@name='stop' and count(parameter)=0]"
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
