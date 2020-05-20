using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ConnectActionListener", DoNotGenerateAcw=true)]
	public partial class ConnectActionListener : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ConnectActionListener", typeof (ConnectActionListener));
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

		protected ConnectActionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/constructor[@name='ConnectActionListener' and count(parameter)=8 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttAsyncClient'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Z)V", "")]
		public unsafe ConnectActionListener (global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient client, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms comms, global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken userToken, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener userCallback, bool reconnect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/MqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				__args [2] = new JniArgumentValue ((comms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comms).Handle);
				__args [3] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [4] = new JniArgumentValue ((userToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userToken).Handle);
				__args [5] = new JniArgumentValue ((userContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userContext).Handle);
				__args [6] = new JniArgumentValue ((userCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userCallback).Handle);
				__args [7] = new JniArgumentValue (reconnect);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == null)
				cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_);
			return cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token, IntPtr native_exception)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken token = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (token, exception);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V", "GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken token, global::Java.Lang.Throwable exception)
		{
			const string __id = "onFailure.(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
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

		static void n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken token = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken']]"
		[Register ("onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V", "GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler")]
		public virtual unsafe void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken token)
		{
			const string __id = "onSuccess.(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
#pragma warning disable 0169
		static Delegate GetSetMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler ()
		{
			if (cb_setMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ == null)
				cb_setMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_);
			return cb_setMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
		}

		static void n_SetMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mqttCallbackExtended)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ConnectActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended mqttCallbackExtended = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (native_mqttCallbackExtended, JniHandleOwnership.DoNotTransfer);
			__this.SetMqttCallbackExtended (mqttCallbackExtended);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ConnectActionListener']/method[@name='setMqttCallbackExtended' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallbackExtended']]"
		[Register ("setMqttCallbackExtended", "(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V", "GetSetMqttCallbackExtended_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler")]
		public virtual unsafe void SetMqttCallbackExtended (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended mqttCallbackExtended)
		{
			const string __id = "setMqttCallbackExtended.(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mqttCallbackExtended == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mqttCallbackExtended).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
