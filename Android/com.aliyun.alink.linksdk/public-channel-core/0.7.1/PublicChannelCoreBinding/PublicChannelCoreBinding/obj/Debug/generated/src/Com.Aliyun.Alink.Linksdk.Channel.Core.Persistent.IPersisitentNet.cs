using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']"
	[Register ("com/aliyun/alink/linksdk/channel/core/persistent/IPersisitentNet", "", "Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker")]
	public partial interface IPersisitentNet : global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.INet {

		global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentConnectState ConnectState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='getConnectState' and count(parameter)=0]"
			[Register ("getConnectState", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentConnectState;", "GetGetConnectStateHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='destroy' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("destroy", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", "GetDestroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void Destroy (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.PersistentInitParams']]"
		[Register ("init", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;)V", "GetInit_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void Init (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='openLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("openLog", "(Z)V", "GetOpenLog_ZHandler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void OpenLog (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request.PersisitentNetParams'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/PersisitentNetParams;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='subscribeRrpc' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener']]"
		[Register ("subscribeRrpc", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener;)V", "GetSubscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void SubscribeRrpc (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/interface[@name='IPersisitentNet']/method[@name='unSubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("unSubscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetUnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler:Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNetInvoker, PublicChannelCoreBinding")]
		void UnSubscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/IPersisitentNet", DoNotGenerateAcw=true)]
	internal partial class IPersisitentNetInvoker : global::Java.Lang.Object, IPersisitentNet {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/IPersisitentNet", typeof (IPersisitentNetInvoker));

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

		public static IPersisitentNet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPersisitentNet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.channel.core.persistent.IPersisitentNet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPersisitentNetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getConnectState;
#pragma warning disable 0169
		static Delegate GetGetConnectStateHandler ()
		{
			if (cb_getConnectState == null)
				cb_getConnectState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectState);
			return cb_getConnectState;
		}

		static IntPtr n_GetConnectState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectState);
		}
#pragma warning restore 0169

		IntPtr id_getConnectState;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentConnectState ConnectState {
			get {
				if (id_getConnectState == IntPtr.Zero)
					id_getConnectState = JNIEnv.GetMethodID (class_ref, "getConnectState", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentConnectState;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentConnectState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDestroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static void n_Destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Destroy (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe void Destroy (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "destroy", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args);
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_ == null)
				cb_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_);
			return cb_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_;
		}

		static void n_Init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_;
		public unsafe void Init (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams p1)
		{
			if (id_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_, __args);
		}

		static Delegate cb_openLog_Z;
#pragma warning disable 0169
		static Delegate GetOpenLog_ZHandler ()
		{
			if (cb_openLog_Z == null)
				cb_openLog_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OpenLog_Z);
			return cb_openLog_Z;
		}

		static void n_OpenLog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenLog (p0);
		}
#pragma warning restore 0169

		IntPtr id_openLog_Z;
		public unsafe void OpenLog (bool p0)
		{
			if (id_openLog_Z == IntPtr.Zero)
				id_openLog_Z = JNIEnv.GetMethodID (class_ref, "openLog", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openLog_Z, __args);
		}

		static Delegate cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == null)
				cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_);
			return cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		}

		static void n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		public unsafe void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1)
		{
			if (id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == null)
				cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_);
			return cb_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		}

		static void n_Subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		public unsafe void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p2)
		{
			if (id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/PersisitentNetParams;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_;
#pragma warning disable 0169
		static Delegate GetSubscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_Handler ()
		{
			if (cb_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_ == null)
				cb_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_);
			return cb_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_;
		}

		static void n_SubscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeRrpc (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_;
		public unsafe void SubscribeRrpc (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener p1)
		{
			if (id_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_ == IntPtr.Zero)
				id_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_ = JNIEnv.GetMethodID (class_ref, "subscribeRrpc", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
#pragma warning disable 0169
		static Delegate GetUnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler ()
		{
			if (cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == null)
				cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_);
			return cb_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		}

		static void n_UnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribe (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_;
		public unsafe void UnSubscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1)
		{
			if (id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ == IntPtr.Zero)
				id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_ = JNIEnv.GetMethodID (class_ref, "unSubscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_Handler ()
		{
			if (cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ == null)
				cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_);
			return cb_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
		}

		static IntPtr n_AsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSend (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1)
		{
			if (id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ == IntPtr.Zero)
				id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_ = JNIEnv.GetMethodID (class_ref, "asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)Lcom/aliyun/alink/linksdk/channel/core/base/ASend;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
#pragma warning disable 0169
		static Delegate GetRetry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler ()
		{
			if (cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == null)
				cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_);
			return cb_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		}

		static void n_Retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Retry (p0);
		}
#pragma warning restore 0169

		IntPtr id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_;
		public unsafe void Retry (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0)
		{
			if (id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ == IntPtr.Zero)
				id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_, __args);
		}

	}

}
