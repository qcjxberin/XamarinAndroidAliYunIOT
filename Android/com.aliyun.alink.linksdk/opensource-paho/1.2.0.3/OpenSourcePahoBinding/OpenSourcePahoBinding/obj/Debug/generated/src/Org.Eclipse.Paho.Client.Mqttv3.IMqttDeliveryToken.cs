using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttDeliveryToken']"
	[Register ("org/eclipse/paho/client/mqttv3/IMqttDeliveryToken", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryTokenInvoker")]
	public partial interface IMqttDeliveryToken : global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken {

		global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttDeliveryToken']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetMessageHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryTokenInvoker, OpenSourcePahoBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/IMqttDeliveryToken", DoNotGenerateAcw=true)]
	internal partial class IMqttDeliveryTokenInvoker : global::Java.Lang.Object, IMqttDeliveryToken {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/IMqttDeliveryToken", typeof (IMqttDeliveryTokenInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMqttDeliveryToken GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttDeliveryToken> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.IMqttDeliveryToken"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttDeliveryTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lorg/eclipse/paho/client/mqttv3/MqttMessage;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getActionCallback;
		IntPtr id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener ActionCallback {
			get {
				if (id_getActionCallback == IntPtr.Zero)
					id_getActionCallback = JNIEnv.GetMethodID (class_ref, "getActionCallback", "()Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
					id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "setActionCallback", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionCallback_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		IntPtr id_getClient;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			get {
				if (id_getClient == IntPtr.Zero)
					id_getClient = JNIEnv.GetMethodID (class_ref, "getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClient), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		IntPtr id_getException;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException Exception {
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Lorg/eclipse/paho/client/mqttv3/MqttException;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getException), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		IntPtr id_isComplete;
		public unsafe bool IsComplete {
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isComplete);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		IntPtr id_getMessageId;
		public unsafe int MessageId {
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageId);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		IntPtr id_getResponse;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage Response {
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;");
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SessionPresent;
		}
#pragma warning restore 0169

		IntPtr id_getSessionPresent;
		public unsafe bool SessionPresent {
			get {
				if (id_getSessionPresent == IntPtr.Zero)
					id_getSessionPresent = JNIEnv.GetMethodID (class_ref, "getSessionPresent", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSessionPresent);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetUserContext_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserContext = p0;
		}
#pragma warning restore 0169

		IntPtr id_getUserContext;
		IntPtr id_setUserContext_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object UserContext {
			get {
				if (id_getUserContext == IntPtr.Zero)
					id_getUserContext = JNIEnv.GetMethodID (class_ref, "getUserContext", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserContext), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setUserContext_Ljava_lang_Object_ == IntPtr.Zero)
					id_setUserContext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setUserContext", "(Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserContext_Ljava_lang_Object_, __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGrantedQos ());
		}
#pragma warning restore 0169

		IntPtr id_getGrantedQos;
		public unsafe int[] GetGrantedQos ()
		{
			if (id_getGrantedQos == IntPtr.Zero)
				id_getGrantedQos = JNIEnv.GetMethodID (class_ref, "getGrantedQos", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantedQos), JniHandleOwnership.TransferLocalRef, typeof (int));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTopics ());
		}
#pragma warning restore 0169

		IntPtr id_getTopics;
		public unsafe string[] GetTopics ()
		{
			if (id_getTopics == IntPtr.Zero)
				id_getTopics = JNIEnv.GetMethodID (class_ref, "getTopics", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopics), JniHandleOwnership.TransferLocalRef, typeof (string));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion ();
		}
#pragma warning restore 0169

		IntPtr id_waitForCompletion;
		public unsafe void WaitForCompletion ()
		{
			if (id_waitForCompletion == IntPtr.Zero)
				id_waitForCompletion = JNIEnv.GetMethodID (class_ref, "waitForCompletion", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_waitForCompletion);
		}

		static Delegate cb_waitForCompletion_J;
#pragma warning disable 0169
		static Delegate GetWaitForCompletion_JHandler ()
		{
			if (cb_waitForCompletion_J == null)
				cb_waitForCompletion_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WaitForCompletion_J);
			return cb_waitForCompletion_J;
		}

		static void n_WaitForCompletion_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForCompletion (p0);
		}
#pragma warning restore 0169

		IntPtr id_waitForCompletion_J;
		public unsafe void WaitForCompletion (long p0)
		{
			if (id_waitForCompletion_J == IntPtr.Zero)
				id_waitForCompletion_J = JNIEnv.GetMethodID (class_ref, "waitForCompletion", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_waitForCompletion_J, __args);
		}

	}

}
