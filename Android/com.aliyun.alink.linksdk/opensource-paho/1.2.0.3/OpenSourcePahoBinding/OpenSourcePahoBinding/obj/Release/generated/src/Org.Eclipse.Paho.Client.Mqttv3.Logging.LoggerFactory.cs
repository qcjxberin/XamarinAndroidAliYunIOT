using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/LoggerFactory", DoNotGenerateAcw=true)]
	public partial class LoggerFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/field[@name='MQTT_CLIENT_MSG_CAT']"
		[Register ("MQTT_CLIENT_MSG_CAT")]
		public const string MqttClientMsgCat = (string) "org.eclipse.paho.client.mqttv3.internal.nls.logcat";
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/logging/LoggerFactory", typeof (LoggerFactory));
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

		protected LoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/constructor[@name='LoggerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='getLogger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLogger", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/logging/Logger;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger GetLogger (string messageCatalogName, string loggerID)
		{
			const string __id = "getLogger.(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/logging/Logger;";
			IntPtr native_messageCatalogName = JNIEnv.NewString (messageCatalogName);
			IntPtr native_loggerID = JNIEnv.NewString (loggerID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_messageCatalogName);
				__args [1] = new JniArgumentValue (native_loggerID);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messageCatalogName);
				JNIEnv.DeleteLocalRef (native_loggerID);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='getLoggingProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLoggingProperty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLoggingProperty (string name)
		{
			const string __id = "getLoggingProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLogger", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetLogger (string loggerClassName)
		{
			const string __id = "setLogger.(Ljava/lang/String;)V";
			IntPtr native_loggerClassName = JNIEnv.NewString (loggerClassName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_loggerClassName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_loggerClassName);
			}
		}

	}
}
