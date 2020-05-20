using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/util/Debug", DoNotGenerateAcw=true)]
	public partial class Debug : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/util/Debug", typeof (Debug));
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

		protected Debug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/constructor[@name='Debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "")]
		public unsafe Debug (string clientID, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms comms)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_clientID = JNIEnv.NewString (clientID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientID);
				__args [1] = new JniArgumentValue ((comms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comms).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientID);
			}
		}

		static Delegate cb_dumpBaseDebug;
#pragma warning disable 0169
		static Delegate GetDumpBaseDebugHandler ()
		{
			if (cb_dumpBaseDebug == null)
				cb_dumpBaseDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpBaseDebug);
			return cb_dumpBaseDebug;
		}

		static void n_DumpBaseDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpBaseDebug ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpBaseDebug' and count(parameter)=0]"
		[Register ("dumpBaseDebug", "()V", "GetDumpBaseDebugHandler")]
		public virtual unsafe void DumpBaseDebug ()
		{
			const string __id = "dumpBaseDebug.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpClientComms;
#pragma warning disable 0169
		static Delegate GetDumpClientCommsHandler ()
		{
			if (cb_dumpClientComms == null)
				cb_dumpClientComms = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientComms);
			return cb_dumpClientComms;
		}

		static void n_DumpClientComms (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientComms ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientComms' and count(parameter)=0]"
		[Register ("dumpClientComms", "()V", "GetDumpClientCommsHandler")]
		public virtual unsafe void DumpClientComms ()
		{
			const string __id = "dumpClientComms.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpClientDebug;
#pragma warning disable 0169
		static Delegate GetDumpClientDebugHandler ()
		{
			if (cb_dumpClientDebug == null)
				cb_dumpClientDebug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientDebug);
			return cb_dumpClientDebug;
		}

		static void n_DumpClientDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientDebug ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientDebug' and count(parameter)=0]"
		[Register ("dumpClientDebug", "()V", "GetDumpClientDebugHandler")]
		public virtual unsafe void DumpClientDebug ()
		{
			const string __id = "dumpClientDebug.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpClientState;
#pragma warning disable 0169
		static Delegate GetDumpClientStateHandler ()
		{
			if (cb_dumpClientState == null)
				cb_dumpClientState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpClientState);
			return cb_dumpClientState;
		}

		static void n_DumpClientState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpClientState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpClientState' and count(parameter)=0]"
		[Register ("dumpClientState", "()V", "GetDumpClientStateHandler")]
		public virtual unsafe void DumpClientState ()
		{
			const string __id = "dumpClientState.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpConOptions;
#pragma warning disable 0169
		static Delegate GetDumpConOptionsHandler ()
		{
			if (cb_dumpConOptions == null)
				cb_dumpConOptions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpConOptions);
			return cb_dumpConOptions;
		}

		static void n_DumpConOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpConOptions ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpConOptions' and count(parameter)=0]"
		[Register ("dumpConOptions", "()V", "GetDumpConOptionsHandler")]
		public virtual unsafe void DumpConOptions ()
		{
			const string __id = "dumpConOptions.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpMemoryTrace;
#pragma warning disable 0169
		static Delegate GetDumpMemoryTraceHandler ()
		{
			if (cb_dumpMemoryTrace == null)
				cb_dumpMemoryTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpMemoryTrace);
			return cb_dumpMemoryTrace;
		}

		static void n_DumpMemoryTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpMemoryTrace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpMemoryTrace' and count(parameter)=0]"
		[Register ("dumpMemoryTrace", "()V", "GetDumpMemoryTraceHandler")]
		protected virtual unsafe void DumpMemoryTrace ()
		{
			const string __id = "dumpMemoryTrace.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpProperties' and count(parameter)=2 and parameter[1][@type='java.util.Properties'] and parameter[2][@type='java.lang.String']]"
		[Register ("dumpProperties", "(Ljava/util/Properties;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DumpProperties (global::Java.Util.Properties props, string name)
		{
			const string __id = "dumpProperties.(Ljava/util/Properties;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((props == null) ? IntPtr.Zero : ((global::Java.Lang.Object) props).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_dumpSystemProperties;
#pragma warning disable 0169
		static Delegate GetDumpSystemPropertiesHandler ()
		{
			if (cb_dumpSystemProperties == null)
				cb_dumpSystemProperties = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpSystemProperties);
			return cb_dumpSystemProperties;
		}

		static void n_DumpSystemProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpSystemProperties ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpSystemProperties' and count(parameter)=0]"
		[Register ("dumpSystemProperties", "()V", "GetDumpSystemPropertiesHandler")]
		public virtual unsafe void DumpSystemProperties ()
		{
			const string __id = "dumpSystemProperties.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dumpVersion;
#pragma warning disable 0169
		static Delegate GetDumpVersionHandler ()
		{
			if (cb_dumpVersion == null)
				cb_dumpVersion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpVersion);
			return cb_dumpVersion;
		}

		static void n_DumpVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpVersion ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='dumpVersion' and count(parameter)=0]"
		[Register ("dumpVersion", "()V", "GetDumpVersionHandler")]
		protected virtual unsafe void DumpVersion ()
		{
			const string __id = "dumpVersion.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Debug']/method[@name='left' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("left", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string Left (string s, int width, char fillChar)
		{
			const string __id = "left.(Ljava/lang/String;IC)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (fillChar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
