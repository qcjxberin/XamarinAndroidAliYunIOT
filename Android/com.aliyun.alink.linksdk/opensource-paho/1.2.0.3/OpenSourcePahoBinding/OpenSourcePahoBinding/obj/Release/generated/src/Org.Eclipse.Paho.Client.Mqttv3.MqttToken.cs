using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttToken", DoNotGenerateAcw=true)]
	public partial class MqttToken : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/field[@name='internalTok']"
		[Register ("internalTok")]
		public global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token InternalTok {
			get {
				const string __id = "internalTok.Lorg/eclipse/paho/client/mqttv3/internal/Token;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Token> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "internalTok.Lorg/eclipse/paho/client/mqttv3/internal/Token;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttToken", typeof (MqttToken));
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

		protected MqttToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/constructor[@name='MqttToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttToken ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/constructor[@name='MqttToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MqttToken (string logContext)
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener listener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ActionCallback = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener ActionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getActionCallback' and count(parameter)=0]"
			[Register ("getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;", "GetGetActionCallbackHandler")]
			get {
				const string __id = "getActionCallback.()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='setActionCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getClient' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Lorg/eclipse/paho/client/mqttv3/MqttException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='isComplete' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		public virtual unsafe int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				const string __id = "getMessageId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getResponse' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool SessionPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getSessionPresent' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			__this.UserContext = userContext;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object UserContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getUserContext' and count(parameter)=0]"
			[Register ("getUserContext", "()Ljava/lang/Object;", "GetGetUserContextHandler")]
			get {
				const string __id = "getUserContext.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='setUserContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedQos ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getGrantedQos' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTopics ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='getTopics' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='waitForCompletion' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttToken']/method[@name='waitForCompletion' and count(parameter)=1 and parameter[1][@type='long']]"
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
