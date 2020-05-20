using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Persist {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/persist/MemoryPersistence", DoNotGenerateAcw=true)]
	public partial class MemoryPersistence : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/persist/MemoryPersistence", typeof (MemoryPersistence));
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

		protected MemoryPersistence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/constructor[@name='MemoryPersistence' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MemoryPersistence ()
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsKey (string key)
		{
			const string __id = "containsKey.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttPersistable;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttPersistable;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/Enumeration;", "GetKeysHandler")]
		public virtual unsafe global::Java.Util.IEnumeration Keys ()
		{
			const string __id = "keys.()Ljava/util/Enumeration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_open_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Open_Ljava_lang_String_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Open_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId, IntPtr native_serverURI)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			string serverURI = JNIEnv.GetString (native_serverURI, JniHandleOwnership.DoNotTransfer);
			__this.Open (clientId, serverURI);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOpen_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Open (string clientId, string serverURI)
		{
			const string __id = "open.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_serverURI);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_serverURI);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ == null)
				cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_);
			return cb_put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_;
		}

		static void n_Put_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_persistable)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable persistable = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable> (native_persistable, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, persistable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttPersistable']]"
		[Register ("put", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)V", "GetPut_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttPersistable_Handler")]
		public virtual unsafe void Put (string key, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPersistable persistable)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttPersistable;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((persistable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) persistable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.MemoryPersistence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='MemoryPersistence']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string key)
		{
			const string __id = "remove.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
