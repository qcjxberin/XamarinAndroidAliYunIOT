using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttAsyncClient", DoNotGenerateAcw=true)]
	public partial class MqttAsyncClient : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/field[@name='comms']"
		[Register ("comms")]
		protected global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms Comms {
			get {
				const string __id = "comms.Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "comms.Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectActionListener']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttAsyncClient$MqttReconnectActionListener", DoNotGenerateAcw=true)]
		public partial class MqttReconnectActionListener : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttAsyncClient$MqttReconnectActionListener", typeof (MqttReconnectActionListener));
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

			protected MqttReconnectActionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == null)
					cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_);
				return cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
			}

			static void n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_asyncActionToken, IntPtr native_exception)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken asyncActionToken = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_asyncActionToken, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_exception, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (asyncActionToken, exception);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectActionListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken'] and parameter[2][@type='java.lang.Throwable']]"
			[Register ("onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V", "GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken asyncActionToken, global::Java.Lang.Throwable exception)
			{
				const string __id = "onFailure.(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((asyncActionToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) asyncActionToken).Handle);
					__args [1] = new JniArgumentValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler ()
			{
				if (cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ == null)
					cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_);
				return cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
			}

			static void n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_asyncActionToken)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken asyncActionToken = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_asyncActionToken, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (asyncActionToken);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectActionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken']]"
			[Register ("onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V", "GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler")]
			public virtual unsafe void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken asyncActionToken)
			{
				const string __id = "onSuccess.(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((asyncActionToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) asyncActionToken).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectCallback']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttAsyncClient$MqttReconnectCallback", DoNotGenerateAcw=true)]
		public partial class MqttReconnectCallback : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttAsyncClient$MqttReconnectCallback", typeof (MqttReconnectCallback));
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

			protected MqttReconnectCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_connectComplete_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetConnectComplete_ZLjava_lang_String_Handler ()
			{
				if (cb_connectComplete_ZLjava_lang_String_ == null)
					cb_connectComplete_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_ConnectComplete_ZLjava_lang_String_);
				return cb_connectComplete_ZLjava_lang_String_;
			}

			static void n_ConnectComplete_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool reconnect, IntPtr native_serverURI)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string serverURI = JNIEnv.GetString (native_serverURI, JniHandleOwnership.DoNotTransfer);
				__this.ConnectComplete (reconnect, serverURI);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectCallback']/method[@name='connectComplete' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("connectComplete", "(ZLjava/lang/String;)V", "GetConnectComplete_ZLjava_lang_String_Handler")]
			public virtual unsafe void ConnectComplete (bool reconnect, string serverURI)
			{
				const string __id = "connectComplete.(ZLjava/lang/String;)V";
				IntPtr native_serverURI = JNIEnv.NewString (serverURI);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (reconnect);
					__args [1] = new JniArgumentValue (native_serverURI);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_serverURI);
				}
			}

			static Delegate cb_connectionLost_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetConnectionLost_Ljava_lang_Throwable_Handler ()
			{
				if (cb_connectionLost_Ljava_lang_Throwable_ == null)
					cb_connectionLost_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Ljava_lang_Throwable_);
				return cb_connectionLost_Ljava_lang_Throwable_;
			}

			static void n_ConnectionLost_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable cause = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_cause, JniHandleOwnership.DoNotTransfer);
				__this.ConnectionLost (cause);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectCallback']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("connectionLost", "(Ljava/lang/Throwable;)V", "GetConnectionLost_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void ConnectionLost (global::Java.Lang.Throwable cause)
			{
				const string __id = "connectionLost.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
#pragma warning disable 0169
			static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler ()
			{
				if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == null)
					cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_);
				return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
			}

			static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken token = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (native_token, JniHandleOwnership.DoNotTransfer);
				__this.DeliveryComplete (token);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectCallback']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttDeliveryToken']]"
			[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler")]
			public virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken token)
			{
				const string __id = "deliveryComplete.(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
			static Delegate GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
			{
				if (cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
					cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
				return cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
			}

			static void n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_message)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient.MqttReconnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
				global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
				__this.MessageArrived (topic, message);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient.MqttReconnectCallback']/method[@name='messageArrived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
			[Register ("messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
			public virtual unsafe void MessageArrived (string topic, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message)
			{
				const string __id = "messageArrived.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V";
				IntPtr native_topic = JNIEnv.NewString (topic);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_topic);
					__args [1] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_topic);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttAsyncClient", typeof (MqttAsyncClient));
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

		protected MqttAsyncClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_serverURI);
				__args [1] = new JniArgumentValue (native_clientId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_serverURI);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttPingSender']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_serverURI);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				__args [3] = new JniArgumentValue ((pingSender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pingSender).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttPingSender'] and parameter[5][@type='java.util.concurrent.ScheduledExecutorService']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;Ljava/util/concurrent/ScheduledExecutorService;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender, global::Java.Util.Concurrent.IScheduledExecutorService executorService)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;Ljava/util/concurrent/ScheduledExecutorService;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_serverURI);
				__args [1] = new JniArgumentValue (native_clientId);
				__args [2] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				__args [3] = new JniArgumentValue ((pingSender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pingSender).Handle);
				__args [4] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		static Delegate cb_getBufferedMessageCount;
#pragma warning disable 0169
		static Delegate GetGetBufferedMessageCountHandler ()
		{
			if (cb_getBufferedMessageCount == null)
				cb_getBufferedMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferedMessageCount);
			return cb_getBufferedMessageCount;
		}

		static int n_GetBufferedMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedMessageCount;
		}
#pragma warning restore 0169

		public virtual unsafe int BufferedMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getBufferedMessageCount' and count(parameter)=0]"
			[Register ("getBufferedMessageCount", "()I", "GetGetBufferedMessageCountHandler")]
			get {
				const string __id = "getBufferedMessageCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentServerURI;
#pragma warning disable 0169
		static Delegate GetGetCurrentServerURIHandler ()
		{
			if (cb_getCurrentServerURI == null)
				cb_getCurrentServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentServerURI);
			return cb_getCurrentServerURI;
		}

		static IntPtr n_GetCurrentServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentServerURI);
		}
#pragma warning restore 0169

		public virtual unsafe string CurrentServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getCurrentServerURI' and count(parameter)=0]"
			[Register ("getCurrentServerURI", "()Ljava/lang/String;", "GetGetCurrentServerURIHandler")]
			get {
				const string __id = "getCurrentServerURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDebug;
#pragma warning disable 0169
		static Delegate GetGetDebugHandler ()
		{
			if (cb_getDebug == null)
				cb_getDebug = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDebug);
			return cb_getDebug;
		}

		static IntPtr n_GetDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getDebug' and count(parameter)=0]"
			[Register ("getDebug", "()Lorg/eclipse/paho/client/mqttv3/util/Debug;", "GetGetDebugHandler")]
			get {
				const string __id = "getDebug.()Lorg/eclipse/paho/client/mqttv3/util/Debug;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInFlightMessageCount;
#pragma warning disable 0169
		static Delegate GetGetInFlightMessageCountHandler ()
		{
			if (cb_getInFlightMessageCount == null)
				cb_getInFlightMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInFlightMessageCount);
			return cb_getInFlightMessageCount;
		}

		static int n_GetInFlightMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InFlightMessageCount;
		}
#pragma warning restore 0169

		public virtual unsafe int InFlightMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getInFlightMessageCount' and count(parameter)=0]"
			[Register ("getInFlightMessageCount", "()I", "GetGetInFlightMessageCountHandler")]
			get {
				const string __id = "getInFlightMessageCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getServerURI;
#pragma warning disable 0169
		static Delegate GetGetServerURIHandler ()
		{
			if (cb_getServerURI == null)
				cb_getServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerURI);
			return cb_getServerURI;
		}

		static IntPtr n_GetServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		public virtual unsafe string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getServerURI' and count(parameter)=0]"
			[Register ("getServerURI", "()Ljava/lang/String;", "GetGetServerURIHandler")]
			get {
				const string __id = "getServerURI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='Character_isHighSurrogate' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("Character_isHighSurrogate", "(C)Z", "")]
		protected static unsafe bool Character_isHighSurrogate (char ch)
		{
			const string __id = "Character_isHighSurrogate.(C)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ch);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetCheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_CheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckPing (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='checkPing' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("checkPing", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetCheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken CheckPing (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "checkPing.(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_close_Z;
#pragma warning disable 0169
		static Delegate GetClose_ZHandler ()
		{
			if (cb_close_Z == null)
				cb_close_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Close_Z);
			return cb_close_Z;
		}

		static void n_Close_Z (IntPtr jnienv, IntPtr native__this, bool force)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (force);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='close' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("close", "(Z)V", "GetClose_ZHandler")]
		public virtual unsafe void Close (bool force)
		{
			const string __id = "close.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static IntPtr n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnectHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect ()
		{
			const string __id = "connect.()Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "connect.(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options)
		{
			const string __id = "connect.(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (options, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "connect.(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
#pragma warning disable 0169
		static Delegate GetCreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler ()
		{
			if (cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == null)
				cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_);
			return cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		}

		static IntPtr n_CreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address, IntPtr native_options)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.CreateNetworkModules (address, options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='createNetworkModules' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("createNetworkModules", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;", "GetCreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] CreateNetworkModules (string address, global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options)
		{
			const string __id = "createNetworkModules.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_deleteBufferedMessage_I;
#pragma warning disable 0169
		static Delegate GetDeleteBufferedMessage_IHandler ()
		{
			if (cb_deleteBufferedMessage_I == null)
				cb_deleteBufferedMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeleteBufferedMessage_I);
			return cb_deleteBufferedMessage_I;
		}

		static void n_DeleteBufferedMessage_I (IntPtr jnienv, IntPtr native__this, int bufferIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteBufferedMessage (bufferIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='deleteBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deleteBufferedMessage", "(I)V", "GetDeleteBufferedMessage_IHandler")]
		public virtual unsafe void DeleteBufferedMessage (int bufferIndex)
		{
			const string __id = "deleteBufferedMessage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bufferIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static IntPtr n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnectHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect ()
		{
			const string __id = "disconnect.()Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "disconnect.(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnect_J;
#pragma warning disable 0169
		static Delegate GetDisconnect_JHandler ()
		{
			if (cb_disconnect_J == null)
				cb_disconnect_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Disconnect_J);
			return cb_disconnect_J;
		}

		static IntPtr n_Disconnect_J (IntPtr jnienv, IntPtr native__this, long quiesceTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect (quiesceTimeout));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long quiesceTimeout)
		{
			const string __id = "disconnect.(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (quiesceTimeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (quiesceTimeout, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long quiesceTimeout, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "disconnect.(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (quiesceTimeout);
				__args [1] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly;
#pragma warning disable 0169
		static Delegate GetDisconnectForciblyHandler ()
		{
			if (cb_disconnectForcibly == null)
				cb_disconnectForcibly = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectForcibly);
			return cb_disconnectForcibly;
		}

		static void n_DisconnectForcibly (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=0]"
		[Register ("disconnectForcibly", "()V", "GetDisconnectForciblyHandler")]
		public virtual unsafe void DisconnectForcibly ()
		{
			const string __id = "disconnectForcibly.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_J;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JHandler ()
		{
			if (cb_disconnectForcibly_J == null)
				cb_disconnectForcibly_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DisconnectForcibly_J);
			return cb_disconnectForcibly_J;
		}

		static void n_DisconnectForcibly_J (IntPtr jnienv, IntPtr native__this, long disconnectTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (disconnectTimeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnectForcibly", "(J)V", "GetDisconnectForcibly_JHandler")]
		public virtual unsafe void DisconnectForcibly (long disconnectTimeout)
		{
			const string __id = "disconnectForcibly.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disconnectTimeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_JJ;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JJHandler ()
		{
			if (cb_disconnectForcibly_JJ == null)
				cb_disconnectForcibly_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_DisconnectForcibly_JJ);
			return cb_disconnectForcibly_JJ;
		}

		static void n_DisconnectForcibly_JJ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, long disconnectTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("disconnectForcibly", "(JJ)V", "GetDisconnectForcibly_JJHandler")]
		public virtual unsafe void DisconnectForcibly (long quiesceTimeout, long disconnectTimeout)
		{
			const string __id = "disconnectForcibly.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (quiesceTimeout);
				__args [1] = new JniArgumentValue (disconnectTimeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_JJZ;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JJZHandler ()
		{
			if (cb_disconnectForcibly_JJZ == null)
				cb_disconnectForcibly_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, bool>) n_DisconnectForcibly_JJZ);
			return cb_disconnectForcibly_JJZ;
		}

		static void n_DisconnectForcibly_JJZ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, long disconnectTimeout, bool sendDisconnectPacket)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout, sendDisconnectPacket);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("disconnectForcibly", "(JJZ)V", "GetDisconnectForcibly_JJZHandler")]
		public virtual unsafe void DisconnectForcibly (long quiesceTimeout, long disconnectTimeout, bool sendDisconnectPacket)
		{
			const string __id = "disconnectForcibly.(JJZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (quiesceTimeout);
				__args [1] = new JniArgumentValue (disconnectTimeout);
				__args [2] = new JniArgumentValue (sendDisconnectPacket);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='generateClientId' and count(parameter)=0]"
		[Register ("generateClientId", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateClientId ()
		{
			const string __id = "generateClientId.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBufferedMessage_I;
#pragma warning disable 0169
		static Delegate GetGetBufferedMessage_IHandler ()
		{
			if (cb_getBufferedMessage_I == null)
				cb_getBufferedMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBufferedMessage_I);
			return cb_getBufferedMessage_I;
		}

		static IntPtr n_GetBufferedMessage_I (IntPtr jnienv, IntPtr native__this, int bufferIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBufferedMessage (bufferIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBufferedMessage", "(I)Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetBufferedMessage_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage GetBufferedMessage (int bufferIndex)
		{
			const string __id = "getBufferedMessage.(I)Lorg/eclipse/paho/client/mqttv3/MqttMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bufferIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPendingDeliveryTokens;
#pragma warning disable 0169
		static Delegate GetGetPendingDeliveryTokensHandler ()
		{
			if (cb_getPendingDeliveryTokens == null)
				cb_getPendingDeliveryTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingDeliveryTokens);
			return cb_getPendingDeliveryTokens;
		}

		static IntPtr n_GetPendingDeliveryTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
		[Register ("getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetGetPendingDeliveryTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] GetPendingDeliveryTokens ()
		{
			const string __id = "getPendingDeliveryTokens.()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
			} finally {
			}
		}

		static Delegate cb_getTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_getTopic_Ljava_lang_String_ == null)
				cb_getTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTopic_Ljava_lang_String_);
			return cb_getTopic_Ljava_lang_String_;
		}

		static IntPtr n_GetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTopic (topic));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;", "GetGetTopic_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic GetTopic (string topic)
		{
			const string __id = "getTopic.(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_topic);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_messageArrivedComplete_II;
#pragma warning disable 0169
		static Delegate GetMessageArrivedComplete_IIHandler ()
		{
			if (cb_messageArrivedComplete_II == null)
				cb_messageArrivedComplete_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_MessageArrivedComplete_II);
			return cb_messageArrivedComplete_II;
		}

		static void n_MessageArrivedComplete_II (IntPtr jnienv, IntPtr native__this, int messageId, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("messageArrivedComplete", "(II)V", "GetMessageArrivedComplete_IIHandler")]
		public virtual unsafe void MessageArrivedComplete (int messageId, int qos)
		{
			const string __id = "messageArrivedComplete.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (messageId);
				__args [1] = new JniArgumentValue (qos);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZ == null)
				cb_publish_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZ);
			return cb_publish_Ljava_lang_String_arrayBIZ;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_payload, int qos, bool retained)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, payload, qos, retained));
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, byte[] payload, int qos, bool retained)
		{
			const string __id = "publish.(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue (native_payload);
				__args [2] = new JniArgumentValue (qos);
				__args [3] = new JniArgumentValue (retained);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_payload, int qos, bool retained, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, payload, qos, retained, userContext, @callback));
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, byte[] payload, int qos, bool retained, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "publish.(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue (native_payload);
				__args [2] = new JniArgumentValue (qos);
				__args [3] = new JniArgumentValue (retained);
				__args [4] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message)
		{
			const string __id = "publish.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_message, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, message, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "publish.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;";
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_topic);
				__args [1] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [2] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public virtual unsafe void Reconnect ()
		{
			const string __id = "reconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
#pragma warning disable 0169
		static Delegate GetSetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_Handler ()
		{
			if (cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ == null)
				cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_);
			return cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
		}

		static void n_SetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bufferOpts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions bufferOpts = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (native_bufferOpts, JniHandleOwnership.DoNotTransfer);
			__this.SetBufferOpts (bufferOpts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setBufferOpts' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.DisconnectedBufferOptions']]"
		[Register ("setBufferOpts", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", "GetSetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_Handler")]
		public virtual unsafe void SetBufferOpts (global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions bufferOpts)
		{
			const string __id = "setBufferOpts.(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bufferOpts == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bufferOpts).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler ()
		{
			if (cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == null)
				cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_);
			return cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		}

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback @callback)
		{
			const string __id = "setCallback.(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setManualAcks_Z;
#pragma warning disable 0169
		static Delegate GetSetManualAcks_ZHandler ()
		{
			if (cb_setManualAcks_Z == null)
				cb_setManualAcks_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetManualAcks_Z);
			return cb_setManualAcks_Z;
		}

		static void n_SetManualAcks_Z (IntPtr jnienv, IntPtr native__this, bool manualAcks)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setManualAcks", "(Z)V", "GetSetManualAcks_ZHandler")]
		public virtual unsafe void SetManualAcks (bool manualAcks)
		{
			const string __id = "setManualAcks.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (manualAcks);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_IHandler ()
		{
			if (cb_subscribe_Ljava_lang_String_I == null)
				cb_subscribe_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Subscribe_Ljava_lang_String_I);
			return cb_subscribe_Ljava_lang_String_I;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos)
		{
			const string __id = "subscribe.(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue (qos);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "subscribe.(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue (qos);
				__args [2] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_userContext, IntPtr native__callback, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, userContext, @callback, messageListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			const string __id = "subscribe.(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue (qos);
				__args [2] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue ((messageListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, messageListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			const string __id = "subscribe.(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue (qos);
				__args [2] = new JniArgumentValue ((messageListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayI == null)
				cb_subscribe_arrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayI);
			return cb_subscribe_arrayLjava_lang_String_arrayI;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos)
		{
			const string __id = "subscribe.([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topicFilters);
				__args [1] = new JniArgumentValue (native_qos);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, userContext, @callback));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "subscribe.([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_topicFilters);
				__args [1] = new JniArgumentValue (native_qos);
				__args [2] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_userContext, IntPtr native__callback, IntPtr native_messageListeners)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_messageListeners, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, userContext, @callback, messageListeners));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			if (messageListeners != null)
				JNIEnv.CopyArray (messageListeners, native_messageListeners);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners)
		{
			const string __id = "subscribe.([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			IntPtr native_messageListeners = JNIEnv.NewArray (messageListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_topicFilters);
				__args [1] = new JniArgumentValue (native_qos);
				__args [2] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue (native_messageListeners);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
				if (messageListeners != null) {
					JNIEnv.CopyArray (native_messageListeners, messageListeners);
					JNIEnv.DeleteLocalRef (native_messageListeners);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_messageListeners)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_messageListeners, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, messageListeners));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			if (messageListeners != null)
				JNIEnv.CopyArray (messageListeners, native_messageListeners);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners)
		{
			const string __id = "subscribe.([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			IntPtr native_messageListeners = JNIEnv.NewArray (messageListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topicFilters);
				__args [1] = new JniArgumentValue (native_qos);
				__args [2] = new JniArgumentValue (native_messageListeners);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
				if (messageListeners != null) {
					JNIEnv.CopyArray (native_messageListeners, messageListeners);
					JNIEnv.DeleteLocalRef (native_messageListeners);
				}
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_ == null)
				cb_unsubscribe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_);
			return cb_unsubscribe_Ljava_lang_String_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string topicFilter)
		{
			const string __id = "unsubscribe.(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_topicFilter);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilter, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string topicFilter, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "unsubscribe.(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_ == null)
				cb_unsubscribe_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_);
			return cb_unsubscribe_arrayLjava_lang_String_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilters));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] topicFilters)
		{
			const string __id = "unsubscribe.([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_topicFilters);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
			}
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilters, userContext, @callback));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] topicFilters, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			const string __id = "unsubscribe.([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;";
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topicFilters);
				__args [1] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
			}
		}

	}
}
