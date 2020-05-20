using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnack']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttConnack", DoNotGenerateAcw=true)]
	public partial class MqttConnack : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttAck {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttConnack", typeof (MqttConnack));
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

		protected MqttConnack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnack']/constructor[@name='MqttConnack' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(B[B)V", "")]
		public unsafe MqttConnack (sbyte info, byte[] variableHeader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(B[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_variableHeader = JNIEnv.NewArray (variableHeader);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (info);
				__args [1] = new JniArgumentValue (native_variableHeader);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (variableHeader != null) {
					JNIEnv.CopyArray (native_variableHeader, variableHeader);
					JNIEnv.DeleteLocalRef (native_variableHeader);
				}
			}
		}

		static Delegate cb_getReturnCode;
#pragma warning disable 0169
		static Delegate GetGetReturnCodeHandler ()
		{
			if (cb_getReturnCode == null)
				cb_getReturnCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReturnCode);
			return cb_getReturnCode;
		}

		static int n_GetReturnCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReturnCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ReturnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnack']/method[@name='getReturnCode' and count(parameter)=0]"
			[Register ("getReturnCode", "()I", "GetGetReturnCodeHandler")]
			get {
				const string __id = "getReturnCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSessionPresent;
#pragma warning disable 0169
		static Delegate GetGetSessionPresentHandler ()
		{
			if (cb_getSessionPresent == null)
				cb_getSessionPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSessionPresent);
			return cb_getSessionPresent;
		}

		static bool n_GetSessionPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool SessionPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnack']/method[@name='getSessionPresent' and count(parameter)=0]"
			[Register ("getSessionPresent", "()Z", "GetGetSessionPresentHandler")]
			get {
				const string __id = "getSessionPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVariableHeader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttConnack']/method[@name='getVariableHeader' and count(parameter)=0]"
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
