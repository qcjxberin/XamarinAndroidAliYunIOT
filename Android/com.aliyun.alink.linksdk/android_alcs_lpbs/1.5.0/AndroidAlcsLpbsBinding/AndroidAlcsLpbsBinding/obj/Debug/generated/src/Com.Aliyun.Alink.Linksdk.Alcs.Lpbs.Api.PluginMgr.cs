using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgr", DoNotGenerateAcw=true)]
	public partial class PluginMgr : global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.IAlcsPal {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgr", typeof (PluginMgr));
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

		protected PluginMgr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgr;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgr;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJsEngine;
#pragma warning disable 0169
		static Delegate GetGetJsEngineHandler ()
		{
			if (cb_getJsEngine == null)
				cb_getJsEngine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsEngine);
			return cb_getJsEngine;
		}

		static IntPtr n_GetJsEngine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsEngine);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine JsEngine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getJsEngine' and count(parameter)=0]"
			[Register ("getJsEngine", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine;", "GetGetJsEngineHandler")]
			get {
				const string __id = "getJsEngine.()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/jsengine/IJSEngine;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Jsengine.IJSEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJsProvider;
#pragma warning disable 0169
		static Delegate GetGetJsProviderHandler ()
		{
			if (cb_getJsProvider == null)
				cb_getJsProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsProvider);
			return cb_getJsProvider;
		}

		static IntPtr n_GetJsProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsProvider);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider JsProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getJsProvider' and count(parameter)=0]"
			[Register ("getJsProvider", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider;", "GetGetJsProviderHandler")]
			get {
				const string __id = "getJsProvider.()Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IJsProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IJsProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPluginCount;
#pragma warning disable 0169
		static Delegate GetGetPluginCountHandler ()
		{
			if (cb_getPluginCount == null)
				cb_getPluginCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPluginCount);
			return cb_getPluginCount;
		}

		static int n_GetPluginCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PluginCount;
		}
#pragma warning restore 0169

		public virtual unsafe int PluginCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getPluginCount' and count(parameter)=0]"
			[Register ("getPluginCount", "()I", "GetGetPluginCountHandler")]
			get {
				const string __id = "getPluginCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPluginList;
#pragma warning disable 0169
		static Delegate GetGetPluginListHandler ()
		{
			if (cb_getPluginList == null)
				cb_getPluginList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPluginList);
			return cb_getPluginList;
		}

		static IntPtr n_GetPluginList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin>.ToLocalJniHandle (__this.PluginList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> PluginList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getPluginList' and count(parameter)=0]"
			[Register ("getPluginList", "()Ljava/util/Map;", "GetGetPluginListHandler")]
			get {
				const string __id = "getPluginList.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_;
#pragma warning disable 0169
		static Delegate GetAddPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_Handler ()
		{
			if (cb_addPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_ == null)
				cb_addPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_);
			return cb_addPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_;
		}

		static bool n_AddPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPlugin (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='addPlugin' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.plugin.IPlugin']]"
		[Register ("addPlugin", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;)Z", "GetAddPlugin_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_IPlugin_Handler")]
		public virtual unsafe bool AddPlugin (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin p0)
		{
			const string __id = "addPlugin.(Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_asyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_AsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AsyncSendRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='asyncSendRequest' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalReqMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("asyncSendRequest", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetAsyncSendRequest_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalReqMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool AsyncSendRequest (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalReqMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			const string __id = "asyncSendRequest.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalReqMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearDiscoveryDevInfo;
#pragma warning disable 0169
		static Delegate GetClearDiscoveryDevInfoHandler ()
		{
			if (cb_clearDiscoveryDevInfo == null)
				cb_clearDiscoveryDevInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDiscoveryDevInfo);
			return cb_clearDiscoveryDevInfo;
		}

		static void n_ClearDiscoveryDevInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDiscoveryDevInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='clearDiscoveryDevInfo' and count(parameter)=0]"
		[Register ("clearDiscoveryDevInfo", "()V", "GetClearDiscoveryDevInfoHandler")]
		public virtual unsafe void ClearDiscoveryDevInfo ()
		{
			const string __id = "clearDiscoveryDevInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deInitAlcs;
#pragma warning disable 0169
		static Delegate GetDeInitAlcsHandler ()
		{
			if (cb_deInitAlcs == null)
				cb_deInitAlcs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeInitAlcs);
			return cb_deInitAlcs;
		}

		static void n_DeInitAlcs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeInitAlcs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='deInitAlcs' and count(parameter)=0]"
		[Register ("deInitAlcs", "()V", "GetDeInitAlcsHandler")]
		public override unsafe void DeInitAlcs ()
		{
			const string __id = "deInitAlcs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDiscoveryedDevInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDiscoveryedDevInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getDiscoveryedDevInfo_Ljava_lang_String_ == null)
				cb_getDiscoveryedDevInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDiscoveryedDevInfo_Ljava_lang_String_);
			return cb_getDiscoveryedDevInfo_Ljava_lang_String_;
		}

		static IntPtr n_GetDiscoveryedDevInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDiscoveryedDevInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getDiscoveryedDevInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDiscoveryedDevInfo", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;", "GetGetDiscoveryedDevInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo GetDiscoveryedDevInfo (string p0)
		{
			const string __id = "getDiscoveryedDevInfo.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPluginByDevId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPluginByDevId_Ljava_lang_String_Handler ()
		{
			if (cb_getPluginByDevId_Ljava_lang_String_ == null)
				cb_getPluginByDevId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPluginByDevId_Ljava_lang_String_);
			return cb_getPluginByDevId_Ljava_lang_String_;
		}

		static IntPtr n_GetPluginByDevId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPluginByDevId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getPluginByDevId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPluginByDevId", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;", "GetGetPluginByDevId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin GetPluginByDevId (string p0)
		{
			const string __id = "getPluginByDevId.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPluginByPluginId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPluginByPluginId_Ljava_lang_String_Handler ()
		{
			if (cb_getPluginByPluginId_Ljava_lang_String_ == null)
				cb_getPluginByPluginId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPluginByPluginId_Ljava_lang_String_);
			return cb_getPluginByPluginId_Ljava_lang_String_;
		}

		static IntPtr n_GetPluginByPluginId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPluginByPluginId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='getPluginByPluginId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPluginByPluginId", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;", "GetGetPluginByPluginId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin GetPluginByPluginId (string p0)
		{
			const string __id = "getPluginByPluginId.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
#pragma warning disable 0169
		static Delegate GetInitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler ()
		{
			if (cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ == null)
				cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_);
			return cb_initAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
		}

		static void n_InitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitAlcs (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='initAlcs' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalInitData']]"
		[Register ("initAlcs", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V", "GetInitAlcs_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler")]
		public override unsafe void InitAlcs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0)
		{
			const string __id = "initAlcs.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_;
#pragma warning disable 0169
		static Delegate GetInitDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_Handler ()
		{
			if (cb_initDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ == null)
				cb_initDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_);
			return cb_initDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_;
		}

		static void n_InitDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitDevTrans (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='initDevTrans' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDevInfoTrans.IDevInfoTransListener']]"
		[Register ("initDevTrans", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener;)V", "GetInitDevTrans_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_Handler")]
		public virtual unsafe void InitDevTrans (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener p1)
		{
			const string __id = "initDevTrans.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_;
#pragma warning disable 0169
		static Delegate GetInitPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_Handler ()
		{
			if (cb_initPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_ == null)
				cb_initPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InitPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_);
			return cb_initPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_;
		}

		static bool n_InitPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgrConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgrConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitPluginMgr (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='initPluginMgr' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.api.PluginMgrConfig']]"
		[Register ("initPluginMgr", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;)Z", "GetInitPluginMgr_Lcom_aliyun_alink_linksdk_alcs_lpbs_api_PluginMgrConfig_Handler")]
		public virtual unsafe bool InitPluginMgr (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgrConfig p0)
		{
			const string __id = "initPluginMgr.(Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_insertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetInsertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Handler ()
		{
			if (cb_insertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ == null)
				cb_insertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_InsertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_);
			return cb_insertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_;
		}

		static bool n_InsertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InsertDiscoveryDev (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='insertDiscoveryDev' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryDeviceInfo']]"
		[Register ("insertDiscoveryDev", "(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;)Z", "GetInsertDiscoveryDev_Ljava_lang_String_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Handler")]
		public virtual unsafe bool InsertDiscoveryDev (string p0, string p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p2)
		{
			const string __id = "insertDiscoveryDev.(Ljava/lang/String;Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetIsDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_isDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_isDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_isDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static bool n_IsDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDataNeedConvert (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='isDataNeedConvert' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDataNeedConvert", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDataNeedConvert_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public virtual unsafe bool IsDataNeedConvert (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "isDataNeedConvert.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetIsDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_isDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_isDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_isDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static bool n_IsDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDataToCloud (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='isDataToCloud' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDataToCloud", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDataToCloud_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public virtual unsafe bool IsDataToCloud (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "isDataToCloud.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_isDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static bool n_IsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceConnected (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='isDeviceConnected' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("isDeviceConnected", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z", "GetIsDeviceConnected_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public override unsafe bool IsDeviceConnected (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "isDeviceConnected.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
#pragma warning disable 0169
		static Delegate GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler ()
		{
			if (cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ == null)
				cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_);
			return cb_onCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
		}

		static void n_OnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCloudChannelCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='onCloudChannelCreate' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel']]"
		[Register ("onCloudChannelCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V", "GetOnCloudChannelCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler")]
		public override unsafe void OnCloudChannelCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p0)
		{
			const string __id = "onCloudChannelCreate.(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_;
#pragma warning disable 0169
		static Delegate GetProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_Handler ()
		{
			if (cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ == null)
				cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_);
			return cb_probeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_;
		}

		static void n_ProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProbeDevice (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='probeDevice' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalProbeListener']]"
		[Register ("probeDevice", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener;)V", "GetProbeDevice_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalProbeListener_Handler")]
		public override unsafe void ProbeDevice (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalProbeListener p1)
		{
			const string __id = "probeDevice.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalProbeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
#pragma warning disable 0169
		static Delegate GetRegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler ()
		{
			if (cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ == null)
				cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_);
			return cb_regAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_;
		}

		static bool n_RegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegAuthProvider (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='regAuthProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.auth.IAuthProvider']]"
		[Register ("regAuthProvider", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z", "GetRegAuthProvider_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_auth_IAuthProvider_Handler")]
		public override unsafe bool RegAuthProvider (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Auth.IAuthProvider p1)
		{
			const string __id = "regAuthProvider.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/auth/IAuthProvider;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_;
#pragma warning disable 0169
		static Delegate GetRegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_Handler ()
		{
			if (cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ == null)
				cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_);
			return cb_regCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_;
		}

		static void n_RegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegCloudChannelFactory (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='regCloudChannelFactory' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory']]"
		[Register ("regCloudChannelFactory", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;)V", "GetRegCloudChannelFactory_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_Handler")]
		public override unsafe void RegCloudChannelFactory (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory p0)
		{
			const string __id = "regCloudChannelFactory.(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
#pragma warning disable 0169
		static Delegate GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler ()
		{
			if (cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == null)
				cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_);
			return cb_regDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		}

		static bool n_RegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='regDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("regDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetRegDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public override unsafe bool RegDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			const string __id = "regDeviceStateListener.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removePlugin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemovePlugin_Ljava_lang_String_Handler ()
		{
			if (cb_removePlugin_Ljava_lang_String_ == null)
				cb_removePlugin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePlugin_Ljava_lang_String_);
			return cb_removePlugin_Ljava_lang_String_;
		}

		static void n_RemovePlugin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePlugin (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='removePlugin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removePlugin", "(Ljava/lang/String;)V", "GetRemovePlugin_Ljava_lang_String_Handler")]
		public virtual unsafe void RemovePlugin (string p0)
		{
			const string __id = "removePlugin.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_;
#pragma warning disable 0169
		static Delegate GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler ()
		{
			if (cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ == null)
				cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_);
			return cb_startConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_;
		}

		static void n_StartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='startConnect' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalConnectParams'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalConnectListener']]"
		[Register ("startConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V", "GetStartConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalConnectListener_Handler")]
		public override unsafe void StartConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalConnectListener p1)
		{
			const string __id = "startConnect.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='startDiscovery' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2)
		{
			const string __id = "startDiscovery.(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='startDiscovery' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1)
		{
			const string __id = "startDiscovery.(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartNotifyMonitor (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='startNotifyMonitor' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startNotifyMonitor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler")]
		public override unsafe bool StartNotifyMonitor (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0)
		{
			const string __id = "startNotifyMonitor.(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_stopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static void n_StopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopConnect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='stopConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("stopConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetStopConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public override unsafe void StopConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "stopConnect.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopDiscovery;
#pragma warning disable 0169
		static Delegate GetStopDiscoveryHandler ()
		{
			if (cb_stopDiscovery == null)
				cb_stopDiscovery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopDiscovery);
			return cb_stopDiscovery;
		}

		static bool n_StopDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDiscovery ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='stopDiscovery' and count(parameter)=0]"
		[Register ("stopDiscovery", "()Z", "GetStopDiscoveryHandler")]
		public override unsafe bool StopDiscovery ()
		{
			const string __id = "stopDiscovery.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopNotifyMonitor;
#pragma warning disable 0169
		static Delegate GetStopNotifyMonitorHandler ()
		{
			if (cb_stopNotifyMonitor == null)
				cb_stopNotifyMonitor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopNotifyMonitor);
			return cb_stopNotifyMonitor;
		}

		static bool n_StopNotifyMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopNotifyMonitor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='stopNotifyMonitor' and count(parameter)=0]"
		[Register ("stopNotifyMonitor", "()Z", "GetStopNotifyMonitorHandler")]
		public override unsafe bool StopNotifyMonitor ()
		{
			const string __id = "stopNotifyMonitor.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_Subscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Subscribe (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("subscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetSubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool Subscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p2)
		{
			const string __id = "subscribe.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetToAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_toAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_toAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_toAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static IntPtr n_ToAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToAliIoTPkDn (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='toAliIoTPkDn' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("toAliIoTPkDn", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;", "GetToAliIoTPkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToAliIoTPkDn (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "toAliIoTPkDn.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetToPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_toPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_toPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_toPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static IntPtr n_ToPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPrivatePkDn (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='toPrivatePkDn' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("toPrivatePkDn", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;", "GetToPrivatePkDn_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToPrivatePkDn (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			const string __id = "toPrivatePkDn.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler ()
		{
			if (cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ == null)
				cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_);
			return cb_unregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_;
		}

		static bool n_UnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregDeviceStateListener (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='unregDeviceStateListener' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDeviceStateListener']]"
		[Register ("unregDeviceStateListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z", "GetUnregDeviceStateListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDeviceStateListener_Handler")]
		public override unsafe bool UnregDeviceStateListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDeviceStateListener p1)
		{
			const string __id = "unregDeviceStateListener.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDeviceStateListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler ()
		{
			if (cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ == null)
				cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_);
			return cb_unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_;
		}

		static bool n_Unsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Unsubscribe (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalSubMessage'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalMsgListener']]"
		[Register ("unsubscribe", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z", "GetUnsubscribe_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalSubMessage_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalMsgListener_Handler")]
		public override unsafe bool Unsubscribe (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalSubMessage p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalMsgListener p1)
		{
			const string __id = "unsubscribe.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalSubMessage;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalMsgListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_;
#pragma warning disable 0169
		static Delegate GetUpdateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Handler ()
		{
			if (cb_updateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_ == null)
				cb_updateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_);
			return cb_updateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_;
		}

		static void n_UpdateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDataFormat (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='updateDataFormat' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalConnectParams']]"
		[Register ("updateDataFormat", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;)V", "GetUpdateDataFormat_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalConnectParams_Handler")]
		public virtual unsafe void UpdateDataFormat (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalConnectParams p0)
		{
			const string __id = "updateDataFormat.(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalConnectParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDiscoveryInfo (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.api']/class[@name='PluginMgr']/method[@name='updateDiscoveryInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateDiscoveryInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateDiscoveryInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateDiscoveryInfo (string p0, string p1, string p2)
		{
			const string __id = "updateDiscoveryInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
