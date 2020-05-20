using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttActionListener']"
	[Register ("org/eclipse/paho/client/mqttv3/IMqttActionListener", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerInvoker")]
	public partial interface IMqttActionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttActionListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V", "GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerInvoker, OpenSourcePahoBinding")]
		void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttActionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttToken']]"
		[Register ("onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V", "GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListenerInvoker, OpenSourcePahoBinding")]
		void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/IMqttActionListener", DoNotGenerateAcw=true)]
	internal partial class IMqttActionListenerInvoker : global::Java.Lang.Object, IMqttActionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/IMqttActionListener", typeof (IMqttActionListenerInvoker));

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

		public static IMqttActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttActionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.IMqttActionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == null)
				cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_);
			return cb_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_;
		public unsafe void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0, global::Java.Lang.Throwable p1)
		{
			if (id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_Handler ()
		{
			if (cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ == null)
				cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_);
			return cb_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
		}

		static void n_OnSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_;
		public unsafe void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0)
		{
			if (id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ == IntPtr.Zero)
				id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/eclipse/paho/client/mqttv3/IMqttToken;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lorg_eclipse_paho_client_mqttv3_IMqttToken_, __args);
		}

	}

	// event args for org.eclipse.paho.client.mqttv3.IMqttActionListener.onFailure
	public partial class FailureEventArgs : global::System.EventArgs {

		public FailureEventArgs (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0, global::Java.Lang.Throwable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0;
		public global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken P0 {
			get { return p0; }
		}

		global::Java.Lang.Throwable p1;
		public global::Java.Lang.Throwable P1 {
			get { return p1; }
		}
	}

	// event args for org.eclipse.paho.client.mqttv3.IMqttActionListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0)
		{
			this.p0 = p0;
		}

		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0;
		public global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/eclipse/paho/client/mqttv3/IMqttActionListenerImplementor")]
	internal sealed partial class IMqttActionListenerImplementor : global::Java.Lang.Object, IMqttActionListener {

		object sender;

		public IMqttActionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/eclipse/paho/client/mqttv3/IMqttActionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

		public void OnFailure (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0, global::Java.Lang.Throwable p1)
		{
			var __h = OnFailureHandler;
			if (__h != null)
				__h (sender, new FailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IMqttActionListenerImplementor value)
		{
			return value.OnFailureHandler == null && value.OnSuccessHandler == null;
		}
	}

}
