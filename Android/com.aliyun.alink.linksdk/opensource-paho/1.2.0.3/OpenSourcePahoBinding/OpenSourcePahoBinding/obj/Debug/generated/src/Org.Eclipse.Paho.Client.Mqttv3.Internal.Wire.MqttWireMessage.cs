using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", DoNotGenerateAcw=true)]
	public abstract partial class MqttWireMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_CONNACK']"
		[Register ("MESSAGE_TYPE_CONNACK")]
		public const sbyte MessageTypeConnack = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_CONNECT']"
		[Register ("MESSAGE_TYPE_CONNECT")]
		public const sbyte MessageTypeConnect = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_DISCONNECT']"
		[Register ("MESSAGE_TYPE_DISCONNECT")]
		public const sbyte MessageTypeDisconnect = (sbyte) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PINGREQ']"
		[Register ("MESSAGE_TYPE_PINGREQ")]
		public const sbyte MessageTypePingreq = (sbyte) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PINGRESP']"
		[Register ("MESSAGE_TYPE_PINGRESP")]
		public const sbyte MessageTypePingresp = (sbyte) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBACK']"
		[Register ("MESSAGE_TYPE_PUBACK")]
		public const sbyte MessageTypePuback = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBCOMP']"
		[Register ("MESSAGE_TYPE_PUBCOMP")]
		public const sbyte MessageTypePubcomp = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBLISH']"
		[Register ("MESSAGE_TYPE_PUBLISH")]
		public const sbyte MessageTypePublish = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBREC']"
		[Register ("MESSAGE_TYPE_PUBREC")]
		public const sbyte MessageTypePubrec = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_PUBREL']"
		[Register ("MESSAGE_TYPE_PUBREL")]
		public const sbyte MessageTypePubrel = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_SUBACK']"
		[Register ("MESSAGE_TYPE_SUBACK")]
		public const sbyte MessageTypeSuback = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_SUBSCRIBE']"
		[Register ("MESSAGE_TYPE_SUBSCRIBE")]
		public const sbyte MessageTypeSubscribe = (sbyte) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_UNSUBACK']"
		[Register ("MESSAGE_TYPE_UNSUBACK")]
		public const sbyte MessageTypeUnsuback = (sbyte) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='MESSAGE_TYPE_UNSUBSCRIBE']"
		[Register ("MESSAGE_TYPE_UNSUBSCRIBE")]
		public const sbyte MessageTypeUnsubscribe = (sbyte) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='STRING_ENCODING']"
		[Register ("STRING_ENCODING")]
		protected const string StringEncoding = (string) "UTF-8";


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='duplicate']"
		[Register ("duplicate")]
		protected bool Duplicate {
			get {
				const string __id = "duplicate.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "duplicate.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/field[@name='msgId']"
		[Register ("msgId")]
		protected int MsgId {
			get {
				const string __id = "msgId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "msgId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", typeof (MqttWireMessage));
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

		protected MqttWireMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/constructor[@name='MqttWireMessage' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MqttWireMessage (sbyte type)
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

		static Delegate cb_isMessageIdRequired;
#pragma warning disable 0169
		static Delegate GetIsMessageIdRequiredHandler ()
		{
			if (cb_isMessageIdRequired == null)
				cb_isMessageIdRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMessageIdRequired);
			return cb_isMessageIdRequired;
		}

		static bool n_IsMessageIdRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMessageIdRequired;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMessageIdRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='isMessageIdRequired' and count(parameter)=0]"
			[Register ("isMessageIdRequired", "()Z", "GetIsMessageIdRequiredHandler")]
			get {
				const string __id = "isMessageIdRequired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRetryable;
#pragma warning disable 0169
		static Delegate GetIsRetryableHandler ()
		{
			if (cb_isRetryable == null)
				cb_isRetryable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetryable);
			return cb_isRetryable;
		}

		static bool n_IsRetryable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRetryable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRetryable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='isRetryable' and count(parameter)=0]"
			[Register ("isRetryable", "()Z", "GetIsRetryableHandler")]
			get {
				const string __id = "isRetryable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getKey' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = msgId;
		}
#pragma warning restore 0169

		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				const string __id = "getMessageId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageInfo;
		}
#pragma warning restore 0169

		protected abstract sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")] get;
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetType);
			return cb_getType;
		}

		static sbyte n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()B", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='createWireMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createWireMessage", "([B)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage CreateWireMessage (byte[] bytes)
		{
			const string __id = "createWireMessage.([B)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='createWireMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttPersistable']]"
		[Register ("createWireMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage CreateWireMessage (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable data)
		{
			const string __id = "createWireMessage.(Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_decodeUTF8_Ljava_io_DataInputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeUTF8_Ljava_io_DataInputStream_Handler ()
		{
			if (cb_decodeUTF8_Ljava_io_DataInputStream_ == null)
				cb_decodeUTF8_Ljava_io_DataInputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeUTF8_Ljava_io_DataInputStream_);
			return cb_decodeUTF8_Ljava_io_DataInputStream_;
		}

		static IntPtr n_DecodeUTF8_Ljava_io_DataInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.DataInputStream input = global::Java.Lang.Object.GetObject<global::Java.IO.DataInputStream> (native_input, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DecodeUTF8 (input));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='decodeUTF8' and count(parameter)=1 and parameter[1][@type='java.io.DataInputStream']]"
		[Register ("decodeUTF8", "(Ljava/io/DataInputStream;)Ljava/lang/String;", "GetDecodeUTF8_Ljava_io_DataInputStream_Handler")]
		protected virtual unsafe string DecodeUTF8 (global::Java.IO.DataInputStream input)
		{
			const string __id = "decodeUTF8.(Ljava/io/DataInputStream;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeMBI' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("encodeMBI", "(J)[B", "")]
		protected static unsafe byte[] EncodeMBI (long number)
		{
			const string __id = "encodeMBI.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_encodeMessageId;
#pragma warning disable 0169
		static Delegate GetEncodeMessageIdHandler ()
		{
			if (cb_encodeMessageId == null)
				cb_encodeMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeMessageId);
			return cb_encodeMessageId;
		}

		static IntPtr n_EncodeMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeMessageId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeMessageId' and count(parameter)=0]"
		[Register ("encodeMessageId", "()[B", "GetEncodeMessageIdHandler")]
		protected virtual unsafe byte[] EncodeMessageId ()
		{
			const string __id = "encodeMessageId.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_Handler ()
		{
			if (cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ == null)
				cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_);
			return cb_encodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_;
		}

		static void n_EncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dos, IntPtr native_stringToEncode)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.DataOutputStream dos = global::Java.Lang.Object.GetObject<global::Java.IO.DataOutputStream> (native_dos, JniHandleOwnership.DoNotTransfer);
			string stringToEncode = JNIEnv.GetString (native_stringToEncode, JniHandleOwnership.DoNotTransfer);
			__this.EncodeUTF8 (dos, stringToEncode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='encodeUTF8' and count(parameter)=2 and parameter[1][@type='java.io.DataOutputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeUTF8", "(Ljava/io/DataOutputStream;Ljava/lang/String;)V", "GetEncodeUTF8_Ljava_io_DataOutputStream_Ljava_lang_String_Handler")]
		protected virtual unsafe void EncodeUTF8 (global::Java.IO.DataOutputStream dos, string stringToEncode)
		{
			const string __id = "encodeUTF8.(Ljava/io/DataOutputStream;Ljava/lang/String;)V";
			IntPtr native_stringToEncode = JNIEnv.NewString (stringToEncode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dos == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dos).Handle);
				__args [1] = new JniArgumentValue (native_stringToEncode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringToEncode);
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHeader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getHeader' and count(parameter)=0]"
		[Register ("getHeader", "()[B", "GetGetHeaderHandler")]
		public virtual unsafe byte[] GetHeader ()
		{
			const string __id = "getHeader.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getPayload' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVariableHeader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected abstract byte[] GetVariableHeader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='readMBI' and count(parameter)=1 and parameter[1][@type='java.io.DataInputStream']]"
		[Register ("readMBI", "(Ljava/io/DataInputStream;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger;", "")]
		protected static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger ReadMBI (global::Java.IO.DataInputStream @in)
		{
			const string __id = "readMBI.(Ljava/io/DataInputStream;)Lorg/eclipse/paho/client/mqttv3/internal/wire/MultiByteInteger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteInteger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool duplicate)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (duplicate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttWireMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		public virtual unsafe void SetDuplicate (bool duplicate)
		{
			const string __id = "setDuplicate.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (duplicate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", DoNotGenerateAcw=true)]
	internal partial class MqttWireMessageInvoker : MqttWireMessage {

		public MqttWireMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage", typeof (MqttWireMessageInvoker));

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
