using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttTopic", DoNotGenerateAcw=true)]
	public partial class MqttTopic : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='MULTI_LEVEL_WILDCARD']"
		[Register ("MULTI_LEVEL_WILDCARD")]
		public const string MultiLevelWildcard = (string) "#";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='MULTI_LEVEL_WILDCARD_PATTERN']"
		[Register ("MULTI_LEVEL_WILDCARD_PATTERN")]
		public const string MultiLevelWildcardPattern = (string) "/#";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='SINGLE_LEVEL_WILDCARD']"
		[Register ("SINGLE_LEVEL_WILDCARD")]
		public const string SingleLevelWildcard = (string) "+";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='TOPIC_LEVEL_SEPARATOR']"
		[Register ("TOPIC_LEVEL_SEPARATOR")]
		public const string TopicLevelSeparator = (string) "/";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/field[@name='TOPIC_WILDCARDS']"
		[Register ("TOPIC_WILDCARDS")]
		public const string TopicWildcards = (string) "#+";
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/MqttTopic", typeof (MqttTopic));
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

		protected MqttTopic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/constructor[@name='MqttTopic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V", "")]
		public unsafe MqttTopic (string name, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms comms)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((comms == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comms).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='isMatched' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isMatched", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsMatched (string topicFilter, string topicName)
		{
			const string __id = "isMatched.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			IntPtr native_topicName = JNIEnv.NewString (topicName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topicFilter);
				__args [1] = new JniArgumentValue (native_topicName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
				JNIEnv.DeleteLocalRef (native_topicName);
			}
		}

		static Delegate cb_publish_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_arrayBIZHandler ()
		{
			if (cb_publish_arrayBIZ == null)
				cb_publish_arrayBIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_Publish_arrayBIZ);
			return cb_publish_arrayBIZ;
		}

		static IntPtr n_Publish_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload, int qos, bool retained)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (payload, qos, retained));
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='publish' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("publish", "([BIZ)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetPublish_arrayBIZHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken Publish (byte[] payload, int qos, bool retained)
		{
			const string __id = "publish.([BIZ)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;";
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_payload);
				__args [1] = new JniArgumentValue (qos);
				__args [2] = new JniArgumentValue (retained);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetPublish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static IntPtr n_Publish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (message));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='publish' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetPublish_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken Publish (global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message)
		{
			const string __id = "publish.(Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttTopic']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("validate", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void Validate (string topicString, bool wildcardAllowed)
		{
			const string __id = "validate.(Ljava/lang/String;Z)V";
			IntPtr native_topicString = JNIEnv.NewString (topicString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_topicString);
				__args [1] = new JniArgumentValue (wildcardAllowed);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicString);
			}
		}

	}
}
