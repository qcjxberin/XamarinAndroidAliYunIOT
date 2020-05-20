using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ClientComms", DoNotGenerateAcw=true)]
	public partial class ClientComms : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/field[@name='BUILD_LEVEL']"
		[Register ("BUILD_LEVEL")]
		public static string BuildLevel {
			get {
				const string __id = "BUILD_LEVEL.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BUILD_LEVEL.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/field[@name='VERSION']"
		[Register ("VERSION")]
		public static string Version {
			get {
				const string __id = "VERSION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "VERSION.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms.ReconnectDisconnectedBufferCallback']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ClientComms$ReconnectDisconnectedBufferCallback", DoNotGenerateAcw=true)]
		public partial class ReconnectDisconnectedBufferCallback : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ClientComms$ReconnectDisconnectedBufferCallback", typeof (ReconnectDisconnectedBufferCallback));
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

			protected ReconnectDisconnectedBufferCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_;
#pragma warning disable 0169
			static Delegate GetPublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_Handler ()
			{
				if (cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ == null)
					cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_);
				return cb_publishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_;
			}

			static void n_PublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bufferedMessage)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms.ReconnectDisconnectedBufferCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms.ReconnectDisconnectedBufferCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage bufferedMessage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage> (native_bufferedMessage, JniHandleOwnership.DoNotTransfer);
				__this.PublishBufferedMessage (bufferedMessage);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms.ReconnectDisconnectedBufferCallback']/method[@name='publishBufferedMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.BufferedMessage']]"
			[Register ("publishBufferedMessage", "(Lorg/eclipse/paho/client/mqttv3/BufferedMessage;)V", "GetPublishBufferedMessage_Lorg_eclipse_paho_client_mqttv3_BufferedMessage_Handler")]
			public virtual unsafe void PublishBufferedMessage (global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage bufferedMessage)
			{
				const string __id = "publishBufferedMessage.(Lorg/eclipse/paho/client/mqttv3/BufferedMessage;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((bufferedMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bufferedMessage).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ClientComms", typeof (ClientComms));
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

		protected ClientComms (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/constructor[@name='ClientComms' and count(parameter)=4 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttAsyncClient'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttPingSender'] and parameter[4][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe ClientComms (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient client, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender, global::Java.Util.Concurrent.IExecutorService executorService)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;Ljava/util/concurrent/ExecutorService;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((persistence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistence).Handle);
				__args [2] = new JniArgumentValue ((pingSender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pingSender).Handle);
				__args [3] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActualInFlight;
		}
#pragma warning restore 0169

		public virtual unsafe int ActualInFlight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getActualInFlight' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedMessageCount;
		}
#pragma warning restore 0169

		public virtual unsafe int BufferedMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getBufferedMessageCount' and count(parameter)=0]"
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

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;", "GetGetClientHandler")]
			get {
				const string __id = "getClient.()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientState;
#pragma warning disable 0169
		static Delegate GetGetClientStateHandler ()
		{
			if (cb_getClientState == null)
				cb_getClientState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientState);
			return cb_getClientState;
		}

		static IntPtr n_GetClientState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState ClientState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getClientState' and count(parameter)=0]"
			[Register ("getClientState", "()Lorg/eclipse/paho/client/mqttv3/internal/ClientState;", "GetGetClientStateHandler")]
			get {
				const string __id = "getClientState.()Lorg/eclipse/paho/client/mqttv3/internal/ClientState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConOptions;
#pragma warning disable 0169
		static Delegate GetGetConOptionsHandler ()
		{
			if (cb_getConOptions == null)
				cb_getConOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConOptions);
			return cb_getConOptions;
		}

		static IntPtr n_GetConOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConOptions);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions ConOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getConOptions' and count(parameter)=0]"
			[Register ("getConOptions", "()Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;", "GetGetConOptionsHandler")]
			get {
				const string __id = "getConOptions.()Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Properties Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getDebug' and count(parameter)=0]"
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

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isConnected' and count(parameter)=0]"
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

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				const string __id = "isConnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDisconnected;
#pragma warning disable 0169
		static Delegate GetIsDisconnectedHandler ()
		{
			if (cb_isDisconnected == null)
				cb_isDisconnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisconnected);
			return cb_isDisconnected;
		}

		static bool n_IsDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisconnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDisconnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isDisconnected' and count(parameter)=0]"
			[Register ("isDisconnected", "()Z", "GetIsDisconnectedHandler")]
			get {
				const string __id = "isDisconnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDisconnecting;
#pragma warning disable 0169
		static Delegate GetIsDisconnectingHandler ()
		{
			if (cb_isDisconnecting == null)
				cb_isDisconnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisconnecting);
			return cb_isDisconnecting;
		}

		static bool n_IsDisconnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisconnecting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDisconnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isDisconnecting' and count(parameter)=0]"
			[Register ("isDisconnecting", "()Z", "GetIsDisconnectingHandler")]
			get {
				const string __id = "isDisconnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isResting;
#pragma warning disable 0169
		static Delegate GetIsRestingHandler ()
		{
			if (cb_isResting == null)
				cb_isResting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsResting);
			return cb_isResting;
		}

		static bool n_IsResting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsResting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsResting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isResting' and count(parameter)=0]"
			[Register ("isResting", "()Z", "GetIsRestingHandler")]
			get {
				const string __id = "isResting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepAlive;
		}
#pragma warning restore 0169

		public virtual unsafe long KeepAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getKeepAlive' and count(parameter)=0]"
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

		static Delegate cb_getNetworkModuleIndex;
#pragma warning disable 0169
		static Delegate GetGetNetworkModuleIndexHandler ()
		{
			if (cb_getNetworkModuleIndex == null)
				cb_getNetworkModuleIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNetworkModuleIndex);
			return cb_getNetworkModuleIndex;
		}

		static int n_GetNetworkModuleIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkModuleIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkModuleIndex_I;
#pragma warning disable 0169
		static Delegate GetSetNetworkModuleIndex_IHandler ()
		{
			if (cb_setNetworkModuleIndex_I == null)
				cb_setNetworkModuleIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNetworkModuleIndex_I);
			return cb_setNetworkModuleIndex_I;
		}

		static void n_SetNetworkModuleIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkModuleIndex = index;
		}
#pragma warning restore 0169

		public virtual unsafe int NetworkModuleIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getNetworkModuleIndex' and count(parameter)=0]"
			[Register ("getNetworkModuleIndex", "()I", "GetGetNetworkModuleIndexHandler")]
			get {
				const string __id = "getNetworkModuleIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setNetworkModuleIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNetworkModuleIndex", "(I)V", "GetSetNetworkModuleIndex_IHandler")]
			set {
				const string __id = "setNetworkModuleIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkForActivity;
#pragma warning disable 0169
		static Delegate GetCheckForActivityHandler ()
		{
			if (cb_checkForActivity == null)
				cb_checkForActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CheckForActivity);
			return cb_checkForActivity;
		}

		static IntPtr n_CheckForActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckForActivity ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='checkForActivity' and count(parameter)=0]"
		[Register ("checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetCheckForActivityHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken CheckForActivity ()
		{
			const string __id = "checkForActivity.()Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener pingCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_pingCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckForActivity (pingCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='checkForActivity' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (force);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='close' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Connect (options, token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "connect.(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cack, IntPtr native_mex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack cack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack> (native_cack, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException mex = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_mex, JniHandleOwnership.DoNotTransfer);
			__this.ConnectComplete (cack, mex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='connectComplete' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttConnack'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("connectComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttConnack;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ConnectComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack cack, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException mex)
		{
			const string __id = "connectComplete.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttConnack;Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cack).Handle);
				__args [1] = new JniArgumentValue ((mex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) mex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteBufferedMessage (bufferIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deleteBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (messageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish msg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish msg)
		{
			const string __id = "deliveryComplete.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disconnect, long quiesceTimeout, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect disconnect = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect> (native_disconnect, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (disconnect, quiesceTimeout, token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttDisconnect'] and parameter[2][@type='long'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("disconnect", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttDisconnect;JLorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetDisconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Disconnect (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect disconnect, long quiesceTimeout, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "disconnect.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttDisconnect;JLorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((disconnect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) disconnect).Handle);
				__args [1] = new JniArgumentValue (quiesceTimeout);
				__args [2] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout, sendDisconnectPacket);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnectForcibly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBufferedMessage (bufferIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getNetworkModules;
#pragma warning disable 0169
		static Delegate GetGetNetworkModulesHandler ()
		{
			if (cb_getNetworkModules == null)
				cb_getNetworkModules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkModules);
			return cb_getNetworkModules;
		}

		static IntPtr n_GetNetworkModules (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNetworkModules ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getNetworkModules' and count(parameter)=0]"
		[Register ("getNetworkModules", "()[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;", "GetGetNetworkModulesHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] GetNetworkModules ()
		{
			const string __id = "getNetworkModules.()[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
		[Register ("getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetGetPendingDeliveryTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[] GetPendingDeliveryTokens ()
		{
			const string __id = "getPendingDeliveryTokens.()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTopic (topic));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_notifyConnect;
#pragma warning disable 0169
		static Delegate GetNotifyConnectHandler ()
		{
			if (cb_notifyConnect == null)
				cb_notifyConnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyConnect);
			return cb_notifyConnect;
		}

		static void n_NotifyConnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyConnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='notifyConnect' and count(parameter)=0]"
		[Register ("notifyConnect", "()V", "GetNotifyConnectHandler")]
		public virtual unsafe void NotifyConnect ()
		{
			const string __id = "notifyConnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeMessageListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMessageListener_Ljava_lang_String_Handler ()
		{
			if (cb_removeMessageListener_Ljava_lang_String_ == null)
				cb_removeMessageListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMessageListener_Ljava_lang_String_);
			return cb_removeMessageListener_Ljava_lang_String_;
		}

		static void n_RemoveMessageListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListener (topicFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='removeMessageListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMessageListener", "(Ljava/lang/String;)V", "GetRemoveMessageListener_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMessageListener (string topicFilter)
		{
			const string __id = "removeMessageListener.(Ljava/lang/String;)V";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_topicFilter);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetSendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_SendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.SendNoWait (message, token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='sendNoWait' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("sendNoWait", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetSendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void SendNoWait (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "sendNoWait.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [1] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
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

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mqttCallback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_mqttCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (mqttCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback)
		{
			const string __id = "setCallback.(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mqttCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mqttCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_;
#pragma warning disable 0169
		static Delegate GetSetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_Handler ()
		{
			if (cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ == null)
				cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_);
			return cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_;
		}

		static void n_SetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disconnectedMessageBuffer)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer disconnectedMessageBuffer = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (native_disconnectedMessageBuffer, JniHandleOwnership.DoNotTransfer);
			__this.SetDisconnectedMessageBuffer (disconnectedMessageBuffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setDisconnectedMessageBuffer' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.DisconnectedMessageBuffer']]"
		[Register ("setDisconnectedMessageBuffer", "(Lorg/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer;)V", "GetSetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_Handler")]
		public virtual unsafe void SetDisconnectedMessageBuffer (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer disconnectedMessageBuffer)
		{
			const string __id = "setDisconnectedMessageBuffer.(Lorg/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((disconnectedMessageBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) disconnectedMessageBuffer).Handle);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static void n_SetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageListener (topicFilter, messageListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setMessageListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("setMessageListener", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)V", "GetSetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe void SetMessageListener (string topicFilter, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			const string __id = "setMessageListener.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)V";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue ((messageListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_;
#pragma warning disable 0169
		static Delegate GetSetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_Handler ()
		{
			if (cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ == null)
				cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_);
			return cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_;
		}

		static void n_SetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkModules)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] networkModules = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (native_networkModules, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
			__this.SetNetworkModules (networkModules);
			if (networkModules != null)
				JNIEnv.CopyArray (networkModules, native_networkModules);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setNetworkModules' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.NetworkModule[]']]"
		[Register ("setNetworkModules", "([Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;)V", "GetSetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_Handler")]
		public virtual unsafe void SetNetworkModules (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] networkModules)
		{
			const string __id = "setNetworkModules.([Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;)V";
			IntPtr native_networkModules = JNIEnv.NewArray (networkModules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_networkModules);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (networkModules != null) {
					JNIEnv.CopyArray (native_networkModules, networkModules);
					JNIEnv.DeleteLocalRef (native_networkModules);
				}
			}
		}

		static Delegate cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
#pragma warning disable 0169
		static Delegate GetSetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler ()
		{
			if (cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ == null)
				cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_);
			return cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
		}

		static void n_SetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetReconnectCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setReconnectCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallbackExtended']]"
		[Register ("setReconnectCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V", "GetSetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler")]
		public virtual unsafe void SetReconnectCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback)
		{
			const string __id = "setReconnectCallback.(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRestingState_Z;
#pragma warning disable 0169
		static Delegate GetSetRestingState_ZHandler ()
		{
			if (cb_setRestingState_Z == null)
				cb_setRestingState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRestingState_Z);
			return cb_setRestingState_Z;
		}

		static void n_SetRestingState_Z (IntPtr jnienv, IntPtr native__this, bool resting)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRestingState (resting);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setRestingState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRestingState", "(Z)V", "GetSetRestingState_ZHandler")]
		public virtual unsafe void SetRestingState (bool resting)
		{
			const string __id = "setRestingState.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resting);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token, IntPtr native_reason)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.ShutdownConnection (token, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='shutdownConnection' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("shutdownConnection", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ShutdownConnection (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason)
		{
			const string __id = "shutdownConnection.(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				__args [1] = new JniArgumentValue ((reason == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) reason).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
