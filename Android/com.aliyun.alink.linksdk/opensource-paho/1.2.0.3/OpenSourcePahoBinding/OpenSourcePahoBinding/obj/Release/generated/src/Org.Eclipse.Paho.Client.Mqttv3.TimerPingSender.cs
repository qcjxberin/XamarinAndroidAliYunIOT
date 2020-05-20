using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/TimerPingSender", DoNotGenerateAcw=true)]
	public partial class TimerPingSender : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/TimerPingSender", typeof (TimerPingSender));
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

		protected TimerPingSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/constructor[@name='TimerPingSender' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimerPingSender ()
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

		static Delegate cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler ()
		{
			if (cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == null)
				cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_);
			return cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		}

		static void n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comms)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms comms = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (native_comms, JniHandleOwnership.DoNotTransfer);
			__this.Init (comms);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register ("init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler")]
		public virtual unsafe void Init (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms comms)
		{
			const string __id = "init.(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comms).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_schedule_J;
#pragma warning disable 0169
		static Delegate GetSchedule_JHandler ()
		{
			if (cb_schedule_J == null)
				cb_schedule_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Schedule_J);
			return cb_schedule_J;
		}

		static void n_Schedule_J (IntPtr jnienv, IntPtr native__this, long delayInMilliseconds)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Schedule (delayInMilliseconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("schedule", "(J)V", "GetSchedule_JHandler")]
		public virtual unsafe void Schedule (long delayInMilliseconds)
		{
			const string __id = "schedule.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delayInMilliseconds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.TimerPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='TimerPingSender']/method[@name='stop' and count(parameter)=0]"
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
