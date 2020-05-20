using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ExceptionHelper", DoNotGenerateAcw=true)]
	public partial class ExceptionHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/internal/ExceptionHelper", typeof (ExceptionHelper));
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

		protected ExceptionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='createMqttException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createMqttException", "(I)Lorg/eclipse/paho/client/mqttv3/MqttException;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException CreateMqttException (int reasonCode)
		{
			const string __id = "createMqttException.(I)Lorg/eclipse/paho/client/mqttv3/MqttException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (reasonCode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='createMqttException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("createMqttException", "(Ljava/lang/Throwable;)Lorg/eclipse/paho/client/mqttv3/MqttException;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttException CreateMqttException (global::Java.Lang.Throwable cause)
		{
			const string __id = "createMqttException.(Ljava/lang/Throwable;)Lorg/eclipse/paho/client/mqttv3/MqttException;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ExceptionHelper']/method[@name='isClassAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isClassAvailable", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsClassAvailable (string className)
		{
			const string __id = "isClassAvailable.(Ljava/lang/String;)Z";
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

	}
}
