using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttOutputStream", DoNotGenerateAcw=true)]
	public partial class MqttOutputStream : global::Java.IO.OutputStream {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttOutputStream", typeof (MqttOutputStream));
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

		protected MqttOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/constructor[@name='MqttOutputStream' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[2][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V", "")]
		public unsafe MqttOutputStream (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState, global::System.IO.Stream @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clientState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientState).Handle);
				__args [1] = new JniArgumentValue (native__out);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_Write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Write (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("write", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetWrite_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe void Write (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "write.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
