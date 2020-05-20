using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", DoNotGenerateAcw=true)]
	public partial class CommsCallback : global::Java.Lang.Object, global::Java.Lang.IRunnable {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/field[@name='running']"
		[Register ("running")]
		public bool Running {
			get {
				const string __id = "running.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "running.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", typeof (CommsCallback));
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

		protected CommsCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isQuiesced;
#pragma warning disable 0169
		static Delegate GetIsQuiescedHandler ()
		{
			if (cb_isQuiesced == null)
				cb_isQuiesced = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsQuiesced);
			return cb_isQuiesced;
		}

		static bool n_IsQuiesced (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsQuiesced;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsQuiesced {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='isQuiesced' and count(parameter)=0]"
			[Register ("isQuiesced", "()Z", "GetIsQuiescedHandler")]
			get {
				const string __id = "isQuiesced.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getThread;
#pragma warning disable 0169
		static Delegate GetGetThreadHandler ()
		{
			if (cb_getThread == null)
				cb_getThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThread);
			return cb_getThread;
		}

		static IntPtr n_GetThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thread);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Thread Thread {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='getThread' and count(parameter)=0]"
			[Register ("getThread", "()Ljava/lang/Thread;", "GetGetThreadHandler")]
			get {
				const string __id = "getThread.()Ljava/lang/Thread;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.AsyncOperationComplete (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='asyncOperationComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void AsyncOperationComplete (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "asyncOperationComplete.(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException cause = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_cause, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (cause);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ConnectionLost (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException cause)
		{
			const string __id = "connectionLost.(Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetDeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_DeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static bool n_DeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicName, int messageId, IntPtr native_aMessage)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicName = JNIEnv.GetString (native_topicName, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage aMessage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_aMessage, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeliverMessage (topicName, messageId, aMessage);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='deliverMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("deliverMessage", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/MqttMessage;)Z", "GetDeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		protected virtual unsafe bool DeliverMessage (string topicName, int messageId, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage aMessage)
		{
			const string __id = "deliverMessage.(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/MqttMessage;)Z";
			IntPtr native_topicName = JNIEnv.NewString (topicName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topicName);
				__args [1] = new JniArgumentValue (messageId);
				__args [2] = new JniArgumentValue ((aMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aMessage).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicName);
			}
		}

		static Delegate cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.FireActionEvent (token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='fireActionEvent' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void FireActionEvent (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "fireActionEvent.(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sendMessage)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish sendMessage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_sendMessage, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (sendMessage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='messageArrived' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		public virtual unsafe void MessageArrived (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish sendMessage)
		{
			const string __id = "messageArrived.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sendMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sendMessage).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_quiesce;
#pragma warning disable 0169
		static Delegate GetQuiesceHandler ()
		{
			if (cb_quiesce == null)
				cb_quiesce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quiesce);
			return cb_quiesce;
		}

		static void n_Quiesce (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='quiesce' and count(parameter)=0]"
		[Register ("quiesce", "()V", "GetQuiesceHandler")]
		public virtual unsafe void Quiesce ()
		{
			const string __id = "quiesce.()V";
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListener (topicFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='removeMessageListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_removeMessageListeners;
#pragma warning disable 0169
		static Delegate GetRemoveMessageListenersHandler ()
		{
			if (cb_removeMessageListeners == null)
				cb_removeMessageListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMessageListeners);
			return cb_removeMessageListeners;
		}

		static void n_RemoveMessageListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListeners ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='removeMessageListeners' and count(parameter)=0]"
		[Register ("removeMessageListeners", "()V", "GetRemoveMessageListenersHandler")]
		public virtual unsafe void RemoveMessageListeners ()
		{
			const string __id = "removeMessageListeners.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_mqttCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (mqttCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
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

		static Delegate cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
#pragma warning disable 0169
		static Delegate GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler ()
		{
			if (cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ == null)
				cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_);
			return cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
		}

		static void n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientState)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (native_clientState, JniHandleOwnership.DoNotTransfer);
			__this.SetClientState (clientState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setClientState' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState']]"
		[Register ("setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V", "GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler")]
		public virtual unsafe void SetClientState (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState)
		{
			const string __id = "setClientState.(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clientState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientState).Handle);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageListener (topicFilter, messageListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setMessageListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetReconnectCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setReconnectCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallbackExtended']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutorService executorService = (global::Java.Util.Concurrent.IExecutorService)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (native_executorService, JniHandleOwnership.DoNotTransfer);
			__this.Start (threadName, executorService);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='start' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='stop' and count(parameter)=0]"
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
