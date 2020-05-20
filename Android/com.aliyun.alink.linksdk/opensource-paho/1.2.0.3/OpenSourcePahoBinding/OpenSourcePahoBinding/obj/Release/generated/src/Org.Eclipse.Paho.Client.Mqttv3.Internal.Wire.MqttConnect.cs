using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttConnect", DoNotGenerateAcw=true)]
	public partial class MqttConnect : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttConnect", typeof (MqttConnect));
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

		protected MqttConnect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']/constructor[@name='MqttConnect' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(B[B)V", "")]
		public unsafe MqttConnect (sbyte info, byte[] data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(B[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (info);
				__args [1] = new JniArgumentValue (native_data);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']/constructor[@name='MqttConnect' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='char[]'] and parameter[7][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;IZILjava/lang/String;[CLorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/String;)V", "")]
		public unsafe MqttConnect (string clientId, int MqttVersion, bool cleanSession, int keepAliveInterval, string userName, char[] password, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage willMessage, string willDestination)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZILjava/lang/String;[CLorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_userName = JNIEnv.NewString (userName);
			IntPtr native_password = JNIEnv.NewArray (password);
			IntPtr native_willDestination = JNIEnv.NewString (willDestination);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (MqttVersion);
				__args [2] = new JniArgumentValue (cleanSession);
				__args [3] = new JniArgumentValue (keepAliveInterval);
				__args [4] = new JniArgumentValue (native_userName);
				__args [5] = new JniArgumentValue (native_password);
				__args [6] = new JniArgumentValue ((willMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) willMessage).Handle);
				__args [7] = new JniArgumentValue (native_willDestination);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_userName);
				if (password != null) {
					JNIEnv.CopyArray (native_password, password);
					JNIEnv.DeleteLocalRef (native_password);
				}
				JNIEnv.DeleteLocalRef (native_willDestination);
			}
		}

		static Delegate cb_isCleanSession;
#pragma warning disable 0169
		static Delegate GetIsCleanSessionHandler ()
		{
			if (cb_isCleanSession == null)
				cb_isCleanSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCleanSession);
			return cb_isCleanSession;
		}

		static bool n_IsCleanSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCleanSession;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCleanSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']/method[@name='isCleanSession' and count(parameter)=0]"
			[Register ("isCleanSession", "()Z", "GetIsCleanSessionHandler")]
			get {
				const string __id = "isCleanSession.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageInfo;
		}
#pragma warning restore 0169

		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']/method[@name='getMessageInfo' and count(parameter)=0]"
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

		static Delegate cb_getVariableHeader;
#pragma warning disable 0169
		static Delegate GetGetVariableHeaderHandler ()
		{
			if (cb_getVariableHeader == null)
				cb_getVariableHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariableHeader);
			return cb_getVariableHeader;
		}

		static IntPtr n_GetVariableHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVariableHeader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnect']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected override unsafe byte[] GetVariableHeader ()
		{
			const string __id = "getVariableHeader.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
