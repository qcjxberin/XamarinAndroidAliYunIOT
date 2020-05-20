using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallbackExtended']"
	[Register ("org/eclipse/paho/client/mqttv3/MqttCallbackExtended", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtendedInvoker")]
	public partial interface IMqttCallbackExtended : global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttCallbackExtended']/method[@name='connectComplete' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("connectComplete", "(ZLjava/lang/String;)V", "GetConnectComplete_ZLjava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtendedInvoker, OpenSourcePahoBinding")]
		void ConnectComplete (bool p0, string p1);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttCallbackExtended", DoNotGenerateAcw=true)]
	internal partial class IMqttCallbackExtendedInvoker : global::Java.Lang.Object, IMqttCallbackExtended {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttCallbackExtended", typeof (IMqttCallbackExtendedInvoker));

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

		public static IMqttCallbackExtended GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttCallbackExtended> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.MqttCallbackExtended"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttCallbackExtendedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connectComplete_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnectComplete_ZLjava_lang_String_Handler ()
		{
			if (cb_connectComplete_ZLjava_lang_String_ == null)
				cb_connectComplete_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_ConnectComplete_ZLjava_lang_String_);
			return cb_connectComplete_ZLjava_lang_String_;
		}

		static void n_ConnectComplete_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConnectComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_connectComplete_ZLjava_lang_String_;
		public unsafe void ConnectComplete (bool p0, string p1)
		{
			if (id_connectComplete_ZLjava_lang_String_ == IntPtr.Zero)
				id_connectComplete_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connectComplete", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectComplete_ZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
