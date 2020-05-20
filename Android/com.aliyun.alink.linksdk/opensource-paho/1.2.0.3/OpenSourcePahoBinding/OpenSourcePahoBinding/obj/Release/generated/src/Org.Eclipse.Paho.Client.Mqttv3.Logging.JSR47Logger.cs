using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/JSR47Logger", DoNotGenerateAcw=true)]
	public partial class JSR47Logger : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger {


		public static class InterfaceConsts {

			// The following are fields from: org.eclipse.paho.client.mqttv3.logging.Logger
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/logging/JSR47Logger", typeof (JSR47Logger));
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

		protected JSR47Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/constructor[@name='JSR47Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JSR47Logger ()
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

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Config (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='config' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Config (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "config.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Config (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='config' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Config (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "config.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_thrown)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable thrown = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_thrown, JniHandleOwnership.DoNotTransfer);
			__this.Config (sourceClass, sourceMethod, msg, inserts, thrown);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='config' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Config (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable thrown)
		{
			const string __id = "config.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((thrown == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrown).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='dumpMemoryTrace47' and count(parameter)=1 and parameter[1][@type='java.util.logging.Logger']]"
		[Register ("dumpMemoryTrace47", "(Ljava/util/logging/Logger;)V", "")]
		protected static unsafe void DumpMemoryTrace47 (global::Java.Util.Logging.Logger logger)
		{
			const string __id = "dumpMemoryTrace47.(Ljava/util/logging/Logger;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_dumpTrace;
#pragma warning disable 0169
		static Delegate GetDumpTraceHandler ()
		{
			if (cb_dumpTrace == null)
				cb_dumpTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpTrace);
			return cb_dumpTrace;
		}

		static void n_DumpTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpTrace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='dumpTrace' and count(parameter)=0]"
		[Register ("dumpTrace", "()V", "GetDumpTraceHandler")]
		public virtual unsafe void DumpTrace ()
		{
			const string __id = "dumpTrace.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Fine (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='fine' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Fine (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "fine.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fine (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='fine' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Fine (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "fine.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.Fine (sourceClass, sourceMethod, msg, inserts, ex);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='fine' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Fine (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable ex)
		{
			const string __id = "fine.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Finer (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Finer (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "finer.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Finer (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finer' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Finer (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "finer.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.Finer (sourceClass, sourceMethod, msg, inserts, ex);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finer' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Finer (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable ex)
		{
			const string __id = "finer.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Finest (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Finest (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "finest.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Finest (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Finest (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "finest.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.Finest (sourceClass, sourceMethod, msg, inserts, ex);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='finest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Finest (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable ex)
		{
			const string __id = "finest.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewString (__this.FormatMessage (msg, inserts));
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='formatMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe string FormatMessage (string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "formatMessage.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (native_inserts);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Info (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Info (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='info' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Info (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_thrown)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable thrown = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_thrown, JniHandleOwnership.DoNotTransfer);
			__this.Info (sourceClass, sourceMethod, msg, inserts, thrown);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='info' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Info (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable thrown)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((thrown == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrown).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_);
			return cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logMsgCatalog, IntPtr native_loggerID, IntPtr native_resourceContext)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.ResourceBundle logMsgCatalog = global::Java.Lang.Object.GetObject<global::Java.Util.ResourceBundle> (native_logMsgCatalog, JniHandleOwnership.DoNotTransfer);
			string loggerID = JNIEnv.GetString (native_loggerID, JniHandleOwnership.DoNotTransfer);
			string resourceContext = JNIEnv.GetString (native_resourceContext, JniHandleOwnership.DoNotTransfer);
			__this.Initialise (logMsgCatalog, loggerID, resourceContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='initialise' and count(parameter)=3 and parameter[1][@type='java.util.ResourceBundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("initialise", "(Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/String;)V", "GetInitialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Initialise (global::Java.Util.ResourceBundle logMsgCatalog, string loggerID, string resourceContext)
		{
			const string __id = "initialise.(Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_loggerID = JNIEnv.NewString (loggerID);
			IntPtr native_resourceContext = JNIEnv.NewString (resourceContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((logMsgCatalog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logMsgCatalog).Handle);
				__args [1] = new JniArgumentValue (native_loggerID);
				__args [2] = new JniArgumentValue (native_resourceContext);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_loggerID);
				JNIEnv.DeleteLocalRef (native_resourceContext);
			}
		}

		static Delegate cb_isLoggable_I;
#pragma warning disable 0169
		static Delegate GetIsLoggable_IHandler ()
		{
			if (cb_isLoggable_I == null)
				cb_isLoggable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsLoggable_I);
			return cb_isLoggable_I;
		}

		static bool n_IsLoggable_I (IntPtr jnienv, IntPtr native__this, int level)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggable (level);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='isLoggable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoggable", "(I)Z", "GetIsLoggable_IHandler")]
		public virtual unsafe bool IsLoggable (int level)
		{
			const string __id = "isLoggable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int level, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_thrown)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable thrown = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_thrown, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, sourceClass, sourceMethod, msg, inserts, thrown);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='log' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]'] and parameter[6][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (int level, string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable thrown)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (level);
				__args [1] = new JniArgumentValue (native_sourceClass);
				__args [2] = new JniArgumentValue (native_sourceMethod);
				__args [3] = new JniArgumentValue (native_msg);
				__args [4] = new JniArgumentValue (native_inserts);
				__args [5] = new JniArgumentValue ((thrown == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrown).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_setResourceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceName_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceName_Ljava_lang_String_ == null)
				cb_setResourceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceName_Ljava_lang_String_);
			return cb_setResourceName_Ljava_lang_String_;
		}

		static void n_SetResourceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logContext)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string logContext = JNIEnv.GetString (native_logContext, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceName (logContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='setResourceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResourceName", "(Ljava/lang/String;)V", "GetSetResourceName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetResourceName (string logContext)
		{
			const string __id = "setResourceName.(Ljava/lang/String;)V";
			IntPtr native_logContext = JNIEnv.NewString (logContext);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_logContext);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logContext);
			}
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Severe (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='severe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Severe (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "severe.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Severe (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='severe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Severe (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "severe.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_thrown)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable thrown = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_thrown, JniHandleOwnership.DoNotTransfer);
			__this.Severe (sourceClass, sourceMethod, msg, inserts, thrown);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='severe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Severe (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable thrown)
		{
			const string __id = "severe.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((thrown == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrown).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int level, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_ex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.Trace (level, sourceClass, sourceMethod, msg, inserts, ex);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='trace' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]'] and parameter[6][@type='java.lang.Throwable']]"
		[Register ("trace", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetTrace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Trace (int level, string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable ex)
		{
			const string __id = "trace.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (level);
				__args [1] = new JniArgumentValue (native_sourceClass);
				__args [2] = new JniArgumentValue (native_sourceMethod);
				__args [3] = new JniArgumentValue (native_msg);
				__args [4] = new JniArgumentValue (native_inserts);
				__args [5] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Warning (sourceClass, sourceMethod, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='warning' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Warning (string sourceClass, string sourceMethod, string msg)
		{
			const string __id = "warning.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warning (sourceClass, sourceMethod, msg, inserts);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='warning' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Warning (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts)
		{
			const string __id = "warning.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sourceClass, IntPtr native_sourceMethod, IntPtr native_msg, IntPtr native_inserts, IntPtr native_thrown)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.JSR47Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sourceClass = JNIEnv.GetString (native_sourceClass, JniHandleOwnership.DoNotTransfer);
			string sourceMethod = JNIEnv.GetString (native_sourceMethod, JniHandleOwnership.DoNotTransfer);
			string msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] inserts = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_inserts, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable thrown = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_thrown, JniHandleOwnership.DoNotTransfer);
			__this.Warning (sourceClass, sourceMethod, msg, inserts, thrown);
			if (inserts != null)
				JNIEnv.CopyArray (inserts, native_inserts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='JSR47Logger']/method[@name='warning' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Warning (string sourceClass, string sourceMethod, string msg, global::Java.Lang.Object[] inserts, global::Java.Lang.Throwable thrown)
		{
			const string __id = "warning.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";
			IntPtr native_sourceClass = JNIEnv.NewString (sourceClass);
			IntPtr native_sourceMethod = JNIEnv.NewString (sourceMethod);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_inserts = JNIEnv.NewArray (inserts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_sourceClass);
				__args [1] = new JniArgumentValue (native_sourceMethod);
				__args [2] = new JniArgumentValue (native_msg);
				__args [3] = new JniArgumentValue (native_inserts);
				__args [4] = new JniArgumentValue ((thrown == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) thrown).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceClass);
				JNIEnv.DeleteLocalRef (native_sourceMethod);
				JNIEnv.DeleteLocalRef (native_msg);
				if (inserts != null) {
					JNIEnv.CopyArray (native_inserts, inserts);
					JNIEnv.DeleteLocalRef (native_inserts);
				}
			}
		}

	}
}
