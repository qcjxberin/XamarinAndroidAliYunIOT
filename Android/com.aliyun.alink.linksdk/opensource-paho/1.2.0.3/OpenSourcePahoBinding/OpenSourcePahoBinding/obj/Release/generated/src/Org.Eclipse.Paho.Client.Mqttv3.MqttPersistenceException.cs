using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttPersistenceException", DoNotGenerateAcw=true)]
	public partial class MqttPersistenceException : global::Org.Eclipse.Paho.Client.Mqttv3.MqttException {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']/field[@name='REASON_CODE_PERSISTENCE_IN_USE']"
		[Register ("REASON_CODE_PERSISTENCE_IN_USE")]
		public const short ReasonCodePersistenceInUse = (short) 32200;
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttPersistenceException", typeof (MqttPersistenceException));
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

		protected MqttPersistenceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']/constructor[@name='MqttPersistenceException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttPersistenceException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']/constructor[@name='MqttPersistenceException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MqttPersistenceException (int reasonCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (reasonCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']/constructor[@name='MqttPersistenceException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/Throwable;)V", "")]
		public unsafe MqttPersistenceException (int reason, global::Java.Lang.Throwable cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (reason);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttPersistenceException']/constructor[@name='MqttPersistenceException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe MqttPersistenceException (global::Java.Lang.Throwable cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
