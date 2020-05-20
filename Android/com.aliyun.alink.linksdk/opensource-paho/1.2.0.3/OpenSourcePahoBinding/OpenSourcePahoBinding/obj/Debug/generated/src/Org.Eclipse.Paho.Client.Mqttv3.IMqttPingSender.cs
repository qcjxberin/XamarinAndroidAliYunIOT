using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPingSender']"
	[Register ("org/eclipse/paho/client/mqttv3/MqttPingSender", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSenderInvoker")]
	public partial interface IMqttPingSender : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPingSender']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register ("init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSenderInvoker, OpenSourcePahoBinding")]
		void Init (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPingSender']/method[@name='schedule' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("schedule", "(J)V", "GetSchedule_JHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSenderInvoker, OpenSourcePahoBinding")]
		void Schedule (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPingSender']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSenderInvoker, OpenSourcePahoBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttPingSender']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSenderInvoker, OpenSourcePahoBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttPingSender", DoNotGenerateAcw=true)]
	internal partial class IMqttPingSenderInvoker : global::Java.Lang.Object, IMqttPingSender {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttPingSender", typeof (IMqttPingSenderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMqttPingSender GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttPingSender> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.MqttPingSender"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttPingSenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Handler ()
		{
			if (cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == null)
				cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_);
			return cb_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		}

		static void n_Init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_;
		public unsafe void Init (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms p0)
		{
			if (id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ == IntPtr.Zero)
				id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_ = JNIEnv.GetMethodID (class_ref, "init", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_, __args);
		}

		static Delegate cb_schedule_J;
#pragma warning disable 0169
		static Delegate GetSchedule_JHandler ()
		{
			if (cb_schedule_J == null)
				cb_schedule_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Schedule_J);
			return cb_schedule_J;
		}

		static void n_Schedule_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Schedule (p0);
		}
#pragma warning restore 0169

		IntPtr id_schedule_J;
		public unsafe void Schedule (long p0)
		{
			if (id_schedule_J == IntPtr.Zero)
				id_schedule_J = JNIEnv.GetMethodID (class_ref, "schedule", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_schedule_J, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
