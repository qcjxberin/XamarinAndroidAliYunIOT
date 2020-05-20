using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/plugin/ICAPlugin", DoNotGenerateAcw=true)]
	public partial class ICAPlugin : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/plugin/ICAPlugin", typeof (ICAPlugin));
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

		protected ICAPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']/constructor[@name='ICAPlugin' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.api.PluginMgrConfig']]"
		[Register (".ctor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;)V", "")]
		public unsafe ICAPlugin (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Api.PluginMgrConfig p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/aliyun/alink/linksdk/alcs/lpbs/api/PluginMgrConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getPalBridge;
#pragma warning disable 0169
		static Delegate GetGetPalBridgeHandler ()
		{
			if (cb_getPalBridge == null)
				cb_getPalBridge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPalBridge);
			return cb_getPalBridge;
		}

		static IntPtr n_GetPalBridge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PalBridge);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge PalBridge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']/method[@name='getPalBridge' and count(parameter)=0]"
			[Register ("getPalBridge", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge;", "GetGetPalBridgeHandler")]
			get {
				const string __id = "getPalBridge.()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPluginId;
#pragma warning disable 0169
		static Delegate GetGetPluginIdHandler ()
		{
			if (cb_getPluginId == null)
				cb_getPluginId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPluginId);
			return cb_getPluginId;
		}

		static IntPtr n_GetPluginId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PluginId);
		}
#pragma warning restore 0169

		public virtual unsafe string PluginId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']/method[@name='getPluginId' and count(parameter)=0]"
			[Register ("getPluginId", "()Ljava/lang/String;", "GetGetPluginIdHandler")]
			get {
				const string __id = "getPluginId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_;
#pragma warning disable 0169
		static Delegate GetStartPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_Handler ()
		{
			if (cb_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_ == null)
				cb_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StartPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_);
			return cb_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_;
		}

		static bool n_StartPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartPlugin (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']/method[@name='startPlugin' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.plugin.PluginConfig']]"
		[Register ("startPlugin", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/PluginConfig;)Z", "GetStartPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_Handler")]
		public virtual unsafe bool StartPlugin (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig p1)
		{
			const string __id = "startPlugin.(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/PluginConfig;)Z";
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

		static Delegate cb_stopPlugin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStopPlugin_Ljava_lang_String_Handler ()
		{
			if (cb_stopPlugin_Ljava_lang_String_ == null)
				cb_stopPlugin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StopPlugin_Ljava_lang_String_);
			return cb_stopPlugin_Ljava_lang_String_;
		}

		static bool n_StopPlugin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.ICAPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopPlugin (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/class[@name='ICAPlugin']/method[@name='stopPlugin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stopPlugin", "(Ljava/lang/String;)Z", "GetStopPlugin_Ljava_lang_String_Handler")]
		public virtual unsafe bool StopPlugin (string p0)
		{
			const string __id = "stopPlugin.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
