using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", DoNotGenerateAcw=true)]
	public abstract partial class MqttPersistableWireMessage : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", typeof (MqttPersistableWireMessage));
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

		protected MqttPersistableWireMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/constructor[@name='MqttPersistableWireMessage' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MqttPersistableWireMessage (sbyte type)
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLength;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderLength' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderOffset' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadLength;
		}
#pragma warning restore 0169

		public virtual unsafe int PayloadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadLength' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PayloadOffset;
		}
#pragma warning restore 0169

		public virtual unsafe int PayloadOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadOffset' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeaderBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getHeaderBytes' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayloadBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPersistableWireMessage']/method[@name='getPayloadBytes' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", DoNotGenerateAcw=true)]
	internal partial class MqttPersistableWireMessageInvoker : MqttPersistableWireMessage {

		public MqttPersistableWireMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPersistableWireMessage", typeof (MqttPersistableWireMessageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")]
			get {
				const string __id = "getMessageInfo.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
