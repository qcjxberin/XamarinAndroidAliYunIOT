using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallback']"
	[Register ("org/eclipse/paho/client/mqttv3/MqttCallback", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackInvoker")]
	public partial interface IMqttCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallback']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("connectionLost", "(Ljava/lang/Throwable;)V", "GetConnectionLost_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackInvoker, OpenSourcePahoBinding")]
		void ConnectionLost (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallback']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttDeliveryToken']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackInvoker, OpenSourcePahoBinding")]
		void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallback']/method[@name='messageArrived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackInvoker, OpenSourcePahoBinding")]
		void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttCallback", DoNotGenerateAcw=true)]
	internal partial class IMqttCallbackInvoker : global::Java.Lang.Object, IMqttCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttCallback", typeof (IMqttCallbackInvoker));

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

		public static IMqttCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.MqttCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connectionLost_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Ljava_lang_Throwable_Handler ()
		{
			if (cb_connectionLost_Ljava_lang_Throwable_ == null)
				cb_connectionLost_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Ljava_lang_Throwable_);
			return cb_connectionLost_Ljava_lang_Throwable_;
		}

		static void n_ConnectionLost_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (p0);
		}
#pragma warning restore 0169

		IntPtr id_connectionLost_Ljava_lang_Throwable_;
		public unsafe void ConnectionLost (global::Java.Lang.Throwable p0)
		{
			if (id_connectionLost_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_connectionLost_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "connectionLost", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectionLost_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		public unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0)
		{
			if (id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == IntPtr.Zero)
				id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

}
