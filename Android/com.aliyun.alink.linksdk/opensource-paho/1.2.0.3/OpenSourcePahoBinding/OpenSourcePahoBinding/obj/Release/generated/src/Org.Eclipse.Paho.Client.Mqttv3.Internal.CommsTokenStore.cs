using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsTokenStore", DoNotGenerateAcw=true)]
	public partial class CommsTokenStore : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/CommsTokenStore", typeof (CommsTokenStore));
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

		protected CommsTokenStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/constructor[@name='CommsTokenStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CommsTokenStore (string logContext)
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

		static Delegate cb_getOutstandingTokens;
#pragma warning disable 0169
		static Delegate GetGetOutstandingTokensHandler ()
		{
			if (cb_getOutstandingTokens == null)
				cb_getOutstandingTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutstandingTokens);
			return cb_getOutstandingTokens;
		}

		static IntPtr n_GetOutstandingTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutstandingTokens);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Vector OutstandingTokens {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getOutstandingTokens' and count(parameter)=0]"
			[Register ("getOutstandingTokens", "()Ljava/util/Vector;", "GetGetOutstandingTokensHandler")]
			get {
				const string __id = "getOutstandingTokens.()Ljava/util/Vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
			return cb_count;
		}

		static int n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "GetCountHandler")]
		public virtual unsafe int Count ()
		{
			const string __id = "count.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getOutstandingDelTokens;
#pragma warning disable 0169
		static Delegate GetGetOutstandingDelTokensHandler ()
		{
			if (cb_getOutstandingDelTokens == null)
				cb_getOutstandingDelTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutstandingDelTokens);
			return cb_getOutstandingDelTokens;
		}

		static IntPtr n_GetOutstandingDelTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutstandingDelTokens ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getOutstandingDelTokens' and count(parameter)=0]"
		[Register ("getOutstandingDelTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetGetOutstandingDelTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[] GetOutstandingDelTokens ()
		{
			const string __id = "getOutstandingDelTokens.()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
			} finally {
			}
		}

		static Delegate cb_getToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Ljava_lang_String_ == null)
				cb_getToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Ljava_lang_String_);
			return cb_getToken_Ljava_lang_String_;
		}

		static IntPtr n_GetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetGetToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken GetToken (string key)
		{
			const string __id = "getToken.(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetGetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_getToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static IntPtr n_GetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetToken (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("getToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetGetToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken GetToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "getToken.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			const string __id = "open.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetQuiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_Quiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_quiesceResponse)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException quiesceResponse = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_quiesceResponse, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce (quiesceResponse);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='quiesce' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("quiesce", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetQuiesce_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void Quiesce (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException quiesceResponse)
		{
			const string __id = "quiesce.(Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((quiesceResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) quiesceResponse).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveToken_Ljava_lang_String_Handler ()
		{
			if (cb_removeToken_Ljava_lang_String_ == null)
				cb_removeToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveToken_Ljava_lang_String_);
			return cb_removeToken_Ljava_lang_String_;
		}

		static IntPtr n_RemoveToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveToken (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='removeToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeToken", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetRemoveToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken RemoveToken (string key)
		{
			const string __id = "removeToken.(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetRemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_removeToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static IntPtr n_RemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveToken (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='removeToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("removeToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetRemoveToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken RemoveToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "removeToken.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)Lorg/eclipse/paho/client/mqttv3/MqttToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetRestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_restoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static IntPtr n_RestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RestoreToken (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='restoreToken' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("restoreToken", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetRestoreToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken RestoreToken (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish message)
		{
			const string __id = "restoreToken.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_Handler ()
		{
			if (cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ == null)
				cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_);
			return cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_;
		}

		static void n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.SaveToken (token, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='saveToken' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/String;)V", "GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Ljava_lang_String_Handler")]
		protected virtual unsafe void SaveToken (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token, string key)
		{
			const string __id = "saveToken.(Lorg/eclipse/paho/client/mqttv3/MqttToken;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				__args [1] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_saveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_SaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.SaveToken (token, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsTokenStore']/method[@name='saveToken' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("saveToken", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetSaveToken_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		protected virtual unsafe void SaveToken (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			const string __id = "saveToken.(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((token == null) ? IntPtr.Zero : ((global::Java.Lang.Object) token).Handle);
				__args [1] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
