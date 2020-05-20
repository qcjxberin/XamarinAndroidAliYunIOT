using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttDeliveryToken']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttDeliveryToken", DoNotGenerateAcw=true)]
	public partial class MqttDeliveryToken : global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttDeliveryToken", typeof (MqttDeliveryToken));
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

		protected MqttDeliveryToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttDeliveryToken']/constructor[@name='MqttDeliveryToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttDeliveryToken ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttDeliveryToken']/constructor[@name='MqttDeliveryToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MqttDeliveryToken (string logContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_logContext = JNIEnv.NewString (logContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_logContext);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logContext);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttDeliveryToken']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Lorg/eclipse/paho/client/mqttv3/MqttMessage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage msg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.SetMessage (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttDeliveryToken']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("setMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		protected virtual unsafe void SetMessage (global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage msg)
		{
			const string __id = "setMessage.(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
