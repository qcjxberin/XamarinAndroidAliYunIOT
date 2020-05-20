using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus", DoNotGenerateAcw=true)]
	public sealed partial class MqttSendStatus : global::Java.Lang.Enum, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ISendStatus {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='completed']"
		[Register ("completed")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus Completed {
			get {
				const string __id = "completed.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='published']"
		[Register ("published")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus Published {
			get {
				const string __id = "published.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='subReplyed']"
		[Register ("subReplyed")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus SubReplyed {
			get {
				const string __id = "subReplyed.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='waitingToComplete']"
		[Register ("waitingToComplete")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus WaitingToComplete {
			get {
				const string __id = "waitingToComplete.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='waitingToPublish']"
		[Register ("waitingToPublish")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus WaitingToPublish {
			get {
				const string __id = "waitingToPublish.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='waitingToSend']"
		[Register ("waitingToSend")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus WaitingToSend {
			get {
				const string __id = "waitingToSend.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/field[@name='waitingToSubReply']"
		[Register ("waitingToSubReply")]
		public static global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus WaitingToSubReply {
			get {
				const string __id = "waitingToSubReply.Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus", typeof (MqttSendStatus));
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

		internal MqttSendStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.send']/class[@name='MqttSendStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;", "")]
		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus[] Values ()
		{
			const string __id = "values.()[Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/send/MqttSendStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Send.MqttSendStatus));
			} finally {
			}
		}

	}
}
