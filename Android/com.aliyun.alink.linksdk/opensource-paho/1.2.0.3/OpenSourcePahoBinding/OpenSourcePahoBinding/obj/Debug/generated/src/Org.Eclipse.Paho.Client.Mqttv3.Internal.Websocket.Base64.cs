using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64$Base64Encoder", DoNotGenerateAcw=true)]
		public partial class Base64Encoder : global::Java.Util.Prefs.AbstractPreferences {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64$Base64Encoder", typeof (Base64Encoder));
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

			protected Base64Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/constructor[@name='Base64.Base64Encoder' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.websocket.Base64']]"
			[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/websocket/Base64;)V", "")]
			public unsafe Base64Encoder (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64 __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getBase64String;
#pragma warning disable 0169
			static Delegate GetGetBase64StringHandler ()
			{
				if (cb_getBase64String == null)
					cb_getBase64String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBase64String);
				return cb_getBase64String;
			}

			static IntPtr n_GetBase64String (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Base64String);
			}
#pragma warning restore 0169

			public virtual unsafe string Base64String {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='getBase64String' and count(parameter)=0]"
				[Register ("getBase64String", "()Ljava/lang/String;", "GetGetBase64StringHandler")]
				get {
					const string __id = "getBase64String.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_childSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetChildSpi_Ljava_lang_String_Handler ()
			{
				if (cb_childSpi_Ljava_lang_String_ == null)
					cb_childSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ChildSpi_Ljava_lang_String_);
				return cb_childSpi_Ljava_lang_String_;
			}

			static IntPtr n_ChildSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChildSpi (name));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='childSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", "GetChildSpi_Ljava_lang_String_Handler")]
			protected override unsafe global::Java.Util.Prefs.AbstractPreferences ChildSpi (string name)
			{
				const string __id = "childSpi.(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Prefs.AbstractPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_childrenNamesSpi;
#pragma warning disable 0169
			static Delegate GetChildrenNamesSpiHandler ()
			{
				if (cb_childrenNamesSpi == null)
					cb_childrenNamesSpi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ChildrenNamesSpi);
				return cb_childrenNamesSpi;
			}

			static IntPtr n_ChildrenNamesSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.ChildrenNamesSpi ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='childrenNamesSpi' and count(parameter)=0]"
			[Register ("childrenNamesSpi", "()[Ljava/lang/String;", "GetChildrenNamesSpiHandler")]
			protected override unsafe string[] ChildrenNamesSpi ()
			{
				const string __id = "childrenNamesSpi.()[Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_flushSpi;
#pragma warning disable 0169
			static Delegate GetFlushSpiHandler ()
			{
				if (cb_flushSpi == null)
					cb_flushSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushSpi);
				return cb_flushSpi;
			}

			static void n_FlushSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FlushSpi ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='flushSpi' and count(parameter)=0]"
			[Register ("flushSpi", "()V", "GetFlushSpiHandler")]
			protected override unsafe void FlushSpi ()
			{
				const string __id = "flushSpi.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_getSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetSpi_Ljava_lang_String_Handler ()
			{
				if (cb_getSpi_Ljava_lang_String_ == null)
					cb_getSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSpi_Ljava_lang_String_);
				return cb_getSpi_Ljava_lang_String_;
			}

			static IntPtr n_GetSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetSpi (key));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='getSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getSpi", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSpi_Ljava_lang_String_Handler")]
			protected override unsafe string GetSpi (string key)
			{
				const string __id = "getSpi.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static Delegate cb_keysSpi;
#pragma warning disable 0169
			static Delegate GetKeysSpiHandler ()
			{
				if (cb_keysSpi == null)
					cb_keysSpi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeysSpi);
				return cb_keysSpi;
			}

			static IntPtr n_KeysSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.KeysSpi ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='keysSpi' and count(parameter)=0]"
			[Register ("keysSpi", "()[Ljava/lang/String;", "GetKeysSpiHandler")]
			protected override unsafe string[] KeysSpi ()
			{
				const string __id = "keysSpi.()[Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_putSpi_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPutSpi_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_putSpi_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_putSpi_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutSpi_Ljava_lang_String_Ljava_lang_String_);
				return cb_putSpi_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_PutSpi_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				__this.PutSpi (key, value);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='putSpi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("putSpi", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutSpi_Ljava_lang_String_Ljava_lang_String_Handler")]
			protected override unsafe void PutSpi (string key, string value)
			{
				const string __id = "putSpi.(Ljava/lang/String;Ljava/lang/String;)V";
				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_key);
					__args [1] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_removeNodeSpi;
#pragma warning disable 0169
			static Delegate GetRemoveNodeSpiHandler ()
			{
				if (cb_removeNodeSpi == null)
					cb_removeNodeSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveNodeSpi);
				return cb_removeNodeSpi;
			}

			static void n_RemoveNodeSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RemoveNodeSpi ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='removeNodeSpi' and count(parameter)=0]"
			[Register ("removeNodeSpi", "()V", "GetRemoveNodeSpiHandler")]
			protected override unsafe void RemoveNodeSpi ()
			{
				const string __id = "removeNodeSpi.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_removeSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveSpi_Ljava_lang_String_Handler ()
			{
				if (cb_removeSpi_Ljava_lang_String_ == null)
					cb_removeSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSpi_Ljava_lang_String_);
				return cb_removeSpi_Ljava_lang_String_;
			}

			static void n_RemoveSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				__this.RemoveSpi (key);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='removeSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeSpi", "(Ljava/lang/String;)V", "GetRemoveSpi_Ljava_lang_String_Handler")]
			protected override unsafe void RemoveSpi (string key)
			{
				const string __id = "removeSpi.(Ljava/lang/String;)V";
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_key);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static Delegate cb_syncSpi;
#pragma warning disable 0169
			static Delegate GetSyncSpiHandler ()
			{
				if (cb_syncSpi == null)
					cb_syncSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncSpi);
				return cb_syncSpi;
			}

			static void n_SyncSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SyncSpi ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='syncSpi' and count(parameter)=0]"
			[Register ("syncSpi", "()V", "GetSyncSpiHandler")]
			protected override unsafe void SyncSpi ()
			{
				const string __id = "syncSpi.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64", typeof (Base64));
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

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Base64 ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode (string s)
		{
			const string __id = "encode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] b)
		{
			const string __id = "encodeBytes.([B)Ljava/lang/String;";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

	}
}
