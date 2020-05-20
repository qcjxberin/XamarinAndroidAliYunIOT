using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketFrame", DoNotGenerateAcw=true)]
	public partial class WebSocketFrame : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/field[@name='frameLengthOverhead']"
		[Register ("frameLengthOverhead")]
		public const int FrameLengthOverhead = (int) 6;
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketFrame", typeof (WebSocketFrame));
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

		protected WebSocketFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='boolean'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(BZ[B)V", "")]
		public unsafe WebSocketFrame (sbyte opcode, bool fin, byte[] payload)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(BZ[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (opcode);
				__args [1] = new JniArgumentValue (fin);
				__args [2] = new JniArgumentValue (native_payload);
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe WebSocketFrame (byte[] rawFrame)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawFrame = JNIEnv.NewArray (rawFrame);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawFrame);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rawFrame != null) {
					JNIEnv.CopyArray (native_rawFrame, rawFrame);
					JNIEnv.DeleteLocalRef (native_rawFrame);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe WebSocketFrame (global::System.IO.Stream input)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_input);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_isCloseFlag;
#pragma warning disable 0169
		static Delegate GetIsCloseFlagHandler ()
		{
			if (cb_isCloseFlag == null)
				cb_isCloseFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCloseFlag);
			return cb_isCloseFlag;
		}

		static bool n_IsCloseFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCloseFlag;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCloseFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='isCloseFlag' and count(parameter)=0]"
			[Register ("isCloseFlag", "()Z", "GetIsCloseFlagHandler")]
			get {
				const string __id = "isCloseFlag.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFin;
#pragma warning disable 0169
		static Delegate GetIsFinHandler ()
		{
			if (cb_isFin == null)
				cb_isFin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFin);
			return cb_isFin;
		}

		static bool n_IsFin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFin;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='isFin' and count(parameter)=0]"
			[Register ("isFin", "()Z", "GetIsFinHandler")]
			get {
				const string __id = "isFin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpcode;
#pragma warning disable 0169
		static Delegate GetGetOpcodeHandler ()
		{
			if (cb_getOpcode == null)
				cb_getOpcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetOpcode);
			return cb_getOpcode;
		}

		static sbyte n_GetOpcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opcode;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte Opcode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='getOpcode' and count(parameter)=0]"
			[Register ("getOpcode", "()B", "GetGetOpcodeHandler")]
			get {
				const string __id = "getOpcode.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='appendFinAndOpCode' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte'] and parameter[3][@type='boolean']]"
		[Register ("appendFinAndOpCode", "(Ljava/nio/ByteBuffer;BZ)V", "")]
		public static unsafe void AppendFinAndOpCode (global::Java.Nio.ByteBuffer buffer, sbyte opcode, bool fin)
		{
			const string __id = "appendFinAndOpCode.(Ljava/nio/ByteBuffer;BZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (opcode);
				__args [2] = new JniArgumentValue (fin);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='appendLengthAndMask' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("appendLengthAndMask", "(Ljava/nio/ByteBuffer;I[B)V", "")]
		public static unsafe void AppendLengthAndMask (global::Java.Nio.ByteBuffer buffer, int length, byte[] mask)
		{
			const string __id = "appendLengthAndMask.(Ljava/nio/ByteBuffer;I[B)V";
			IntPtr native_mask = JNIEnv.NewArray (mask);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (length);
				__args [2] = new JniArgumentValue (native_mask);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (mask != null) {
					JNIEnv.CopyArray (native_mask, mask);
					JNIEnv.DeleteLocalRef (native_mask);
				}
			}
		}

		static Delegate cb_encodeFrame;
#pragma warning disable 0169
		static Delegate GetEncodeFrameHandler ()
		{
			if (cb_encodeFrame == null)
				cb_encodeFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeFrame);
			return cb_encodeFrame;
		}

		static IntPtr n_EncodeFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeFrame ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='encodeFrame' and count(parameter)=0]"
		[Register ("encodeFrame", "()[B", "GetEncodeFrameHandler")]
		public virtual unsafe byte[] EncodeFrame ()
		{
			const string __id = "encodeFrame.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='generateMaskingKey' and count(parameter)=0]"
		[Register ("generateMaskingKey", "()[B", "")]
		public static unsafe byte[] GenerateMaskingKey ()
		{
			const string __id = "generateMaskingKey.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='getPayload' and count(parameter)=0]"
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

	}
}
