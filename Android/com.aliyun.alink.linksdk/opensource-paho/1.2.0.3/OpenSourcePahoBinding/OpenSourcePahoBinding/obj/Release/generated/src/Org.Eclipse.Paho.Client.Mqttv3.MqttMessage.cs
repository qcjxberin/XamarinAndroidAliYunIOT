using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttMessage", DoNotGenerateAcw=true)]
	public partial class MqttMessage : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttMessage", typeof (MqttMessage));
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

		protected MqttMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttMessage ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MqttMessage (byte[] payload)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_payload);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_I;
#pragma warning disable 0169
		static Delegate GetSetId_IHandler ()
		{
			if (cb_setId_I == null)
				cb_setId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetId_I);
			return cb_setId_I;
		}

		static void n_SetId_I (IntPtr jnienv, IntPtr native__this, int messageId)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = messageId;
		}
#pragma warning restore 0169

		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setId", "(I)V", "GetSetId_IHandler")]
			set {
				const string __id = "setId.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDuplicate;
#pragma warning disable 0169
		static Delegate GetIsDuplicateHandler ()
		{
			if (cb_isDuplicate == null)
				cb_isDuplicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDuplicate);
			return cb_isDuplicate;
		}

		static bool n_IsDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDuplicate;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDuplicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isDuplicate' and count(parameter)=0]"
			[Register ("isDuplicate", "()Z", "GetIsDuplicateHandler")]
			get {
				const string __id = "isDuplicate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getQos;
#pragma warning disable 0169
		static Delegate GetGetQosHandler ()
		{
			if (cb_getQos == null)
				cb_getQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQos);
			return cb_getQos;
		}

		static int n_GetQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qos;
		}
#pragma warning restore 0169

		static Delegate cb_setQos_I;
#pragma warning disable 0169
		static Delegate GetSetQos_IHandler ()
		{
			if (cb_setQos_I == null)
				cb_setQos_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQos_I);
			return cb_setQos_I;
		}

		static void n_SetQos_I (IntPtr jnienv, IntPtr native__this, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Qos = qos;
		}
#pragma warning restore 0169

		public virtual unsafe int Qos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getQos' and count(parameter)=0]"
			[Register ("getQos", "()I", "GetGetQosHandler")]
			get {
				const string __id = "getQos.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setQos' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQos", "(I)V", "GetSetQos_IHandler")]
			set {
				const string __id = "setQos.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRetained;
#pragma warning disable 0169
		static Delegate GetIsRetainedHandler ()
		{
			if (cb_isRetained == null)
				cb_isRetained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetained);
			return cb_isRetained;
		}

		static bool n_IsRetained (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retained;
		}
#pragma warning restore 0169

		static Delegate cb_setRetained_Z;
#pragma warning disable 0169
		static Delegate GetSetRetained_ZHandler ()
		{
			if (cb_setRetained_Z == null)
				cb_setRetained_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRetained_Z);
			return cb_setRetained_Z;
		}

		static void n_SetRetained_Z (IntPtr jnienv, IntPtr native__this, bool retained)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retained = retained;
		}
#pragma warning restore 0169

		public virtual unsafe bool Retained {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isRetained' and count(parameter)=0]"
			[Register ("isRetained", "()Z", "GetIsRetainedHandler")]
			get {
				const string __id = "isRetained.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setRetained' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetained", "(Z)V", "GetSetRetained_ZHandler")]
			set {
				const string __id = "setRetained.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkMutable;
#pragma warning disable 0169
		static Delegate GetCheckMutableHandler ()
		{
			if (cb_checkMutable == null)
				cb_checkMutable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckMutable);
			return cb_checkMutable;
		}

		static void n_CheckMutable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckMutable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='checkMutable' and count(parameter)=0]"
		[Register ("checkMutable", "()V", "GetCheckMutableHandler")]
		protected virtual unsafe void CheckMutable ()
		{
			const string __id = "checkMutable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearPayload;
#pragma warning disable 0169
		static Delegate GetClearPayloadHandler ()
		{
			if (cb_clearPayload == null)
				cb_clearPayload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPayload);
			return cb_clearPayload;
		}

		static void n_ClearPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPayload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='clearPayload' and count(parameter)=0]"
		[Register ("clearPayload", "()V", "GetClearPayloadHandler")]
		public virtual unsafe void ClearPayload ()
		{
			const string __id = "clearPayload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getPayload;
#pragma warning disable 0169
		static Delegate GetGetPayloadHandler ()
		{
			if (cb_getPayload == null)
				cb_getPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayload);
			return cb_getPayload;
		}

		static IntPtr n_GetPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual unsafe byte[] GetPayload ()
		{
			const string __id = "getPayload.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
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

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool dup)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (dup);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		protected virtual unsafe void SetDuplicate (bool dup)
		{
			const string __id = "setDuplicate.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dup);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMutable_Z;
#pragma warning disable 0169
		static Delegate GetSetMutable_ZHandler ()
		{
			if (cb_setMutable_Z == null)
				cb_setMutable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMutable_Z);
			return cb_setMutable_Z;
		}

		static void n_SetMutable_Z (IntPtr jnienv, IntPtr native__this, bool mutable)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMutable (mutable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setMutable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMutable", "(Z)V", "GetSetMutable_ZHandler")]
		protected virtual unsafe void SetMutable (bool mutable)
		{
			const string __id = "setMutable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mutable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (payload);
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler")]
		public virtual unsafe void SetPayload (byte[] payload)
		{
			const string __id = "setPayload.([B)V";
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_payload);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='validateQos' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("validateQos", "(I)V", "")]
		public static unsafe void ValidateQos (int qos)
		{
			const string __id = "validateQos.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (qos);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
