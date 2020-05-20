using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/interface[@name='IPlugin']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPluginInvoker")]
	public partial interface IPlugin : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge PalBridge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/interface[@name='IPlugin']/method[@name='getPalBridge' and count(parameter)=0]"
			[Register ("getPalBridge", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge;", "GetGetPalBridgeHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPluginInvoker, AndroidAlcsLpbsBinding")] get;
		}

		string PluginId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/interface[@name='IPlugin']/method[@name='getPluginId' and count(parameter)=0]"
			[Register ("getPluginId", "()Ljava/lang/String;", "GetGetPluginIdHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPluginInvoker, AndroidAlcsLpbsBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/interface[@name='IPlugin']/method[@name='startPlugin' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.plugin.PluginConfig']]"
		[Register ("startPlugin", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/PluginConfig;)Z", "GetStartPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPluginInvoker, AndroidAlcsLpbsBinding")]
		bool StartPlugin (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.plugin']/interface[@name='IPlugin']/method[@name='stopPlugin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stopPlugin", "(Ljava/lang/String;)Z", "GetStopPlugin_Ljava_lang_String_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPluginInvoker, AndroidAlcsLpbsBinding")]
		bool StopPlugin (string p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin", DoNotGenerateAcw=true)]
	internal partial class IPluginInvoker : global::Java.Lang.Object, IPlugin {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/plugin/IPlugin", typeof (IPluginInvoker));

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

		public static IPlugin GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlugin> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.plugin.IPlugin"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PalBridge);
		}
#pragma warning restore 0169

		IntPtr id_getPalBridge;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge PalBridge {
			get {
				if (id_getPalBridge == IntPtr.Zero)
					id_getPalBridge = JNIEnv.GetMethodID (class_ref, "getPalBridge", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalBridge), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PluginId);
		}
#pragma warning restore 0169

		IntPtr id_getPluginId;
		public unsafe string PluginId {
			get {
				if (id_getPluginId == IntPtr.Zero)
					id_getPluginId = JNIEnv.GetMethodID (class_ref, "getPluginId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPluginId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartPlugin (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_;
		public unsafe bool StartPlugin (string p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.PluginConfig p1)
		{
			if (id_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_ == IntPtr.Zero)
				id_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_ = JNIEnv.GetMethodID (class_ref, "startPlugin", "(Ljava/lang/String;Lcom/aliyun/alink/linksdk/alcs/lpbs/plugin/PluginConfig;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startPlugin_Ljava_lang_String_Lcom_aliyun_alink_linksdk_alcs_lpbs_plugin_PluginConfig_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Plugin.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopPlugin (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_stopPlugin_Ljava_lang_String_;
		public unsafe bool StopPlugin (string p0)
		{
			if (id_stopPlugin_Ljava_lang_String_ == IntPtr.Zero)
				id_stopPlugin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stopPlugin", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopPlugin_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
