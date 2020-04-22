using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/interface[@name='ISDKDelegate']"
	[Register ("com/aliyun/iot/aep/sdk/framework/sdk/ISDKDelegate", "", "Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegateInvoker")]
	public partial interface ISDKDelegate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/interface[@name='ISDKDelegate']/method[@name='canBeenInitialized' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("canBeenInitialized", "(Ljava/util/Map;)Z", "GetCanBeenInitialized_Ljava_util_Map_Handler:Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegateInvoker, SdkFramework")]
		bool CanBeenInitialized (global::System.Collections.Generic.IDictionary<string, string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/interface[@name='ISDKDelegate']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I", "GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler:Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegateInvoker, SdkFramework")]
		int Init (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1, global::System.Collections.Generic.IDictionary<string, string> p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/ISDKDelegate", DoNotGenerateAcw=true)]
	internal partial class ISDKDelegateInvoker : global::Java.Lang.Object, ISDKDelegate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/ISDKDelegate", typeof (ISDKDelegateInvoker));

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

		public static ISDKDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDKDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.framework.sdk.ISDKDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDKDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_canBeenInitialized_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCanBeenInitialized_Ljava_util_Map_Handler ()
		{
			if (cb_canBeenInitialized_Ljava_util_Map_ == null)
				cb_canBeenInitialized_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanBeenInitialized_Ljava_util_Map_);
			return cb_canBeenInitialized_Ljava_util_Map_;
		}

		static bool n_CanBeenInitialized_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanBeenInitialized (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canBeenInitialized_Ljava_util_Map_;
		public unsafe bool CanBeenInitialized (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_canBeenInitialized_Ljava_util_Map_ == IntPtr.Zero)
				id_canBeenInitialized_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "canBeenInitialized", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canBeenInitialized_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler ()
		{
			if (cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ == null)
				cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_);
			return cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
		}

		static int n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application p0 = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Init (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
		public unsafe int Init (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ == IntPtr.Zero)
				id_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
