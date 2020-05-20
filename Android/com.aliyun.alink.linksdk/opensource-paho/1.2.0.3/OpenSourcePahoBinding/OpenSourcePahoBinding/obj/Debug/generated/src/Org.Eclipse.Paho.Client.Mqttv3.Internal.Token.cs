using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/Token", DoNotGenerateAcw=true)]
	public partial class Token : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/Token", typeof (Token));
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

		protected Token (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/constructor[@name='Token' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Token (string logContext)
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

		static Delegate cb_getActionCallback;
#pragma warning disable 0169
		static Delegate GetGetActionCallbackHandler ()
		{
			if (cb_getActionCallback == null)
				cb_getActionCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionCallback);
			return cb_getActionCallback;
		}

		static IntPtr n_GetActionCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static void n_SetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener listener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ActionCallback = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener ActionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getActionCallback' and count(parameter)=0]"
			[Register ("getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;", "GetGetActionCallbackHandler")]
			get {
				const string __id = "getActionCallback.()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setActionCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
			[Register ("setActionCallback", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", "GetSetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
			set {
				const string __id = "setActionCallback.(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;", "GetGetClientHandler")]
			get {
				const string __id = "getClient.()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static Delegate cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetSetException_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetException_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_setException_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_SetException_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException exception = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.Exception = exception;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Lorg/eclipse/paho/client/mqttv3/MqttException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setException' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
			[Register ("setException", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetSetException_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
			set {
				const string __id = "setException.(Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				const string __id = "isComplete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCompletePending;
#pragma warning disable 0169
		static Delegate GetIsCompletePendingHandler ()
		{
			if (cb_isCompletePending == null)
				cb_isCompletePending = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompletePending);
			return cb_isCompletePending;
		}

		static bool n_IsCompletePending (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompletePending;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsCompletePending {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isCompletePending' and count(parameter)=0]"
			[Register ("isCompletePending", "()Z", "GetIsCompletePendingHandler")]
			get {
				const string __id = "isCompletePending.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInUse;
#pragma warning disable 0169
		static Delegate GetIsInUseHandler ()
		{
			if (cb_isInUse == null)
				cb_isInUse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInUse);
			return cb_isInUse;
		}

		static bool n_IsInUse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInUse;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsInUse {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isInUse' and count(parameter)=0]"
			[Register ("isInUse", "()Z", "GetIsInUseHandler")]
			get {
				const string __id = "isInUse.()Z";
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static void n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Key = key;
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey", "(Ljava/lang/String;)V", "GetSetKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setKey.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_setMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_SetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage msg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Message = msg;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Lorg/eclipse/paho/client/mqttv3/MqttMessage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
			[Register ("setMessage", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetSetMessage_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
			set {
				const string __id = "setMessage.(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageID;
#pragma warning disable 0169
		static Delegate GetGetMessageIDHandler ()
		{
			if (cb_getMessageID == null)
				cb_getMessageID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageID);
			return cb_getMessageID;
		}

		static int n_GetMessageID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageID;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageID_I;
#pragma warning disable 0169
		static Delegate GetSetMessageID_IHandler ()
		{
			if (cb_setMessageID_I == null)
				cb_setMessageID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageID_I);
			return cb_setMessageID_I;
		}

		static void n_SetMessageID_I (IntPtr jnienv, IntPtr native__this, int messageID)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageID = messageID;
		}
#pragma warning restore 0169

		public virtual unsafe int MessageID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getMessageID' and count(parameter)=0]"
			[Register ("getMessageID", "()I", "GetGetMessageIDHandler")]
			get {
				const string __id = "getMessageID.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setMessageID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageID", "(I)V", "GetSetMessageID_IHandler")]
			set {
				const string __id = "setMessageID.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNotified;
#pragma warning disable 0169
		static Delegate GetIsNotifiedHandler ()
		{
			if (cb_isNotified == null)
				cb_isNotified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotified);
			return cb_isNotified;
		}

		static bool n_IsNotified (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Notified;
		}
#pragma warning restore 0169

		static Delegate cb_setNotified_Z;
#pragma warning disable 0169
		static Delegate GetSetNotified_ZHandler ()
		{
			if (cb_setNotified_Z == null)
				cb_setNotified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotified_Z);
			return cb_setNotified_Z;
		}

		static void n_SetNotified_Z (IntPtr jnienv, IntPtr native__this, bool notified)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Notified = notified;
		}
#pragma warning restore 0169

		public virtual unsafe bool Notified {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='isNotified' and count(parameter)=0]"
			[Register ("isNotified", "()Z", "GetIsNotifiedHandler")]
			get {
				const string __id = "isNotified.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setNotified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotified", "(Z)V", "GetSetNotified_ZHandler")]
			set {
				const string __id = "setNotified.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetResponseHandler")]
			get {
				const string __id = "getResponse.()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool SessionPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getSessionPresent' and count(parameter)=0]"
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

		static Delegate cb_getUserContext;
#pragma warning disable 0169
		static Delegate GetGetUserContextHandler ()
		{
			if (cb_getUserContext == null)
				cb_getUserContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserContext);
			return cb_getUserContext;
		}

		static IntPtr n_GetUserContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserContext);
		}
#pragma warning restore 0169

		static Delegate cb_setUserContext_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUserContext_Ljava_lang_Object_Handler ()
		{
			if (cb_setUserContext_Ljava_lang_Object_ == null)
				cb_setUserContext_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserContext_Ljava_lang_Object_);
			return cb_setUserContext_Ljava_lang_Object_;
		}

		static void n_SetUserContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			__this.UserContext = userContext;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object UserContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getUserContext' and count(parameter)=0]"
			[Register ("getUserContext", "()Ljava/lang/Object;", "GetGetUserContextHandler")]
			get {
				const string __id = "getUserContext.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setUserContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setUserContext", "(Ljava/lang/Object;)V", "GetSetUserContext_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setUserContext.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWireMessage;
#pragma warning disable 0169
		static Delegate GetGetWireMessageHandler ()
		{
			if (cb_getWireMessage == null)
				cb_getWireMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWireMessage);
			return cb_getWireMessage;
		}

		static IntPtr n_GetWireMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WireMessage);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WireMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getWireMessage' and count(parameter)=0]"
			[Register ("getWireMessage", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetGetWireMessageHandler")]
			get {
				const string __id = "getWireMessage.()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkResult;
#pragma warning disable 0169
		static Delegate GetCheckResultHandler ()
		{
			if (cb_checkResult == null)
				cb_checkResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckResult);
			return cb_checkResult;
		}

		static bool n_CheckResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckResult ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='checkResult' and count(parameter)=0]"
		[Register ("checkResult", "()Z", "GetCheckResultHandler")]
		public virtual unsafe bool CheckResult ()
		{
			const string __id = "checkResult.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getGrantedQos;
#pragma warning disable 0169
		static Delegate GetGetGrantedQosHandler ()
		{
			if (cb_getGrantedQos == null)
				cb_getGrantedQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantedQos);
			return cb_getGrantedQos;
		}

		static IntPtr n_GetGrantedQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedQos ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getGrantedQos' and count(parameter)=0]"
		[Register ("getGrantedQos", "()[I", "GetGetGrantedQosHandler")]
		public virtual unsafe int[] GetGrantedQos ()
		{
			const string __id = "getGrantedQos.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getTopics;
#pragma warning disable 0169
		static Delegate GetGetTopicsHandler ()
		{
			if (cb_getTopics == null)
				cb_getTopics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopics);
			return cb_getTopics;
		}

		static IntPtr n_GetTopics (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTopics ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='getTopics' and count(parameter)=0]"
		[Register ("getTopics", "()[Ljava/lang/String;", "GetGetTopicsHandler")]
		public virtual unsafe string[] GetTopics ()
		{
			const string __id = "getTopics.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetMarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_markComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_MarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage msg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException ex = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.MarkComplete (msg, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='markComplete' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("markComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetMarkComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		protected virtual unsafe void MarkComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage msg, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException ex)
		{
			const string __id = "markComplete.(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyComplete;
#pragma warning disable 0169
		static Delegate GetNotifyCompleteHandler ()
		{
			if (cb_notifyComplete == null)
				cb_notifyComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyComplete);
			return cb_notifyComplete;
		}

		static void n_NotifyComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='notifyComplete' and count(parameter)=0]"
		[Register ("notifyComplete", "()V", "GetNotifyCompleteHandler")]
		protected virtual unsafe void NotifyComplete ()
		{
			const string __id = "notifyComplete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_notifySent;
#pragma warning disable 0169
		static Delegate GetNotifySentHandler ()
		{
			if (cb_notifySent == null)
				cb_notifySent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifySent);
			return cb_notifySent;
		}

		static void n_NotifySent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifySent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='notifySent' and count(parameter)=0]"
		[Register ("notifySent", "()V", "GetNotifySentHandler")]
		protected virtual unsafe void NotifySent ()
		{
			const string __id = "notifySent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_;
#pragma warning disable 0169
		static Delegate GetSetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Handler ()
		{
			if (cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ == null)
				cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_);
			return cb_setClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_;
		}

		static void n_SetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_client)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient client = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (native_client, JniHandleOwnership.DoNotTransfer);
			__this.SetClient (client);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setClient' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttAsyncClient']]"
		[Register ("setClient", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;)V", "GetSetClient_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Handler")]
		protected virtual unsafe void SetClient (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient client)
		{
			const string __id = "setClient.(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTopics_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopics_arrayLjava_lang_String_Handler ()
		{
			if (cb_setTopics_arrayLjava_lang_String_ == null)
				cb_setTopics_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopics_arrayLjava_lang_String_);
			return cb_setTopics_arrayLjava_lang_String_;
		}

		static void n_SetTopics_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topics)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topics = (string[]) JNIEnv.GetArray (native_topics, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetTopics (topics);
			if (topics != null)
				JNIEnv.CopyArray (topics, native_topics);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='setTopics' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setTopics", "([Ljava/lang/String;)V", "GetSetTopics_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetTopics (string[] topics)
		{
			const string __id = "setTopics.([Ljava/lang/String;)V";
			IntPtr native_topics = JNIEnv.NewArray (topics);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_topics);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (topics != null) {
					JNIEnv.CopyArray (native_topics, topics);
					JNIEnv.DeleteLocalRef (native_topics);
				}
			}
		}

		static Delegate cb_waitForCompletion;
#pragma warning disable 0169
		static Delegate GetWaitForCompletionHandler ()
		{
			if (cb_waitForCompletion == null)
				cb_waitForCompletion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitForCompletion);
			return cb_waitForCompletion;
		}

		static void n_WaitForCompletion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForCompletion' and count(parameter)=0]"
		[Register ("waitForCompletion", "()V", "GetWaitForCompletionHandler")]
		public virtual unsafe void WaitForCompletion ()
		{
			const string __id = "waitForCompletion.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_waitForCompletion_J;
#pragma warning disable 0169
		static Delegate GetWaitForCompletion_JHandler ()
		{
			if (cb_waitForCompletion_J == null)
				cb_waitForCompletion_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WaitForCompletion_J);
			return cb_waitForCompletion_J;
		}

		static void n_WaitForCompletion_J (IntPtr jnienv, IntPtr native__this, long timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForCompletion' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("waitForCompletion", "(J)V", "GetWaitForCompletion_JHandler")]
		public virtual unsafe void WaitForCompletion (long timeout)
		{
			const string __id = "waitForCompletion.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_waitForResponse;
#pragma warning disable 0169
		static Delegate GetWaitForResponseHandler ()
		{
			if (cb_waitForResponse == null)
				cb_waitForResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WaitForResponse);
			return cb_waitForResponse;
		}

		static IntPtr n_WaitForResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WaitForResponse ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForResponse' and count(parameter)=0]"
		[Register ("waitForResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetWaitForResponseHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WaitForResponse ()
		{
			const string __id = "waitForResponse.()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_waitForResponse_J;
#pragma warning disable 0169
		static Delegate GetWaitForResponse_JHandler ()
		{
			if (cb_waitForResponse_J == null)
				cb_waitForResponse_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WaitForResponse_J);
			return cb_waitForResponse_J;
		}

		static IntPtr n_WaitForResponse_J (IntPtr jnienv, IntPtr native__this, long timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WaitForResponse (timeout));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitForResponse' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("waitForResponse", "(J)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;", "GetWaitForResponse_JHandler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage WaitForResponse (long timeout)
		{
			const string __id = "waitForResponse.(J)Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_waitUntilSent;
#pragma warning disable 0169
		static Delegate GetWaitUntilSentHandler ()
		{
			if (cb_waitUntilSent == null)
				cb_waitUntilSent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitUntilSent);
			return cb_waitUntilSent;
		}

		static void n_WaitUntilSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitUntilSent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='Token']/method[@name='waitUntilSent' and count(parameter)=0]"
		[Register ("waitUntilSent", "()V", "GetWaitUntilSentHandler")]
		public virtual unsafe void WaitUntilSent ()
		{
			const string __id = "waitUntilSent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener"
		public event EventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.FailureEventArgs> Failure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						__CreateIMqttActionListenerImplementor,
						__v => ActionCallback = __v,
						__h => __h.OnFailureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor.__IsEmpty,
						__v => ActionCallback = null,
						__h => __h.OnFailureHandler -= value);
			}
		}

		public event EventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.SuccessEventArgs> Success {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						__CreateIMqttActionListenerImplementor,
						__v => ActionCallback = __v,
						__h => __h.OnSuccessHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor>(
						ref weak_implementor___SetActionCallback,
						global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor.__IsEmpty,
						__v => ActionCallback = null,
						__h => __h.OnSuccessHandler -= value);
			}
		}

		WeakReference weak_implementor___SetActionCallback;

		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor __CreateIMqttActionListenerImplementor ()
		{
			return new global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerImplementor (this);
		}
#endregion
	}
}
