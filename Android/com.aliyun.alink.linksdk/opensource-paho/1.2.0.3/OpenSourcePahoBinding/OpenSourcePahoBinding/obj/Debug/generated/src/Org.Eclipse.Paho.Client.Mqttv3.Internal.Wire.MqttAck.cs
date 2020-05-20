using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttAck']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttAck", DoNotGenerateAcw=true)]
	public abstract partial class MqttAck : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttAck", typeof (MqttAck));
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

		protected MqttAck (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttAck']/constructor[@name='MqttAck' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MqttAck (sbyte type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMessageInfo;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoHandler ()
		{
			if (cb_getMessageInfo == null)
				cb_getMessageInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetMessageInfo);
			return cb_getMessageInfo;
		}

		static sbyte n_GetMessageInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageInfo;
		}
#pragma warning restore 0169

		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttAck']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")]
			get {
				const string __id = "getMessageInfo.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttAck", DoNotGenerateAcw=true)]
	internal partial class MqttAckInvoker : MqttAck {

		public MqttAckInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttAck", typeof (MqttAckInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected override unsafe byte[] GetVariableHeader ()
		{
			const string __id = "getVariableHeader.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

}
