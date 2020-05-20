using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer", DoNotGenerateAcw=true)]
	public partial class DisconnectedMessageBuffer : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer", typeof (DisconnectedMessageBuffer));
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

		protected DisconnectedMessageBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/constructor[@name='DisconnectedMessageBuffer' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.DisconnectedBufferOptions']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", "")]
		public unsafe DisconnectedMessageBuffer (global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isPersistBuffer;
#pragma warning disable 0169
		static Delegate GetIsPersistBufferHandler ()
		{
			if (cb_isPersistBuffer == null)
				cb_isPersistBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPersistBuffer);
			return cb_isPersistBuffer;
		}

		static bool n_IsPersistBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPersistBuffer;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPersistBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='isPersistBuffer' and count(parameter)=0]"
			[Register ("isPersistBuffer", "()Z", "GetIsPersistBufferHandler")]
			get {
				const string __id = "isPersistBuffer.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMessageCount;
#pragma warning disable 0169
		static Delegate GetGetMessageCountHandler ()
		{
			if (cb_getMessageCount == null)
				cb_getMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageCount);
			return cb_getMessageCount;
		}

		static int n_GetMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageCount;
		}
#pragma warning restore 0169

		public virtual unsafe int MessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='getMessageCount' and count(parameter)=0]"
			[Register ("getMessageCount", "()I", "GetGetMessageCountHandler")]
			get {
				const string __id = "getMessageCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_deleteMessage_I;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_IHandler ()
		{
			if (cb_deleteMessage_I == null)
				cb_deleteMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeleteMessage_I);
			return cb_deleteMessage_I;
		}

		static void n_DeleteMessage_I (IntPtr jnienv, IntPtr native__this, int messageIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (messageIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deleteMessage", "(I)V", "GetDeleteMessage_IHandler")]
		public virtual unsafe void DeleteMessage (int messageIndex)
		{
			const string __id = "deleteMessage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (messageIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMessage_I;
#pragma warning disable 0169
		static Delegate GetGetMessage_IHandler ()
		{
			if (cb_getMessage_I == null)
				cb_getMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessage_I);
			return cb_getMessage_I;
		}

		static IntPtr n_GetMessage_I (IntPtr jnienv, IntPtr native__this, int messageIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessage (messageIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessage", "(I)Lorg/eclipse/paho/client/mqttv3/BufferedMessage;", "GetGetMessage_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage GetMessage (int messageIndex)
		{
			const string __id = "getMessage.(I)Lorg/eclipse/paho/client/mqttv3/BufferedMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (messageIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetPutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_PutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.PutMessage (message, token);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='putMessage' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("putMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetPutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void PutMessage (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			const string __id = "putMessage.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [1] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_;
#pragma warning disable 0169
		static Delegate GetSetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_Handler ()
		{
			if (cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ == null)
				cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_);
			return cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_;
		}

		static void n_SetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetPublishCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='setPublishCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.IDisconnectedBufferCallback']]"
		[Register ("setPublishCallback", "(Lorg/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback;)V", "GetSetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_Handler")]
		public virtual unsafe void SetPublishCallback (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback @callback)
		{
			const string __id = "setPublishCallback.(Lorg/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
