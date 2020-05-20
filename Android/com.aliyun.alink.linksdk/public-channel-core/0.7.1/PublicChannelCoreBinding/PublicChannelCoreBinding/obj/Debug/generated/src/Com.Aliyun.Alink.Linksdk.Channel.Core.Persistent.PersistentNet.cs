using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/channel/core/persistent/PersistentNet", DoNotGenerateAcw=true)]
	public partial class PersistentNet : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IPersisitentNet {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/channel/core/persistent/PersistentNet", typeof (PersistentNet));
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

		protected PersistentNet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/constructor[@name='PersistentNet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PersistentNet ()
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentConnectState ConnectState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='getConnectState' and count(parameter)=0]"
			[Register ("getConnectState", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentConnectState;", "GetGetConnectStateHandler")]
			get {
				const string __id = "getConnectState.()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentConnectState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentConnectState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultProtocol;
#pragma warning disable 0169
		static Delegate GetGetDefaultProtocolHandler ()
		{
			if (cb_getDefaultProtocol == null)
				cb_getDefaultProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultProtocol);
			return cb_getDefaultProtocol;
		}

		static IntPtr n_GetDefaultProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultProtocol);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultProtocol_Ljava_lang_String_ == null)
				cb_setDefaultProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultProtocol_Ljava_lang_String_);
			return cb_setDefaultProtocol_Ljava_lang_String_;
		}

		static void n_SetDefaultProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultProtocol = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DefaultProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='getDefaultProtocol' and count(parameter)=0]"
			[Register ("getDefaultProtocol", "()Ljava/lang/String;", "GetGetDefaultProtocolHandler")]
			get {
				const string __id = "getDefaultProtocol.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='setDefaultProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDefaultProtocol", "(Ljava/lang/String;)V", "GetSetDefaultProtocol_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDefaultProtocol.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInitParams;
#pragma warning disable 0169
		static Delegate GetGetInitParamsHandler ()
		{
			if (cb_getInitParams == null)
				cb_getInitParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitParams);
			return cb_getInitParams;
		}

		static IntPtr n_GetInitParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitParams);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams InitParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='getInitParams' and count(parameter)=0]"
			[Register ("getInitParams", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;", "GetGetInitParamsHandler")]
			get {
				const string __id = "getInitParams.()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentNet;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentNet;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSDKVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKVersionHandler ()
		{
			if (cb_getSDKVersion == null)
				cb_getSDKVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKVersion);
			return cb_getSDKVersion;
		}

		static IntPtr n_GetSDKVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				const string __id = "getSDKVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AsyncSend (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='asyncSend' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ARequest'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.base.IOnCallListener']]"
		[Register ("asyncSend", "(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)Lcom/aliyun/alink/linksdk/channel/core/base/ASend;", "GetAsyncSend_Lcom_aliyun_alink_linksdk_channel_core_base_ARequest_Lcom_aliyun_alink_linksdk_channel_core_base_IOnCallListener_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend AsyncSend (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ARequest p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.IOnCallListener p1)
		{
			const string __id = "asyncSend.(Lcom/aliyun/alink/linksdk/channel/core/base/ARequest;Lcom/aliyun/alink/linksdk/channel/core/base/IOnCallListener;)Lcom/aliyun/alink/linksdk/channel/core/base/ASend;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Destroy (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='destroy' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("destroy", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V", "GetDestroy_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe void Destroy (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			const string __id = "destroy.(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.PersistentInitParams']]"
		[Register ("init", "(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;)V", "GetInit_Landroid_content_Context_Lcom_aliyun_alink_linksdk_channel_core_persistent_PersistentInitParams_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentInitParams p1)
		{
			const string __id = "init.(Landroid/content/Context;Lcom/aliyun/alink/linksdk/channel/core/persistent/PersistentInitParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenLog (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='openLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("openLog", "(Z)V", "GetOpenLog_ZHandler")]
		public virtual unsafe void OpenLog (bool p0)
		{
			const string __id = "openLog.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Retry (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.channel.core.base.ASend']]"
		[Register ("retry", "(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V", "GetRetry_Lcom_aliyun_alink_linksdk_channel_core_base_ASend_Handler")]
		public virtual unsafe void Retry (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Base.ASend p0)
		{
			const string __id = "retry.(Lcom/aliyun/alink/linksdk/channel/core/base/ASend;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setReportVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReportVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setReportVersion_Ljava_lang_String_ == null)
				cb_setReportVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReportVersion_Ljava_lang_String_);
			return cb_setReportVersion_Ljava_lang_String_;
		}

		static void n_SetReportVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReportVersion (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='setReportVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReportVersion", "(Ljava/lang/String;)V", "GetSetReportVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetReportVersion (string p0)
		{
			const string __id = "setReportVersion.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler")]
		public virtual unsafe void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p2 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.mqtt.request.PersisitentNetParams'] and parameter[3][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("subscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/PersisitentNetParams;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_mqtt_request_PersisitentNetParams_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler")]
		public virtual unsafe void Subscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.Mqtt.Request.PersisitentNetParams p1, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p2)
		{
			const string __id = "subscribe.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/mqtt/request/PersisitentNetParams;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeRrpc (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='subscribeRrpc' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeRrpcListener']]"
		[Register ("subscribeRrpc", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener;)V", "GetSubscribeRrpc_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeRrpcListener_Handler")]
		public virtual unsafe void SubscribeRrpc (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeRrpcListener p1)
		{
			const string __id = "subscribeRrpc.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeRrpcListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.PersistentNet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribe (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.channel.core.persistent']/class[@name='PersistentNet']/method[@name='unSubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.channel.core.persistent.IOnSubscribeListener']]"
		[Register ("unSubscribe", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V", "GetUnSubscribe_Ljava_lang_String_Lcom_aliyun_alink_linksdk_channel_core_persistent_IOnSubscribeListener_Handler")]
		public virtual unsafe void UnSubscribe (string p0, global::Com.Aliyun.Alink.Linksdk.Channel.Core.Persistent.IOnSubscribeListener p1)
		{
			const string __id = "unSubscribe.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/channel/core/persistent/IOnSubscribeListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
