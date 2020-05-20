using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/MqttPersistentData", DoNotGenerateAcw=true)]
	public partial class MqttPersistentData : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/MqttPersistentData", typeof (MqttPersistentData));
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

		protected MqttPersistentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/constructor[@name='MqttPersistentData' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;[BII[BII)V", "")]
		public unsafe MqttPersistentData (string key, byte[] header, int hOffset, int hLength, byte[] payload, int pOffset, int pLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[BII[BII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_header = JNIEnv.NewArray (header);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_header);
				__args [2] = new JniArgumentValue (hOffset);
				__args [3] = new JniArgumentValue (hLength);
				__args [4] = new JniArgumentValue (native_payload);
				__args [5] = new JniArgumentValue (pOffset);
				__args [6] = new JniArgumentValue (pLength);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (header != null) {
					JNIEnv.CopyArray (native_header, header);
					JNIEnv.DeleteLocalRef (native_header);
				}
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_getHeaderLength;
#pragma warning disable 0169
		static Delegate GetGetHeaderLengthHandler ()
		{
			if (cb_getHeaderLength == null)
				cb_getHeaderLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderLength);
			return cb_getHeaderLength;
		}

		static int n_GetHeaderLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLength;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderLength' and count(parameter)=0]"
			[Register ("getHeaderLength", "()I", "GetGetHeaderLengthHandler")]
			get {
				const string __id = "getHeaderLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderOffset;
#pragma warning disable 0169
		static Delegate GetGetHeaderOffsetHandler ()
		{
			if (cb_getHeaderOffset == null)
				cb_getHeaderOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderOffset);
			return cb_getHeaderOffset;
		}

		static int n_GetHeaderOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderOffset' and count(parameter)=0]"
			[Register ("getHeaderOffset", "()I", "GetGetHeaderOffsetHandler")]
			get {
				const string __id = "getHeaderOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadLength;
#pragma warning disable 0169
		static Delegate GetGetPayloadLengthHandler ()
		{
			if (cb_getPayloadLength == null)
				cb_getPayloadLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadLength);
			return cb_getPayloadLength;
		}

		static int n_GetPayloadLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadLength;
		}
#pragma warning restore 0169

		public virtual unsafe int PayloadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadLength' and count(parameter)=0]"
			[Register ("getPayloadLength", "()I", "GetGetPayloadLengthHandler")]
			get {
				const string __id = "getPayloadLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadOffset;
#pragma warning disable 0169
		static Delegate GetGetPayloadOffsetHandler ()
		{
			if (cb_getPayloadOffset == null)
				cb_getPayloadOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayloadOffset);
			return cb_getPayloadOffset;
		}

		static int n_GetPayloadOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int PayloadOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadOffset' and count(parameter)=0]"
			[Register ("getPayloadOffset", "()I", "GetGetPayloadOffsetHandler")]
			get {
				const string __id = "getPayloadOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderBytes;
#pragma warning disable 0169
		static Delegate GetGetHeaderBytesHandler ()
		{
			if (cb_getHeaderBytes == null)
				cb_getHeaderBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderBytes);
			return cb_getHeaderBytes;
		}

		static IntPtr n_GetHeaderBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaderBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getHeaderBytes' and count(parameter)=0]"
		[Register ("getHeaderBytes", "()[B", "GetGetHeaderBytesHandler")]
		public virtual unsafe byte[] GetHeaderBytes ()
		{
			const string __id = "getHeaderBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPayloadBytes;
#pragma warning disable 0169
		static Delegate GetGetPayloadBytesHandler ()
		{
			if (cb_getPayloadBytes == null)
				cb_getPayloadBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadBytes);
			return cb_getPayloadBytes;
		}

		static IntPtr n_GetPayloadBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.MqttPersistentData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayloadBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='MqttPersistentData']/method[@name='getPayloadBytes' and count(parameter)=0]"
		[Register ("getPayloadBytes", "()[B", "GetGetPayloadBytesHandler")]
		public virtual unsafe byte[] GetPayloadBytes ()
		{
			const string __id = "getPayloadBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
