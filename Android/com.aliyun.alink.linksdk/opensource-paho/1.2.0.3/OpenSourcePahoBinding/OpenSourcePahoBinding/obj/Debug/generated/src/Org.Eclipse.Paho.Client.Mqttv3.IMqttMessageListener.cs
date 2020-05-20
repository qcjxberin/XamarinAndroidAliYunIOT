using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttMessageListener']"
	[Register ("org/eclipse/paho/client/mqttv3/IMqttMessageListener", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListenerInvoker")]
	public partial interface IMqttMessageListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttMessageListener']/method[@name='messageArrived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListenerInvoker, OpenSourcePahoBinding")]
		void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/IMqttMessageListener", DoNotGenerateAcw=true)]
	internal partial class IMqttMessageListenerInvoker : global::Java.Lang.Object, IMqttMessageListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/IMqttMessageListener", typeof (IMqttMessageListenerInvoker));

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

		public static IMqttMessageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttMessageListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.IMqttMessageListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttMessageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		public unsafe void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			if (id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for org.eclipse.paho.client.mqttv3.IMqttMessageListener.messageArrived
	public partial class MqttMessageEventArgs : global::System.EventArgs {

		public MqttMessageEventArgs (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1;
		public global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/eclipse/paho/client/mqttv3/IMqttMessageListenerImplementor")]
	internal sealed partial class IMqttMessageListenerImplementor : global::Java.Lang.Object, IMqttMessageListener {

		object sender;

		public IMqttMessageListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/eclipse/paho/client/mqttv3/IMqttMessageListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MqttMessageEventArgs> Handler;
#pragma warning restore 0649

		public void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MqttMessageEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMqttMessageListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
