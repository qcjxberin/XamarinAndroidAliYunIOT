using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/init/ThingModuleSDKDelegate", DoNotGenerateAcw=true)]
	public partial class ThingModuleSDKDelegate : global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/field[@name='DISCOVERY_ON']"
		[Register ("DISCOVERY_ON")]
		public const string DiscoveryOn = (string) "discovery_on";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/field[@name='DISCOVERY_SETTING_FILENAME']"
		[Register ("DISCOVERY_SETTING_FILENAME")]
		public const string DiscoverySettingFilename = (string) "discovery_setting";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/init/ThingModuleSDKDelegate", typeof (ThingModuleSDKDelegate));
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

		protected ThingModuleSDKDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/constructor[@name='ThingModuleSDKDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThingModuleSDKDelegate ()
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

		static Delegate cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler ()
		{
			if (cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ == null)
				cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_);
			return cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
		}

		static int n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application, IntPtr native_sdkConfigure, IntPtr native_map)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.ThingModuleSDKDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.ThingModuleSDKDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application application = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_application, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure sdkConfigure = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> (native_sdkConfigure, JniHandleOwnership.DoNotTransfer);
			var map = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_map, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Init (application, sdkConfigure, map);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I", "GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler")]
		public override unsafe int Init (global::Android.App.Application application, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure sdkConfigure, global::System.Collections.Generic.IDictionary<string, string> map)
		{
			const string __id = "init.(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I";
			IntPtr native_map = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [1] = new JniArgumentValue ((sdkConfigure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkConfigure).Handle);
				__args [2] = new JniArgumentValue (native_map);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/method[@name='startSchedule' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("startSchedule", "(Landroid/app/Application;)V", "")]
		public static unsafe void StartSchedule (global::Android.App.Application application)
		{
			const string __id = "startSchedule.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='ThingModuleSDKDelegate']/method[@name='stopSchedule' and count(parameter)=0]"
		[Register ("stopSchedule", "()V", "")]
		public static unsafe void StopSchedule ()
		{
			const string __id = "stopSchedule.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
