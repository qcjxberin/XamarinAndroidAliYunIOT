using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ClientState", DoNotGenerateAcw=true)]
	public partial class ClientState : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ClientState", typeof (ClientState));
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

		protected ClientState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/constructor[@name='ClientState' and count(parameter)=5 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.CommsTokenStore'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.CommsCallback'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.MqttPingSender']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", "")]
		protected unsafe ClientState (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore tokenStore, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback @callback, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms clientComms, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Lorg/eclipse/paho/client/mqttv3/internal/CommsCallback;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				__args [1] = new JniArgumentValue ((tokenStore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenStore).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [3] = new JniArgumentValue ((clientComms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientComms).Handle);
				__args [4] = new JniArgumentValue ((pingSender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pingSender).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getActualInFlight;
#pragma warning disable 0169
		static Delegate GetGetActualInFlightHandler ()
		{
			if (cb_getActualInFlight == null)
				cb_getActualInFlight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActualInFlight);
			return cb_getActualInFlight;
		}

		static int n_GetActualInFlight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActualInFlight;
		}
#pragma warning restore 0169

		public virtual unsafe int ActualInFlight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getActualInFlight' and count(parameter)=0]"
			[Register ("getActualInFlight", "()I", "GetGetActualInFlightHandler")]
			get {
				const string __id = "getActualInFlight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCleanSession;
#pragma warning disable 0169
		static Delegate GetGetCleanSessionHandler ()
		{
			if (cb_getCleanSession == null)
				cb_getCleanSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCleanSession);
			return cb_getCleanSession;
		}

		static bool n_GetCleanSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CleanSession;
		}
#pragma warning restore 0169

		static Delegate cb_setCleanSession_Z;
#pragma warning disable 0169
		static Delegate GetSetCleanSession_ZHandler ()
		{
			if (cb_setCleanSession_Z == null)
				cb_setCleanSession_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCleanSession_Z);
			return cb_setCleanSession_Z;
		}

		static void n_SetCleanSession_Z (IntPtr jnienv, IntPtr native__this, bool cleanSession)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanSession = cleanSession;
		}
#pragma warning restore 0169

		protected virtual unsafe bool CleanSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getCleanSession' and count(parameter)=0]"
			[Register ("getCleanSession", "()Z", "GetGetCleanSessionHandler")]
			get {
				const string __id = "getCleanSession.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setCleanSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCleanSession", "(Z)V", "GetSetCleanSession_ZHandler")]
			set {
				const string __id = "setCleanSession.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Properties Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getDebug' and count(parameter)=0]"
			[Register ("getDebug", "()Ljava/util/Properties;", "GetGetDebugHandler")]
			get {
				const string __id = "getDebug.()Ljava/util/Properties;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeepAlive;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveHandler ()
		{
			if (cb_getKeepAlive == null)
				cb_getKeepAlive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetKeepAlive);
			return cb_getKeepAlive;
		}

		static long n_GetKeepAlive (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepAlive;
		}
#pragma warning restore 0169

		protected virtual unsafe long KeepAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getKeepAlive' and count(parameter)=0]"
			[Register ("getKeepAlive", "()J", "GetGetKeepAliveHandler")]
			get {
				const string __id = "getKeepAlive.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxInFlight;
#pragma warning disable 0169
		static Delegate GetGetMaxInFlightHandler ()
		{
			if (cb_getMaxInFlight == null)
				cb_getMaxInFlight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxInFlight);
			return cb_getMaxInFlight;
		}

		static int n_GetMaxInFlight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxInFlight;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxInFlight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='getMaxInFlight' and count(parameter)=0]"
			[Register ("getMaxInFlight", "()I", "GetGetMaxInFlightHandler")]
			get {
				const string __id = "getMaxInFlight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetCheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_CheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pingCallback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener pingCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_pingCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckForActivity (pingCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='checkForActivity' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("checkForActivity", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetCheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken CheckForActivity (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener pingCallback)
		{
			const string __id = "checkForActivity.(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pingCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pingCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkQuiesceLock;
#pragma warning disable 0169
		static Delegate GetCheckQuiesceLockHandler ()
		{
			if (cb_checkQuiesceLock == null)
				cb_checkQuiesceLock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckQuiesceLock);
			return cb_checkQuiesceLock;
		}

		static bool n_CheckQuiesceLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckQuiesceLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='checkQuiesceLock' and count(parameter)=0]"
		[Register ("checkQuiesceLock", "()Z", "GetCheckQuiesceLockHandler")]
		protected virtual unsafe bool CheckQuiesceLock ()
		{
			const string __id = "checkQuiesceLock.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearState;
#pragma warning disable 0169
		static Delegate GetClearStateHandler ()
		{
			if (cb_clearState == null)
				cb_clearState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearState);
			return cb_clearState;
		}

		static void n_ClearState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='clearState' and count(parameter)=0]"
		[Register ("clearState", "()V", "GetClearStateHandler")]
		protected virtual unsafe void ClearState ()
		{
			const string __id = "clearState.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		protected virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connected;
#pragma warning disable 0169
		static Delegate GetConnectedHandler ()
		{
			if (cb_connected == null)
				cb_connected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connected);
			return cb_connected;
		}

		static void n_Connected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='connected' and count(parameter)=0]"
		[Register ("connected", "()V", "GetConnectedHandler")]
		public virtual unsafe void Connected ()
		{
			const string __id = "connected.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deliveryComplete_I;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_IHandler ()
		{
			if (cb_deliveryComplete_I == null)
				cb_deliveryComplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeliveryComplete_I);
			return cb_deliveryComplete_I;
		}

		static void n_DeliveryComplete_I (IntPtr jnienv, IntPtr native__this, int messageId)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (messageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deliveryComplete", "(I)V", "GetDeliveryComplete_IHandler")]
		protected virtual unsafe void DeliveryComplete (int messageId)
		{
			const string __id = "deliveryComplete.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (messageId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message)
		{
			const string __id = "deliveryComplete.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetDisconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_Disconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reason)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.Disconnected (reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='disconnected' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("disconnected", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetDisconnected_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void Disconnected (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason)
		{
			const string __id = "disconnected.(Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reason == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) reason).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Get ()
		{
			const string __id = "get.()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetNotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_notifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_NotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.NotifyComplete (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("notifyComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetNotifyComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		protected virtual unsafe void NotifyComplete (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "notifyComplete.(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyQueueLock;
#pragma warning disable 0169
		static Delegate GetNotifyQueueLockHandler ()
		{
			if (cb_notifyQueueLock == null)
				cb_notifyQueueLock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyQueueLock);
			return cb_notifyQueueLock;
		}

		static void n_NotifyQueueLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyQueueLock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyQueueLock' and count(parameter)=0]"
		[Register ("notifyQueueLock", "()V", "GetNotifyQueueLockHandler")]
		public virtual unsafe void NotifyQueueLock ()
		{
			const string __id = "notifyQueueLock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_Handler ()
		{
			if (cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ == null)
				cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_);
			return cb_notifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_;
		}

		static void n_NotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ack)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck ack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck> (native_ack, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedAck (ack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedAck' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttAck']]"
		[Register ("notifyReceivedAck", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttAck;)V", "GetNotifyReceivedAck_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttAck_Handler")]
		protected virtual unsafe void NotifyReceivedAck (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck ack)
		{
			const string __id = "notifyReceivedAck.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttAck;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyReceivedBytes_I;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedBytes_IHandler ()
		{
			if (cb_notifyReceivedBytes_I == null)
				cb_notifyReceivedBytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyReceivedBytes_I);
			return cb_notifyReceivedBytes_I;
		}

		static void n_NotifyReceivedBytes_I (IntPtr jnienv, IntPtr native__this, int receivedBytesCount)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedBytes (receivedBytesCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyReceivedBytes", "(I)V", "GetNotifyReceivedBytes_IHandler")]
		public virtual unsafe void NotifyReceivedBytes (int receivedBytesCount)
		{
			const string __id = "notifyReceivedBytes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (receivedBytesCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetNotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_notifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_NotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReceivedMsg (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyReceivedMsg' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("notifyReceivedMsg", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetNotifyReceivedMsg_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void NotifyReceivedMsg (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "notifyReceivedMsg.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetNotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_notifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_NotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ack, IntPtr native_token, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage ack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_ack, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException ex = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.NotifyResult (ack, token, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifyResult' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("notifyResult", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetNotifyResult_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void NotifyResult (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage ack, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException ex)
		{
			const string __id = "notifyResult.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((ack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ack).Handle);
				__args [1] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				__args [2] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetNotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_notifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_NotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.NotifySent (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifySent' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("notifySent", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetNotifySent_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void NotifySent (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "notifySent.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifySentBytes_I;
#pragma warning disable 0169
		static Delegate GetNotifySentBytes_IHandler ()
		{
			if (cb_notifySentBytes_I == null)
				cb_notifySentBytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifySentBytes_I);
			return cb_notifySentBytes_I;
		}

		static void n_NotifySentBytes_I (IntPtr jnienv, IntPtr native__this, int sentBytesCount)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySentBytes (sentBytesCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='notifySentBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifySentBytes", "(I)V", "GetNotifySentBytes_IHandler")]
		public virtual unsafe void NotifySentBytes (int sentBytesCount)
		{
			const string __id = "notifySentBytes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sentBytesCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_persistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_persistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_persistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_persistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_PersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.PersistBufferedMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='persistBufferedMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("persistBufferedMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe void PersistBufferedMessage (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "persistBufferedMessage.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_quiesce_J;
#pragma warning disable 0169
		static Delegate GetQuiesce_JHandler ()
		{
			if (cb_quiesce_J == null)
				cb_quiesce_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Quiesce_J);
			return cb_quiesce_J;
		}

		static void n_Quiesce_J (IntPtr jnienv, IntPtr native__this, long timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='quiesce' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("quiesce", "(J)V", "GetQuiesce_JHandler")]
		public virtual unsafe void Quiesce (long timeout)
		{
			const string __id = "quiesce.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_resolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static IntPtr n_ResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reason)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_reason, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResolveOldTokens (reason));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='resolveOldTokens' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("resolveOldTokens", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)Ljava/util/Vector;", "GetResolveOldTokens_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe global::Java.Util.Vector ResolveOldTokens (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason)
		{
			const string __id = "resolveOldTokens.(Lorg/eclipse/paho/client/mqttv3/MqttException;)Ljava/util/Vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reason == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) reason).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_restoreState;
#pragma warning disable 0169
		static Delegate GetRestoreStateHandler ()
		{
			if (cb_restoreState == null)
				cb_restoreState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RestoreState);
			return cb_restoreState;
		}

		static void n_RestoreState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='restoreState' and count(parameter)=0]"
		[Register ("restoreState", "()V", "GetRestoreStateHandler")]
		protected virtual unsafe void RestoreState ()
		{
			const string __id = "restoreState.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetSend_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Send_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Send (message, token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='send' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("send", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetSend_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Send (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "send.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [1] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setKeepAliveInterval_J;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveInterval_JHandler ()
		{
			if (cb_setKeepAliveInterval_J == null)
				cb_setKeepAliveInterval_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetKeepAliveInterval_J);
			return cb_setKeepAliveInterval_J;
		}

		static void n_SetKeepAliveInterval_J (IntPtr jnienv, IntPtr native__this, long interval)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAliveInterval (interval);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setKeepAliveInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setKeepAliveInterval", "(J)V", "GetSetKeepAliveInterval_JHandler")]
		public virtual unsafe void SetKeepAliveInterval (long interval)
		{
			const string __id = "setKeepAliveInterval.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (interval);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setKeepAliveSecs_J;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveSecs_JHandler ()
		{
			if (cb_setKeepAliveSecs_J == null)
				cb_setKeepAliveSecs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetKeepAliveSecs_J);
			return cb_setKeepAliveSecs_J;
		}

		static void n_SetKeepAliveSecs_J (IntPtr jnienv, IntPtr native__this, long keepAliveSecs)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAliveSecs (keepAliveSecs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setKeepAliveSecs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setKeepAliveSecs", "(J)V", "GetSetKeepAliveSecs_JHandler")]
		protected virtual unsafe void SetKeepAliveSecs (long keepAliveSecs)
		{
			const string __id = "setKeepAliveSecs.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keepAliveSecs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxInflight_I;
#pragma warning disable 0169
		static Delegate GetSetMaxInflight_IHandler ()
		{
			if (cb_setMaxInflight_I == null)
				cb_setMaxInflight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxInflight_I);
			return cb_setMaxInflight_I;
		}

		static void n_SetMaxInflight_I (IntPtr jnienv, IntPtr native__this, int maxInflight)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxInflight (maxInflight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='setMaxInflight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxInflight", "(I)V", "GetSetMaxInflight_IHandler")]
		protected virtual unsafe void SetMaxInflight (int maxInflight)
		{
			const string __id = "setMaxInflight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxInflight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetUnPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_unPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_unPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_unPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_UnPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.UnPersistBufferedMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='unPersistBufferedMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("unPersistBufferedMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetUnPersistBufferedMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe void UnPersistBufferedMessage (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "unPersistBufferedMessage.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetUndo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_Undo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Undo (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientState']/method[@name='undo' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("undo", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetUndo_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void Undo (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message)
		{
			const string __id = "undo.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
