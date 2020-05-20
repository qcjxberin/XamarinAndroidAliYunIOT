using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request']/class[@name='MqttRrpcRequest']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/MqttRrpcRequest", DoNotGenerateAcw=true)]
	public partial class MqttRrpcRequest : global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentRequest {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request']/class[@name='MqttRrpcRequest']/field[@name='replyTopic']"
		[Register ("replyTopic")]
		public string ReplyTopic {
			get {
				const string __id = "replyTopic.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "replyTopic.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request']/class[@name='MqttRrpcRequest']/field[@name='topic']"
		[Register ("topic")]
		public string Topic {
			get {
				const string __id = "topic.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "topic.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/MqttRrpcRequest", typeof (MqttRrpcRequest));
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

		protected MqttRrpcRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request']/class[@name='MqttRrpcRequest']/constructor[@name='MqttRrpcRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttRrpcRequest ()
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

		static Delegate cb_setTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_setTopic_Ljava_lang_String_ == null)
				cb_setTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopic_Ljava_lang_String_);
			return cb_setTopic_Ljava_lang_String_;
		}

		static void n_SetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.MqttRrpcRequest __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.MqttRrpcRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTopic (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request']/class[@name='MqttRrpcRequest']/method[@name='setTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTopic", "(Ljava/lang/String;)V", "GetSetTopic_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTopic (string p0)
		{
			const string __id = "setTopic.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
