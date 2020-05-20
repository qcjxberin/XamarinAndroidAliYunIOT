using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttReceivedMessage", DoNotGenerateAcw=true)]
	public partial class MqttReceivedMessage : global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttReceivedMessage", typeof (MqttReceivedMessage));
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

		protected MqttReceivedMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/constructor[@name='MqttReceivedMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttReceivedMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageId);
			return cb_getMessageId;
		}

		static int n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageId_I;
#pragma warning disable 0169
		static Delegate GetSetMessageId_IHandler ()
		{
			if (cb_setMessageId_I == null)
				cb_setMessageId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageId_I);
			return cb_setMessageId_I;
		}

		static void n_SetMessageId_I (IntPtr jnienv, IntPtr native__this, int msgId)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = msgId;
		}
#pragma warning restore 0169

		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				const string __id = "getMessageId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageId", "(I)V", "GetSetMessageId_IHandler")]
			set {
				const string __id = "setMessageId.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttReceivedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttReceivedMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		public virtual unsafe void SetDuplicate (bool value)
		{
			const string __id = "setDuplicate.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
