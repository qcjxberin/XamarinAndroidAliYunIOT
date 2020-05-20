using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']"
	[Register ("org/eclipse/paho/client/mqttv3/MqttClientPersistence", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker")]
	public partial interface IMqttClientPersistence : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		bool ContainsKey (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttPersistable;", "GetGet_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/Enumeration;", "GetKeysHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		global::Java.Util.IEnumeration Keys ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOpen_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		void Open (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttPersistable']]"
		[Register ("put", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)V", "GetPut_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		void Put (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='MqttClientPersistence']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistenceInvoker, OpenSourcePahoBinding")]
		void Remove (string p0);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttClientPersistence", DoNotGenerateAcw=true)]
	internal partial class IMqttClientPersistenceInvoker : global::Java.Lang.Object, IMqttClientPersistence {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttClientPersistence", typeof (IMqttClientPersistenceInvoker));

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

		public static IMqttClientPersistence GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttClientPersistence> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.MqttClientPersistence"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttClientPersistenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsKey_Ljava_lang_String_;
		public unsafe bool ContainsKey (string p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttPersistable;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_keys;
#pragma warning disable 0169
		static Delegate GetKeysHandler ()
		{
			if (cb_keys == null)
				cb_keys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Keys);
			return cb_keys;
		}

		static IntPtr n_Keys (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		IntPtr id_keys;
		public unsafe global::Java.Util.IEnumeration Keys ()
		{
			if (id_keys == IntPtr.Zero)
				id_keys = JNIEnv.GetMethodID (class_ref, "keys", "()Ljava/util/Enumeration;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keys), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_open_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Open_Ljava_lang_String_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Open_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_open_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Open (string p0, string p1)
		{
			if (id_open_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ == null)
				cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_);
			return cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
		}

		static void n_Put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable p1 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
		public unsafe void Put (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable p1)
		{
			if (id_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
